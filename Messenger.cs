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
    public partial class Messenger : Form
    {
        public Messenger()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GenKey_SaveInContainer("MyKeyContainer");
            GetKeyFromContainer("MyKeyContainer");

        }
        static byte[] bytes = ASCIIEncoding.ASCII.GetBytes("ZeroCool");
        string var, cryptedString;

        public void textMessage_TextChanged(object sender, EventArgs e) { }

        public void btnEncrypt_Click(object sender, EventArgs e)
        {
            var = textMessage.Text;
            cryptedString = Encrypt(var);
            textEncrypted.Text = cryptedString;
            textMessage.Enabled = false;
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string decryptedString = Decrypt(cryptedString);
            textEncrypted.Text = String.Empty;
            textMessage.Enabled = true;
            textEncrypted.Text = decryptedString;
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

       
        public static void GenKey_SaveInContainer(string ContainerName)
        {
            // Create the CspParameters object and set the key container
            // name used to store the RSA key pair.  
            CspParameters cp = new CspParameters();
            cp.KeyContainerName = ContainerName;

            // Create a new instance of RSACryptoServiceProvider that accesses  
            // the key container MyKeyContainerName.  
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(cp);

            // Display the key information to the console.  
            Console.WriteLine("Key added to container: \n  {0}", rsa.ToXmlString(true));
        }
        public static void GetKeyFromContainer(string ContainerName)
        {
            // Create the CspParameters object and set the key container
            // name used to store the RSA key pair.  
            CspParameters cp = new CspParameters();
            cp.KeyContainerName = ContainerName;

            // Create a new instance of RSACryptoServiceProvider that accesses  
            // the key container MyKeyContainerName.  
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(cp);

            // Display the key information to the console.  
            Console.WriteLine("Key retrieved from container : \n {0}", rsa.ToXmlString(true));
          
        }

        public static void DeleteKeyFromContainer(string ContainerName)
        {
            // Create the CspParameters object and set the key container
            // name used to store the RSA key pair.  
            CspParameters cp = new CspParameters();
            cp.KeyContainerName = ContainerName;

            // Create a new instance of RSACryptoServiceProvider that accesses  
            // the key container.  
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(cp);

            // Delete the key entry in the container.  
            rsa.PersistKeyInCsp = false;

            // Call Clear to release resources and delete the key from the container.  
            rsa.Clear();

            Console.WriteLine("Key deleted.");
        }
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

        }
    }
   
}