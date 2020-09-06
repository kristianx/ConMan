using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConManApp.Models
{
    public class PredracunDetaljiVM
    {
        public int ProjektID { get; set; }
        public int PredracunID { get; set; }
        public string NazivPredracuna { get; set; }
        public string NazivProjekta { get; set; }
        public float UkupnaCijenaPredracuna { get; set; }
        public List<Rows> rows { get; set; }
        public class Rows
        {
            public int PredracunMaterijalId { get; set; }
            public int MaterijalID { get; set; }
            public string MaterijalNaziv { get; set; }
            public int Kolicina { get; set; }
            public string GrupaMaterijalaNaziv { get; set; }
            public string OznakaMjerneJedinice { get; set; }
            public float MaterijalCijena { get; set; }
        }
    }
}
