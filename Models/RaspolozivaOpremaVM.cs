using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConManApp.Models
{
    public class RaspolozivaOpremaVM
    {
        public string username { get; set; }
        public List<Rows> rows { get; set; }
        public string Filter { get; set; }
        public class Rows
        {
            public int OpremaID { get; set; }
            public string Naziv { get; set; }
            public string NazivSkladista { get; set; }
            public string AdresaSkladista { get; set; }
        }
    }
}
