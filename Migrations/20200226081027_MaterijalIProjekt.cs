using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ConManApp.Migrations
{
    public partial class MaterijalIProjekt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "pozicijauProjektu",
                table: "RadnikProjekt",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 8);

            migrationBuilder.AddColumn<DateTime>(
                name: "Kraj",
                table: "Projekt",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Pocetak",
                table: "Projekt",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Projekt",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "JedinicaMjere",
                table: "Materijal",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Kolicina",
                table: "Materijal",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Kraj",
                table: "Projekt");

            migrationBuilder.DropColumn(
                name: "Pocetak",
                table: "Projekt");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Projekt");

            migrationBuilder.DropColumn(
                name: "JedinicaMjere",
                table: "Materijal");

            migrationBuilder.DropColumn(
                name: "Kolicina",
                table: "Materijal");

            migrationBuilder.AlterColumn<string>(
                name: "pozicijauProjektu",
                table: "RadnikProjekt",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 10);
        }
    }
}
