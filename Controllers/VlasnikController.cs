using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ConManApp.EnModels;
using ConManApp.DB;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;

namespace ConManApp.Controllers
{
    public class VlasnikController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddDrzava(Drzava d)
        {
            MojDBCOntext db = new MojDBCOntext();
            Drzava drzava = new Drzava();
            drzava.Naziv = d.Naziv;
            db.Drzava.Add(drzava);
            db.SaveChanges();
            return View();
        }
        public IActionResult AddPodaci(Vlasnik v)
        {
            MojDBCOntext db = new MojDBCOntext();
            Vlasnik vlasnik = new Vlasnik();
            vlasnik.Ime = v.Ime;
            vlasnik.Prezime = v.Prezime;
            vlasnik.username = v.username;
            vlasnik.password = v.password;
            db.Vlasnik.Add(vlasnik);
            db.SaveChanges();
            ModelState.Clear();
            return View();
        }
        public ActionResult AddGrad(Grad grad)
        {
            MojDBCOntext db = new MojDBCOntext();
            Grad g = new Grad();
            List<Drzava> drzavalist = db.Drzava.Where(x => x.Naziv != null).ToList();
            ViewBag.D = new SelectList(drzavalist, "DrzavaId", "Naziv");

            if (grad.DrzavaId == 0)
                grad.DrzavaId = drzavalist.FirstOrDefault(x => x.DrzavaId > 0).DrzavaId;

            g.Naziv = grad.Naziv;
            g.DrzavaId = grad.DrzavaId;
            List<Grad> check = db.Grad.Where(x => x.Naziv == g.Naziv && x.DrzavaId == g.DrzavaId).ToList();
            if (check.Count() > 0)
            {
                return View("AddGrad");
            }
            db.Grad.Add(g);

            db.SaveChanges();
            ModelState.Clear();
            return View();
        }

        public IActionResult AddUred(Ured u)
        {
            MojDBCOntext db = new MojDBCOntext();

            List<Grad> gradovi = db.Grad.Where(x => x.Naziv != null).ToList();
            ViewBag.GradoviBag = new SelectList(gradovi, "GradId", "Naziv");
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
            List<Ured> t = db.Ured.Where(x => x.Adresa == ured.Adresa && x.GradId == ured.GradId).ToList();

            if (t.Count() != 0)
            {
                return View("AddUred");
                //return Json(new { status = false, message = "Ured vec dodan!" });


            }

            db.Ured.Add(ured);
            db.SaveChanges();
            ModelState.Clear();
            return View();
        }

        public IActionResult AddAdministracija(Administracija a)
        {
            MojDBCOntext db = new MojDBCOntext();
            List<Ured> uredi = new List<Ured>();
            uredi = db.Ured.ToList();
            ViewBag.UrediBag = new SelectList(uredi, "UredId", "Adresa");
            if (a.UredId == 0)
            {
                a.UredId = uredi.FirstOrDefault(x => x.UredId > 0).UredId;
            }
           
            
            Administracija admi = new Administracija();
            admi.Ime = a.Ime;
            admi.Prezime = a.Prezime;
            admi.KontaktBroj = a.KontaktBroj;
            admi.username = a.username;
            admi.password = a.password;
            admi.StrucnoZvanje = a.StrucnoZvanje;
            admi.UredId = a.UredId;
            if (ModelState.IsValid)
            {
                db.Administracija.Add(admi);
                db.SaveChanges();
                ModelState.Clear();
                return View();
            }
            else
                return View("AddAdministracija");

            
        }
    }
}