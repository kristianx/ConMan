using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ConManApp.DB;
using ConManApp.EnModels;
namespace ConManApp.Controllers
{
    public class TipVozilaController : Controller
    {
        public IActionResult Index()
        {
            MojDBCOntext db = new MojDBCOntext();
            List<TipVozila> lista=db.TipVozila.ToList();
            return View(lista);
        }

        public IActionResult AddTipTest(string nazivtipa)
        {
            MojDBCOntext db = new MojDBCOntext();
            TipVozila t = new TipVozila();
            t.NazivTipa = nazivtipa;
            db.TipVozila.Add(t);
            db.SaveChanges();
            return View();
        }
    }
}