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
   public partial class CreateAcc : Form {

      private readonly CreateAccMethods createAccMethods;
      private readonly double monthlyInterest;

      public CreateAcc(CreateAccMethods createAccMethods) {
         InitializeComponent();
         this.createAccMethods = createAccMethods;
         monthlyInterest = createAccMethods.RandomMonthlyInterest();
         MonthlyInterestLbl.Text = monthlyInterest.ToString() + "%";
         MonthlyInterestLbl.Refresh();
      }

      private void BackToLoginBtn_Click(object sender, EventArgs e) {
         this.Close();
         Login login = new(new LoginMethods());
         login.Show();
      }

      private void CreateAccBtn_Click(object sender, EventArgs e) {
         createAccMethods.CreateClient(NameTb.Text, SurnameTb.Text, AddressTb.Text, DateOfBirthDtp, CurrentAccBalanceNum.Value, SavingAccBalanceNum.Value, monthlyInterest, UsernameTb.Text, PinCodeTb.Text);
         this.Close();
         Login login = new(new LoginMethods());
         login.Show();
      }
   }
}
