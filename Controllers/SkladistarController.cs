using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ConManApp.EnModels;
using ConManApp.Models;
using ConManApp.DB;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Web;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Builder;
using static System.Net.Mime.MediaTypeNames;
using System.IO;
using Google.Authenticator;
using ConManApp.Helper;

namespace ConManApp.Controllers
{
    public class SkladistarController : Controller
    {
        private const string fakey = "qwerty!@#$%^";
        public IActionResult Index()
        {
            

            /*
            ViewData["korisnickiusername"] = username;
            ViewData["korisnickoime"] = s.Ime;*/

            using (MojDBCOntext db = new MojDBCOntext())
            {
               //HttpContext.Session.SetString("username", "skladistar1");

                string username = HttpContext.Session.GetString("username");
                Skladistar s = db.Skladistar.FirstOrDefault(x => x.username == username);
                Skladiste ss = new Skladiste();
                
                ss = db.Skladiste.SingleOrDefault(x => x.SkladisteId == s.SkladisteId);



                //valjda parc view za vozila i materijale
                List<Materijal> materijali = db.Materijal.Where(x => x.SkladisteId == ss.SkladisteId && x.Naziv != null).ToList();
                List<VoziloSkladisteVM> vozila = db.Vozilo.Where(x => x.SkladisteId == ss.SkladisteId && x.NazivProizvodjaca != null).Select(w => new VoziloSkladisteVM
                { 
                   SkladisteId = ss.SkladisteId,
                   GodinaProizvodnje = w.GodinaProizvodnje,
                   JeIznajmljeno = w.JeIznajmljeno,
                   Model = w.Model,
                   NazivProizvodjaca = w.NazivProizvodjaca,
                   TipVozilaId = w.TipVozilaId,
                   VoziloId = w.VoziloId,
                   SlikaVozila = ImageHelper.GetImageBase64(w.SlikaVozila)

            }).ToList();
                List<Oprema> oprema = db.Oprema.Where(x => x.SkladisteId == ss.SkladisteId && x.Naziv != null).ToList();
                SkladisteViewModel vm = new SkladisteViewModel
                {
                    ImeSkladistara = s.Ime,
                    UsernameSkladistara = s.username,
                    Adresa = ss.Adresa,
                    Naziv = ss.Naziv,
                    Vozila = vozila,
                    Materijali = materijali,
                    Oprema = oprema
                };
                Grad g = new Grad();
                g = db.Grad.SingleOrDefault(x => x.GradId == ss.GradId);
                vm.GradNaziv = g.Naziv;
                
                return View(vm);
            }
        }
        public IActionResult AddTipVozilo(string nazivtipa)
        {
            MojDBCOntext db = new MojDBCOntext();
            TipVozila t = new TipVozila();
            t.NazivTipa = nazivtipa;
            db.TipVozila.Add(t);
            db.SaveChanges();
            ModelState.Clear();
            return View();

        }

        public IActionResult VoziloDodaj()
        {
            MojDBCOntext db = new MojDBCOntext();
            //Skladistar s = new Skladistar();
            //s = db.Skladistar.SingleOrDefault(d => d.UposlenikId == sid);
            string username = HttpContext.Session.GetString("username");
            Skladistar s = db.Skladistar.FirstOrDefault(x => x.username == username);
            ViewBag.Username = s.username;


            List<TipVozila> lista = db.TipVozila.ToList();
            ViewBag.TipVozila = new SelectList(lista, "TipVozilaId", "NazivTipa");
            return View("AddVozilo");
        }

