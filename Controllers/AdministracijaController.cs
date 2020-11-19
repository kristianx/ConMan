using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ConManApp.EnModels;
using ConManApp.DB;
using Microsoft.AspNetCore.Mvc.Rendering;
using ConManApp.Models;
using ConManApp.Helper;

namespace ConManApp.Controllers
{
    public class AdministracijaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddDrzava(Drzava n)
        {
            MojDBCOntext db = new MojDBCOntext();

            Drzava d = new Drzava();
            d.Naziv = n.Naziv;
            d.DrzavaId = n.DrzavaId;
            db.Drzava.Add(d);
            db.SaveChanges();
            ModelState.Clear();
            return View();
        }
        public ActionResult AddGrad(Grad grad)
        {
            MojDBCOntext db = new MojDBCOntext();
            Grad g = new Grad();
            List<Drzava> drzavalist = db.Drzava.Where(x=>x.Naziv!=null).ToList();
            ViewBag.D = new SelectList(drzavalist, "DrzavaId", "Naziv");

            if (grad.DrzavaId == 0)
                grad.DrzavaId = drzavalist.FirstOrDefault(x => x.DrzavaId > 0).DrzavaId;

            g.Naziv = grad.Naziv;
            g.DrzavaId = grad.DrzavaId;
            List<Grad> check = db.Grad.Where(x => x.Naziv == g.Naziv && x.DrzavaId == g.DrzavaId).ToList();
            if(check.Count()>0)
            {
                return View("AddGrad");
            }
            db.Grad.Add(g);
            
            db.SaveChanges();
            ModelState.Clear();
            return View();
        }
        public IActionResult AddSkladiste(/*string naziv,string adresa,int gradid=2*/ Skladiste sk) //za test postavim 12
                                                                                                    //,a pomocu padajuce liste se overwrites u broj zeljenog grada.ovo je samo testni pokusaj
        {
            MojDBCOntext db = new MojDBCOntext();
            List<Grad> gradovi = db.Grad.Where(x=>x.Naziv!=null).ToList();
            ViewBag.GradoviBag = new SelectList(gradovi, "GradId", "Naziv");
            if (sk.GradId == 0)
            {
                sk.GradId = gradovi.FirstOrDefault(x => x.GradId > 0).GradId;
            }
            Skladiste s = new Skladiste();
            s.Naziv = sk.Naziv;
            s.Adresa = sk.Adresa;
            s.GradId = sk.GradId;

            db.Skladiste.Add(s);
            db.SaveChanges();
            ModelState.Clear();
            return View();

        }

        public IActionResult GetSkladiste(int skladisteid)
        {
            MojDBCOntext db = new MojDBCOntext();
            //Skladiste r = db.Skladiste.SingleOrDefault(x => x.SkladisteId == skladisteid);
            List<Skladiste> listaskladista = db.Skladiste.Where(x=>x.Naziv!=null && x.Adresa!=null).ToList();
            ViewBag.Skladista = new SelectList(listaskladista, "SkladisteId", "Naziv");

            return View(/*r*/);
        }

        public IActionResult ViewSkladiste(Skladiste s)
        {
            MojDBCOntext db = new MojDBCOntext();
            Skladiste ss = new Skladiste();
            ss = db.Skladiste.SingleOrDefault(x => x.SkladisteId == s.SkladisteId);



            //valjda parc view za vozila i materijale
            List<Materijal> materijali = db.Materijal.Where(x => x.SkladisteId == ss.SkladisteId).ToList();
            //List<Vozilo> vozila = db.Vozilo.Where(x => x.SkladisteId == ss.SkladisteId).ToList();
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
            SkladisteViewModel vm = new SkladisteViewModel();
            vm.Adresa = ss.Adresa;
            vm.Naziv = ss.Naziv;
            vm.Vozila = vozila;
            vm.Materijali = materijali;
            Grad g = new Grad();
            g = db.Grad.SingleOrDefault(x => x.GradId == ss.GradId);
            vm.GradNaziv = g.Naziv;

            return View(vm);

        }

        //Radnik 
        public IActionResult AddRadnik(Radnik r)
        {
            MojDBCOntext db = new MojDBCOntext();

            if (ModelState.IsValid == true)
            {
                Radnik radnik = new Radnik();
                radnik.Ime = r.Ime;
                radnik.Prezime = r.Prezime;
                radnik.KontaktBroj = r.KontaktBroj;
                radnik.username = r.username;
                radnik.password = r.password;
                radnik.info = r.info;


                db.Radnik.Add(radnik);
                db.SaveChanges();
                ModelState.Clear();

                return View();
            }

            return View("AddRadnik");
        }

