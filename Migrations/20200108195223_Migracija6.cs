using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ConManApp.Migrations
{
    public partial class Migracija6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RadnikOprema",
                columns: table => new
                {
                    RadnikOpremaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DatumVracanja = table.Column<DateTime>(nullable: true),
                    DatumZaduzivanja = table.Column<DateTime>(nullable: false),
                    OpremaId = table.Column<int>(nullable: false),
                    UposlenikId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RadnikOprema", x => x.RadnikOpremaId);
                    table.ForeignKey(
                        name: "FK_RadnikOprema_Oprema_OpremaId",
                        column: x => x.OpremaId,
                        principalTable: "Oprema",
                        principalColumn: "OpremaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RadnikOprema_Radnik_UposlenikId",
                        column: x => x.UposlenikId,
                        principalTable: "Radnik",
                        principalColumn: "UposlenikId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RadnikOprema_OpremaId",
                table: "RadnikOprema",
                column: "OpremaId");

            migrationBuilder.CreateIndex(
                name: "IX_RadnikOprema_UposlenikId",
                table: "RadnikOprema",
                column: "UposlenikId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RadnikOprema");
        }
    }
}
