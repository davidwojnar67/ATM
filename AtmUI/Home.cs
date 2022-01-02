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

      public Home(HomeMethods homeMethods) {
         InitializeComponent();
         this.homeMethods = homeMethods;
         label1.Text = homeMethods.LoggedUsername;
      }

      private void LogOutBtn_Click(object sender, EventArgs e) {
         this.Close();
         Login login = new(new LoginMethods());
         login.Show();
      }
   }
}
