using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ConManApp.EnModels
{
    public class ProjektInfo
    {
        public int ProjektInfoId { get; set; }
        public string textInfo { get; set; }
        public DateTime DatumKreiranja { get; set; }
        [ForeignKey("Projekt")]
        public int ProjektId { get; set; }
        public Projekt Projekt { get; set; }
       
        
        

    }
}
