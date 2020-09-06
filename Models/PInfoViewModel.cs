using ConManApp.EnModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConManApp.Models
{
    public class PInfoViewModel
    {
       
        public int ProjektID { get; set; }
        public List<Rows> rows { get; set; }

        public class Rows
        {
            public string textinfo { get; set; }
            public string DatumInfo { get; set; }
        }

       
        
       
        
    }
}
