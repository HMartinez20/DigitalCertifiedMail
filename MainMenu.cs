using System;
using System.IO;
using System.Windows.Forms;

namespace DigitalCertifiedMail
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private string user = "";

        private void MainMenu_Load(object sender, EventArgs e)
        {
            // Create directories to store messages
            Directory.CreateDirectory(Directory.GetParent(Directory.GetParent(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory)).FullName).FullName + @"\Rec\Alice");
            Directory.CreateDirectory(Directory.GetParent(Directory.GetParent(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory)).FullName).FullName + @"\Rec\Bob");
        }

        private void userList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(userList.SelectedIndex >= 0)
            {
                Login loginForm = new Login(userList.GetItemText(userList.Items[userList.SelectedIndex]));
                loginForm.ShowDialog();
                if(loginForm.returnUser != String.Empty)
                {
                    btnNewMsg.Enabled = true;
                    btnViewMsgs.Enabled = true;
                    user = loginForm.returnUser;
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

        private void btnNewMsg_Click(object sender, EventArgs e)
        {
            Messenger form = new Messenger(user);
            form.Show();
        }

        private void btnViewMsgs_Click(object sender, EventArgs e)
        {
            Inbox form = new Inbox(user);
            form.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
