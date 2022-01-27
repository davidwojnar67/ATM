using System;
using System.Windows.Forms;
using System.Configuration;
using System.ComponentModel;

namespace AtmUI
{
    public partial class LoginForm : Form
    {

        private readonly LoginMethods loginMethods;

        public LoginForm(LoginMethods loginMethods)
        {
            InitializeComponent();
            this.loginMethods = loginMethods;
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                var result = loginMethods.Login(UsernameTb.Text, PinCodeTb.Text);
                Cursor.Current = Cursors.Default;
                if (result == LoginMethods.LoginStatus.Success)
                {
                    GlobalSettings.Username = UsernameTb.Text;
                    HomeForm home = new(new HomeMethods());
                    this.Close();
                    home.Show();
                }
                else if (result == LoginMethods.LoginStatus.LoginFailed)
                {
                    MessageBox.Show(ConfigurationManager.AppSettings["LoginErrorText"], ConfigurationManager.AppSettings["LoginErrorCaption"], MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (result == LoginMethods.LoginStatus.InvalidConnection)
                {
                    MessageBox.Show(ConfigurationManager.AppSettings["ConnectionErrorText"], ConfigurationManager.AppSettings["ErrorCaption"], MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void CreateAccBtn_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                AutoValidate = AutoValidate.Disable;
                CreateAccForm createAcc = new(new CreateAccMethods());
                this.Close();
                createAcc.Show();
                Cursor.Current = Cursors.Default;
            }
            catch (Exception)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show(ConfigurationManager.AppSettings["ConnectionErrorText"], ConfigurationManager.AppSettings["ErrorCaption"], MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
                
        
        // Validace vyplněného pole Username
        private void UsernameTb_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UsernameTb.Text))
            {
                e.Cancel = true;
                UsernameTb.Focus();
                errorProvider.SetError(UsernameTb, "!!!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(UsernameTb, "");
            }
        }

        // Validace vyplněného pole PinCode
        private void PinCodeTb_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PinCodeTb.Text))
            {
                e.Cancel = true;
                PinCodeTb.Focus();
                errorProvider.SetError(PinCodeTb, "!!!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(PinCodeTb, "");
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            e.Cancel = false;
        }

    }
}
