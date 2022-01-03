
namespace AtmUI {
   partial class HomeForm {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
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
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent() {
         this.LogOutBtn = new System.Windows.Forms.Button();
         this.label2 = new System.Windows.Forms.Label();
         this.CurrentAccGb = new System.Windows.Forms.GroupBox();
         this.CurrentAccSendMoneyBtn = new System.Windows.Forms.Button();
         this.CurrentAccWithdrawMoneyBtn = new System.Windows.Forms.Button();
         this.CurrentAccInsertMoneyBtn = new System.Windows.Forms.Button();
         this.CurrentAccBalanceLbl = new System.Windows.Forms.Label();
         this.label8 = new System.Windows.Forms.Label();
         this.SavingsAccGb = new System.Windows.Forms.GroupBox();
         this.SavingsAccSendMoneyBtn = new System.Windows.Forms.Button();
         this.SavingsAccWithdrawMoneyBtn = new System.Windows.Forms.Button();
         this.SavingsAccInsertMoneyBtn = new System.Windows.Forms.Button();
         this.SavingsAccBalanceLbl = new System.Windows.Forms.Label();
         this.MonthlyInterestLbl = new System.Windows.Forms.Label();
         this.label10 = new System.Windows.Forms.Label();
         this.label9 = new System.Windows.Forms.Label();
         this.NameSurnameLbl = new System.Windows.Forms.Label();
         this.CurrentAccGb.SuspendLayout();
         this.SavingsAccGb.SuspendLayout();
         this.SuspendLayout();
         // 
         // LogOutBtn
         // 
         this.LogOutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
         this.LogOutBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
         this.LogOutBtn.Location = new System.Drawing.Point(705, 688);
         this.LogOutBtn.Name = "LogOutBtn";
         this.LogOutBtn.Size = new System.Drawing.Size(163, 57);
         this.LogOutBtn.TabIndex = 2;
         this.LogOutBtn.Text = "Log out";
         this.LogOutBtn.UseVisualStyleBackColor = true;
         this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
         this.label2.Location = new System.Drawing.Point(400, 25);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(104, 45);
         this.label2.TabIndex = 19;
         this.label2.Text = "ATM";
         // 
         // CurrentAccGb
         // 
         this.CurrentAccGb.BackColor = System.Drawing.SystemColors.Control;
         this.CurrentAccGb.Controls.Add(this.CurrentAccSendMoneyBtn);
         this.CurrentAccGb.Controls.Add(this.CurrentAccWithdrawMoneyBtn);
         this.CurrentAccGb.Controls.Add(this.CurrentAccInsertMoneyBtn);
         this.CurrentAccGb.Controls.Add(this.CurrentAccBalanceLbl);
         this.CurrentAccGb.Controls.Add(this.label8);
         this.CurrentAccGb.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.CurrentAccGb.Location = new System.Drawing.Point(150, 98);
         this.CurrentAccGb.Name = "CurrentAccGb";
         this.CurrentAccGb.Size = new System.Drawing.Size(587, 235);
         this.CurrentAccGb.TabIndex = 0;
         this.CurrentAccGb.TabStop = false;
         this.CurrentAccGb.Text = "Current account";
         // 
         // CurrentAccSendMoneyBtn
         // 
         this.CurrentAccSendMoneyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
         this.CurrentAccSendMoneyBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.CurrentAccSendMoneyBtn.Location = new System.Drawing.Point(387, 145);
         this.CurrentAccSendMoneyBtn.Name = "CurrentAccSendMoneyBtn";
         this.CurrentAccSendMoneyBtn.Size = new System.Drawing.Size(175, 50);
         this.CurrentAccSendMoneyBtn.TabIndex = 2;
         this.CurrentAccSendMoneyBtn.Text = "Send Money";
         this.CurrentAccSendMoneyBtn.UseVisualStyleBackColor = true;
         this.CurrentAccSendMoneyBtn.Click += new System.EventHandler(this.CurrentAccSendMoneyBtn_Click);
         // 
         // CurrentAccWithdrawMoneyBtn
         // 
         this.CurrentAccWithdrawMoneyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
         this.CurrentAccWithdrawMoneyBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.CurrentAccWithdrawMoneyBtn.Location = new System.Drawing.Point(206, 145);
         this.CurrentAccWithdrawMoneyBtn.Name = "CurrentAccWithdrawMoneyBtn";
         this.CurrentAccWithdrawMoneyBtn.Size = new System.Drawing.Size(175, 50);
         this.CurrentAccWithdrawMoneyBtn.TabIndex = 1;
         this.CurrentAccWithdrawMoneyBtn.Text = "Withdraw Money";
         this.CurrentAccWithdrawMoneyBtn.UseVisualStyleBackColor = true;
         this.CurrentAccWithdrawMoneyBtn.Click += new System.EventHandler(this.CurrentAccWithdrawMoneyBtn_Click);
         // 
         // CurrentAccInsertMoneyBtn
         // 
         this.CurrentAccInsertMoneyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
         this.CurrentAccInsertMoneyBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.CurrentAccInsertMoneyBtn.Location = new System.Drawing.Point(25, 145);
         this.CurrentAccInsertMoneyBtn.Name = "CurrentAccInsertMoneyBtn";
         this.CurrentAccInsertMoneyBtn.Size = new System.Drawing.Size(175, 50);
         this.CurrentAccInsertMoneyBtn.TabIndex = 0;
         this.CurrentAccInsertMoneyBtn.Text = "Insert Money";
         this.CurrentAccInsertMoneyBtn.UseVisualStyleBackColor = true;
         this.CurrentAccInsertMoneyBtn.Click += new System.EventHandler(this.CurrentAccInsertMoneyBtn_Click);
         // 
         // CurrentAccBalanceLbl
         // 
         this.CurrentAccBalanceLbl.AutoSize = true;
         this.CurrentAccBalanceLbl.BackColor = System.Drawing.SystemColors.Control;
         this.CurrentAccBalanceLbl.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.CurrentAccBalanceLbl.Location = new System.Drawing.Point(165, 70);
         this.CurrentAccBalanceLbl.MaximumSize = new System.Drawing.Size(300, 0);
         this.CurrentAccBalanceLbl.Name = "CurrentAccBalanceLbl";
         this.CurrentAccBalanceLbl.Size = new System.Drawing.Size(132, 37);
         this.CurrentAccBalanceLbl.TabIndex = 7;
         this.CurrentAccBalanceLbl.Text = "XXX XXX";
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.BackColor = System.Drawing.SystemColors.Control;
         this.label8.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.label8.Location = new System.Drawing.Point(25, 70);
         this.label8.MaximumSize = new System.Drawing.Size(230, 0);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(123, 37);
         this.label8.TabIndex = 7;
         this.label8.Text = "Balance:";
         // 
         // SavingsAccGb
         // 
         this.SavingsAccGb.Controls.Add(this.SavingsAccSendMoneyBtn);
         this.SavingsAccGb.Controls.Add(this.SavingsAccWithdrawMoneyBtn);
         this.SavingsAccGb.Controls.Add(this.SavingsAccInsertMoneyBtn);
         this.SavingsAccGb.Controls.Add(this.SavingsAccBalanceLbl);
         this.SavingsAccGb.Controls.Add(this.MonthlyInterestLbl);
         this.SavingsAccGb.Controls.Add(this.label10);
         this.SavingsAccGb.Controls.Add(this.label9);
         this.SavingsAccGb.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.SavingsAccGb.Location = new System.Drawing.Point(150, 343);
         this.SavingsAccGb.Name = "SavingsAccGb";
         this.SavingsAccGb.Size = new System.Drawing.Size(587, 310);
         this.SavingsAccGb.TabIndex = 1;
         this.SavingsAccGb.TabStop = false;
         this.SavingsAccGb.Text = "Savings account";
         // 
         // SavingsAccSendMoneyBtn
         // 
         this.SavingsAccSendMoneyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
         this.SavingsAccSendMoneyBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.SavingsAccSendMoneyBtn.Location = new System.Drawing.Point(387, 220);
         this.SavingsAccSendMoneyBtn.Name = "SavingsAccSendMoneyBtn";
         this.SavingsAccSendMoneyBtn.Size = new System.Drawing.Size(175, 50);
         this.SavingsAccSendMoneyBtn.TabIndex = 2;
         this.SavingsAccSendMoneyBtn.Text = "Send Money";
         this.SavingsAccSendMoneyBtn.UseVisualStyleBackColor = true;
         this.SavingsAccSendMoneyBtn.Click += new System.EventHandler(this.SavingsAccSendMoneyBtn_Click);
         // 
         // SavingsAccWithdrawMoneyBtn
         // 
         this.SavingsAccWithdrawMoneyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
         this.SavingsAccWithdrawMoneyBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.SavingsAccWithdrawMoneyBtn.Location = new System.Drawing.Point(206, 220);
         this.SavingsAccWithdrawMoneyBtn.Name = "SavingsAccWithdrawMoneyBtn";
         this.SavingsAccWithdrawMoneyBtn.Size = new System.Drawing.Size(175, 50);
         this.SavingsAccWithdrawMoneyBtn.TabIndex = 1;
         this.SavingsAccWithdrawMoneyBtn.Text = "Withdraw Money";
         this.SavingsAccWithdrawMoneyBtn.UseVisualStyleBackColor = true;
         this.SavingsAccWithdrawMoneyBtn.Click += new System.EventHandler(this.SavingsAccWithdrawMoneyBtn_Click);
         // 
         // SavingsAccInsertMoneyBtn
         // 
         this.SavingsAccInsertMoneyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
         this.SavingsAccInsertMoneyBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.SavingsAccInsertMoneyBtn.Location = new System.Drawing.Point(25, 220);
         this.SavingsAccInsertMoneyBtn.Name = "SavingsAccInsertMoneyBtn";
         this.SavingsAccInsertMoneyBtn.Size = new System.Drawing.Size(175, 50);
         this.SavingsAccInsertMoneyBtn.TabIndex = 0;
         this.SavingsAccInsertMoneyBtn.Text = "Insert Money";
         this.SavingsAccInsertMoneyBtn.UseVisualStyleBackColor = true;
         this.SavingsAccInsertMoneyBtn.Click += new System.EventHandler(this.SavingsAccInsertMoneyBtn_Click);
         // 
         // SavingsAccBalanceLbl
         // 
         this.SavingsAccBalanceLbl.AutoSize = true;
         this.SavingsAccBalanceLbl.BackColor = System.Drawing.SystemColors.Control;
         this.SavingsAccBalanceLbl.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.SavingsAccBalanceLbl.Location = new System.Drawing.Point(165, 145);
         this.SavingsAccBalanceLbl.MaximumSize = new System.Drawing.Size(300, 0);
         this.SavingsAccBalanceLbl.Name = "SavingsAccBalanceLbl";
         this.SavingsAccBalanceLbl.Size = new System.Drawing.Size(132, 37);
         this.SavingsAccBalanceLbl.TabIndex = 16;
         this.SavingsAccBalanceLbl.Text = "XXX XXX";
         // 
         // MonthlyInterestLbl
         // 
         this.MonthlyInterestLbl.AutoSize = true;
         this.MonthlyInterestLbl.BackColor = System.Drawing.SystemColors.Control;
         this.MonthlyInterestLbl.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.MonthlyInterestLbl.Location = new System.Drawing.Point(270, 70);
         this.MonthlyInterestLbl.Name = "MonthlyInterestLbl";
         this.MonthlyInterestLbl.Size = new System.Drawing.Size(58, 37);
         this.MonthlyInterestLbl.TabIndex = 15;
         this.MonthlyInterestLbl.Text = "X%";
         // 
         // label10
         // 
         this.label10.AutoSize = true;
         this.label10.BackColor = System.Drawing.SystemColors.Control;
         this.label10.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.label10.Location = new System.Drawing.Point(25, 70);
         this.label10.Name = "label10";
         this.label10.Size = new System.Drawing.Size(239, 37);
         this.label10.TabIndex = 13;
         this.label10.Text = "Monthly interest:";
         // 
         // label9
         // 
         this.label9.AutoSize = true;
         this.label9.BackColor = System.Drawing.SystemColors.Control;
         this.label9.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.label9.Location = new System.Drawing.Point(25, 145);
         this.label9.MaximumSize = new System.Drawing.Size(230, 0);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(123, 37);
         this.label9.TabIndex = 13;
         this.label9.Text = "Balance:";
         // 
         // NameSurnameLbl
         // 
         this.NameSurnameLbl.AutoSize = true;
         this.NameSurnameLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
         this.NameSurnameLbl.Location = new System.Drawing.Point(12, 9);
         this.NameSurnameLbl.Name = "NameSurnameLbl";
         this.NameSurnameLbl.Size = new System.Drawing.Size(313, 45);
         this.NameSurnameLbl.TabIndex = 22;
         this.NameSurnameLbl.Text = "Name Surname";
         // 
         // Home
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(880, 757);
         this.Controls.Add(this.NameSurnameLbl);
         this.Controls.Add(this.SavingsAccGb);
         this.Controls.Add(this.CurrentAccGb);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.LogOutBtn);
         this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
         this.MaximizeBox = false;
         this.Name = "Home";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "ATM - Home";
         this.CurrentAccGb.ResumeLayout(false);
         this.CurrentAccGb.PerformLayout();
         this.SavingsAccGb.ResumeLayout(false);
         this.SavingsAccGb.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button LogOutBtn;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.GroupBox CurrentAccGb;
      private System.Windows.Forms.Label label8;
      private System.Windows.Forms.Label CurrentAccBalanceLbl;
      private System.Windows.Forms.GroupBox SavingsAccGb;
      private System.Windows.Forms.Label SavingsAccBalanceLbl;
      private System.Windows.Forms.Label MonthlyInterestLbl;
      private System.Windows.Forms.Label label10;
      private System.Windows.Forms.Label label9;
      private System.Windows.Forms.Label NameSurnameLbl;
      private System.Windows.Forms.Button CurrentAccInsertMoneyBtn;
      private System.Windows.Forms.Button CurrentAccSendMoneyBtn;
      private System.Windows.Forms.Button CurrentAccWithdrawMoneyBtn;
      private System.Windows.Forms.Button SavingsAccSendMoneyBtn;
      private System.Windows.Forms.Button SavingsAccWithdrawMoneyBtn;
      private System.Windows.Forms.Button SavingsAccInsertMoneyBtn;
   }
}