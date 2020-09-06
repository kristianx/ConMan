using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ConManApp.EnModels
{
    public class PlatnaRadnik
    {
        public int PlatnaRadnikId { get; set; }
        [ForeignKey("PlatnaLista")]
        public int PlatnaListaId { get; set; }
        public PlatnaLista PlatnaLista { get; set; }
        [ForeignKey("Radnik")]
        public int UposlenikId { get; set; }
        public Radnik Radnik { get; set; }
        public int IznosPlate { get; set; }
    }
}
