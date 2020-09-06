using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ConManApp.EnModels
{
    public class Materijal
    {
        public int MaterijalId { get; set; }
        public string Naziv { get; set; }
        [ForeignKey("Skladiste")]
        public int SkladisteId { get; set; }
        public Skladiste Skladiste { get; set; }
        [ForeignKey("Dobavljac")]
        public int DobavljacId { get; set; }
        public Dobavljac Dobavljac { get; set; }
        [ForeignKey("GrupaMaterijal")]
        public int GrupaMaterijalId { get; set; }
        public GrupaMaterijal GrupaMaterijal { get; set; }
        public int Kolicina { get; set; }
        public float Cijena { get; set; }
        public bool Potrosen { get; set; }

    }
}
