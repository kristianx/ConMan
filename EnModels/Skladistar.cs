using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ConManApp.EnModels
{
    public class Skladistar : Uposlenik
    {

        [ForeignKey("Skladiste")]
        public int SkladisteId { get; set; }
        public Skladiste Skladiste { get; set; }
        public bool TwoFaAuth {get;set;}

    }
}