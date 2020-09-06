using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ConManApp.EnModels
{
    public class PlatnaSkladistar
    {
        public int  PlatnaSkladistarID { get; set; }
        [ForeignKey("PlatnaLista")]
        public int PlatnaListaId { get; set; }
        public PlatnaLista PlatnaLista { get; set; }
        [ForeignKey("Skladistar")]
        public int UposlenikId { get; set; }
        public Skladistar Skladistar { get; set; }

        public int IznosPlate { get; set; }
    }
}
