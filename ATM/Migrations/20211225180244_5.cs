using Microsoft.EntityFrameworkCore.Migrations;

namespace Atm.Migrations
{
    public partial class _5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PinHash",
                table: "Clients",
                newName: "PinCodeHash");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PinCodeHash",
                table: "Clients",
                newName: "PinHash");
        }
    }
}
