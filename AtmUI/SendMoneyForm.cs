using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtmUI {
   public partial class SendMoneyForm : Form {
      public decimal Amount { get; private set; }
      public int RecipientAccId { get; private set; }
      public int? VariableNumber { get; private set; }
      public string Note { get; private set; }
      public string NoteForRecipient { get; private set; }

      public SendMoneyForm() {
         InitializeComponent();
         RecipientAccIdTb.Controls[0].Visible = false;
         VariableNumberTb.Controls[0].Visible = false;
      }

      private void SendMoneyBtn_Click(object sender, EventArgs e) {
         Amount = AmountNum.Value;
         RecipientAccId = int.Parse(RecipientAccIdTb.Text);
         VariableNumber = VariableNumberTb.Value == 0 ? null : (int)VariableNumberTb.Value;
         Note = NoteTb.Text;
         NoteForRecipient = NoteForRecipientTb.Text;

         this.DialogResult = DialogResult.OK;
         this.Close();
      }

      private void CancelBtn_Click(object sender, EventArgs e) {
         this.Close();
      }

   }
}
