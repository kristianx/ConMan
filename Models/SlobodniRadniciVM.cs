using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConManApp.Models
{
    public class SlobodniRadniciVM
    {
        public int ProjektID { get; set; }
        public string ProjektNaziv { get; set; }
        public List<Rows> rows { get; set; }
        public string Filter { get; set; }
        public class Rows
        {
            public int UposlenikId { get; set; }
            public string Ime { get; set; }
            public string Prezime { get; set; }
            public string KontaktBroj { get; set; }
            public string Username { get; set; }
        }
    }
}
