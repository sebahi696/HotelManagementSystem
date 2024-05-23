using System;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (AuthenticateUser(username, password))
            {
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private bool AuthenticateUser(string username, string password)
        {
            // Implement authentication logic here
            return username == "admin" && password == "password";
        }
    }
}