        //Vozilo
        [ValidateAntiForgeryToken]
        public IActionResult AddVozilo(Vozilo v, IFormFile slika)
        {
            MojDBCOntext db = new MojDBCOntext();
            //Skladistar s = new Skladistar();
            //s = db.Skladistar.SingleOrDefault(d => d.UposlenikId == sid);
            string username = HttpContext.Session.GetString("username");
            Skladistar s = db.Skladistar.FirstOrDefault(x => x.username == username);
            ViewBag.Username = s.username;


            List<TipVozila> lista = db.TipVozila.ToList();
            ViewBag.TipVozila = new SelectList(lista, "TipVozilaId", "NazivTipa");

            //List<Skladiste> lista2 = db.Skladiste.Where(d=>d.SkladisteId==s.SkladisteId).ToList();
            //List<Skladiste> lista2 = db.Skladiste.ToList();
            Skladiste skladiste = db.Skladiste.FirstOrDefault(x => x.SkladisteId == s.SkladisteId);
            //ViewBag.Skla = new SelectList(lista2, "SkladisteId", "Naziv");
            //if (v.SkladisteId == 0)
            //{
            //    v.SkladisteId = lista2.FirstOrDefault(x => x.SkladisteId>0).SkladisteId;
            //}//defaultna postavka radi foreignkey!=null ili bilo koji idevi iz baze za skladiste i tip vozila za potrebe testne app

            if (v.TipVozilaId == 0)
            {
                v.TipVozilaId = lista.FirstOrDefault(x => x.TipVozilaId > 0).TipVozilaId;
            }

            if (v.SkladisteId == 0)
                v.SkladisteId = skladiste.SkladisteId;
            Vozilo m = new Vozilo();
            m.NazivProizvodjaca = v.NazivProizvodjaca;
            m.Model = v.Model;
            m.JeIznajmljeno = false;
            m.GodinaProizvodnje = v.GodinaProizvodnje;

            //m.SlikaVozila = v.SlikaVozila;

            m.SlikaVozila = ImageHelper.GetImageByteArray(slika);

            m.TipVozilaId = v.TipVozilaId;
            m.SkladisteId = v.SkladisteId;
            if (m.NazivProizvodjaca == null)
                return View("AddVozilo");

            db.Vozilo.Add(m);
            db.SaveChanges();

            ModelState.Clear();

            string poruka = "Uspjesno ste dodali vozilo " + v.NazivProizvodjaca + " na skladiste " + skladiste.Naziv;
            WhatsAppHelper.Send(s.KontaktBroj, poruka);

            return RedirectToAction("Index");

        }
        public IActionResult AddMaterijal(Materijal m)
        {
            MojDBCOntext db = new MojDBCOntext();
            string username = HttpContext.Session.GetString("username");
            Skladistar s = db.Skladistar.FirstOrDefault(x => x.username == username);
            ViewBag.username = s.username;
            Skladiste skladiste = db.Skladiste.FirstOrDefault(x => x.SkladisteId == s.SkladisteId);
            Materijal mm = new Materijal();

            //List<Skladiste> skladiste = db.Skladiste.ToList();
            //ViewBag.SkladisteBag = new SelectList(skladiste, "SkladisteId", "Adresa");
            List<GrupaMaterijal> grupe = db.GrupaMaterijal.ToList();
            ViewBag.GrupeBag = new SelectList(grupe, "GrupaMaterijalId", "NazivGrupe");
            List<Dobavljac> dobavljaci = db.Dobavljac.ToList();
            ViewBag.DobavljaciBag = new SelectList(dobavljaci, "DobavljacId", "Naziv");

            if (m.DobavljacId == 0)
            {
                m.DobavljacId = dobavljaci.FirstOrDefault(x => x.DobavljacId > 0).DobavljacId;


            }
            if (m.SkladisteId == 0)
            {
                m.SkladisteId = skladiste.SkladisteId;
            }
            if (m.GrupaMaterijalId == 0)
            {
                m.GrupaMaterijalId = grupe.FirstOrDefault(x => x.GrupaMaterijalId > 0).GrupaMaterijalId;
            }

            if (m.GrupaMaterijal == null)
                return View("AddMaterijal");


            //mm.MaterijalId = m.MaterijalId;
            mm.GrupaMaterijalId = m.GrupaMaterijalId;
            mm.Naziv = m.Naziv;
            mm.SkladisteId = m.SkladisteId;
            mm.DobavljacId = m.DobavljacId;
            mm.Cijena = m.Cijena;
            mm.Potrosen = false;
            mm.Kolicina = m.Kolicina;
            db.Materijal.Add(mm);
            db.SaveChanges();
            ModelState.Clear();

            return RedirectToAction("Index");
            
        }

