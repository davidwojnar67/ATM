
namespace AtmUI {
   partial class SendMoneyForm {
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
         this.components = new System.ComponentModel.Container();
         this.label1 = new System.Windows.Forms.Label();
         this.AmountNum = new System.Windows.Forms.NumericUpDown();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.NoteTb = new System.Windows.Forms.TextBox();
         this.label5 = new System.Windows.Forms.Label();
         this.NoteForRecipientTb = new System.Windows.Forms.TextBox();
         this.SendMoneyBtn = new System.Windows.Forms.Button();
         this.CancelBtn = new System.Windows.Forms.Button();
         this.RecipientAccIdTb = new System.Windows.Forms.NumericUpDown();
         this.VariableNumberTb = new System.Windows.Forms.NumericUpDown();
         this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
         ((System.ComponentModel.ISupportInitialize)(this.AmountNum)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.RecipientAccIdTb)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.VariableNumberTb)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.label1.Location = new System.Drawing.Point(25, 25);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(128, 37);
         this.label1.TabIndex = 4;
         this.label1.Text = "Amount:";
         // 
         // AmountNum
         // 
         this.AmountNum.DecimalPlaces = 4;
         this.AmountNum.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.AmountNum.Location = new System.Drawing.Point(320, 23);
         this.AmountNum.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
         this.AmountNum.Name = "AmountNum";
         this.AmountNum.Size = new System.Drawing.Size(260, 43);
         this.AmountNum.TabIndex = 0;
         this.AmountNum.ThousandsSeparator = true;
         this.AmountNum.Validating += new System.ComponentModel.CancelEventHandler(this.AmountNum_Validating);
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.label2.Location = new System.Drawing.Point(25, 90);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(289, 37);
         this.label2.TabIndex = 5;
         this.label2.Text = "Recipient Account Id:";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.label3.Location = new System.Drawing.Point(25, 154);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(242, 37);
         this.label3.TabIndex = 6;
         this.label3.Text = "Variable Number:";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.label4.Location = new System.Drawing.Point(25, 220);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(88, 37);
         this.label4.TabIndex = 7;
         this.label4.Text = "Note:";
         // 
         // NoteTb
         // 
         this.NoteTb.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
         this.NoteTb.Location = new System.Drawing.Point(25, 260);
         this.NoteTb.Multiline = true;
         this.NoteTb.Name = "NoteTb";
         this.NoteTb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.NoteTb.Size = new System.Drawing.Size(260, 150);
         this.NoteTb.TabIndex = 3;
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.label5.Location = new System.Drawing.Point(320, 220);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(260, 37);
         this.label5.TabIndex = 9;
         this.label5.Text = "Note for Recipient:";
         // 
         // NoteForRecipientTb
         // 
         this.NoteForRecipientTb.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
         this.NoteForRecipientTb.Location = new System.Drawing.Point(320, 260);
         this.NoteForRecipientTb.Multiline = true;
         this.NoteForRecipientTb.Name = "NoteForRecipientTb";
         this.NoteForRecipientTb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.NoteForRecipientTb.Size = new System.Drawing.Size(260, 150);
         this.NoteForRecipientTb.TabIndex = 4;
         // 
         // SendMoneyBtn
         // 
         this.SendMoneyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
         this.SendMoneyBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.SendMoneyBtn.Location = new System.Drawing.Point(382, 459);
         this.SendMoneyBtn.Name = "SendMoneyBtn";
         this.SendMoneyBtn.Size = new System.Drawing.Size(198, 56);
         this.SendMoneyBtn.TabIndex = 5;
         this.SendMoneyBtn.Text = "Send Money";
         this.SendMoneyBtn.UseVisualStyleBackColor = true;
         this.SendMoneyBtn.Click += new System.EventHandler(this.SendMoneyBtn_Click);
         // 
         // CancelBtn
         // 
         this.CancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
         this.CancelBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
         this.CancelBtn.Location = new System.Drawing.Point(25, 475);
         this.CancelBtn.Name = "CancelBtn";
         this.CancelBtn.Size = new System.Drawing.Size(145, 40);
         this.CancelBtn.TabIndex = 6;
         this.CancelBtn.Text = "Cancel";
         this.CancelBtn.UseVisualStyleBackColor = true;
         this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
         // 
         // RecipientAccIdTb
         // 
         this.RecipientAccIdTb.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.RecipientAccIdTb.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
         this.RecipientAccIdTb.InterceptArrowKeys = false;
         this.RecipientAccIdTb.Location = new System.Drawing.Point(320, 87);
         this.RecipientAccIdTb.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
         this.RecipientAccIdTb.Name = "RecipientAccIdTb";
         this.RecipientAccIdTb.Size = new System.Drawing.Size(260, 43);
         this.RecipientAccIdTb.TabIndex = 1;
         this.RecipientAccIdTb.Validating += new System.ComponentModel.CancelEventHandler(this.RecipientAccIdTb_Validating);
         // 
         // VariableNumberTb
         // 
         this.VariableNumberTb.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.VariableNumberTb.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
         this.VariableNumberTb.InterceptArrowKeys = false;
         this.VariableNumberTb.Location = new System.Drawing.Point(320, 152);
         this.VariableNumberTb.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
         this.VariableNumberTb.Name = "VariableNumberTb";
         this.VariableNumberTb.Size = new System.Drawing.Size(260, 43);
         this.VariableNumberTb.TabIndex = 2;
         // 
         // errorProvider1
         // 
         this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
         this.errorProvider1.ContainerControl = this;
         // 
         // SendMoneyForm
         // 
         this.AcceptButton = this.SendMoneyBtn;
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(608, 527);
         this.Controls.Add(this.VariableNumberTb);
         this.Controls.Add(this.RecipientAccIdTb);
         this.Controls.Add(this.CancelBtn);
         this.Controls.Add(this.SendMoneyBtn);
         this.Controls.Add(this.NoteForRecipientTb);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.NoteTb);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.AmountNum);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
         this.MaximizeBox = false;
         this.Name = "SendMoneyForm";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Send Money";
         ((System.ComponentModel.ISupportInitialize)(this.AmountNum)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.RecipientAccIdTb)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.VariableNumberTb)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.NumericUpDown AmountNum;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.TextBox NoteTb;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.TextBox NoteForRecipientTb;
      private System.Windows.Forms.Button SendMoneyBtn;
      private System.Windows.Forms.Button CancelBtn;
      private System.Windows.Forms.NumericUpDown RecipientAccIdTb;
      private System.Windows.Forms.NumericUpDown VariableNumberTb;
      private System.Windows.Forms.ErrorProvider errorProvider1;
   }
}