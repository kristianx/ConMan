using Microsoft.EntityFrameworkCore.Migrations;

namespace ConManApp.Migrations
{
    public partial class Skladistar2fa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "TwoFaAuth",
                table: "Skladistar",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TwoFaAuth",
                table: "Skladistar");
        }
    }
}
