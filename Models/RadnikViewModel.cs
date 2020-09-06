using ConManApp.EnModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConManApp.Models
{
    public class RadnikViewModel
    {
        public int RadnikViewModelId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KontaktBroj { get; set; }
        public string username { get; set; }
        public string password { get; set; }

        public string info { get; set; }

        public List<RadnikVozilo> zaduzenaVozila { get; set; }
        public List<RadnikOprema> zaudzenaOprema { get; set; }
    }
}
