using System;
using System.Windows.Forms;

namespace BAPAss4
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private int _passwordAttempts = 2;

        /// <summary>
        /// onclick listener button to validate login details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PasswordSubmitButton_Click_1(object sender, EventArgs e)
        {
            // Login validation
            if ((UsernameTextBox.Text == "admin" && PasswordTextBox.Text == "admin") ||
                (UsernameTextBox.Text == "Neil" && PasswordTextBox.Text == "password"))
            {
                OrderForm orderForm = new OrderForm(UsernameTextBox.Text);
                orderForm.Show();
                Hide();
            }
            else if (_passwordAttempts > 0)
            {
                _passwordAttempts--;
                toolTip1.SetToolTip(this.PasswordSubmitButton,
                    "Incorrect Password. Attepts Remaining: " + (_passwordAttempts + 1));
            }
        }
    }
}