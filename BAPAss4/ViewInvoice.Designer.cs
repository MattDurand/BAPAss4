namespace BAPAss4
{
    partial class ViewInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewInvoice));
            this.cartListBox = new System.Windows.Forms.ListBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // cartListBox
            // 
            this.cartListBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartListBox.FormattingEnabled = true;
            this.cartListBox.ItemHeight = 14;
            this.cartListBox.Location = new System.Drawing.Point(12, 12);
            this.cartListBox.Name = "cartListBox";
            this.cartListBox.Size = new System.Drawing.Size(310, 368);
            this.cartListBox.TabIndex = 5;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(230, 21);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 6;
            this.CloseButton.Text = "&Return";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // GroupBox
            // 
            this.GroupBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.GroupBox.Controls.Add(this.CloseButton);
            this.GroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox.Location = new System.Drawing.Point(12, 386);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(311, 61);
            this.GroupBox.TabIndex = 22;
            this.GroupBox.TabStop = false;
            // 
            // ViewInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 456);
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.cartListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewInvoice";
            this.Text = "Transaction Invoice";
            this.GroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox cartListBox;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.GroupBox GroupBox;
    }
}