        public IActionResult GetVozilo()
        {
            MojDBCOntext db = new MojDBCOntext();
            string username = HttpContext.Session.GetString("username");
            Skladistar s = db.Skladistar.FirstOrDefault(x => x.username == username);
            Skladiste skladiste = db.Skladiste.FirstOrDefault(x => x.SkladisteId == s.SkladisteId);
            List<Vozilo> vozilanasklad = db.Vozilo.Where(x => x.SkladisteId == skladiste.SkladisteId).ToList();
            //Vozilo v = new Vozilo();
            //v = db.Vozilo.SingleOrDefault(x => x.VoziloId == voziloid);
            ViewBag.username = s.username;
            ViewBag.vozila = new SelectList(vozilanasklad, "VoziloId", "Model");

            return View();
        }
        [HttpGet]
        public IActionResult ViewVozilo(Vozilo v)
        {
            MojDBCOntext db = new MojDBCOntext();
            Vozilo vozilo = new Vozilo();

            vozilo = db.Vozilo.SingleOrDefault(x => x.VoziloId == v.VoziloId);

            VoziloViewModel vm = new VoziloViewModel();
            vm.voziloID = vozilo.VoziloId;

            vm.ProizvodjacNaziv = vozilo.NazivProizvodjaca;
            vm.ModdelNaziv = vozilo.Model;

            vm.slika = ImageHelper.GetImageBase64(vozilo.SlikaVozila);

            Skladiste s = new Skladiste();
            s = db.Skladiste.SingleOrDefault(x => x.SkladisteId == vozilo.SkladisteId);
            vm.nazivskladista = s.Naziv;
            vm.adresaskladista = s.Adresa;
            Grad g = new Grad();
            g = db.Grad.SingleOrDefault(x => x.GradId == s.GradId);
            vm.NazivGrada = g.Naziv;
            TipVozila tv = new TipVozila();
            tv = db.TipVozila.Single(x => x.TipVozilaId == vozilo.TipVozilaId);
            vm.tipvozila = tv.NazivTipa;
            return View(vm);
        }
        //Materijali i grupa materijala
        public IActionResult AddGrupaMaterijala(GrupaMaterijal g)
        {
            MojDBCOntext db = new MojDBCOntext();
            List<GrupaMaterijal> provjera = db.GrupaMaterijal.Where(x => x.NazivGrupe == g.NazivGrupe).ToList();
            if (provjera.Count() == 0)
            {
                GrupaMaterijal gm = new GrupaMaterijal();
                gm.NazivGrupe = g.NazivGrupe;
                db.GrupaMaterijal.Add(gm);
                db.SaveChanges();
                ModelState.Clear();

                return View();
            }
            else
                return View("AddGrupaMaterijala");
        }
      

        public IActionResult AddOprema(Oprema o)
        {
            MojDBCOntext db = new MojDBCOntext();
            string username = HttpContext.Session.GetString("username");
            Skladistar s = db.Skladistar.FirstOrDefault(x => x.username == username);
            ViewBag.username = s.username;
            Skladiste skladiste = db.Skladiste.FirstOrDefault(x => x.SkladisteId == s.SkladisteId);
            Oprema oprema = new Oprema();

            if (o.SkladisteId == 0)
            {
                o.SkladisteId = skladiste.SkladisteId;
            }
            oprema.Naziv = o.Naziv;
            oprema.JeIznajmljeno = false;
            oprema.usable = o.usable;
            if (o.Naziv == null)
                return View("AddOprema");
            db.Oprema.Add(o);
            db.SaveChanges();
            ModelState.Clear();

            string poruka = "Uspjesno ste dodali opremu pod nazivom " + o.Naziv + " na skladiste " + o.Skladiste.Naziv;
            WhatsAppHelper.Send(s.KontaktBroj, poruka);

            return RedirectToAction("Index");

        }

        public IActionResult GetSkladiste(int skladisteid)
        {
            MojDBCOntext db = new MojDBCOntext();
            List<Skladiste> listaskladista = db.Skladiste.ToList();
            ViewBag.Skladista = new SelectList(listaskladista, "SkladisteId", "Naziv");
            //Skladiste r = new Skladiste();
            //r = db.Skladiste.SingleOrDefault(x => x.SkladisteId == skladisteid);



            return View(/*r*/);


        }

