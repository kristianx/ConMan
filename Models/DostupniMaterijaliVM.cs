using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConManApp.Models
{
    public class DostupniMaterijaliVM
    {
        public int ProjektID { get; set; }
        public int PredracunID { get; set; }
        public List<Rows> rows { get; set; }
        public string Filter { get; set; }
        public class Rows
        {
            public int MaterijalID { get; set; }
            public string Naziv { get; set; }
            public string NazivGrupe { get; set; }
            public string MjernaJedinicaGrupe { get; set; }
            public string NazivSkladista { get; set; }
            public int Kolicina { get; set; }
        }
    }
}
