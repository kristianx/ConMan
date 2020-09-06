using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using ConManApp.EnModels;
using ConManApp.DB;
using Microsoft.AspNetCore.Mvc.Rendering;
using ConManApp.Models;
using PagedList.Mvc;
using PagedList;
using System.Web;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using ReflectionIT.Mvc.Paging;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Identity;
using static ConManApp.Models.ProjektViewModel;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;
using System.Reflection;
using System.IO;
using System.Xml;
using GridMvc;
using OfficeOpenXml;



namespace ConManApp.Controllers
{
    public class PoslovodjaController : Controller
    {
        public IActionResult Index1()
        {
            MojDBCOntext db = new MojDBCOntext();
            string username = HttpContext.Session.GetString("username");
            Poslovodja p = db.Poslovodja.FirstOrDefault(x => x.username == username);


            List<Projekt> projekti = db.Projekt.Where(x => x.UposlenikId == p.UposlenikId && x.Naziv != null && x.Status==true).ToList();
            PoslovodjaVM pos = new PoslovodjaVM();
            pos.username = p.username;
            pos.Ime = p.Ime;
            pos.projekti = projekti;
            return View(pos);

        }
        public IActionResult PregledSlobodnihRadnika(int projektid,string Filter="")
        {
            MojDBCOntext db = new MojDBCOntext();
            string username = HttpContext.Session.GetString("username");
            Poslovodja p = db.Poslovodja.FirstOrDefault(x => x.username == username);
            Projekt proj = db.Projekt.FirstOrDefault(x => x.ProjektId == projektid && x.UposlenikId == p.UposlenikId);
            if (Filter == null)
            {
                SlobodniRadniciVM Model = new SlobodniRadniciVM()
                {
                    ProjektID=proj.ProjektId,
                    ProjektNaziv=proj.Naziv,
                    rows = db.Radnik.Where(x => x.Zauzet == false).Select(x => new SlobodniRadniciVM.Rows
                    {
                        UposlenikId = x.UposlenikId,
                        Ime = x.Ime,
                        Prezime = x.Prezime,
                        KontaktBroj = x.KontaktBroj,
                        Username = x.username

                    }).ToList()
                };
                return View(Model);
            }
            else
            {
                SlobodniRadniciVM Model = new SlobodniRadniciVM()
                {
                    ProjektID = proj.ProjektId,
                    ProjektNaziv = proj.Naziv,
                    rows = db.Radnik.Where(x => x.Zauzet == false && x.Ime.Contains(Filter)).Select(x => new SlobodniRadniciVM.Rows
                    {
                        UposlenikId = x.UposlenikId,
                        Ime = x.Ime,
                        Prezime = x.Prezime,
                        KontaktBroj = x.KontaktBroj,
                        Username = x.username

                    }).ToList()
                };
                return View(Model);
            }

            
        }

        public IActionResult PregledDostupnihMaterijala(int predracunid,string Filter="")
        {
            MojDBCOntext db = new MojDBCOntext();
            string username = HttpContext.Session.GetString("username");
            Poslovodja p = db.Poslovodja.FirstOrDefault(x => x.username == username);
            Predracun predracun = db.Predracun.FirstOrDefault(x => x.PredracunId == predracunid && x.UposlenikId == p.UposlenikId);
            List<PredracunMaterijal> postojeciMaterijali = db.PredracunMaterijal.Where(x => x.PredracunId == predracunid).ToList();
            List<int> listaMaterijaliID = new List<int>();
            foreach(var x in postojeciMaterijali)
            {
                listaMaterijaliID.Add(x.MaterijalId);
            }
            if (Filter == null)
            {
                DostupniMaterijaliVM Model = new DostupniMaterijaliVM()
                {
                    ProjektID = predracun.ProjektId,
                    PredracunID = predracun.PredracunId,
                    rows = db.Materijal.Include(x => x.GrupaMaterijal).Include(x => x.Skladiste).Where(x => x.Potrosen == false&& !listaMaterijaliID.Contains(x.MaterijalId) && x.Naziv!=null).Select(x => new DostupniMaterijaliVM.Rows
                    {
                        MaterijalID = x.MaterijalId,
                        Naziv = x.Naziv,
                        NazivGrupe = x.GrupaMaterijal.NazivGrupe,
                        MjernaJedinicaGrupe = x.GrupaMaterijal.JedinicaMjere,
                        NazivSkladista = x.Skladiste.Naziv,
                        Kolicina = x.Kolicina
                    }).ToList()

                };
                return View(Model);
            }
            else
            {
                DostupniMaterijaliVM Model = new DostupniMaterijaliVM()
                {
                    ProjektID = predracun.ProjektId,
                    PredracunID = predracun.PredracunId,
                    rows = db.Materijal.Include(x => x.GrupaMaterijal).Include(x => x.Skladiste).Where(x => x.Potrosen == false&& !listaMaterijaliID.Contains(x.MaterijalId)&& x.Naziv != null&&(x.Naziv.Contains(Filter) || x.Skladiste.Naziv.Contains(Filter))).Select(x => new DostupniMaterijaliVM.Rows
                    {
                        MaterijalID = x.MaterijalId,
                        Naziv = x.Naziv,
                        NazivGrupe = x.GrupaMaterijal.NazivGrupe,
                        MjernaJedinicaGrupe = x.GrupaMaterijal.JedinicaMjere,
                        NazivSkladista = x.Skladiste.Naziv,
                        Kolicina = x.Kolicina
                    }).ToList()

                };
                return View(Model);
            }

            
        }

