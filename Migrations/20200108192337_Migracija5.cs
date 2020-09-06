using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ConManApp.Migrations
{
    public partial class Migracija5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Narudzba",
                columns: table => new
                {
                    NarudzbaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DatumKreiranja = table.Column<DateTime>(nullable: false),
                    SpisakPotrebnihMaterijala = table.Column<string>(nullable: true),
                    UposlenikId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Narudzba", x => x.NarudzbaId);
                    table.ForeignKey(
                        name: "FK_Narudzba_Administracija_UposlenikId",
                        column: x => x.UposlenikId,
                        principalTable: "Administracija",
                        principalColumn: "UposlenikId");
                });

            migrationBuilder.CreateTable(
                name: "PlatnaPoslovodja",
                columns: table => new
                {
                    PlatnaPoslovodjaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IznosPlate = table.Column<int>(nullable: false),
                    PlatnaListaId = table.Column<int>(nullable: false),
                    UposlenikId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlatnaPoslovodja", x => x.PlatnaPoslovodjaId);
                    table.ForeignKey(
                        name: "FK_PlatnaPoslovodja_PlatnaLista_PlatnaListaId",
                        column: x => x.PlatnaListaId,
                        principalTable: "PlatnaLista",
                        principalColumn: "PlatnaListaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlatnaPoslovodja_Poslovodja_UposlenikId",
                        column: x => x.UposlenikId,
                        principalTable: "Poslovodja",
                        principalColumn: "UposlenikId");
                });

            migrationBuilder.CreateTable(
                name: "PlatnaRadnik",
                columns: table => new
                {
                    PlatnaRadnikId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IznosPlate = table.Column<int>(nullable: false),
                    PlatnaListaId = table.Column<int>(nullable: false),
                    UposlenikId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlatnaRadnik", x => x.PlatnaRadnikId);
                    table.ForeignKey(
                        name: "FK_PlatnaRadnik_PlatnaLista_PlatnaListaId",
                        column: x => x.PlatnaListaId,
                        principalTable: "PlatnaLista",
                        principalColumn: "PlatnaListaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlatnaRadnik_Radnik_UposlenikId",
                        column: x => x.UposlenikId,
                        principalTable: "Radnik",
                        principalColumn: "UposlenikId");
                });

            migrationBuilder.CreateTable(
                name: "PlatnaSkladistar",
                columns: table => new
                {
                    PlatnaSkladistarID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IznosPlate = table.Column<int>(nullable: false),
                    PlatnaListaId = table.Column<int>(nullable: false),
                    UposlenikId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlatnaSkladistar", x => x.PlatnaSkladistarID);
                    table.ForeignKey(
                        name: "FK_PlatnaSkladistar_PlatnaLista_PlatnaListaId",
                        column: x => x.PlatnaListaId,
                        principalTable: "PlatnaLista",
                        principalColumn: "PlatnaListaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlatnaSkladistar_Skladistar_UposlenikId",
                        column: x => x.UposlenikId,
                        principalTable: "Skladistar",
                        principalColumn: "UposlenikId");
                });

            migrationBuilder.CreateTable(
                name: "RadnikVozilo",
                columns: table => new
                {
                    RadnikVoziloId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DatumVracanja = table.Column<DateTime>(nullable: true),
                    DatumZaduzivanja = table.Column<DateTime>(nullable: false),
                    UposlenikId = table.Column<int>(nullable: false),
                    VoziloId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RadnikVozilo", x => x.RadnikVoziloId);
                    table.ForeignKey(
                        name: "FK_RadnikVozilo_Radnik_UposlenikId",
                        column: x => x.UposlenikId,
                        principalTable: "Radnik",
                        principalColumn: "UposlenikId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RadnikVozilo_Vozilo_VoziloId",
                        column: x => x.VoziloId,
                        principalTable: "Vozilo",
                        principalColumn: "VoziloId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Narudzba_UposlenikId",
                table: "Narudzba",
                column: "UposlenikId");

            migrationBuilder.CreateIndex(
                name: "IX_PlatnaPoslovodja_PlatnaListaId",
                table: "PlatnaPoslovodja",
                column: "PlatnaListaId");

            migrationBuilder.CreateIndex(
                name: "IX_PlatnaPoslovodja_UposlenikId",
                table: "PlatnaPoslovodja",
                column: "UposlenikId");

            migrationBuilder.CreateIndex(
                name: "IX_PlatnaRadnik_PlatnaListaId",
                table: "PlatnaRadnik",
                column: "PlatnaListaId");

            migrationBuilder.CreateIndex(
                name: "IX_PlatnaRadnik_UposlenikId",
                table: "PlatnaRadnik",
                column: "UposlenikId");

            migrationBuilder.CreateIndex(
                name: "IX_PlatnaSkladistar_PlatnaListaId",
                table: "PlatnaSkladistar",
                column: "PlatnaListaId");

            migrationBuilder.CreateIndex(
                name: "IX_PlatnaSkladistar_UposlenikId",
                table: "PlatnaSkladistar",
                column: "UposlenikId");

            migrationBuilder.CreateIndex(
                name: "IX_RadnikVozilo_UposlenikId",
                table: "RadnikVozilo",
                column: "UposlenikId");

            migrationBuilder.CreateIndex(
                name: "IX_RadnikVozilo_VoziloId",
                table: "RadnikVozilo",
                column: "VoziloId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Narudzba");

            migrationBuilder.DropTable(
                name: "PlatnaPoslovodja");

            migrationBuilder.DropTable(
                name: "PlatnaRadnik");

            migrationBuilder.DropTable(
                name: "PlatnaSkladistar");

            migrationBuilder.DropTable(
                name: "RadnikVozilo");
        }
    }
}
