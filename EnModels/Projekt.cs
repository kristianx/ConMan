using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ConManApp.EnModels
{
    public class Projekt
    {
        public int ProjektId { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        [ForeignKey("Grad")]
        public int GradId { get; set; }
        public Grad Grad { get; set; }
        [ForeignKey("Poslovodja")]
        public int UposlenikId { get; set; }
        public Poslovodja Poslovodja { get; set; }
        public bool Status { get; set; }
        public DateTime Pocetak { get; set; }
        public DateTime Kraj { get; set; }

       
        



    }
}