        public IActionResult AddMaterijalPredracun(int predracunid,int materijalid)
        {
            MojDBCOntext db = new MojDBCOntext();
            string username = HttpContext.Session.GetString("username");
            Poslovodja p = db.Poslovodja.FirstOrDefault(x => x.username == username);
            Predracun predracun = db.Predracun.FirstOrDefault(x => x.PredracunId == predracunid && x.UposlenikId == p.UposlenikId);
            Materijal m = db.Materijal.FirstOrDefault(x => x.MaterijalId == materijalid);

            PredracunMaterijal predmat = new PredracunMaterijal()
            {
                MaterijalId = m.MaterijalId,
                PredracunId = predracun.PredracunId
            };
            db.PredracunMaterijal.Add(predmat);
            db.SaveChanges();

            return Redirect("/Poslovodja/PredracunDetalji?predracunid="+predracunid);
        }
        public IActionResult AddProjektInfo(int projektid,ProjektInfo pi)
        {
            MojDBCOntext db = new MojDBCOntext();
            string username = HttpContext.Session.GetString("username");
            Poslovodja p = db.Poslovodja.SingleOrDefault(x => x.username == username);

            //List<Projekt> projekti = db.Projekt.Where(x => x.UposlenikId == p.UposlenikId).ToList();

            ////List<Projekt> projekti = db.Projekt.Where(x=>x.Naziv!=null).ToList();
            //ViewBag.ProjektiBag = new SelectList(projekti, "ProjektId", "Naziv");
            //pi.DatumKreiranja = System.DateTime.Now;
            if (pi.ProjektId == 0)
                pi.ProjektId = projektid;

            pi.ProjektId = projektid;

            ProjektInfo projekt = new ProjektInfo();
            projekt.textInfo = pi.textInfo;
            projekt.ProjektId = projektid;
            projekt.DatumKreiranja = System.DateTime.Now;
            if (projekt.textInfo != null)
            {
                db.ProjektInfo.Add(projekt);
                db.SaveChanges();
                ModelState.Clear();
                return Redirect("/Poslovodja/DetaljiProjekta?id=" + projektid);
               
            }
           
            return View();

        }

