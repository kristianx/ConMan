using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ConManApp.Migrations
{
    public partial class Predracun : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            /*
            migrationBuilder.RenameColumn(
                name: "SpisakPotrebnihMaterijala",
                table: "Predracun",
                newName: "NazivPredracuna");
            */
            migrationBuilder.AddColumn<string>(
                name: "NazivPredracuna",
                table: "Predracun",
                nullable: true
                );

            migrationBuilder.AddColumn<int>(
                name: "ProjektId",
                table: "Predracun",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "CijenaUKM",
                table: "Materijal",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.CreateIndex(
                name: "IX_Predracun_ProjektId",
                table: "Predracun",
                column: "ProjektId");

            migrationBuilder.AddForeignKey(
                name: "FK_Predracun_Projekt_ProjektId",
                table: "Predracun",
                column: "ProjektId",
                principalTable: "Projekt",
                principalColumn: "ProjektId",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Predracun_Projekt_ProjektId",
                table: "Predracun");

            migrationBuilder.DropIndex(
                name: "IX_Predracun_ProjektId",
                table: "Predracun");

            migrationBuilder.DropColumn(
                name: "ProjektId",
                table: "Predracun");

            migrationBuilder.DropColumn(
                name: "CijenaUKM",
                table: "Materijal");

            migrationBuilder.RenameColumn(
                name: "NazivPredracuna",
                table: "Predracun",
                newName: "SpisakPotrebnihMaterijala");
        }
    }
}
