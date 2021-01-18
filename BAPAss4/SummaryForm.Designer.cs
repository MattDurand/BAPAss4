namespace BAPAss4
{
    partial class SummaryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SummaryForm));
            this.SummaryGroupBox = new System.Windows.Forms.GroupBox();
            this.TotalTransactionsTextBox = new System.Windows.Forms.Label();
            this.TotalRevenueTextBox = new System.Windows.Forms.Label();
            this.AverageRevenueTextBox = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.InvoiceButton = new System.Windows.Forms.Button();
            this.SummaryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SummaryGroupBox
            // 
            this.SummaryGroupBox.Controls.Add(this.TotalTransactionsTextBox);
            this.SummaryGroupBox.Controls.Add(this.InvoiceButton);
            this.SummaryGroupBox.Controls.Add(this.TotalRevenueTextBox);
            this.SummaryGroupBox.Controls.Add(this.AverageRevenueTextBox);
            this.SummaryGroupBox.Controls.Add(this.label16);
            this.SummaryGroupBox.Controls.Add(this.label14);
            this.SummaryGroupBox.Controls.Add(this.label13);
            this.SummaryGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummaryGroupBox.Location = new System.Drawing.Point(12, 12);
            this.SummaryGroupBox.Name = "SummaryGroupBox";
            this.SummaryGroupBox.Size = new System.Drawing.Size(369, 220);
            this.SummaryGroupBox.TabIndex = 20;
            this.SummaryGroupBox.TabStop = false;
            this.SummaryGroupBox.Text = "Summary Data";
            // 
            // TotalTransactionsTextBox
            // 
            this.TotalTransactionsTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TotalTransactionsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalTransactionsTextBox.Location = new System.Drawing.Point(219, 62);
            this.TotalTransactionsTextBox.Name = "TotalTransactionsTextBox";
            this.TotalTransactionsTextBox.Size = new System.Drawing.Size(120, 22);
            this.TotalTransactionsTextBox.TabIndex = 18;
            // 
            // TotalRevenueTextBox
            // 
            this.TotalRevenueTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TotalRevenueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalRevenueTextBox.Location = new System.Drawing.Point(219, 99);
            this.TotalRevenueTextBox.Name = "TotalRevenueTextBox";
            this.TotalRevenueTextBox.Size = new System.Drawing.Size(120, 22);
            this.TotalRevenueTextBox.TabIndex = 17;
            // 
            // AverageRevenueTextBox
            // 
            this.AverageRevenueTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AverageRevenueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AverageRevenueTextBox.Location = new System.Drawing.Point(219, 138);
            this.AverageRevenueTextBox.Name = "AverageRevenueTextBox";
            this.AverageRevenueTextBox.Size = new System.Drawing.Size(120, 22);
            this.AverageRevenueTextBox.TabIndex = 15;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(27, 144);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(107, 16);
            this.label16.TabIndex = 3;
            this.label16.Text = "Average Total";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(27, 105);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 16);
            this.label14.TabIndex = 1;
            this.label14.Text = "Total Revenue";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 68);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(138, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "Total Transactions";
            // 
            // InvoiceButton
            // 
            this.InvoiceButton.Location = new System.Drawing.Point(219, 181);
            this.InvoiceButton.Name = "InvoiceButton";
            this.InvoiceButton.Size = new System.Drawing.Size(120, 23);
            this.InvoiceButton.TabIndex = 6;
            this.InvoiceButton.Text = "&Return";
            this.InvoiceButton.UseVisualStyleBackColor = true;
            this.InvoiceButton.Click += new System.EventHandler(this.InvoiceButton_Click);
            // 
            // SummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 249);
            this.Controls.Add(this.SummaryGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SummaryForm";
            this.Text = "Summary Data";
            this.SummaryGroupBox.ResumeLayout(false);
            this.SummaryGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SummaryGroupBox;
        private System.Windows.Forms.Label TotalTransactionsTextBox;
        private System.Windows.Forms.Label TotalRevenueTextBox;
        private System.Windows.Forms.Label AverageRevenueTextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button InvoiceButton;
    }
}