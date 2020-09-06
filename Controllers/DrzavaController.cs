using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ConManApp.DB;
using ConManApp.EnModels;
namespace ConManApp.Controllers
{
    public class DrzavaController : Controller
    {
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
    }
}