        public IActionResult AddRadnikProjekt(int projektid,int radnikid, string pozicija=""/*RadnikProjekt rp*/)
        {
            MojDBCOntext db = new MojDBCOntext();
            //List<Projekt> projekti = db.Projekt.Where(x => x.Naziv != null).ToList();
            string uname = HttpContext.Session.GetString("username");

            Poslovodja p = db.Poslovodja.FirstOrDefault(x => x.username == uname);

            //List<Projekt> projekti = db.Projekt.Where(x => x.UposlenikId == p.UposlenikId && x.Naziv != null).ToList();
            //List<Radnik> radnici = db.Radnik.Where(x => x.Ime != null).ToList();
            //ViewBag.usernameBag = p.username;
            //ViewBag.ProjektiBag = new SelectList(projekti, "ProjektId", "Naziv");
            //ViewBag.RadniciBag = new SelectList(radnici, "UposlenikId", "username");
            //if (rp.UposlenikId == 0)
            //    rp.UposlenikId = db.Radnik.FirstOrDefault(x => x.UposlenikId > 0).UposlenikId;
            //if (rp.ProjektId == 0)
            //    rp.ProjektId = db.Projekt.FirstOrDefault(x=>x.ProjektId>0).ProjektId;

            //rp.UposlenikId = radnikid;
            //rp.ProjektId = projektid;
            RadnikProjekt radnikProjekt = new RadnikProjekt();
            radnikProjekt.ProjektId = projektid;
            radnikProjekt.UposlenikId = radnikid;
            radnikProjekt.pozicijauProjektu = pozicija;
            Radnik r = db.Radnik.FirstOrDefault(x => x.UposlenikId == radnikProjekt.UposlenikId);
            r.Zauzet = true;
            //RadnikProjekt provjera = db.RadnikProjekt.FirstOrDefault(x => x.UposlenikId == rp.UposlenikId && x.ProjektId == rp.ProjektId && x.DatumUklanjanja==null);
            if (radnikProjekt.pozicijauProjektu != null)
            {
                radnikProjekt.DatumDodavanja = System.DateTime.Now;
                radnikProjekt.DatumUklanjanja = null;
                db.RadnikProjekt.Add(radnikProjekt);
                db.SaveChanges();
                ModelState.Clear();
                return Redirect("/Poslovodja/DetaljiProjekta?id=" + projektid);
            }
            else
                return View();
        }
        public IActionResult UkloniRadnika(int projektid, int radnikid)
        {
            MojDBCOntext db = new MojDBCOntext();
            string username = HttpContext.Session.GetString("username");
            Poslovodja p = db.Poslovodja.FirstOrDefault(x => x.username == username);
            RadnikProjekt rp = db.RadnikProjekt.FirstOrDefault(x => x.ProjektId == projektid && x.UposlenikId == radnikid && x.DatumUklanjanja == null);
            Radnik r = db.Radnik.FirstOrDefault(x => x.UposlenikId == rp.UposlenikId);
            r.Zauzet = false;
            rp.DatumUklanjanja = System.DateTime.Now;
            db.SaveChanges();
            return Redirect("/Poslovodja/DetaljiProjekta?id=" + rp.ProjektId); 
        }
        public IActionResult UkloniPredracunStavku(int predracunid,int stavkaid)
        {
            MojDBCOntext db = new MojDBCOntext();
            Predracun p = db.Predracun.FirstOrDefault(x => x.PredracunId == predracunid);
            PredracunMaterijal predmat = db.PredracunMaterijal.Find(stavkaid);
            db.PredracunMaterijal.Remove(predmat);
            db.SaveChanges();
            return Redirect("/Poslovodja/PredracunDetalji?predracunid=" + p.PredracunId);
        }
        public IActionResult KreirajPredracun(int projektid,Predracun predracun)
        {
            MojDBCOntext db = new MojDBCOntext();
            var username = HttpContext.Session.GetString("username");
            Poslovodja poslovodja = db.Poslovodja.FirstOrDefault(x => x.username == username);
            predracun.ProjektId = projektid;

            Predracun p = new Predracun()
            {
                ProjektId = projektid,
                DatumKreiranja = System.DateTime.Now,
                NazivPredracuna = predracun.NazivPredracuna,
                UposlenikId = poslovodja.UposlenikId,
                JeOdobren = false


            };
            if (p.NazivPredracuna != null)
            {
                db.Predracun.Add(p);
                db.SaveChanges();
                ModelState.Clear();
                return Redirect("/Poslovodja/DetaljiProjekta?id=" + projektid);
            }
            else
            return View();
        }

        public IActionResult PredracunDetalji(int predracunid)
        {
            MojDBCOntext db = new MojDBCOntext();

            Predracun predracun = db.Predracun.Include(c=>c.Projekt).FirstOrDefault(x => x.PredracunId == predracunid);
            PredracunDetaljiVM Model = new PredracunDetaljiVM()
            {
                ProjektID=predracun.ProjektId,
                PredracunID = predracun.PredracunId,
                NazivProjekta = predracun.Projekt.Naziv,
                NazivPredracuna = predracun.NazivPredracuna,
                rows = db.PredracunMaterijal.Include(x=>x.Materijal).Include(x=>x.Materijal.GrupaMaterijal).Where(x => x.PredracunId == predracunid).Select(x => new PredracunDetaljiVM.Rows
                {
                    PredracunMaterijalId=x.PredracunMaterijalId,
                    MaterijalID=x.MaterijalId,
                    MaterijalNaziv=x.Materijal.Naziv,
                    GrupaMaterijalaNaziv=x.Materijal.GrupaMaterijal.NazivGrupe,
                    Kolicina=x.Materijal.Kolicina,
                    MaterijalCijena=x.Materijal.Cijena,
                    OznakaMjerneJedinice=x.Materijal.GrupaMaterijal.OznakaJediniceMjere
                    


                }).ToList()


            };
            foreach(var x in Model.rows)
            {
                Model.UkupnaCijenaPredracuna += x.MaterijalCijena;
            }
            return View(Model);
        }

