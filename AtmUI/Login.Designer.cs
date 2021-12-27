
namespace AtmUI {
   partial class Login {
      /// <summary>
      ///  Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      ///  Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing) {
         if (disposing && (components != null)) {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      ///  Required method for Designer support - do not modify
      ///  the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent() {
         this.UsernameTb = new System.Windows.Forms.TextBox();
         this.PinCodeTb = new System.Windows.Forms.TextBox();
         this.LoginBtn = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.CreateAccBtn = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // UsernameTb
         // 
         this.UsernameTb.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.UsernameTb.Location = new System.Drawing.Point(290, 100);
         this.UsernameTb.Name = "UsernameTb";
         this.UsernameTb.Size = new System.Drawing.Size(160, 43);
         this.UsernameTb.TabIndex = 0;
         // 
         // PinCodeTb
         // 
         this.PinCodeTb.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.PinCodeTb.Location = new System.Drawing.Point(290, 160);
         this.PinCodeTb.Name = "PinCodeTb";
         this.PinCodeTb.PasswordChar = '*';
         this.PinCodeTb.Size = new System.Drawing.Size(160, 43);
         this.PinCodeTb.TabIndex = 1;
         // 
         // LoginBtn
         // 
         this.LoginBtn.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.LoginBtn.Location = new System.Drawing.Point(204, 232);
         this.LoginBtn.Name = "LoginBtn";
         this.LoginBtn.Size = new System.Drawing.Size(163, 57);
         this.LoginBtn.TabIndex = 2;
         this.LoginBtn.Text = "Login";
         this.LoginBtn.UseVisualStyleBackColor = true;
         this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
         this.label1.Location = new System.Drawing.Point(235, 24);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(104, 45);
         this.label1.TabIndex = 3;
         this.label1.Text = "ATM";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.label2.Location = new System.Drawing.Point(128, 106);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(153, 37);
         this.label2.TabIndex = 4;
         this.label2.Text = "Username:";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.label3.Location = new System.Drawing.Point(128, 166);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(138, 37);
         this.label3.TabIndex = 4;
         this.label3.Text = "Pin Code:";
         // 
         // CreateAccBtn
         // 
         this.CreateAccBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
         this.CreateAccBtn.Location = new System.Drawing.Point(204, 322);
         this.CreateAccBtn.Name = "CreateAccBtn";
         this.CreateAccBtn.Size = new System.Drawing.Size(163, 67);
         this.CreateAccBtn.TabIndex = 5;
         this.CreateAccBtn.Text = "Create account";
         this.CreateAccBtn.UseVisualStyleBackColor = true;
         this.CreateAccBtn.Click += new System.EventHandler(this.CreateAccBtn_Click);
         // 
         // Login
         // 
         this.AcceptButton = this.LoginBtn;
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(580, 457);
         this.Controls.Add(this.CreateAccBtn);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.LoginBtn);
         this.Controls.Add(this.PinCodeTb);
         this.Controls.Add(this.UsernameTb);
         this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
         this.MaximizeBox = false;
         this.Name = "Login";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "ATM - Login";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox UsernameTb;
      private System.Windows.Forms.TextBox PinCodeTb;
      private System.Windows.Forms.Button LoginBtn;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Button CreateAccBtn;
   }
}

