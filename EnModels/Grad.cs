using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ConManApp.EnModels
{
    public class Grad
    {
        public int GradId { get; set; }
        public string Naziv { get; set; }
        [ForeignKey("Drzava")]
        public int DrzavaId { get; set; }
        public Drzava Drzava { get; set; }

        public int getGradId() { return GradId; }
        public string getNaziv() { return Naziv; }
    }
}
