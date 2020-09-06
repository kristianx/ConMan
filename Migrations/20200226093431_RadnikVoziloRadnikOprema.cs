using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ConManApp.Migrations
{
    public partial class RadnikVoziloRadnikOprema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DatumKrajaZaduzivanja",
                table: "RadnikVozilo",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "SvrhaIznajmljivanja",
                table: "RadnikVozilo",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DatumKrajaZaduzivanja",
                table: "RadnikOprema",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DatumKrajaZaduzivanja",
                table: "RadnikVozilo");

            migrationBuilder.DropColumn(
                name: "SvrhaIznajmljivanja",
                table: "RadnikVozilo");

            migrationBuilder.DropColumn(
                name: "DatumKrajaZaduzivanja",
                table: "RadnikOprema");
        }
    }
}
