using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ConManApp.EnModels
{
    public class NarudzbaMaterijal
    {
        public int NarudzbaMaterijalId { get; set; }
        [ForeignKey("Narudzba")]
        public int NarudzbaId { get; set; }
        public Narudzba Narudzba { get; set; }
        [ForeignKey("Materijal")]
        public int MaterijalId { get; set; }
        public Materijal Materijal { get; set; }
    }
}
