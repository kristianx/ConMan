using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ConManApp.Migrations
{
    public partial class migracija3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlatnaLista",
                columns: table => new
                {
                    PlatnaListaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DatumKreiranja = table.Column<DateTime>(nullable: false),
                    UposlenikId = table.Column<int>(nullable: false),
                    godina = table.Column<string>(nullable: true),
                    mjesec = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlatnaLista", x => x.PlatnaListaId);
                    table.ForeignKey(
                        name: "FK_PlatnaLista_Administracija_UposlenikId",
                        column: x => x.UposlenikId,
                        principalTable: "Administracija",
                        principalColumn: "UposlenikId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlatnaLista_UposlenikId",
                table: "PlatnaLista",
                column: "UposlenikId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlatnaLista");
        }
    }
}
