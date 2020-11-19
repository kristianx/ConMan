using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ConManApp.EnModels;
using ConManApp.Models;
using ConManApp.DB;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace ConManApp.Controllers
{
    public class RadnikController : Controller
    {
        public IActionResult Index()
        {
            MojDBCOntext db = new MojDBCOntext();
            string username = HttpContext.Session.GetString("username");
            Radnik r = db.Radnik.FirstOrDefault(x => x.username == username);



            RadnikIndexVM Model = new RadnikIndexVM()
            {
                UposlenikID = r.UposlenikId,
                Username = r.username,
                Password = r.password,
                OpremaIznajmljena = db.RadnikOprema.Include(c=>c.Oprema).Include(c=>c.Oprema.Skladiste).Where(x => x.UposlenikId == r.UposlenikId && x.DatumVracanja == null).Select(x => new RadnikIndexVM.IznOprema
                {
                    RadnikOpremaID=x.RadnikOpremaId,
                    OpremaID=x.OpremaId,
                    OpremaNaziv=x.Oprema.Naziv,
                    SvrhaIznajmljivanja=x.svrhaIznajmljivanja,
                    DatumIznajmljivanja=x.DatumZaduzivanja,
                    DatumKrajaIznajmljivanja=x.DatumKrajaZaduzivanja,
                    NazivSkladista=x.Oprema.Skladiste.Naziv


                }).ToList(),
                VozilaIznajmljena=db.RadnikVozilo.Include(c=>c.Vozilo).Include(c=>c.Vozilo.Skladiste).Where(x=>x.UposlenikId==r.UposlenikId && x.DatumVracanja==null).Select(x=>new RadnikIndexVM.IznVozilo
                {
                    RadnikVoziloID=x.RadnikVoziloId,
                    VoziloID=x.VoziloId,
                    GodinaProizvodnje=x.Vozilo.GodinaProizvodnje,
                    NazivVozila=x.Vozilo.NazivProizvodjaca+' '+x.Vozilo.Model,
                    SvrhaIznajmljivanja=x.SvrhaIznajmljivanja,
                    DatumIznajmljivanja=x.DatumZaduzivanja,
                    DatumKrajaIznajmljivanja=x.DatumKrajaZaduzivanja,
                    NazivSkladista=x.Vozilo.Skladiste.Naziv

                }).ToList()

            };
            return View(Model);
            
        }

        public IActionResult PregledRaspoloziveOpreme(string Filter="")
        {
            MojDBCOntext db = new MojDBCOntext();
            var username = HttpContext.Session.GetString("username");
            Radnik r = db.Radnik.FirstOrDefault(x => x.username == username);

            if (Filter==null)
            {
                RaspolozivaOpremaVM Model = new RaspolozivaOpremaVM
                {

                    rows = db.Oprema.Include(c => c.Skladiste).Where(x => x.usable == true && x.JeIznajmljeno == false).Select(x => new RaspolozivaOpremaVM.Rows
                    {
                        OpremaID = x.OpremaId,
                        Naziv = x.Naziv,
                        NazivSkladista = x.Skladiste.Naziv,
                        AdresaSkladista = x.Skladiste.Adresa

                    }).ToList()

                };
                Model.username = r.username;
                return View(Model);
            }
            else
            {
                RaspolozivaOpremaVM Model = new RaspolozivaOpremaVM
                {

                    rows = db.Oprema.Include(c => c.Skladiste).Where(x => x.usable == true && x.Naziv.Contains(Filter) && x.JeIznajmljeno == false).Select(x => new RaspolozivaOpremaVM.Rows
                    {
                        OpremaID = x.OpremaId,
                        Naziv = x.Naziv,
                        NazivSkladista = x.Skladiste.Naziv,
                        AdresaSkladista = x.Skladiste.Adresa

                    }).ToList()

                };
                Model.username = r.username;
                return View(Model);
            }

            

        }
        
        public IActionResult PregledRaspolozivihVozila()
        {
            MojDBCOntext db = new MojDBCOntext();
            var username = HttpContext.Session.GetString("username");
            Radnik r = db.Radnik.FirstOrDefault(x => x.username == username);

            RaspolozivaVozilaVM Model = new RaspolozivaVozilaVM
            {
                rows=db.Vozilo.Include(c=>c.Skladiste).Include(c=>c.TipVozila).Where(x=>x.JeIznajmljeno==false).Select(x=>new RaspolozivaVozilaVM.Rows
                {
                    VoziloID=x.VoziloId,
                    Slika=x.SlikaVozila,
                    Proizvodjac=x.NazivProizvodjaca,
                    Model=x.Model,
                    GodinaProizvodnje=x.GodinaProizvodnje,
                    TipVozila=x.TipVozila.NazivTipa,
                    NazivSkladista=x.Skladiste.Naziv,
                    AdresaSkladista=x.Skladiste.Adresa

                }).ToList()
            };
            Model.username = r.username;
            return View(Model);
        }

        public IActionResult IznajmiVozilo(int voziloid,RadnikVozilo rv)
        {
            MojDBCOntext db = new MojDBCOntext();
            var username = HttpContext.Session.GetString("username");
            Radnik r = db.Radnik.FirstOrDefault(x => x.username == username);

            List<Vozilo> vozila = db.Vozilo.Where(x => x.Model != null).ToList();
            ViewBag.username = r.username;
            ViewBag.VozilaBag = new SelectList(vozila,"VoziloId","Model");
            //if (voziloid == 0)
            //{
            //    voziloid = vozila.FirstOrDefault().VoziloId;
            //}
            if(rv.VoziloId==0)
            {
                rv.VoziloId = vozila.Where(x => x.NazivProizvodjaca != null).FirstOrDefault().VoziloId;
            }
            if(rv.UposlenikId==0)
            {
                rv.UposlenikId = r.UposlenikId;
            }

            rv.VoziloId = voziloid;
            rv.UposlenikId = r.UposlenikId;
            RadnikVozilo riv = new RadnikVozilo();
            riv.VoziloId = voziloid;
            riv.UposlenikId = r.UposlenikId;
            riv.SvrhaIznajmljivanja = rv.SvrhaIznajmljivanja;
            riv.DatumZaduzivanja = rv.DatumZaduzivanja;
            riv.DatumKrajaZaduzivanja = rv.DatumKrajaZaduzivanja;
            riv.DatumVracanja = null;
            db.Vozilo.Find(riv.VoziloId).JeIznajmljeno = true;
            if (riv.SvrhaIznajmljivanja != null)
            {
                db.RadnikVozilo.Add(riv);
                db.SaveChanges();
                ModelState.Clear();
                return Redirect("/Radnik/Index");
            }
            return View();

           
        }
        public IActionResult VratiVozilo(int narudzbaid)
        {
            MojDBCOntext db = new MojDBCOntext();
            var username = HttpContext.Session.GetString("username");
            Radnik r = db.Radnik.FirstOrDefault(x => x.username == username);
           
            RadnikVozilo rad = db.RadnikVozilo.FirstOrDefault(x=>x.RadnikVoziloId == narudzbaid && x.UposlenikId==r.UposlenikId && x.DatumVracanja==null);
            Vozilo n = db.Vozilo.Find(rad.VoziloId);
            n.JeIznajmljeno = false;
            rad.DatumVracanja = System.DateTime.Now;
            db.SaveChanges();

            return RedirectToAction("Index", "Radnik");
        }
     
        
        public IActionResult IznajmiOpremu(int opremaid,RadnikOprema radniko)
        {
            MojDBCOntext db = new MojDBCOntext();
            var username = HttpContext.Session.GetString("username");
            Radnik r = db.Radnik.FirstOrDefault(x => x.username == username);
            
            
            
            
            List<Oprema> oprema = db.Oprema.Where(x=>x.usable==true && x.JeIznajmljeno==false).ToList();
            
            RadnikOprema novi = new RadnikOprema();
            List<RadnikOprema> provjera = db.RadnikOprema.Where(x => x.OpremaId == radniko.OpremaId && x.DatumVracanja == null).ToList();
            if(radniko.OpremaId==0)
                radniko.OpremaId = oprema.FirstOrDefault(x => x.OpremaId > 0).OpremaId;
            if (radniko.UposlenikId == 0)
                radniko.UposlenikId = r.UposlenikId;

            novi.UposlenikId = r.UposlenikId;
            novi.OpremaId = radniko.OpremaId;
            Oprema nn = db.Oprema.Find(radniko.OpremaId);
            nn.JeIznajmljeno = true;
            novi.DatumZaduzivanja = radniko.DatumZaduzivanja;
            novi.DatumKrajaZaduzivanja = radniko.DatumKrajaZaduzivanja;
            novi.DatumVracanja = null;
            novi.svrhaIznajmljivanja = radniko.svrhaIznajmljivanja;



            if (novi.svrhaIznajmljivanja != null)
            {
                db.RadnikOprema.Add(novi);
               
                db.SaveChanges();
                ModelState.Clear();
                return Redirect("/Radnik/Index");

            }
                return View("IznajmiOpremu");
            
            

           
        }
        public IActionResult VratiOpremu(int radnikopremaid)
        {
            MojDBCOntext db = new MojDBCOntext();
            var username = HttpContext.Session.GetString("username");
            Radnik r = db.Radnik.FirstOrDefault(x => x.username == username);

            
            RadnikOprema rad = db.RadnikOprema.FirstOrDefault(x => x.RadnikOpremaId == radnikopremaid && x.UposlenikId==r.UposlenikId && x.DatumVracanja==null);
            Oprema nn = db.Oprema.Find(rad.OpremaId);
            nn.JeIznajmljeno = false;

            rad.DatumVracanja = System.DateTime.Now;
            db.SaveChanges();

            return RedirectToAction("Index", "Radnik");
        }
        public IActionResult Login()
        {


            return View();
 
        }

        [HttpPost]
        public IActionResult Validacija(LoginViewModel login)
        {
            MojDBCOntext db = new MojDBCOntext();
            var uname = login.username;
            var pw = login.password;

            Radnik p = db.Radnik.Where(x => x.password == pw && x.username == uname).FirstOrDefault();

            if (p != null)
            {
                HttpContext.Session.SetString("username", p.username);
                return Json(new { status = true, message = "Login uspjesan!" });

            }
            else
            {
                ViewBag.error = "Invalid Account";
                return Json(new { status = false, message = "Login neuspjesan!" });
            }

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


        }

        public ActionResult LogOut()
        {
            HttpContext.Session.Remove("username");

            return RedirectToAction("Login");
        }



        public IActionResult ViewMyProfile()
        {
            MojDBCOntext db = new MojDBCOntext();
            var username = HttpContext.Session.GetString("username");
            Radnik s = db.Radnik.SingleOrDefault(x => x.username == username);
           
            RadnikViewModel p = new RadnikViewModel();
            p.Ime = s.Ime;
            p.username = s.username;
            p.KontaktBroj = s.KontaktBroj;
            p.Prezime = s.Prezime;
           
            p.RadnikViewModelId = s.UposlenikId;
            p.password = s.password;
            List<RadnikVozilo> zaduzenavozila = db.RadnikVozilo.Where(x => x.UposlenikId == s.UposlenikId && x.DatumVracanja==null).ToList();
            ViewBag.ZaduzenaVozila = zaduzenavozila;
            List<RadnikOprema> zaduzenaoprema = db.RadnikOprema.Where(x => x.UposlenikId == s.UposlenikId && x.DatumVracanja == null).ToList();
            ViewBag.ZaduzenaOprema = zaduzenaoprema;
            p.zaduzenaVozila = new List<RadnikVozilo>();
            p.zaduzenaVozila = zaduzenavozila;
            p.zaudzenaOprema = new List<RadnikOprema>();
            p.zaudzenaOprema = zaduzenaoprema;


            
            return View(p);
        }
    }
}