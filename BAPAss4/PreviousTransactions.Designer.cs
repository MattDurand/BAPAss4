namespace BAPAss4
{
    partial class PreviousTransactions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.PreviousGridView = new System.Windows.Forms.DataGridView();
            this.DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CashierColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViewButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.FilenameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PreviousGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(90, 48);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(100, 20);
            this.SearchTextBox.TabIndex = 0;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(223, 48);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // PreviousGridView
            // 
            this.PreviousGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PreviousGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateColumn,
            this.CashierColumn,
            this.TransactionIDColumn,
            this.TotalColumn,
            this.ViewButtonColumn,
            this.FilenameColumn});
            this.PreviousGridView.Location = new System.Drawing.Point(12, 130);
            this.PreviousGridView.Name = "PreviousGridView";
            this.PreviousGridView.Size = new System.Drawing.Size(743, 150);
            this.PreviousGridView.TabIndex = 2;
            this.PreviousGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PreviousGridView_CellContentClick);
            // 
            // DateColumn
            // 
            this.DateColumn.HeaderText = "Date";
            this.DateColumn.Name = "DateColumn";
            this.DateColumn.ReadOnly = true;
            this.DateColumn.Width = 200;
            // 
            // CashierColumn
            // 
            this.CashierColumn.HeaderText = "Cashier";
            this.CashierColumn.Name = "CashierColumn";
            this.CashierColumn.ReadOnly = true;
            // 
            // TransactionIDColumn
            // 
            this.TransactionIDColumn.HeaderText = "Transaction ID";
            this.TransactionIDColumn.Name = "TransactionIDColumn";
            this.TransactionIDColumn.ReadOnly = true;
            this.TransactionIDColumn.Width = 200;
            // 
            // TotalColumn
            // 
            this.TotalColumn.HeaderText = "Total";
            this.TotalColumn.Name = "TotalColumn";
            // 
            // ViewButtonColumn
            // 
            this.ViewButtonColumn.HeaderText = "";
            this.ViewButtonColumn.Name = "ViewButtonColumn";
            this.ViewButtonColumn.ReadOnly = true;
            this.ViewButtonColumn.Text = "View";
            this.ViewButtonColumn.UseColumnTextForButtonValue = true;
            // 
            // FilenameColumn
            // 
            this.FilenameColumn.HeaderText = "Filename";
            this.FilenameColumn.Name = "FilenameColumn";
            this.FilenameColumn.ReadOnly = true;
            this.FilenameColumn.Visible = false;
            // 
            // PreviousTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.PreviousGridView);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchTextBox);
            this.Name = "PreviousTransactions";
            this.Text = "PreviousTransactions";
            ((System.ComponentModel.ISupportInitialize)(this.PreviousGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridView PreviousGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CashierColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalColumn;
        private System.Windows.Forms.DataGridViewButtonColumn ViewButtonColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilenameColumn;
    }
}