        public IActionResult GetRadnik(int radnikid)
        {
            MojDBCOntext db = new MojDBCOntext();
            Radnik r = db.Radnik.SingleOrDefault(x => x.UposlenikId == radnikid);


            return View(r);
        }
        [HttpGet]
        public IActionResult ViewRadnik(Radnik r)
        {
            MojDBCOntext db = new MojDBCOntext();
            Radnik rad = db.Radnik.SingleOrDefault(x => x.UposlenikId == r.UposlenikId);

            //Radnik f = new Radnik();
            //f.Ime = rad.Ime;
            //f.Prezime = rad.Prezime;
            //f.username = rad.username;
            //f.KontaktBroj = rad.KontaktBroj;
            //f.password = rad.password;
            //f.info = rad.info;

            return View(rad);

        }

        //Poslovodja-ProjektManager

        public IActionResult AddPoslovodja(Poslovodja p)
        {
            MojDBCOntext db = new MojDBCOntext();

            if (ModelState.IsValid == true)
            {
                Poslovodja poslovodja = new Poslovodja();
                poslovodja.Ime = p.Ime;
                poslovodja.Prezime = p.Prezime;
                poslovodja.KontaktBroj = p.KontaktBroj;
                poslovodja.username = p.username;
                poslovodja.password = p.password;
                poslovodja.OpisIskustva = p.OpisIskustva;


                db.Poslovodja.Add(poslovodja);
                db.SaveChanges();
                ModelState.Clear();

                return View();
            }

            return View("AddPoslovodja");
        }

        public IActionResult GetPoslovodja(int poslovodjaid)
        {
            MojDBCOntext db = new MojDBCOntext();
            Poslovodja p = db.Poslovodja.SingleOrDefault(x => x.UposlenikId == poslovodjaid);


            return View(p);
        }

        [HttpGet]
        public IActionResult ViewPoslovodja(Poslovodja r)
        {
            MojDBCOntext db = new MojDBCOntext();
            Poslovodja p = db.Poslovodja.SingleOrDefault(x => x.UposlenikId == r.UposlenikId);



            return View(p);

        }

        //Skladistar
        public IActionResult AddSkladistar(Skladistar s)
        {
            MojDBCOntext db = new MojDBCOntext();


            List<Skladiste> skladista = new List<Skladiste>();
            skladista = db.Skladiste.ToList();
            ViewBag.skladisteBag = new SelectList(skladista, "SkladisteId", "Naziv");
            if (s.SkladisteId == 0)
            {
                s.SkladisteId = skladista.FirstOrDefault(x => x.SkladisteId > 0).SkladisteId;
            }
            Skladistar skladistar = new Skladistar();
            skladistar.Ime = s.Ime;
            skladistar.Prezime = s.Prezime;
            skladistar.KontaktBroj = s.KontaktBroj;
            skladistar.username = s.username;
            skladistar.password = s.password;
            skladistar.SkladisteId = s.SkladisteId;

            if (ModelState.IsValid)
            {
                db.Skladistar.Add(skladistar);
                db.SaveChanges();
                ModelState.Clear();

                return View();
            }
            else
            {
                return View("AddSkladistar");
            }

        }

        public IActionResult GetSkladistar(int Skladistarid)
        {
            MojDBCOntext db = new MojDBCOntext();
            Skladistar s = db.Skladistar.SingleOrDefault(x => x.UposlenikId == Skladistarid);


            return View(s);
        }

        [HttpGet]
        public IActionResult ViewSkladistar(Skladistar r)
        {
            MojDBCOntext db = new MojDBCOntext();
            Skladistar s = db.Skladistar.SingleOrDefault(x => x.UposlenikId == r.UposlenikId);


   
            return View(s);

        }

        //Skladiste

        //Vozilo
        //Projekt
        //Poslovodja-Projekt
        //Materijali i GrupaMaterijala
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
        public IActionResult AddDobavljac(Dobavljac d)
        {

            MojDBCOntext db = new MojDBCOntext();

            Dobavljac dob = new Dobavljac();
            dob.Naziv = d.Naziv;
            dob.GodinaOsnivanja = d.GodinaOsnivanja;
            dob.DobavljacId = d.DobavljacId;
            db.Dobavljac.Add(dob);
            db.SaveChanges();
            ModelState.Clear();
            return View();
        }