        public IActionResult Login()
        {
            return View();
        }

     

        
        [HttpPost]
        public IActionResult Validacija(LoginViewModel login)
        {
            MojDBCOntext db = new MojDBCOntext();

            var uname = login.username;
            var pw = login.password;

            Poslovodja p = db.Poslovodja.Where(x => x.password == pw && x.username == uname).FirstOrDefault();

            if (p!=null)
            {
                HttpContext.Session.SetString("username", p.username);
                return Json(new { status = true, message = "Login uspjesan!" });

            }
            else
            {
                ViewBag.error = "Invalid Account";
                return Json(new { status = false, message = "Login neuspjesan!" });
            }
        }

        //[Route("logout")]
        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("username");

            return RedirectToAction("Login");
        }



        public IActionResult ViewMyProfile()
        {
            MojDBCOntext db = new MojDBCOntext();
            string username = HttpContext.Session.GetString("username");
            Poslovodja s = db.Poslovodja.SingleOrDefault(x => x.username == username);

            //Skladiste ss = db.Skladiste.FirstOrDefault(x => x.SkladisteId == s.SkladisteId);
            //ViewBag.AdresaSkladista = ss.Adresa;
            List<Projekt> projekti = db.Projekt.Where(x => x.UposlenikId == s.UposlenikId && x.Naziv != null).ToList();
            PoslovodjaVM p = new PoslovodjaVM();
            p.Ime = s.Ime;
            p.username = s.username;
            p.KontaktBroj = s.KontaktBroj;
            p.Prezime = s.Prezime;
            p.iskustvo = s.OpisIskustva;
            p.UposlenikId = s.UposlenikId;
            p.password = s.password;
            p.projekti = projekti;

            return View(p);
        }
        public IActionResult MojiProjekti()
        {
            MojDBCOntext db = new MojDBCOntext();
            string username = HttpContext.Session.GetString("username");
            Poslovodja p = db.Poslovodja.FirstOrDefault(x => x.username == username);
            

            List<Projekt> projekti = db.Projekt.Where(x => x.UposlenikId == p.UposlenikId && x.Naziv != null).ToList();
            PoslovodjaVM pos = new PoslovodjaVM();
            pos.username = p.username;
            pos.projekti = projekti;
            return View(pos);


        }
        public IActionResult UkloniPredracun(int projektid,int predracunid)
        {
            MojDBCOntext db = new MojDBCOntext();

            Projekt p = db.Projekt.FirstOrDefault(x => x.ProjektId == projektid);
            Predracun pred = db.Predracun.FirstOrDefault(x => x.PredracunId == predracunid);
            db.Predracun.Remove(pred);
            db.SaveChanges();
            return Redirect("/Poslovodja/DetaljiProjekta?id=" + projektid);
        }

        public IActionResult DetaljiProjekta(int id)
        {
            MojDBCOntext db = new MojDBCOntext();
            string username = HttpContext.Session.GetString("username");
            Poslovodja s = db.Poslovodja.SingleOrDefault(x => x.username == username);
            List<Projekt> projekti = db.Projekt.Where(x => x.UposlenikId == s.UposlenikId).ToList();
            ViewBag.username = s.username;
            Projekt p = projekti.FirstOrDefault(x => x.ProjektId == id);

            Grad g = db.Grad.FirstOrDefault(x => x.GradId == p.GradId);

            ProjektViewModel pvm = new ProjektViewModel()
            {
                GradNaziv = g.Naziv,
                Adresa = p.Adresa,
                Naziv = p.Naziv,
                ProjektViewModelId = p.ProjektId,
                InformacijeOProjektu = db.ProjektInfo.Where(x => x.ProjektId == id).Select(x => new ProjektViewModel.ProjektiInfo
                {
                    InfoID = x.ProjektInfoId,
                    InfoDatum = x.DatumKreiranja,
                    InfoText = x.textInfo

                }).ToList(),
                Radnici = db.RadnikProjekt.Include(n => n.Radnik).Where(c => c.ProjektId == id && c.DatumUklanjanja == null).Select(c => new ProjektViewModel.RadnikNaProjektu
                {
                    ID = c.Radnik.UposlenikId,
                    ImePrezime = c.Radnik.Ime + ' ' + c.Radnik.Prezime,
                    DatumDodavanja = c.DatumDodavanja,
                    PozicijaUProjektu = c.pozicijauProjektu,
                    Username = c.Radnik.username


                }).ToList(),
                Predracuni = db.Predracun.Where(x => x.ProjektId == id).Select(x => new ProjektViewModel.PredracunZaProjekt
                {
                    PredracunID = x.PredracunId,
                    NazivPredracuna = x.NazivPredracuna,
                    DatumKreiranja = x.DatumKreiranja

                }).ToList()
                

            };



            return View(pvm);
        }

       



