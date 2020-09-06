using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ConManApp.EnModels
{
    public class Skladiste
    {
        public int SkladisteId { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        [ForeignKey("Grad")]
        public int GradId { get; set; }
        public Grad Grad { get; set; }

        public int GetId() { return SkladisteId; }

    }
}
