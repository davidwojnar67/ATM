using Microsoft.EntityFrameworkCore.Migrations;

namespace Atm.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Typ",
                table: "Cdl_Movements",
                newName: "Type");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Cdl_Movements",
                newName: "Typ");
        }
    }
}
