using Microsoft.EntityFrameworkCore.Migrations;

namespace LimayracIsContactList.Infrastructure.Migrations
{
    public partial class ChangeOnContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Movie",
                table: "Movie");

            migrationBuilder.RenameTable(
                name: "Movie",
                newName: "Entreprise");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Entreprise",
                table: "Entreprise",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Entreprise",
                table: "Entreprise");

            migrationBuilder.RenameTable(
                name: "Entreprise",
                newName: "Movie");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movie",
                table: "Movie",
                column: "Id");
        }
    }
}
