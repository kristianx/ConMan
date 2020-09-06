using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ConManApp.EnModels
{
    public class PredracunMaterijal
    {
        public int PredracunMaterijalId { get; set; }
        [ForeignKey("Predracun")]
        public int PredracunId { get; set; }
        public Predracun Predracun { get; set; }
        [ForeignKey("Materijal")]
        public int MaterijalId { get; set; }
        public Materijal Materijal { get; set; }
        
    }
}
