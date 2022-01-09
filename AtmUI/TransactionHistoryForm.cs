using Newtonsoft.Json;
using System;
using System.Data;
using System.Windows.Forms;

namespace AtmUI {
   public partial class TransactionHistoryForm : Form {

      public TransactionHistoryForm(string history) {
         InitializeComponent();
         // Konverze historie účtu (string history, format JSON) do DataTable dataTable.
         DataTable dataTable = (DataTable)JsonConvert.DeserializeObject(history, (typeof(DataTable)));
         // Ošetření případu, kdy je historie prázdná.
         if (dataTable.Rows.Count > 0) {
            // Odebrání sloupce s idAccount. (V celém sloupci se opakuje id účtu, na kterém je zobrazovaná historie.)
            dataTable.Columns.Remove("idAccount");    //dataTable.Columns.RemoveAt(0);    //2. varianta
            // Přejmenování hlaviček tabulky.
            dataTable.Columns["type"].ColumnName = "Type Of Operation";
            dataTable.Columns["amount"].ColumnName = "Amount";
            dataTable.Columns["date"].ColumnName = "Date";
            dataTable.Columns["note"].ColumnName = "Note";
            dataTable.Columns["noteForRecipient"].ColumnName = "Note For Recipient";
            dataTable.Columns["variableNumber"].ColumnName = "Variable Number";
            dataTable.Columns["fromAccId"].ColumnName = "From Account";
            dataTable.Columns["toAccId"].ColumnName = "To Account";
         }
         // Načtení dat historie účtu do dataGridView.
         dataGridView.DataSource = dataTable;

      }

      private void CloseBtn_Click(object sender, EventArgs e) {
         this.Close();
      }
   }
}
