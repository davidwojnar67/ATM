
namespace AtmUI {
   partial class TransactionHistoryForm {
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
         this.dataGridView = new System.Windows.Forms.DataGridView();
         this.CloseBtn = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
         this.SuspendLayout();
         // 
         // dataGridView
         // 
         this.dataGridView.AllowUserToAddRows = false;
         this.dataGridView.AllowUserToDeleteRows = false;
         this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
         this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dataGridView.Location = new System.Drawing.Point(12, 12);
         this.dataGridView.Name = "dataGridView";
         this.dataGridView.RowTemplate.Height = 25;
         this.dataGridView.Size = new System.Drawing.Size(1356, 687);
         this.dataGridView.TabIndex = 0;
         // 
         // CloseBtn
         // 
         this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
         this.CloseBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
         this.CloseBtn.Location = new System.Drawing.Point(1223, 705);
         this.CloseBtn.Name = "CloseBtn";
         this.CloseBtn.Size = new System.Drawing.Size(145, 40);
         this.CloseBtn.TabIndex = 3;
         this.CloseBtn.Text = "Close";
         this.CloseBtn.UseVisualStyleBackColor = true;
         this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
         // 
         // TransactionHistoryForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1380, 757);
         this.Controls.Add(this.CloseBtn);
         this.Controls.Add(this.dataGridView);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
         this.MaximizeBox = false;
         this.Name = "TransactionHistoryForm";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Transaction History";
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.DataGridView dataGridView;
      private System.Windows.Forms.Button CloseBtn;
   }
}