using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ConManApp.EnModels
{
    public class Predracun
    {
        public int PredracunId { get; set; }
        public string NazivPredracuna { get; set; }
        public DateTime DatumKreiranja { get; set; }
        [ForeignKey("Poslovodja")] 
        public int UposlenikId { get; set; }
        public Poslovodja Poslovodja { get; set; }
        [ForeignKey("Projekt")]
        public int ProjektId { get; set; }
        public Projekt Projekt { get; set; }
        public bool JeOdobren { get; set; }
        

    }
}
