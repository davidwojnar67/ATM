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
         AutoValidate = AutoValidate.Disable;
         this.Close();
         Login login = new(new LoginMethods());
         login.Show();
      }

      private void CreateAccBtn_Click(object sender, EventArgs e) {
         if (ValidateChildren(ValidationConstraints.Enabled)) {
            createAccMethods.CreateClient(NameTb.Text, SurnameTb.Text, AddressTb.Text, DateOfBirthDtp, CurrentAccBalanceNum.Value, SavingAccBalanceNum.Value, monthlyInterest, UsernameTb.Text, PinCodeTb.Text);
            this.Close();
            Login login = new(new LoginMethods());
            login.Show();
         }
         else {

         }
      }


      // Validace

      private void NameTb_Validating(object sender, CancelEventArgs e) {
         if (string.IsNullOrWhiteSpace(NameTb.Text)) {
            e.Cancel = true;
            NameTb.Focus();
            errorProvider.SetError(NameTb, "Name should not be left blank!");
         }
         else {
            e.Cancel = false;
            errorProvider.SetError(NameTb, "");
         }
      }

      private void SurnameTb_Validating(object sender, CancelEventArgs e) {
         if (string.IsNullOrWhiteSpace(SurnameTb.Text)) {
            e.Cancel = true;
            SurnameTb.Focus();
            errorProvider.SetError(SurnameTb, "Surname should not be left blank!");
         }
         else {
            e.Cancel = false;
            errorProvider.SetError(SurnameTb, "");
         }
      }

      private void AddressTb_Validating(object sender, CancelEventArgs e) {
         if (string.IsNullOrWhiteSpace(AddressTb.Text)) {
            e.Cancel = true;
            AddressTb.Focus();
            errorProvider.SetError(AddressTb, "Address should not be left blank!");
         }
         else {
            e.Cancel = false;
            errorProvider.SetError(AddressTb, "");
         }
      }

      private void UsernameTb_Validating(object sender, CancelEventArgs e) {
         if (string.IsNullOrWhiteSpace(UsernameTb.Text)) {
            e.Cancel = true;
            UsernameTb.Focus();
            errorProvider.SetError(UsernameTb, "Username should not be left blank!");
         }
         else {
            e.Cancel = false;
            errorProvider.SetError(UsernameTb, "");
         }
      }

      private void PinCodeTb_Validating(object sender, CancelEventArgs e) {
         if (string.IsNullOrWhiteSpace(PinCodeTb.Text)) {
            e.Cancel = true;
            PinCodeTb.Focus();
            errorProvider.SetError(PinCodeTb, "Pin Code should not be left blank!");
         }
         else {
            e.Cancel = false;
            errorProvider.SetError(PinCodeTb, "");
         }
      }

   }
}
