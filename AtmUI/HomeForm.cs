﻿using System;
using System.Configuration;
using System.Windows.Forms;

namespace AtmUI {
   public partial class HomeForm : Form {

      private readonly HomeMethods homeMethods;
      private int IdCurrentAcc;
      private int IdSavingsAcc;

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
      /// <param name="amount"></param>
      private void MoneyOperation(bool typeOfOperation, int idAccount) {
         InsertWithdrawMoneyForm insertWithdrawMoney = new(typeOfOperation);
         int resultCode;
         var result = insertWithdrawMoney.ShowDialog();
         if (result == DialogResult.OK) {
            if (typeOfOperation) {
               homeMethods.InsertMoney(idAccount, insertWithdrawMoney.Amount);
            }
            else {
               resultCode = homeMethods.WithdrawMoney(idAccount, insertWithdrawMoney.Amount);
               if (resultCode == 204) {
                  MessageBox.Show(ConfigurationManager.AppSettings["WithdrawErrorText"], ConfigurationManager.AppSettings["ErrorCaption"], MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
            }
            RefreshValues();
         }
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
            if (resultCode == 204) {
               MessageBox.Show(ConfigurationManager.AppSettings["SendMoneyErrorText"], ConfigurationManager.AppSettings["ErrorCaption"], MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         }
      }

   }
}
