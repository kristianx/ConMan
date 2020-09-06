using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ConManApp.Migrations
{
    public partial class Migracija11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "pozicijauProjektu",
                table: "RadnikProjekt",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(string));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "pozicijauProjektu",
                table: "RadnikProjekt",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 8);
        }
    }
}
