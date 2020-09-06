using ConManApp.EnModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConManApp.Models
{
    public class RadnikIndexVM
    {
        public int UposlenikID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public List<IznOprema> OpremaIznajmljena { get;set;}
        public List<IznVozilo> VozilaIznajmljena { get; set; }
        public class IznOprema
        {
            public int RadnikOpremaID { get; set; }
            public int OpremaID { get; set; }
            public string OpremaNaziv { get; set; }
            public string NazivSkladista { get; set; }
            public DateTime DatumIznajmljivanja { get; set; }
            public DateTime DatumKrajaIznajmljivanja { get; set; }
            public string SvrhaIznajmljivanja { get; set; }
            
        }
        public class IznVozilo
        {
            public int RadnikVoziloID { get; set; }
            public int VoziloID { get; set; }
            public string GodinaProizvodnje { get; set; }
            public string NazivVozila { get; set; }
            public string NazivSkladista { get; set; }
            public DateTime DatumIznajmljivanja { get; set; }
            public DateTime DatumKrajaIznajmljivanja { get; set; }
            public string SvrhaIznajmljivanja { get; set; }
        }
    }
}
