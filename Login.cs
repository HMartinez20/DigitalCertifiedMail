using System;
using System.Windows.Forms;

namespace DigitalCertifiedMail
{
    public partial class Login : Form
    {
        public Login(string user)
        {
            InitializeComponent();
            selectedUser = user;
            returnUser = "";
        }

        public string selectedUser = "";
        public string returnUser { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (selectedUser)
            {
                case "Alice":
                    if (textUsername.Text == "alice.cryptography@gmail.com" && textPassword.Text == "alice1234")
                        signInUser("Alice");
                    else
                        MessageBox.Show("Incorrect email or password.", "Login Failure");
                    break;
                case "Bob":
                    if (textUsername.Text == "bob.cryptography@gmail.com" && textPassword.Text == "bob1234")
                        signInUser("Bob");
                    else
                        MessageBox.Show("Incorrect email or password.", "Login Failure");
                    break;
                default:
                    MessageBox.Show("Incorrect email or password.", "Login Failure");
                    break;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e){ this.Close(); }

        private void signInUser(string user)
        {
            MessageBox.Show("Login successful!", "Login Success");
            this.returnUser = user;
            this.Close();
        }

    }
}
