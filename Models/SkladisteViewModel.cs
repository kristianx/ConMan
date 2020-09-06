using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConManApp.EnModels;
namespace ConManApp.Models
{
    public class SkladisteViewModel
    {
        public string ImeSkladistara { get; set; }
        public string UsernameSkladistara { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public string GradNaziv { get; set; }

        public List<Vozilo> Vozila { get; set; }
        public List<Materijal> Materijali { get; set; }
        public List<Oprema> Oprema { get; set; }

    }
}
