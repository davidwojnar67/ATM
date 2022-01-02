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
   public partial class Home : Form {

      private readonly HomeMethods homeMethods;
      private int IdCurrentAcc;
      private int IdSavingsAcc;

      public Home(HomeMethods homeMethods) {
         InitializeComponent();
         this.homeMethods = homeMethods;

         var client = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(homeMethods.GetClientByUsername());
         IdCurrentAcc = client.currentAccount.idAccount;
         IdSavingsAcc = client.savingsAccount.idAccount;
         CurrentAccGb.Text = "Current account, Id: " + IdCurrentAcc;
         SavingsAccGb.Text = "Savings account, Id: " + IdSavingsAcc;
         MonthlyInterestLbl.Text = client.savingsAccount.interestPerMensem + "%";
         NameSurnameLbl.Text = client.name + " " + client.surname;

         RefreshValues();
      }

      private void RefreshValues() {
         var client = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(homeMethods.GetClientByUsername());

         CurrentAccBalanceLbl.Text = client.currentAccount.balance;
         SavingsAccBalanceLbl.Text = client.savingsAccount.balance;
      }


      private void LogOutBtn_Click(object sender, EventArgs e) {
         this.Close();
         Login login = new(new LoginMethods());
         login.Show();
      }

      private void CurrentAccInsertMoneyBtn_Click(object sender, EventArgs e) {
         MoneyOperation(true, IdCurrentAcc);
      }

      private void CurrentAccWithdrawMoneyBtn_Click(object sender, EventArgs e) {
         MoneyOperation(false, IdCurrentAcc);
      }

      private void CurrentAccSendMoneyBtn_Click(object sender, EventArgs e) {

      }

      private void SavingsAccInsertMoneyBtn_Click(object sender, EventArgs e) {
         MoneyOperation(true, IdSavingsAcc);
      }

      private void SavingsAccWithdrawMoneyBtn_Click(object sender, EventArgs e) {        
         MoneyOperation(false, IdSavingsAcc);
      }

      private void SavingsAccSendMoneyBtn_Click(object sender, EventArgs e) {

      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="typeOfOperation">True = insert money, False = withdraw money</param>
      /// <param name="idAccount"></param>
      /// <param name="amount"></param>
      private void MoneyOperation(bool typeOfOperation, int idAccount) {
         InsertWithdrawMoney insertWithdrawMoney = new(typeOfOperation);
         var result = insertWithdrawMoney.ShowDialog();
         if (result == DialogResult.OK) {
            decimal amount = insertWithdrawMoney.Amount;
            if (typeOfOperation) {
               homeMethods.InsertMoney(idAccount, amount);
            }
            else {
               homeMethods.WithdrawMoney(idAccount, amount);
            }
            RefreshValues();
         }
      }

   }
}
