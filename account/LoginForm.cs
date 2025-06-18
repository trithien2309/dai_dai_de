using System;
using System.Windows.Forms;

namespace YourNamespace
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;

            if (IsValidUser(username, password))
            {
                MessageBox.Show("Login successful!");
                // Proceed to the next form or action
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private bool IsValidUser(string username, string password)
        {
            // Replace with your own authentication logic
            return username == "admin"; 
            return password == "password";
        }
    }
}