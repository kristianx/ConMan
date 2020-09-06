using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ConManApp.Migrations
{
    public partial class JeIznajmljenoOpremaVozilo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "JeIznajmljeno",
                table: "Vozilo",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "JeIznajmljeno",
                table: "Oprema",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JeIznajmljeno",
                table: "Vozilo");

            migrationBuilder.DropColumn(
                name: "JeIznajmljeno",
                table: "Oprema");
        }
    }
}
