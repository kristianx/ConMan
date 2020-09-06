using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConManApp.Models
{
    public class VoziloViewModel
    {
        public int voziloID { get; set; }
        public string ProizvodjacNaziv { get; set; }
        public string ModdelNaziv { get; set; }
        public string nazivskladista { get; set; }
        public string adresaskladista { get; set; }
        public string NazivGrada { get; set; }
        public string tipvozila { get; set; }
    }
}
