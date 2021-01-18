namespace BAPAss4
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.PasswordPanel = new System.Windows.Forms.Panel();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordSubmitButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.PasswordPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PasswordPanel
            // 
            this.PasswordPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PasswordPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordPanel.Controls.Add(this.UsernameTextBox);
            this.PasswordPanel.Controls.Add(this.label2);
            this.PasswordPanel.Controls.Add(this.label1);
            this.PasswordPanel.Controls.Add(this.PasswordTextBox);
            this.PasswordPanel.Controls.Add(this.PasswordSubmitButton);
            this.PasswordPanel.Location = new System.Drawing.Point(33, 49);
            this.PasswordPanel.Name = "PasswordPanel";
            this.PasswordPanel.Size = new System.Drawing.Size(258, 122);
            this.PasswordPanel.TabIndex = 1;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(93, 23);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.PasswordChar = '*';
            this.UsernameTextBox.Size = new System.Drawing.Size(123, 20);
            this.UsernameTextBox.TabIndex = 4;
            this.UsernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password ";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(93, 49);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(123, 20);
            this.PasswordTextBox.TabIndex = 1;
            this.PasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PasswordSubmitButton
            // 
            this.PasswordSubmitButton.Location = new System.Drawing.Point(93, 75);
            this.PasswordSubmitButton.Name = "PasswordSubmitButton";
            this.PasswordSubmitButton.Size = new System.Drawing.Size(123, 23);
            this.PasswordSubmitButton.TabIndex = 0;
            this.PasswordSubmitButton.Text = "&Log In";
            this.PasswordSubmitButton.UseVisualStyleBackColor = true;
            this.PasswordSubmitButton.Click += new System.EventHandler(this.PasswordSubmitButton_Click_1);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 205);
            this.Controls.Add(this.PasswordPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "User Login";
            this.PasswordPanel.ResumeLayout(false);
            this.PasswordPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PasswordPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button PasswordSubmitButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Label label2;
    }
}

