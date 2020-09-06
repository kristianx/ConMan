using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ConManApp.EnModels
{
    public class RadnikProjekt
    {
        public int RadnikProjektId { get; set; }
        [ForeignKey("Projekt")]
        public int ProjektId { get; set; }
        public Projekt Projekt { get; set; }
        [ForeignKey("Radnik")]
        public int UposlenikId { get; set; }
        public Radnik Radnik { get; set; }

        [Required(ErrorMessage ="Obavezan unos polja")]
        [RegularExpression(@"[A-Z][a-zA-Z]{2,10}"), StringLength(10)]
        public string pozicijauProjektu { get; set; }
        public DateTime DatumDodavanja { get; set; }
        public Nullable<DateTime> DatumUklanjanja { get; set; }

        public Radnik GetRadnik()
        {
            return Radnik;
        }
    }
}