        public IActionResult AddUred(Ured u)
        {
            MojDBCOntext db = new MojDBCOntext();
           
            List<Grad> gradovi = db.Grad.Where(x=>x.Naziv != null).ToList();
            ViewBag.GradoviBag = new SelectList(gradovi,"GradId", "Naziv");
            if (u.GradId == 0)
            {
                u.GradId = gradovi.FirstOrDefault(x => x.GradId > 0).GradId;
            }
            if (u.Adresa == null)
                u.Adresa = "/";
            Ured ured = new Ured();
            ured.UredId = u.UredId;
            ured.GradId = u.GradId;
            ured.Adresa = u.Adresa;
            List<Ured> t = db.Ured.Where(x => x.Adresa == ured.Adresa && x.GradId==ured.GradId).ToList();
            if(t.Count()!=0)
            {
                return View("AddUred");
               
                
            }

            db.Ured.Add(ured);
            db.SaveChanges();
            ModelState.Clear();
            return View();
        }

        public IActionResult AddProjekt(Projekt p)
        {
            MojDBCOntext db = new MojDBCOntext();

            List<Grad> gradovi =db.Grad.Where(x=>x.Naziv!=null).ToList(); 
            ViewBag.GradoviBag = new SelectList(gradovi, "GradId", "Naziv");

            List<Poslovodja> poslovodje = db.Poslovodja.Where(x => x.Ime != null &x.Prezime != null).ToList();


            ViewBag.PoslovodjeBag = new SelectList(poslovodje, "UposlenikId", "username");
           
            if(p.UposlenikId==0)
            {
                p.UposlenikId = poslovodje.FirstOrDefault(x => x.UposlenikId > 0).UposlenikId;
            }
            if(p.GradId==0)
            {
                p.GradId = gradovi.FirstOrDefault(x => x.GradId > 0).GradId;
            }
            List<Projekt> provjera = db.Projekt.Where(x => x.Adresa == p.Adresa & x.UposlenikId==p.UposlenikId).ToList();
            if (provjera.Count() > 0 || p.Naziv==null)
            {
                //return Json(new { status = false, message = "Projekt vec dodan" });
                return View("AddProjekt");
            }
            p.Status = true;

            Projekt projekt = new Projekt();
           
            projekt.Naziv = p.Naziv;
            projekt.Adresa = p.Adresa;
            projekt.GradId = p.GradId;
            projekt.UposlenikId = p.UposlenikId;
            projekt.Status = p.Status;
            projekt.Pocetak = p.Pocetak;
            projekt.Kraj = p.Kraj;
            db.Projekt.Add(projekt);
            db.SaveChanges();
            ModelState.Clear();
            //return Json(new { status = true, message = "Dodavanje uspjesno!" });
            return View();
        }
       
        public IActionResult KreirajPlatnaLista(PlatnaLista p)
        {
            MojDBCOntext db = new MojDBCOntext();
           
            List<Administracija> listaadm = db.Administracija.ToList();
                if (p.UposlenikId == 0)
                    p.UposlenikId = listaadm.FirstOrDefault(x => x.UposlenikId > 0).UposlenikId;

            ViewBag.AdmiBag = new SelectList(listaadm, "UposlenikId", "UposlenikId");


            PlatnaLista pl = db.PlatnaLista.SingleOrDefault(x => x.godina == p.godina && x.mjesec == p.mjesec);
            if (pl != null)
                return View("KreirajPlatnaLista");


            PlatnaLista plista = new PlatnaLista();
                plista.mjesec = p.mjesec;
                plista.godina = p.godina;
                plista.DatumKreiranja = System.DateTime.Now;
                plista.UposlenikId = p.UposlenikId;
                db.PlatnaLista.Add(plista);
                db.SaveChanges();
                ModelState.Clear();

                return View();
           
            

        }

        public IActionResult AddSkladistarPlatna(string username,Skladistar s)
        {


            return View();
        }
        public IActionResult AddPoslovodjaPlatna(Poslovodja p)
        {
            return View();
        }
        public IActionResult AddRadnikPlatna(Radnik r)
        {
            return View();
        }

        

    }
}