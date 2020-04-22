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


namespace DigitalCertifiedMail
{
    public partial class Messenger : Form
    {
        public Messenger()
        {
            InitializeComponent();

        }
        static byte[] bytes = ASCIIEncoding.ASCII.GetBytes("ZeroCool");
        string var;

        public void textMessage_TextChanged(object sender, EventArgs e){}
        
        public void btnEncrypt_Click(object sender, EventArgs e)
        {
            var = textMessage.Text;
            string cryptedString = Encrypt(var);
            textDecrypted.Text = cryptedString;
            textMessage.Enabled = false;
        }
        
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string cryptedString = Encrypt(var);
            textDecrypted.Text = String.Empty;
            textMessage.Enabled = true;
            textMessage.Text = var;
        }

        public static string Encrypt(string var)
        {
            if (String.IsNullOrEmpty(var))
            {
                throw new ArgumentNullException("The string which needs to be encrypted can not be null.");
            }

            DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoProvider.CreateEncryptor(bytes, bytes), CryptoStreamMode.Write);

            StreamWriter writer = new StreamWriter(cryptoStream);
            writer.Write(var);
            writer.Flush();
            cryptoStream.FlushFinalBlock();
            writer.Flush();

            return Convert.ToBase64String(memoryStream.GetBuffer(), 0, (int)memoryStream.Length);

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

        private void Form1_Load(object sender, EventArgs e){}

        private void textDecrypted_TextChanged(object sender, EventArgs e)
        {
            if (textDecrypted.Text != String.Empty)
                btnSend.Enabled = true;
            else
                btnSend.Enabled = false;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            bool flag = true;
            var errorMsg = "Please include the following:\n";

            if (textFrom.Text == String.Empty)
            {
                flag = false;
                errorMsg += "From\n";
            }
            if (textTo.Text == String.Empty)
            {
                flag = false;
                errorMsg += "To\n";
            }
            if (textDecrypted.Text == String.Empty)
            {
                flag = false;
                errorMsg += "Decrypted Message\n";
            }

            if (flag)
                sendMessage();
            else
                MessageBox.Show(errorMsg, "Missing Fields");
        }

        private void sendMessage()
        {

        }
    }
   
}