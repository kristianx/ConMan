using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ConManApp.EnModels
{
    public class Narudzba
    {
        public int NarudzbaId { get; set; }
        public DateTime DatumKreiranja { get; set; }
        [ForeignKey("Administracija")]
        public int UposlenikId{ get; set; }
        public Administracija Administracija { get; set; }

        public string SpisakPotrebnihMaterijala { get; set; }


    }
}
