using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ConManApp.Migrations
{
    public partial class GrupaJedinicaMjere : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JedinicaMjere",
                table: "Materijal");

            migrationBuilder.AddColumn<string>(
                name: "JedinicaMjere",
                table: "GrupaMaterijal",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JedinicaMjere",
                table: "GrupaMaterijal");

            migrationBuilder.AddColumn<string>(
                name: "JedinicaMjere",
                table: "Materijal",
                nullable: true);
        }
    }
}
