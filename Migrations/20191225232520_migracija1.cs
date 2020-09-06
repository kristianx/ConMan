using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ConManApp.Migrations
{
    public partial class migracija1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dobavljac",
                columns: table => new
                {
                    DobavljacId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GodinaOsnivanja = table.Column<string>(nullable: true),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dobavljac", x => x.DobavljacId);
                });

            migrationBuilder.CreateTable(
                name: "Drzava",
                columns: table => new
                {
                    DrzavaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drzava", x => x.DrzavaId);
                });

            migrationBuilder.CreateTable(
                name: "GrupaMaterijal",
                columns: table => new
                {
                    GrupaMaterijalId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NazivGrupe = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrupaMaterijal", x => x.GrupaMaterijalId);
                });

            migrationBuilder.CreateTable(
                name: "Poslovodja",
                columns: table => new
                {
                    UposlenikId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ime = table.Column<string>(nullable: false),
                    KontaktBroj = table.Column<string>(nullable: true),
                    OpisIskustva = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true),
                    username = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Poslovodja", x => x.UposlenikId);
                });

            migrationBuilder.CreateTable(
                name: "Radnik",
                columns: table => new
                {
                    UposlenikId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ime = table.Column<string>(nullable: false),
                    KontaktBroj = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    info = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true),
                    username = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Radnik", x => x.UposlenikId);
                });

            migrationBuilder.CreateTable(
                name: "TipVozila",
                columns: table => new
                {
                    TipVozilaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NazivTipa = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipVozila", x => x.TipVozilaId);
                });

            migrationBuilder.CreateTable(
                name: "Vlasnik",
                columns: table => new
                {
                    VlasnikId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true),
                    username = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vlasnik", x => x.VlasnikId);
                });

            migrationBuilder.CreateTable(
                name: "Grad",
                columns: table => new
                {
                    GradId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DrzavaId = table.Column<int>(nullable: false),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grad", x => x.GradId);
                    table.ForeignKey(
                        name: "FK_Grad_Drzava_DrzavaId",
                        column: x => x.DrzavaId,
                        principalTable: "Drzava",
                        principalColumn: "DrzavaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Predracun",
                columns: table => new
                {
                    PredracunId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DatumKreiranja = table.Column<DateTime>(nullable: false),
                    UposlenikId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Predracun", x => x.PredracunId);
                    table.ForeignKey(
                        name: "FK_Predracun_Poslovodja_UposlenikId",
                        column: x => x.UposlenikId,
                        principalTable: "Poslovodja",
                        principalColumn: "UposlenikId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Projekt",
                columns: table => new
                {
                    ProjektId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Adresa = table.Column<string>(nullable: true),
                    GradId = table.Column<int>(nullable: false),
                    Naziv = table.Column<string>(nullable: true),
                    UposlenikId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projekt", x => x.ProjektId);
                    table.ForeignKey(
                        name: "FK_Projekt_Grad_GradId",
                        column: x => x.GradId,
                        principalTable: "Grad",
                        principalColumn: "GradId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Projekt_Poslovodja_UposlenikId",
                        column: x => x.UposlenikId,
                        principalTable: "Poslovodja",
                        principalColumn: "UposlenikId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Skladiste",
                columns: table => new
                {
                    SkladisteId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Adresa = table.Column<string>(nullable: true),
                    GradId = table.Column<int>(nullable: false),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skladiste", x => x.SkladisteId);
                    table.ForeignKey(
                        name: "FK_Skladiste_Grad_GradId",
                        column: x => x.GradId,
                        principalTable: "Grad",
                        principalColumn: "GradId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ured",
                columns: table => new
                {
                    UredId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Adresa = table.Column<string>(nullable: false),
                    GradId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ured", x => x.UredId);
                    table.ForeignKey(
                        name: "FK_Ured_Grad_GradId",
                        column: x => x.GradId,
                        principalTable: "Grad",
                        principalColumn: "GradId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjektInfo",
                columns: table => new
                {
                    ProjektInfoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DatumKreiranja = table.Column<DateTime>(nullable: false),
                    ProjektId = table.Column<int>(nullable: false),
                    textInfo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjektInfo", x => x.ProjektInfoId);
                    table.ForeignKey(
                        name: "FK_ProjektInfo_Projekt_ProjektId",
                        column: x => x.ProjektId,
                        principalTable: "Projekt",
                        principalColumn: "ProjektId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RadnikProjekt",
                columns: table => new
                {
                    RadnikProjektId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DatumDodavanja = table.Column<DateTime>(nullable: false),
                    ProjektId = table.Column<int>(nullable: false),
                    UposlenikId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RadnikProjekt", x => x.RadnikProjektId);
                    table.ForeignKey(
                        name: "FK_RadnikProjekt_Projekt_ProjektId",
                        column: x => x.ProjektId,
                        principalTable: "Projekt",
                        principalColumn: "ProjektId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RadnikProjekt_Radnik_UposlenikId",
                        column: x => x.UposlenikId,
                        principalTable: "Radnik",
                        principalColumn: "UposlenikId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Materijal",
                columns: table => new
                {
                    MaterijalId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cijena = table.Column<int>(nullable: false),
                    DobavljacId = table.Column<int>(nullable: false),
                    GrupaMaterijalId = table.Column<int>(nullable: false),
                    Naziv = table.Column<string>(nullable: true),
                    SkladisteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materijal", x => x.MaterijalId);
                    table.ForeignKey(
                        name: "FK_Materijal_Dobavljac_DobavljacId",
                        column: x => x.DobavljacId,
                        principalTable: "Dobavljac",
                        principalColumn: "DobavljacId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Materijal_GrupaMaterijal_GrupaMaterijalId",
                        column: x => x.GrupaMaterijalId,
                        principalTable: "GrupaMaterijal",
                        principalColumn: "GrupaMaterijalId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Materijal_Skladiste_SkladisteId",
                        column: x => x.SkladisteId,
                        principalTable: "Skladiste",
                        principalColumn: "SkladisteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Oprema",
                columns: table => new
                {
                    OpremaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true),
                    SkladisteId = table.Column<int>(nullable: false),
                    usable = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oprema", x => x.OpremaId);
                    table.ForeignKey(
                        name: "FK_Oprema_Skladiste_SkladisteId",
                        column: x => x.SkladisteId,
                        principalTable: "Skladiste",
                        principalColumn: "SkladisteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Skladistar",
                columns: table => new
                {
                    UposlenikId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ime = table.Column<string>(nullable: false),
                    KontaktBroj = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    SkladisteId = table.Column<int>(nullable: false),
                    password = table.Column<string>(nullable: true),
                    username = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skladistar", x => x.UposlenikId);
                    table.ForeignKey(
                        name: "FK_Skladistar_Skladiste_SkladisteId",
                        column: x => x.SkladisteId,
                        principalTable: "Skladiste",
                        principalColumn: "SkladisteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vozilo",
                columns: table => new
                {
                    VoziloId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GodinaProizvodnje = table.Column<string>(nullable: true),
                    Iznajmljeno = table.Column<bool>(nullable: false),
                    Model = table.Column<string>(nullable: true),
                    NazivProizvodjaca = table.Column<string>(nullable: true),
                    SkladisteId = table.Column<int>(nullable: false),
                    TipVozilaId = table.Column<int>(nullable: false),
                    UVoznomStanju = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vozilo", x => x.VoziloId);
                    table.ForeignKey(
                        name: "FK_Vozilo_Skladiste_SkladisteId",
                        column: x => x.SkladisteId,
                        principalTable: "Skladiste",
                        principalColumn: "SkladisteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vozilo_TipVozila_TipVozilaId",
                        column: x => x.TipVozilaId,
                        principalTable: "TipVozila",
                        principalColumn: "TipVozilaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Administracija",
                columns: table => new
                {
                    UposlenikId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ime = table.Column<string>(nullable: false),
                    KontaktBroj = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    StrucnoZvanje = table.Column<string>(nullable: true),
                    UredId = table.Column<int>(nullable: false),
                    password = table.Column<string>(nullable: true),
                    username = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administracija", x => x.UposlenikId);
                    table.ForeignKey(
                        name: "FK_Administracija_Ured_UredId",
                        column: x => x.UredId,
                        principalTable: "Ured",
                        principalColumn: "UredId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PredracunMaterijal",
                columns: table => new
                {
                    PredracunMaterijalId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MaterijalId = table.Column<int>(nullable: false),
                    PredracunId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PredracunMaterijal", x => x.PredracunMaterijalId);
                    table.ForeignKey(
                        name: "FK_PredracunMaterijal_Materijal_MaterijalId",
                        column: x => x.MaterijalId,
                        principalTable: "Materijal",
                        principalColumn: "MaterijalId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PredracunMaterijal_Predracun_PredracunId",
                        column: x => x.PredracunId,
                        principalTable: "Predracun",
                        principalColumn: "PredracunId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Administracija_UredId",
                table: "Administracija",
                column: "UredId");

            migrationBuilder.CreateIndex(
                name: "IX_Grad_DrzavaId",
                table: "Grad",
                column: "DrzavaId");

            migrationBuilder.CreateIndex(
                name: "IX_Materijal_DobavljacId",
                table: "Materijal",
                column: "DobavljacId");

            migrationBuilder.CreateIndex(
                name: "IX_Materijal_GrupaMaterijalId",
                table: "Materijal",
                column: "GrupaMaterijalId");

            migrationBuilder.CreateIndex(
                name: "IX_Materijal_SkladisteId",
                table: "Materijal",
                column: "SkladisteId");

            migrationBuilder.CreateIndex(
                name: "IX_Oprema_SkladisteId",
                table: "Oprema",
                column: "SkladisteId");

            migrationBuilder.CreateIndex(
                name: "IX_Predracun_UposlenikId",
                table: "Predracun",
                column: "UposlenikId");

            migrationBuilder.CreateIndex(
                name: "IX_PredracunMaterijal_MaterijalId",
                table: "PredracunMaterijal",
                column: "MaterijalId");

            migrationBuilder.CreateIndex(
                name: "IX_PredracunMaterijal_PredracunId",
                table: "PredracunMaterijal",
                column: "PredracunId");

            migrationBuilder.CreateIndex(
                name: "IX_Projekt_GradId",
                table: "Projekt",
                column: "GradId");

            migrationBuilder.CreateIndex(
                name: "IX_Projekt_UposlenikId",
                table: "Projekt",
                column: "UposlenikId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjektInfo_ProjektId",
                table: "ProjektInfo",
                column: "ProjektId");

            migrationBuilder.CreateIndex(
                name: "IX_RadnikProjekt_ProjektId",
                table: "RadnikProjekt",
                column: "ProjektId");

            migrationBuilder.CreateIndex(
                name: "IX_RadnikProjekt_UposlenikId",
                table: "RadnikProjekt",
                column: "UposlenikId");

            migrationBuilder.CreateIndex(
                name: "IX_Skladistar_SkladisteId",
                table: "Skladistar",
                column: "SkladisteId");

            migrationBuilder.CreateIndex(
                name: "IX_Skladiste_GradId",
                table: "Skladiste",
                column: "GradId");

            migrationBuilder.CreateIndex(
                name: "IX_Ured_GradId",
                table: "Ured",
                column: "GradId");

            migrationBuilder.CreateIndex(
                name: "IX_Vozilo_SkladisteId",
                table: "Vozilo",
                column: "SkladisteId");

            migrationBuilder.CreateIndex(
                name: "IX_Vozilo_TipVozilaId",
                table: "Vozilo",
                column: "TipVozilaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Administracija");

            migrationBuilder.DropTable(
                name: "Oprema");

            migrationBuilder.DropTable(
                name: "PredracunMaterijal");

            migrationBuilder.DropTable(
                name: "ProjektInfo");

            migrationBuilder.DropTable(
                name: "RadnikProjekt");

            migrationBuilder.DropTable(
                name: "Skladistar");

            migrationBuilder.DropTable(
                name: "Vlasnik");

            migrationBuilder.DropTable(
                name: "Vozilo");

            migrationBuilder.DropTable(
                name: "Ured");

            migrationBuilder.DropTable(
                name: "Materijal");

            migrationBuilder.DropTable(
                name: "Predracun");

            migrationBuilder.DropTable(
                name: "Projekt");

            migrationBuilder.DropTable(
                name: "Radnik");

            migrationBuilder.DropTable(
                name: "TipVozila");

            migrationBuilder.DropTable(
                name: "Dobavljac");

            migrationBuilder.DropTable(
                name: "GrupaMaterijal");

            migrationBuilder.DropTable(
                name: "Skladiste");

            migrationBuilder.DropTable(
                name: "Poslovodja");

            migrationBuilder.DropTable(
                name: "Grad");

            migrationBuilder.DropTable(
                name: "Drzava");
        }
    }
}
