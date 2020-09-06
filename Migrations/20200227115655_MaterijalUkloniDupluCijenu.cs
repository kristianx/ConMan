using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ConManApp.Migrations
{
    public partial class MaterijalUkloniDupluCijenu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CijenaUKM",
                table: "Materijal");

            migrationBuilder.AlterColumn<float>(
                name: "Cijena",
                table: "Materijal",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Cijena",
                table: "Materijal",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.AddColumn<float>(
                name: "CijenaUKM",
                table: "Materijal",
                nullable: false,
                defaultValue: 0f);
        }
    }
}
