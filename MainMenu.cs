using System;
using System.Windows.Forms;

namespace DigitalCertifiedMail
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnNewMsg_Click(object sender, EventArgs e)
        {
            Messenger form = new Messenger();
            form.Show();
        }

        private void btnViewMsgs_Click(object sender, EventArgs e)
        {
            Inbox form = new Inbox();
            form.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void userList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(userList.SelectedIndex >= 0)
            {
                Login loginForm = new Login(userList.GetItemText(userList.Items[userList.SelectedIndex]));
                Console.WriteLine("Opening form...");
                loginForm.ShowDialog();
                Console.WriteLine("Form closed...");
                Console.WriteLine("Returned user: " + loginForm.returnUser);
                if(loginForm.returnUser != String.Empty)
                {
                    btnNewMsg.Enabled = true;
                    btnViewMsgs.Enabled = true;
                }
                else
                {
                    userList.ResetText();
                    userList.SelectedIndex = -1;
                    btnNewMsg.Enabled = false;
                    btnViewMsgs.Enabled = false;
                }
            }
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
