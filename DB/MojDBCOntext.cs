using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ConManApp.EnModels;
using Nexmo.Api;

namespace ConManApp.DB
{
    public class MojDBCOntext:DbContext
    {
        public MojDBCOntext()
        {

        }

        public DbSet<Drzava> Drzava { get; set; }
        public DbSet<Grad> Grad { get; set; }
        
        public DbSet<Skladistar> Skladistar { get; set; }
        public DbSet<TipVozila> TipVozila { get; set; }
        public DbSet<Vozilo> Vozilo { get; set; }
        public DbSet<Skladiste> Skladiste{ get; set; }

        public DbSet<Poslovodja> Poslovodja { get; set; }
        public DbSet<Ured> Ured { get; set; }
        public DbSet<Administracija> Administracija { get; set; }
        public DbSet<Radnik> Radnik { get; set; }
        public DbSet<GrupaMaterijal> GrupaMaterijal { get; set; }
        public DbSet<Dobavljac> Dobavljac { get; set; }
        public DbSet<Materijal> Materijal { get; set; }

        public DbSet<Projekt> Projekt { get; set; }
        public DbSet<Oprema> Oprema { get; set; }
        public DbSet<Predracun> Predracun { get; set; }
        public DbSet<PredracunMaterijal> PredracunMaterijal { get; set; }
        public DbSet<Narudzba> Narudzba { get; set; }
        public DbSet<RadnikProjekt> RadnikProjekt { get; set; }
        public DbSet<Vlasnik> Vlasnik { get; set; }

        public DbSet<ProjektInfo> ProjektInfo { get; set; }
       public DbSet<PlatnaLista> PlatnaLista { get; set; }
        //platna i naziv klase x4
        public DbSet<PlatnaSkladistar> PlatnaSkladistar { get; set; }
        public DbSet<PlatnaPoslovodja> PlatnaPoslovodja { get; set; }
        public DbSet<PlatnaRadnik> PlatnaRadnik { get; set; }
        public DbSet<RadnikVozilo> RadnikVozilo { get; set; }
        public DbSet<RadnikOprema> RadnikOprema { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=DESKTOP-8UD67O1\\MSSQLSERVER1;Database=ConMan; integrated security = true");
            optionsBuilder.UseSqlServer("Server=DESKTOP-8UD67O1\\MSSQLSERVER1;Database = ConMan; integrated security = true");

            
            //optionsBuilder.UseSqlServer(@"Server=DESKTOP-8UD67O1\\MSSQLSERVER1;Database=ConMan; integrated security = true");

            //optionsBuilder.UseSqlServer(@"Server=p1750.app.fit.ba,1431;Database=ConMan;Trusted_Connection=true;uid=testuser;Password=Test.user123@");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Skladistar>().HasKey(sk => sk.UposlenikId);
            modelBuilder.Entity<Radnik>().HasKey(r => r.UposlenikId);
            modelBuilder.Entity<Administracija>().HasKey(a => a.UposlenikId);
            modelBuilder.Entity<Poslovodja>().HasKey(p => p.UposlenikId);


        }

    }

    
}
