using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConManApp.EnModels;
namespace ConManApp.Models
{
    public class SkladisteViewModel2
    {

       
            public string Naziv { get; set; }
            public string Adresa { get; set; }
            public string GradNaziv { get; set; }

            List<Vozilo> Vozila { get; set; }
            List<Materijal> Materijali { get; set; }
        
    }
}