        public /*void DownloadExcelFile*/  MemoryStream Download(int id)
        {
            MojDBCOntext db = new MojDBCOntext();
            string username = HttpContext.Session.GetString("username");
            Poslovodja s = db.Poslovodja.SingleOrDefault(x => x.username == username);

            Predracun predracun = db.Predracun.Include(c => c.Projekt).FirstOrDefault(x => x.PredracunId == id);
            PredracunDetaljiVM Model = new PredracunDetaljiVM()
            {
                ProjektID = predracun.ProjektId,
                PredracunID = predracun.PredracunId,
                NazivProjekta = predracun.Projekt.Naziv,
                NazivPredracuna = predracun.NazivPredracuna,
                rows = db.PredracunMaterijal.Include(x => x.Materijal).Include(x => x.Materijal.GrupaMaterijal).Where(x => x.PredracunId == id).Select(x => new PredracunDetaljiVM.Rows
                {
                    PredracunMaterijalId = x.PredracunMaterijalId,
                    MaterijalID = x.MaterijalId,
                    MaterijalNaziv = x.Materijal.Naziv,
                    GrupaMaterijalaNaziv = x.Materijal.GrupaMaterijal.NazivGrupe,
                    Kolicina = x.Materijal.Kolicina,
                    MaterijalCijena = x.Materijal.Cijena,
                    OznakaMjerneJedinice = x.Materijal.GrupaMaterijal.OznakaJediniceMjere



                }).ToList()


            };
            foreach (var x in Model.rows)
            {
                Model.UkupnaCijenaPredracuna += x.MaterijalCijena;
            }

            ExcelPackage Ep = new ExcelPackage();
            MemoryStream memStream;

            using (var package = new ExcelPackage())
            {
                //List<ProjektViewModel.RadnikNaProjektu> viewModel = new List<ProjektViewModel.RadnikNaProjektu>();
                List<PredracunDetaljiVM.Rows> viewModel = new List<PredracunDetaljiVM.Rows>();
                foreach (var x in /*pvm.Radnici*/  Model.rows)
                {
                    viewModel.Add(x);
                }
                ExcelWorksheet Sheet = package.Workbook.Worksheets.Add("MarksheetExcel");
               
                Sheet.Cells["A1"].Value = "Materijal naziv";
                Sheet.Cells["B1"].Value = "Tip materijala";
                Sheet.Cells["C1"].Value = "Mjerna jedinica";
                Sheet.Cells["D1"].Value = "Kolicina";
                Sheet.Cells["E1"].Value = "Cijena u KM";
               
                int row = 2;
                float ukupnacijena = 0;
                foreach (var item in viewModel)
                {
                    

                    Sheet.Cells[string.Format("A{0}", row)].Value = item.MaterijalNaziv;
                    Sheet.Cells[string.Format("B{0}", row)].Value = item.GrupaMaterijalaNaziv;
                    Sheet.Cells[string.Format("C{0}", row)].Value = item.OznakaMjerneJedinice;
                    Sheet.Cells[string.Format("D{0}", row)].Value = item.Kolicina;
                    Sheet.Cells[string.Format("E{0}", row)].Value = item.MaterijalCijena;
                    ukupnacijena += item.MaterijalCijena;
                    row++;
                }
                Sheet.Cells[string.Format("F{0}", row)].Value ="Ukupna cijena";
                Sheet.Cells[string.Format("F{0}", row+1)].Value =ukupnacijena;

                Sheet.Cells["A:AZ"].AutoFitColumns();
               
                memStream = new MemoryStream(package.GetAsByteArray());
            }
            return memStream;


            
        }

        public FileStreamResult DownloadFile(int id)
        {
            var memStream = this.Download(id);
            return File(memStream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
        }









        public async Task<IActionResult> Index(int pid,int page=1)
        {
            MojDBCOntext db = new MojDBCOntext();

            var item = db.ProjektInfo.AsNoTracking().Where(v => v.ProjektId == pid).OrderBy(p => p.DatumKreiranja);
            

            var model = await PagingList<ProjektInfo>.CreateAsync(item,1,page);
            model.RouteValue = new RouteValueDictionary {
                                             { "pid", pid}
                                                         };

            return View(model);
        }


        public IActionResult PosaljiPoruku()
        {
            var username = HttpContext.Session.GetString("username");


            return View();
        }


       


    }
}