using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ConManApp.EnModels
{
    public class Oprema
    {
        public int OpremaId { get; set; }
        public string Naziv { get; set; }
        [ForeignKey("Skladiste")]
        public int SkladisteId { get; set; }
        public Skladiste Skladiste { get; set; }
        public bool JeIznajmljeno { get; set; }
        public bool usable { get; set; }
        

    }
}
