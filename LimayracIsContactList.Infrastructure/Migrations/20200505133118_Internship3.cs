using Microsoft.EntityFrameworkCore.Migrations;

namespace LimayracIsContactList.Infrastructure.Migrations
{
    public partial class Internship3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Person_Service_ServiceId",
                table: "Person");

            migrationBuilder.DropIndex(
                name: "IX_Person_ServiceId",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "ServiceId",
                table: "Person");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ServiceId",
                table: "Person",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Person_ServiceId",
                table: "Person",
                column: "ServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Service_ServiceId",
                table: "Person",
                column: "ServiceId",
                principalTable: "Service",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
