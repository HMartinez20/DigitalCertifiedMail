using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void listUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
