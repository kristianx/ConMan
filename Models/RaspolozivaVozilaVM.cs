using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConManApp.Models
{
    public class RaspolozivaVozilaVM
    {
        public string username { get; set; }
        public List<Rows> rows { get; set; }
        public class Rows
        {
            public int VoziloID { get; set; }
            public byte[] Slika { get; set; }
            public string Proizvodjac { get; set; }
            public string Model { get; set; }
            public string GodinaProizvodnje { get; set; }
            public string TipVozila { get; set; }
            public string NazivSkladista { get; set; }
            public string AdresaSkladista { get; set; }
        }
    }
}
