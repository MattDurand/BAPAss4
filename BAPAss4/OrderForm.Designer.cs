namespace BAPAss4
{
    partial class OrderForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.ProductGridView = new System.Windows.Forms.DataGridView();
            this.Add = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Remove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.StockLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartListBox = new System.Windows.Forms.ListBox();
            this.InvoiceButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TransactionButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.skuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductGridView
            // 
            this.ProductGridView.AutoGenerateColumns = false;
            this.ProductGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.skuDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.Add,
            this.Remove,
            this.StockLevel});
            this.ProductGridView.DataSource = this.productBindingSource;
            this.ProductGridView.Location = new System.Drawing.Point(12, 12);
            this.ProductGridView.Name = "ProductGridView";
            this.ProductGridView.Size = new System.Drawing.Size(565, 380);
            this.ProductGridView.TabIndex = 1;
            this.ProductGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductGridView_CellContentClick);
            this.ProductGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.ProductGridView_CellFormatting);
            // 
            // Add
            // 
            this.Add.HeaderText = "";
            this.Add.Name = "Add";
            this.Add.ReadOnly = true;
            this.Add.Text = "Add";
            this.Add.UseColumnTextForButtonValue = true;
            this.Add.Width = 60;
            // 
            // Remove
            // 
            this.Remove.HeaderText = "";
            this.Remove.Name = "Remove";
            this.Remove.ReadOnly = true;
            this.Remove.Text = "Remove";
            this.Remove.UseColumnTextForButtonValue = true;
            this.Remove.Width = 60;
            // 
            // StockLevel
            // 
            this.StockLevel.HeaderText = "Stock Level";
            this.StockLevel.Name = "StockLevel";
            this.StockLevel.ReadOnly = true;
            // 
            // cartListBox
            // 
            this.cartListBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartListBox.FormattingEnabled = true;
            this.cartListBox.ItemHeight = 14;
            this.cartListBox.Location = new System.Drawing.Point(583, 12);
            this.cartListBox.Name = "cartListBox";
            this.cartListBox.Size = new System.Drawing.Size(310, 284);
            this.cartListBox.TabIndex = 4;
            // 
            // InvoiceButton
            // 
            this.InvoiceButton.Location = new System.Drawing.Point(6, 19);
            this.InvoiceButton.Name = "InvoiceButton";
            this.InvoiceButton.Size = new System.Drawing.Size(85, 52);
            this.InvoiceButton.TabIndex = 6;
            this.InvoiceButton.Text = "&Purchase";
            this.InvoiceButton.UseVisualStyleBackColor = true;
            this.InvoiceButton.Click += new System.EventHandler(this.InvoiceButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.TransactionButton);
            this.groupBox1.Controls.Add(this.LogoutButton);
            this.groupBox1.Controls.Add(this.InvoiceButton);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Location = new System.Drawing.Point(583, 299);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 93);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // TransactionButton
            // 
            this.TransactionButton.Location = new System.Drawing.Point(97, 19);
            this.TransactionButton.Name = "TransactionButton";
            this.TransactionButton.Size = new System.Drawing.Size(85, 52);
            this.TransactionButton.TabIndex = 9;
            this.TransactionButton.Text = "&Previous Transactions";
            this.TransactionButton.UseVisualStyleBackColor = true;
            this.TransactionButton.Click += new System.EventHandler(this.TransactionButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(188, 19);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(116, 23);
            this.LogoutButton.TabIndex = 8;
            this.LogoutButton.Text = "&Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(188, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // skuDataGridViewTextBoxColumn
            // 
            this.skuDataGridViewTextBoxColumn.DataPropertyName = "Sku";
            this.skuDataGridViewTextBoxColumn.HeaderText = "Sku";
            this.skuDataGridViewTextBoxColumn.Name = "skuDataGridViewTextBoxColumn";
            this.skuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(BAPAss4.Product);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 404);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cartListBox);
            this.Controls.Add(this.ProductGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrderForm";
            this.Text = "Order Form";
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView ProductGridView;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.ListBox cartListBox;
        private System.Windows.Forms.Button InvoiceButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button TransactionButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn skuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Add;
        private System.Windows.Forms.DataGridViewButtonColumn Remove;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockLevel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button1;
    }
}