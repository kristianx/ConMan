using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ConManApp.DB;
using ConManApp.EnModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ConManApp.Controllers
{
    public class VoziloController : Controller
    {
        public ActionResult AddVozilo(Vozilo v)
        {
            MojDBCOntext db = new MojDBCOntext();
            
            List<TipVozila> lista = db.TipVozila.ToList();
            ViewBag.Tip = new SelectList(lista, "TipVozilaId", "NazivTipa");
            List<Skladiste> lista2 = db.Skladiste.ToList();
            ViewBag.Skla = new SelectList(lista2, "SkladisteId", "Naziv");
            if (v.SkladisteId == 0)
            {
                v.SkladisteId = lista2.FirstOrDefault(x => x.SkladisteId > 0).SkladisteId;
            }//defaultna postavka radi foreignkey!=null ili bilo koji idevi iz baze za skladiste i tip vozila za potrebe testne app
            if(v.TipVozilaId ==0)
            {
                v.TipVozilaId = lista.FirstOrDefault(x => x.TipVozilaId > 0).TipVozilaId;
            }


                Vozilo m = new Vozilo();

                m.NazivProizvodjaca = v.NazivProizvodjaca;
                m.Model = v.Model;
                m.GodinaProizvodnje = v.GodinaProizvodnje;
                m.TipVozilaId = v.TipVozilaId;
                m.SkladisteId = v.SkladisteId;
            m.SlikaVozila = v.SlikaVozila;

            
           

            db.Vozilo.Add(m);
            db.SaveChanges();

            ModelState.Clear();

            return View();
        }
    }
}