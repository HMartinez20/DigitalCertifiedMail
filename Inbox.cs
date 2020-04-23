using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Management.Instrumentation;
namespace DigitalCertifiedMail
{
    public partial class Inbox : Form
    {
        public Inbox()
        {
            InitializeComponent();
        }
        static byte[] bytes = ASCIIEncoding.ASCII.GetBytes("ZeroCool");
        string var1, var2;

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var1 = textBox1.Text;
            var2 = textBox2.Text;
            // string cryptedString = var1;
            textBox3.Text += Decrypt(var1);
            textBox4.Text += Decrypt(var2);



            //string cryptedString

            // string cryptedString = Encrypt(var);
            // textEncrypted.Text = String.Empty;
            // textMessage.Enabled = true;
            // textMessage.Text = var;
        }
        public static string Decrypt(string cryptedString)
        {
            if (String.IsNullOrEmpty(cryptedString))
            {
                throw new ArgumentNullException("The string which needs to be decrypted can not be null.");
            }

            DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
            MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(cryptedString));
            CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoProvider.CreateDecryptor(bytes, bytes), CryptoStreamMode.Read);
            StreamReader reader = new StreamReader(cryptoStream);

            return reader.ReadToEnd();
        }
     

     
    }
}
