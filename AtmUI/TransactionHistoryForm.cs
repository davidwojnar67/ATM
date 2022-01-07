using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtmUI {
   public partial class TransactionHistoryForm : Form {

      public TransactionHistoryForm(string history) {
         InitializeComponent();
         DataTable dataTable = (DataTable)JsonConvert.DeserializeObject(history, (typeof(DataTable)));
         dataTable.Columns.Remove("idAccount");    //dataTable.Columns.RemoveAt(0);    //2. varianta
         dataTable.Columns["type"].ColumnName = "Type Of Operation";
         dataTable.Columns["amount"].ColumnName = "Amount";
         dataTable.Columns["date"].ColumnName = "Date";
         dataTable.Columns["note"].ColumnName = "Note";
         dataTable.Columns["noteForRecipient"].ColumnName = "Note For Recipient";
         dataTable.Columns["variableNumber"].ColumnName = "Variable Number";
         dataTable.Columns["fromAccId"].ColumnName = "From Account";
         dataTable.Columns["toAccId"].ColumnName = "To Account";
         dataGridView.DataSource = dataTable;

      }

      private void CloseBtn_Click(object sender, EventArgs e) {
         this.Close();
      }
   }
}
