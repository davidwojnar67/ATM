using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace AtmUI
{
    public partial class InsertWithdrawMoneyForm : Form
    {

        private bool TypeOfOperation { get; set; }
        public decimal Amount { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="typeOfOperation">True = insert money, False = withdraw money</param>
        public InsertWithdrawMoneyForm(bool typeOfOperation)
        {
            InitializeComponent();
            TypeOfOperation = typeOfOperation;
            if (typeOfOperation)
            {
                this.Text = "Deposit";
                AcceptBtn.Text = "Deposit";
            }
            else
            {
                this.Text = "Withdraw";
                AcceptBtn.Text = "Withdraw";
            }
        }

        private void AcceptBtn_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                Amount = AmountNum.Value;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            AutoValidate = AutoValidate.Disable;
            this.Close();
        }


        private void AmountNum_Validating(object sender, CancelEventArgs e)
        {
            if (AmountNum.Value == 0)
            {
                e.Cancel = true;
                AmountNum.Focus();
                errorProvider1.SetError(AmountNum, "!!!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(AmountNum, "");
            }
        }

    }
}
