﻿
namespace AtmUI {
   partial class Home {
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
         this.label1 = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // LogOutBtn
         // 
         this.LogOutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
         this.LogOutBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
         this.LogOutBtn.Location = new System.Drawing.Point(805, 688);
         this.LogOutBtn.Name = "LogOutBtn";
         this.LogOutBtn.Size = new System.Drawing.Size(163, 57);
         this.LogOutBtn.TabIndex = 17;
         this.LogOutBtn.Text = "Log out";
         this.LogOutBtn.UseVisualStyleBackColor = true;
         this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
         this.label1.Location = new System.Drawing.Point(328, 77);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(97, 41);
         this.label1.TabIndex = 18;
         this.label1.Text = "label1";
         // 
         // Home
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(980, 757);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.LogOutBtn);
         this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
         this.MaximizeBox = false;
         this.Name = "Home";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "ATM - Home";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button LogOutBtn;
      private System.Windows.Forms.Label label1;
   }
}