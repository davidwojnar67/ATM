using Microsoft.EntityFrameworkCore.Migrations;

namespace Atm.Migrations
{
    public partial class _4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Clients",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Cdl_Movements",
                keyColumn: "Id",
                keyValue: 4,
                column: "Type",
                value: "Incoming Payment");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_Username",
                table: "Clients",
                column: "Username",
                unique: true,
                filter: "[Username] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Clients_Username",
                table: "Clients");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Cdl_Movements",
                keyColumn: "Id",
                keyValue: 4,
                column: "Type",
                value: "Incoming payment");
        }
    }
}
