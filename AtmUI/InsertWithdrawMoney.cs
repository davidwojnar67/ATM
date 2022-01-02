﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtmUI {
   public partial class InsertWithdrawMoney : Form {

      private bool TypeOfOperation { get; set; }
      public decimal Amount { get; private set; }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="typeOfOperation">True = insert money, False = withdraw money</param>
      public InsertWithdrawMoney(bool typeOfOperation) {
         InitializeComponent();
         TypeOfOperation = typeOfOperation;
         if (typeOfOperation) {
            this.Text = "Insert Money";
            AcceptBtn.Text = "Insert";
         }
         else {
            this.Text = "Withdraw Money";
            AcceptBtn.Text = "Withdraw";
         }
      }

      private void AcceptBtn_Click(object sender, EventArgs e) {
         Amount = AmountNum.Value;
         this.DialogResult = DialogResult.OK;
         this.Close();
      }
   }
}
