using ConManApp.EnModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConManApp.Models
{
    public class PoslovodjaVM
    {
        public int UposlenikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KontaktBroj { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string iskustvo { get; set; }
        public List<Projekt> projekti { get; set; }
    }
}
