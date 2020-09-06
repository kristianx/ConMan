using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ConManApp.Migrations
{
    public partial class Vozilo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Iznajmljeno",
                table: "Vozilo");

            migrationBuilder.DropColumn(
                name: "UVoznomStanju",
                table: "Vozilo");

            migrationBuilder.AddColumn<byte[]>(
                name: "SlikaVozila",
                table: "Vozilo",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SlikaVozila",
                table: "Vozilo");

            migrationBuilder.AddColumn<bool>(
                name: "Iznajmljeno",
                table: "Vozilo",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "UVoznomStanju",
                table: "Vozilo",
                nullable: false,
                defaultValue: false);
        }
    }
}
