using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConManApp.Models
{
    public class VoziloSkladisteVM
    {
        public int VoziloId { get; set; }
        public string NazivProizvodjaca { get; set; }
        public string Model { get; set; }
        public bool JeIznajmljeno { get; set; }
        public string GodinaProizvodnje { get; set; }
        public int SkladisteId { get; set; }
        public int TipVozilaId { get; set; }
        public string SlikaVozila { get; set; }
    }
}
