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
            if(dataTable.Columns.Contains("idAccount"))
            dataTable.Columns.Remove("idAccount");    //dataTable.Columns.RemoveAt(0);    //2. varianta
            // Kontroly zda existují sloupce s danými jmény, pokud ano proběhne přejmenování hlaviček tabulky.
            if(dataTable.Columns.Contains("type"))
               dataTable.Columns["type"].ColumnName = "Type Of Operation";
            if(dataTable.Columns.Contains("amount"))
               dataTable.Columns["amount"].ColumnName = "Amount";
            if(dataTable.Columns.Contains("date"))
               dataTable.Columns["date"].ColumnName = "Date";
            if(dataTable.Columns.Contains("note"))
               dataTable.Columns["note"].ColumnName = "Note";
            if(dataTable.Columns.Contains("noteForRecipient"))
               dataTable.Columns["noteForRecipient"].ColumnName = "Note For Recipient";
            if(dataTable.Columns.Contains("variableNumber"))
               dataTable.Columns["variableNumber"].ColumnName = "Variable Number";
            if(dataTable.Columns.Contains("fromAccId"))
               dataTable.Columns["fromAccId"].ColumnName = "From Account";
            if(dataTable.Columns.Contains("toAccId"))
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
