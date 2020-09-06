using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ConManApp.EnModels
{
    public class PlatnaPoslovodja
    {
        public int PlatnaPoslovodjaId { get; set; }
        [ForeignKey("PlatnaLista")]
        public int PlatnaListaId { get; set; }
        public PlatnaLista PlatnaLista { get; set; }
        [ForeignKey("Poslovodja")]
        public int UposlenikId { get; set; }
        public Poslovodja Poslovodja { get; set; }
        public int IznosPlate { get; set; }
    }
}
