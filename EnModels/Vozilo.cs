using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ConManApp.EnModels
{
    public class Vozilo
    {
        public int VoziloId { get; set; }
        public string NazivProizvodjaca { get; set; }
        public string Model { get; set; }
        public bool JeIznajmljeno { get; set; }
        public string GodinaProizvodnje { get; set; }
        [ForeignKey("Skladiste")]
        public int SkladisteId { get; set; }
        public Skladiste Skladiste { get; set; }
        [ForeignKey("TipVozila")]
        public int TipVozilaId { get; set; }
        public TipVozila TipVozila { get; set; }
        public byte[] SlikaVozila { get; set; }


    }
}
