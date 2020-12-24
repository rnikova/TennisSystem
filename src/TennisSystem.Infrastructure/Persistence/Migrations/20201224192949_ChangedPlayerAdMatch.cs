using Microsoft.EntityFrameworkCore.Migrations;

namespace TennisSystem.Infrastructure.Persistence.Migrations
{
    public partial class ChangedPlayerAdMatch : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Tournament",
                table: "Title",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "Title",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tournament",
                table: "Title");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "Title");
        }
    }
}
