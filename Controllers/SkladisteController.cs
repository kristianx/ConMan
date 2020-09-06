using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ConManApp.DB;
using ConManApp.EnModels;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ConManApp.Controllers
{
    public class SkladisteController : Controller
    {
        public IActionResult AddSkladiste(/*string naziv,string adresa,int gradid=2*/ Skladiste sk) //za test postavim 12
            //,a pomocu padajuce liste se overwrites u broj zeljenog grada.ovo je samo testni pokusaj
        {
            MojDBCOntext db = new MojDBCOntext();
            List<Grad> gradovi = db.Grad.ToList();
            ViewBag.GradoviBag = new SelectList(gradovi, "GradId", "Naziv");
            if(sk.GradId==0)
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
    }
}