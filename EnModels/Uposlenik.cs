using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ConManApp.EnModels
{
    public abstract class Uposlenik
    {
       
        public int UposlenikId { get; set; }
        [Required(ErrorMessage ="Obavezan unos imena")]
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KontaktBroj { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }
}