        public IActionResult StanjeNaSkladistu()
        {
            MojDBCOntext db = new MojDBCOntext();
            string username = HttpContext.Session.GetString("username");
            Skladistar s = db.Skladistar.SingleOrDefault(x => x.username == username);
            Skladiste ss = new Skladiste();
            ss = db.Skladiste.SingleOrDefault(x => x.SkladisteId == s.SkladisteId);



            //valjda parc view za vozila i materijale
            List<Materijal> materijali = db.Materijal.Where(x => x.SkladisteId == ss.SkladisteId && x.Naziv != null).ToList();
            //List<Vozilo> vozila = db.Vozilo.Where(x => x.SkladisteId == ss.SkladisteId && x.NazivProizvodjaca != null).ToList();
            List<VoziloSkladisteVM> vozila = db.Vozilo.Where(x => x.SkladisteId == ss.SkladisteId && x.NazivProizvodjaca != null).Select(w => new VoziloSkladisteVM
            {
                SkladisteId = ss.SkladisteId,
                GodinaProizvodnje = w.GodinaProizvodnje,
                JeIznajmljeno = w.JeIznajmljeno,
                Model = w.Model,
                NazivProizvodjaca = w.NazivProizvodjaca,
                TipVozilaId = w.TipVozilaId,
                VoziloId = w.VoziloId,
                SlikaVozila = ImageHelper.GetImageBase64(w.SlikaVozila)

            }).ToList();
            List<Oprema> oprema = db.Oprema.Where(x => x.SkladisteId == ss.SkladisteId && x.Naziv != null).ToList();
            SkladisteViewModel vm = new SkladisteViewModel
            {
                ImeSkladistara = s.Ime,
                UsernameSkladistara = s.username,
                Adresa = ss.Adresa,
                Naziv = ss.Naziv,
                Vozila = vozila,
                Materijali = materijali,
                Oprema = oprema
            };
            Grad g = new Grad();
            g = db.Grad.SingleOrDefault(x => x.GradId == ss.GradId);
            vm.GradNaziv = g.Naziv;

            return View(vm);


        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Validacija(LoginViewModel login)
        {
            /*
            MojDBCOntext db = new MojDBCOntext();
            Skladistar korisnik = db.Skladistar.SingleOrDefault(x => x.username == lg.username && x.password == lg.password);
            
            if (korisnik != null)
            {
                

                return Json(new { status = true, message = "Login uspjesan!" });
                 
            }
            return Json(new { status = false, message = "Login nije uspjesan!" });*/

            ////var korisnik = db.Skladistar.Where(x => x.username == lg.username);// postoji username
            //if (korisnik != null)
            //{
            //    if (korisnik.password==lg.password)
            //    {
            //        return Json(new { status = true, message = "Login uspjesan!" });
            //    }
            //    else
            //    {
            //        return Json(new { status = false, message = "Provjerite lozinku!" });
            //    }
            //}
            //else
            //{
            //    return Json(new { status = false, message = "Pogresan username!" });
            //}

            MojDBCOntext db = new MojDBCOntext();

            var uname = login.username;
            var pw = login.password;

            Skladistar p = db.Skladistar.Where(x => x.password == pw && x.username == uname).FirstOrDefault();

            if (p != null)
            {
                if (p.TwoFaAuth)
                {
                    return Json(new { status = true, message = "Login uspjesan!", twofa = true, username = uname });
                }
                else
                {
                    HttpContext.Session.SetString("username", p.username);
                    return Json(new { status = true, message = "Login uspjesan!", twofa = false });
                }
               

            }
            else
            {
                ViewBag.error = "Invalid Account";
                return Json(new { status = false, message = "Login neuspjesan!" });
            }


        }

        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("username");

            return View("Login");
        }


        public IActionResult ViewMyProfile()
        {
            MojDBCOntext db = new MojDBCOntext();
            string username = HttpContext.Session.GetString("username");
            Skladistar s = db.Skladistar.SingleOrDefault(x => x.username == username);
            Skladiste ss = db.Skladiste.FirstOrDefault(x => x.SkladisteId == s.SkladisteId);
            ViewBag.AdresaSkladista = ss.Adresa;
            ViewBag.SkladistarUsername = s.username;

            //Two factor authentication
            TwoFactorAuthenticator tfa = new TwoFactorAuthenticator();
            string uniqueKey = s.username + fakey;

            var setupInfo = tfa.GenerateSetupCode("ConManager", s.username, uniqueKey, false, 300);

            ViewBag.BarcodeImageUrl = setupInfo.QrCodeSetupImageUrl;
            string qrCodeImageUrl = setupInfo.QrCodeSetupImageUrl;

            string manualEntrySetupCode = setupInfo.ManualEntryKey;

            return View(s);
        }

        public IActionResult TwoFa(string username)
        {
            ViewBag.username = username;
            return View();
        }

        public async Task<IActionResult> TwoFaVerifikacija(int twofakod, string username, bool iskljucivanje = false)
        {
            MojDBCOntext db = new MojDBCOntext();
            Skladistar s = db.Skladistar.SingleOrDefault(x => x.username == username);

            TwoFactorAuthenticator tfa = new TwoFactorAuthenticator();
            string uniqueKey = s.username + fakey;
            bool isCorrectPIN = tfa.ValidateTwoFactorPIN(uniqueKey, twofakod.ToString());

            if (isCorrectPIN)
            {
                //Za aktivaciju
                if (!s.TwoFaAuth)
                {
                    db.Skladistar.SingleOrDefault(x => x.username == username).TwoFaAuth = true;
                    await db.SaveChangesAsync();
                    return Json(new { status = true, message = "Verifikacija uspjesna!" });
                }
                //Za deaktivaciju
                if (iskljucivanje == true)
                {
                    db.Skladistar.SingleOrDefault(x => x.username == username).TwoFaAuth = false;
                    await db.SaveChangesAsync();
                    return Json(new { status = true, message = "Verifikacija uspjesna!" });
                }

                //Za login
                HttpContext.Session.SetString("username", s.username);
                return Json(new { status = true, message = "Verifikacija uspjesna!" });

            }
            return Json(new { status = false, message = "Verifikacija neuspjesna!" });


            /*
            
            */
        }
       


    }
}