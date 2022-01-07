using Microsoft.EntityFrameworkCore.Migrations;

namespace Atm.Migrations
{
    public partial class TransactionHistoryView : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
         migrationBuilder.Sql("create view TransactionHistoryView as select t.IdTranHis as 'Id', t.IdAccount, m.Type, t.Amount, t.Date, t.Note, t.NoteForRecipient, t.VariableNumber, t.FromAccId, t.ToAccId from TransactionHistory t join Cdl_Movements m on m.Id = t.Movement");
      }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
         migrationBuilder.Sql("drop view TransactionHistoryView;");
      }
    }
}
