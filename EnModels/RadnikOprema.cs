using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ConManApp.EnModels
{
    public class RadnikOprema
    {
        public int RadnikOpremaId { get; set; }
        [ForeignKey("Radnik")]
        public int UposlenikId { get; set; }
        public Radnik Radnik { get; set; }
        [ForeignKey("Oprema")]
        public int OpremaId { get; set; }
        public Oprema Oprema { get; set; }

        public DateTime DatumZaduzivanja { get; set; }
        public DateTime DatumKrajaZaduzivanja { get; set; }
        public Nullable<DateTime> DatumVracanja { get; set; }
        public string svrhaIznajmljivanja { get; set; }
    }
}
