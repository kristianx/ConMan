using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ConManApp.EnModels
{
    public class Ured
    {
        public int UredId { get; set; }
        [Required(ErrorMessage ="Unesite adresu:")]
        public string Adresa { get; set; }
        [ForeignKey("Grad")]
        public int GradId { get; set; }
        public Grad Grad { get; set; }

    }
}
