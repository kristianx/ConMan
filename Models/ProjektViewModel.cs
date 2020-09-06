using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConManApp.EnModels;
using PagedList;
using ReflectionIT.Mvc.Paging;

namespace ConManApp.Models
{
    public class ProjektViewModel
    {
        public int ProjektViewModelId { get; set; }
        public string Naziv { get; set; }
        public string GradNaziv { get; set; }
        public string Adresa { get; set; }
        public List<ProjektiInfo> InformacijeOProjektu { get; set; }
        public List<RadnikNaProjektu> Radnici { get; set; }
        public List<PredracunZaProjekt> Predracuni { get; set; }
        public class ProjektiInfo
        {
            public int InfoID { get; set; }
            public string InfoText { get; set; }
            public DateTime InfoDatum { get; set; }
        }
        public class RadnikNaProjektu
        {
            public int ID { get; set; }
            public string ImePrezime { get; set; }
            public string Username { get; set; }
            public DateTime DatumDodavanja { get; set; }
            public string PozicijaUProjektu { get; set; }
        }

        public class PredracunZaProjekt
        {
            public int PredracunID { get; set; }
            public string NazivPredracuna { get; set; }
            public bool JeOdobren { get; set; }
            public DateTime DatumKreiranja { get; set; }

        }


        public List<RadnikNaProjektu> GetRadniciSaProjekta()
        {
            return Radnici;
        }

        
    }
}
