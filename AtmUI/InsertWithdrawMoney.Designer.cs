
namespace AtmUI {
   partial class InsertWithdrawMoney {
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
         this.AcceptBtn = new System.Windows.Forms.Button();
         this.AmountNum = new System.Windows.Forms.NumericUpDown();
         this.label1 = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.AmountNum)).BeginInit();
         this.SuspendLayout();
         // 
         // AcceptBtn
         // 
         this.AcceptBtn.Cursor = System.Windows.Forms.Cursors.Hand;
         this.AcceptBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.AcceptBtn.Location = new System.Drawing.Point(228, 145);
         this.AcceptBtn.Name = "AcceptBtn";
         this.AcceptBtn.Size = new System.Drawing.Size(175, 50);
         this.AcceptBtn.TabIndex = 1;
         this.AcceptBtn.Text = "accept";
         this.AcceptBtn.UseVisualStyleBackColor = true;
         this.AcceptBtn.Click += new System.EventHandler(this.AcceptBtn_Click);
         // 
         // AmountNum
         // 
         this.AmountNum.DecimalPlaces = 4;
         this.AmountNum.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.AmountNum.Location = new System.Drawing.Point(159, 23);
         this.AmountNum.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
         this.AmountNum.Name = "AmountNum";
         this.AmountNum.Size = new System.Drawing.Size(244, 43);
         this.AmountNum.TabIndex = 0;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.label1.Location = new System.Drawing.Point(25, 25);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(128, 37);
         this.label1.TabIndex = 2;
         this.label1.Text = "Amount:";
         // 
         // InsertWithdrawMoney
         // 
         this.AcceptButton = this.AcceptBtn;
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(430, 207);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.AmountNum);
         this.Controls.Add(this.AcceptBtn);
         this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
         this.MaximizeBox = false;
         this.Name = "InsertWithdrawMoney";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "InsertWithdrawMoney";
         this.TopMost = true;
         ((System.ComponentModel.ISupportInitialize)(this.AmountNum)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button AcceptBtn;
      private System.Windows.Forms.NumericUpDown AmountNum;
      private System.Windows.Forms.Label label1;
   }
}