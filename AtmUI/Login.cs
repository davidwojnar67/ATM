using System;
using System.Windows.Forms;
using System.Configuration;

namespace AtmUI {
   public partial class Login : Form {

      private readonly LoginMethods loginMethods;

      public Login(LoginMethods loginMethods) {
         InitializeComponent();
         this.loginMethods = loginMethods;
      }

      private void LoginBtn_Click(object sender, EventArgs e) {

         if (loginMethods.Login(UsernameTb.Text, PinCodeTb.Text)) {
            this.Close();
            Home home = new();
            home.Show();
         }
         else {
            MessageBox.Show(ConfigurationManager.AppSettings["LoginErrorText"], ConfigurationManager.AppSettings["LoginErrorCaption"], MessageBoxButtons.OK, MessageBoxIcon.Error);
         }

      }

      private void CreateAccBtn_Click(object sender, EventArgs e) {
         this.Close();
         CreateAcc createAcc = new(new CreateAccMethods());
         createAcc.Show();
      }
   }
}
