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
using System.Net.Mail;
using System.Net;

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

        public void textMessage_LostFocus(object sender, EventArgs e) 
        {

            var bogusMsg = "";
            Random random = new Random();

            char letter;
            foreach (char c in textMessage.Text)
            {
                if (c == ' ')
                    bogusMsg += " ";
                else
                {
                    double flt = random.NextDouble();
                    int shift = Convert.ToInt32(Math.Floor(25 * flt));
                    letter = Convert.ToChar(shift + 65);
                    bogusMsg += letter;
                }
            }
            textBogus.Text = bogusMsg;

        }

        public void btnEncrypt_Click(object sender, EventArgs e)
        {
            var = textMessage.Text;
            string cryptedString = Encrypt(var);
            textEncrypted.Text = cryptedString;
            textMessage.Enabled = false;
        }
        
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string cryptedString = Encrypt(var);
            textEncrypted.Text = String.Empty;
            textBogus.Text = String.Empty;
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

        private void textEncrypted_TextChanged(object sender, EventArgs e)
        {
            if (textEncrypted.Text != String.Empty)
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
            if (textEncrypted.Text == String.Empty)
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
            MailMessage message = new MailMessage(textFrom.Text, textTo.Text);
            message.Subject = "Please Sign";
            message.Body = textEncrypted.Text;

            SmtpClient client = new SmtpClient("smtp.mailtrap.io", 2525);
            client.EnableSsl = true;
            
            // Credentials are provided by mailtrap.io
            // Emails using these credentials will be "trapped" in a private inbox.
            client.Credentials = new NetworkCredential("1187a0fe3e0b30", "6c9f57cd6a7a23");

            try
            {
                client.Send(message);
                MessageBox.Show("Email sent!", "Send Message");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!", "Send Message");
                Console.WriteLine("Exception caught in CreateTestMessage2(): {0}",
                    ex.ToString());
            }
        }
    }
   
}