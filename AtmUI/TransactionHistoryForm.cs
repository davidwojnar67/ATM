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
         dataGridView.DataSource = dataTable;

      }

      private void CloseBtn_Click(object sender, EventArgs e) {
         this.Close();
      }
   }
}
