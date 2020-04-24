using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace DigitalCertifiedMail
{
    public partial class Messenger : Form
    {
        public Messenger()
        {
            InitializeComponent();
        }

        DES des = DES.Create();
        byte[] decryptedDESKey1 = { }; // These will be used 
        byte[] decryptedDESKey2 = { }; // when sending the message!
        string var = "";

        private void Form1_Load(object sender, EventArgs e)
        {
            // Generate Alice's keys (two pairs of private and public - 4 keys total)
            RSACryptoServiceProvider AliceKey = new RSACryptoServiceProvider();
            RSAParameters AlicePublic = AliceKey.ExportParameters(false);
            RSAParameters AlicePrivate = AliceKey.ExportParameters(true);

            RSACryptoServiceProvider AliceKey2 = new RSACryptoServiceProvider();
            RSAParameters AlicePublic2 = AliceKey2.ExportParameters(false);
            RSAParameters AlicePrivate2 = AliceKey2.ExportParameters(true);

            Console.WriteLine("Alice Key  : " + AliceKey.ToXmlString(true));
            Console.WriteLine("Alice Key 2: " + AliceKey2.ToXmlString(true));


            // Generate Bob's symmetric key using DES
            // See public variable "des"


            // Use random generator to choose Alice's public key A or B
            // With chosen key (A or B) encrypt Bob's DES key
            byte[] encryptedDESKey = { };
            byte[] encryptedDESDummyKey = { };
            var keyChosen = new Random().Next(0, 1);
            switch (keyChosen)
            {
                case 0:
                    AliceKey.ImportParameters(AlicePublic);
                    encryptedDESKey = AliceKey.Encrypt(des.Key, false);
                    AliceKey2.ImportParameters(AlicePublic2);
                    encryptedDESDummyKey = AliceKey2.Encrypt(DES.Create().Key, false);
                    break;
                case 1:
                    AliceKey2.ImportParameters(AlicePublic2);
                    encryptedDESKey = AliceKey2.Encrypt(des.Key, false);
                    AliceKey.ImportParameters(AlicePublic);
                    encryptedDESDummyKey = AliceKey.Encrypt(DES.Create().Key, false);
                    break;
            }
            Console.WriteLine("Encrypted DES Key: " + Convert.ToBase64String(encryptedDESKey));


            // Decrypt Bob's encrypted DES key with Alice's public keys A and B - two separate messages
            // *** Encrypted data MUST be decrypted with the matching private key - otherwise, error is thrown.
            //     Instead of decrypting one encrypted DES key with both private keys, there will be the original
            //     encrypted DES key and a dummy encrypted DES key.
            switch (keyChosen)
            {
                case 0:
                    AliceKey.ImportParameters(AlicePrivate);
                    decryptedDESKey1 = AliceKey.Decrypt(encryptedDESKey, false);
                    AliceKey2.ImportParameters(AlicePrivate2);
                    decryptedDESKey2 = AliceKey2.Decrypt(encryptedDESDummyKey, false);
                    break;
                case 1:
                    AliceKey2.ImportParameters(AlicePrivate2);
                    decryptedDESKey1 = AliceKey2.Decrypt(encryptedDESKey, false);
                    AliceKey.ImportParameters(AlicePrivate);
                    decryptedDESKey2 = AliceKey.Decrypt(encryptedDESDummyKey, false);
                    break;
            }
            Console.WriteLine("Decrypted Key 1: " + Convert.ToBase64String(decryptedDESKey1));
            Console.WriteLine("Decrypted Key 2: " + Convert.ToBase64String(decryptedDESKey2));
            Console.WriteLine("Writing to File:");
            


            // With the decrypted keys from previous step, encrypt both the real and bogus messages with DES keys
            Console.WriteLine("True DES Key: " + Convert.ToBase64String(des.Key));
            //Save DES key to Keys.txt
            string dir = Directory.GetParent(Directory.GetParent(Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory)).FullName).FullName + "\\Rec";
            string path = dir + @"\Keys.txt";
            System.IO.StreamWriter sw = new System.IO.StreamWriter(path);
            //StreamWriter sw = new StreamWriter("Test.txt");
            sw.WriteLine(Convert.ToBase64String(des.Key));
            sw.Close();

            // Email bob with encrypted messages


            // Clear Alice's keys
            AliceKey.Clear();
            AliceKey2.Clear();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            var = textMessage.Text;
            textEncrypted.Text = Encrypt(var, des.Key, des.IV);
            textMessage.Enabled = false;

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
            textEncBogus.Text = Encrypt(bogusMsg, des.Key, des.IV);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string cryptedString = Decrypt(textEncrypted.Text, des.Key, des.IV);
            textEncrypted.Text = String.Empty;
            textBogus.Text = String.Empty;
            textMessage.Enabled = true;
            textMessage.Text = cryptedString;
        }

        public static string Encrypt(string var, byte[] key, byte[] IV)
        {
            if (String.IsNullOrEmpty(var))
            {
                throw new ArgumentNullException("The string which needs to be encrypted can not be null.");
            }

            DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
            MemoryStream memoryStream = new MemoryStream(); // Where encryption is stored
            CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoProvider.CreateEncryptor(key, IV), CryptoStreamMode.Write);

            StreamWriter writer = new StreamWriter(cryptoStream);
            writer.Write(var);
            writer.Flush();
            cryptoStream.FlushFinalBlock();
            writer.Flush();

            return Convert.ToBase64String(memoryStream.GetBuffer(), 0, (int)memoryStream.Length);
        }

        public static string Decrypt(string cryptedString, byte[] key, byte[] IV)
        {
            if (String.IsNullOrEmpty(cryptedString))
            {
                throw new ArgumentNullException("The string which needs to be decrypted can not be null.");
            }

            DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
            MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(cryptedString));
            CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoProvider.CreateDecryptor(key, IV), CryptoStreamMode.Read);
            StreamReader reader = new StreamReader(cryptoStream);

            return reader.ReadToEnd();
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
            {
                sendMessages();
                this.Close();
            }
            else
                MessageBox.Show(errorMsg, "Missing Fields");
        }

        private void sendMessages()
        {
            // Create messages
            var msg1 = Encrypt(textEncrypted.Text, decryptedDESKey1, des.IV);
            var msg2 = Encrypt(textEncBogus.Text, decryptedDESKey2, des.IV);

            // Create email
            MailMessage message = new MailMessage(textFrom.Text, textTo.Text);
            message.Subject = "New Message!";
            message.Body = string.Join("\n\n", msg1, msg2);

            SmtpClient client = new SmtpClient("smtp.mailtrap.io", 2525);
            client.EnableSsl = true;

            // Credentials are provided by mailtrap.io
            // Emails using these credentials will be "trapped" in a private inbox.
            client.Credentials = new NetworkCredential("1187a0fe3e0b30", "6c9f57cd6a7a23");

            try
            {
                storeMessage(des, string.Join("\n", msg1, msg2));
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

        private void storeMessage(DES des, string message)
        {
            var path = @"";
            /*
            using (FileStream fs = File.Create(path))
            {
                byte[] info = new UTF8Encoding(true).GetBytes("This is some text in the file.");
                // Add some information to the file.
                fs.Write(info, 0, info.Length);
            }

            // Open the stream and read it back.
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            */
        }
    }

}
