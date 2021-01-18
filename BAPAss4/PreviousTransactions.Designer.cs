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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreviousTransactions));
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.PreviousGridView = new System.Windows.Forms.DataGridView();
            this.DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CashierColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViewButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.FilenameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceButton = new System.Windows.Forms.Button();
            this.SearchGroupBox = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PreviousGridView)).BeginInit();
            this.SearchGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(131, 44);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(223, 22);
            this.SearchTextBox.TabIndex = 0;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(279, 82);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "&Search";
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
            this.PreviousGridView.Location = new System.Drawing.Point(12, 12);
            this.PreviousGridView.Name = "PreviousGridView";
            this.PreviousGridView.Size = new System.Drawing.Size(763, 361);
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
            // InvoiceButton
            // 
            this.InvoiceButton.Location = new System.Drawing.Point(131, 82);
            this.InvoiceButton.Name = "InvoiceButton";
            this.InvoiceButton.Size = new System.Drawing.Size(75, 23);
            this.InvoiceButton.TabIndex = 7;
            this.InvoiceButton.Text = "&Return";
            this.InvoiceButton.UseVisualStyleBackColor = true;
            this.InvoiceButton.Click += new System.EventHandler(this.InvoiceButton_Click);
            // 
            // SearchGroupBox
            // 
            this.SearchGroupBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SearchGroupBox.Controls.Add(this.label17);
            this.SearchGroupBox.Controls.Add(this.InvoiceButton);
            this.SearchGroupBox.Controls.Add(this.SearchTextBox);
            this.SearchGroupBox.Controls.Add(this.SearchButton);
            this.SearchGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchGroupBox.Location = new System.Drawing.Point(797, 12);
            this.SearchGroupBox.Name = "SearchGroupBox";
            this.SearchGroupBox.Size = new System.Drawing.Size(369, 152);
            this.SearchGroupBox.TabIndex = 21;
            this.SearchGroupBox.TabStop = false;
            this.SearchGroupBox.Text = "Search";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(23, 45);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(102, 16);
            this.label17.TabIndex = 0;
            this.label17.Text = "Search Query";
            // 
            // PreviousTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 413);
            this.Controls.Add(this.SearchGroupBox);
            this.Controls.Add(this.PreviousGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PreviousTransactions";
            this.Text = "Search Previous Transactions";
            ((System.ComponentModel.ISupportInitialize)(this.PreviousGridView)).EndInit();
            this.SearchGroupBox.ResumeLayout(false);
            this.SearchGroupBox.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button InvoiceButton;
        private System.Windows.Forms.GroupBox SearchGroupBox;
        private System.Windows.Forms.Label label17;
    }
}