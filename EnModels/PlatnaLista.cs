using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ConManApp.EnModels
{
    public class PlatnaLista
    {
        public int PlatnaListaId { get; set; }
        [ForeignKey("Administracija")]
        public int UposlenikId { get; set; }
        public Administracija Administracija { get; set; }
        public DateTime DatumKreiranja { get; set; }
        public string mjesec { get; set; }
        public string godina { get; set; }
    }
}
