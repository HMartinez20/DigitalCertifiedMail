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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static byte[] bytes = ASCIIEncoding.ASCII.GetBytes("ZeroCool");
        string var;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
    
        }
        
        public void button1_Click(object sender, EventArgs e)
        {
           
            var = textBox1.Text;
            string cryptedString = Encrypt(var);
            textBox1.Text = String.Empty;
            textBox1.Text += cryptedString;

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            string cryptedString = Encrypt(var);
            textBox1.Text = String.Empty;
            textBox1.Text += var;
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

            private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
   
}

