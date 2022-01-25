using System;
using System.Configuration;
using System.Windows.Forms;

namespace AtmUI {
   public partial class HomeForm : Form {

      private readonly HomeMethods homeMethods;
      private readonly int IdCurrentAcc;
      private readonly int IdSavingsAcc;

      public HomeForm(HomeMethods homeMethods) {
         InitializeComponent();
         this.homeMethods = homeMethods;

         var client = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(homeMethods.ClientByUsername());
         IdCurrentAcc = client.currentAccount.idAccount;
         IdSavingsAcc = client.savingsAccount.idAccount;
         CurrentAccGb.Text = "Current account, Id: " + IdCurrentAcc;
         SavingsAccGb.Text = "Savings account, Id: " + IdSavingsAcc;
         MonthlyInterestLbl.Text = client.savingsAccount.interestPerMensem + "%";
         NameSurnameLbl.Text = client.name + " " + client.surname;

         RefreshValues();
      }

      private void RefreshValues() {
         var client = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(homeMethods.ClientByUsername());

         CurrentAccBalanceLbl.Text = client.currentAccount.balance;
         SavingsAccBalanceLbl.Text = client.savingsAccount.balance;
      }


      private void LogOutBtn_Click(object sender, EventArgs e) {
         this.Close();
         LoginForm login = new(new LoginMethods());
         login.Show();
      }

      private void CurrentAccInsertMoneyBtn_Click(object sender, EventArgs e) {
         MoneyOperation(true, IdCurrentAcc);
      }

      private void CurrentAccWithdrawMoneyBtn_Click(object sender, EventArgs e) {
         MoneyOperation(false, IdCurrentAcc);
      }

      private void CurrentAccSendMoneyBtn_Click(object sender, EventArgs e) {
         SendMoney(IdCurrentAcc);
      }

      private void CurrentAccTranHisBtn_Click(object sender, EventArgs e) {
         string response = homeMethods.TransactionHistory(IdCurrentAcc);
         TransactionHistoryForm transactionHistoryForm = new(response);
         transactionHistoryForm.ShowDialog();
      }

      private void SavingsAccInsertMoneyBtn_Click(object sender, EventArgs e) {
         MoneyOperation(true, IdSavingsAcc);
      }

      private void SavingsAccWithdrawMoneyBtn_Click(object sender, EventArgs e) {
         MoneyOperation(false, IdSavingsAcc);
      }

      private void SavingsAccSendMoneyBtn_Click(object sender, EventArgs e) {
         SendMoney(IdSavingsAcc);
      }

      private void SavingsAccTranHisBtn_Click(object sender, EventArgs e) {
         string response = homeMethods.TransactionHistory(IdSavingsAcc);
         TransactionHistoryForm transactionHistoryForm = new(response);
         transactionHistoryForm.ShowDialog();
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="typeOfOperation">True = insert money, False = withdraw money</param>
      /// <param name="idAccount"></param>
      private void MoneyOperation(bool typeOfOperation, int idAccount) {
         Cursor.Current = Cursors.WaitCursor;
         InsertWithdrawMoneyForm insertWithdrawMoney = new(typeOfOperation);
         int resultCode;
         var result = insertWithdrawMoney.ShowDialog();
         if (result == DialogResult.OK) {
            if (typeOfOperation) {
               resultCode = homeMethods.InsertMoney(idAccount, insertWithdrawMoney.Amount);
               if (resultCode == 200) {
                  MessageBox.Show(ConfigurationManager.AppSettings["InsertSuccessText"], ConfigurationManager.AppSettings["SuccessCaption"], MessageBoxButtons.OK, MessageBoxIcon.Information);
               }
               else if (resultCode == 400) {
                  MessageBox.Show(ConfigurationManager.AppSettings["InsertErrorText"], ConfigurationManager.AppSettings["ErrorCaption"], MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
            }
            else {
               resultCode = homeMethods.WithdrawMoney(idAccount, insertWithdrawMoney.Amount);
               if (resultCode == 200) {
                  MessageBox.Show(ConfigurationManager.AppSettings["WithdrawSuccessText"], ConfigurationManager.AppSettings["SuccessCaption"], MessageBoxButtons.OK, MessageBoxIcon.Information);
               }
               else if (resultCode == 204) {
                  MessageBox.Show(ConfigurationManager.AppSettings["WithdrawErrorText"], ConfigurationManager.AppSettings["ErrorCaption"], MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
            }
            RefreshValues();
         }
         Cursor.Current = Cursors.Default;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="IdAccSender"></param>
      private void SendMoney(int IdAccSender) {
         SendMoneyForm sendMoneyForm = new();
         int resultCode;
         var result = sendMoneyForm.ShowDialog();
         if (result == DialogResult.OK) {
            resultCode = homeMethods.SendMoney(IdAccSender, sendMoneyForm.RecipientAccId, sendMoneyForm.Amount, sendMoneyForm.VariableNumber, sendMoneyForm.Note, sendMoneyForm.NoteForRecipient);
            RefreshValues();
            if (resultCode == 200) {
               MessageBox.Show(ConfigurationManager.AppSettings["SendMoneySuccessText"], ConfigurationManager.AppSettings["SuccessCaption"], MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (resultCode == 204) {
               MessageBox.Show(ConfigurationManager.AppSettings["SendMoney204ErrorText"], ConfigurationManager.AppSettings["ErrorCaption"], MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (resultCode == 400) {
               MessageBox.Show(ConfigurationManager.AppSettings["SendMoney400ErrorText"], ConfigurationManager.AppSettings["ErrorCaption"], MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

         }
      }

   }
}
