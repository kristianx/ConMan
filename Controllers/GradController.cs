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
    public class GradController : Controller
    {
        public ActionResult DDList()
        {
            MojDBCOntext db = new MojDBCOntext();
            List<Drzava> drzavalist = db.Drzava.ToList();
            ViewBag.D = new SelectList(drzavalist, "DrzavaId", "Naziv");
            return View();
        }
        public ActionResult Add(Grad grad)
        {
            MojDBCOntext db = new MojDBCOntext();
            Grad g = new Grad();
            List<Drzava> drzavalist = db.Drzava.ToList();
            ViewBag.D = new SelectList(drzavalist, "DrzavaId", "Naziv");

            if (grad.DrzavaId == 0)
                grad.DrzavaId = drzavalist.FirstOrDefault(x => x.DrzavaId > 0).DrzavaId;

            g.Naziv = grad.Naziv;
            g.DrzavaId = grad.DrzavaId;
            db.Grad.Add(g);
            db.SaveChanges();
            return View();
        }
    }
}