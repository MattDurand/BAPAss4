using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAPAss4
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private int passwordAttempts = 2;

        /// <summary>
        /// onclick listener button to validate login details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        

        private void PasswordSubmitButton_Click_1(object sender, EventArgs e)
        {
            // Login validation
            if ((UsernameTextBox.Text == "admin" || UsernameTextBox.Text == "") && (PasswordTextBox.Text == "admin" || PasswordTextBox.Text == ""))
            {
                OrderForm orderForm = new OrderForm(UsernameTextBox.Text);
                orderForm.Show();
                this.Hide();

            }
            else if (passwordAttempts > 0)
            {
                passwordAttempts--;
                toolTip1.SetToolTip(this.PasswordSubmitButton, "Incorrect Password. Attepts Remaining: " + (passwordAttempts + 1));
            }
            else if (passwordAttempts == 0)
            {
                MessageBox.Show("Three incorrect passwords have been entered. Shutting Down.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }

    
}
