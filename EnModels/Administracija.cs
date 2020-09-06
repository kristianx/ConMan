using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ConManApp.EnModels
{
    public class Administracija:Uposlenik
    {
        public string StrucnoZvanje { get; set; }
        [ForeignKey("Ured")]
        public int UredId { get; set; }
        public Ured Ured { get; set; }


    }
}
