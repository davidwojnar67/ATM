using System;
using System.ComponentModel;
using System.Configuration;
using System.Windows.Forms;

namespace AtmUI
{
    public partial class CreateAccForm : Form
    {

        private readonly CreateAccMethods createAccMethods;
        private readonly float monthlyInterest;

        public CreateAccForm(CreateAccMethods createAccMethods)
        {
            InitializeComponent();
            this.createAccMethods = createAccMethods;
            monthlyInterest = createAccMethods.MonthlyInterest();
            MonthlyInterestLbl.Text = monthlyInterest.ToString() + "%";
            MonthlyInterestLbl.Refresh();
        }

        private void BackToLoginBtn_Click(object sender, EventArgs e)
        {
            AutoValidate = AutoValidate.Disable;
            this.Close();
            LoginForm login = new(new LoginMethods());
            login.Show();
        }

        private void CreateAccBtn_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                var status = createAccMethods.CreateClient(NameTb.Text, SurnameTb.Text, AddressTb.Text, DateOfBirthDtp, CurrentAccBalanceNum.Value, SavingAccBalanceNum.Value, monthlyInterest, UsernameTb.Text, PinCodeTb.Text);
                if (status == CreateAccMethods.CreateStatus.Ok)
                {
                    this.Close();
                    LoginForm login = new(new LoginMethods());
                    login.Show();
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show(ConfigurationManager.AppSettings["CreateAccSuccessText"], ConfigurationManager.AppSettings["SuccessCaption"], MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show(createAccMethods.GetErrorMessage(), ConfigurationManager.AppSettings["ErrorCaption"], MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (status == CreateAccMethods.CreateStatus.UserAlreadyExists)
                    {
                        UsernameTb.ForeColor = System.Drawing.Color.Red;
                        UsernameTb.Focus();
                    }
                }
            }
        }


        // Validace vyplnění povinných údajů.

        private void NameTb_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameTb.Text))
            {
                e.Cancel = true;
                NameTb.Focus();
                errorProvider.SetError(NameTb, "Name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(NameTb, "");
            }
        }

        private void SurnameTb_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SurnameTb.Text))
            {
                e.Cancel = true;
                SurnameTb.Focus();
                errorProvider.SetError(SurnameTb, "Surname should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(SurnameTb, "");
            }
        }

        private void AddressTb_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AddressTb.Text))
            {
                e.Cancel = true;
                AddressTb.Focus();
                errorProvider.SetError(AddressTb, "Address should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(AddressTb, "");
            }
        }

        private void UsernameTb_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UsernameTb.Text))
            {
                e.Cancel = true;
                UsernameTb.Focus();
                errorProvider.SetError(UsernameTb, "Username should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(UsernameTb, "");
            }
        }

        private void PinCodeTb_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PinCodeTb.Text))
            {
                e.Cancel = true;
                PinCodeTb.Focus();
                errorProvider.SetError(PinCodeTb, "Pin Code should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(PinCodeTb, "");
            }
        }

    }
}
