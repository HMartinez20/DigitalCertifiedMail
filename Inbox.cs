using System;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
namespace DigitalCertifiedMail
{
    public partial class Inbox : Form
    {
        public Inbox(string user)
        {
            InitializeComponent();
            currentUser = user;
        }

        string currentUser = "";
        
        string var1, var2;
        byte[] var3, var4, var5;
        string dir = "";
        private void Inbox_Load(object sender, EventArgs e)
        {
            dir = Directory.GetParent(Directory.GetParent(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory)).FullName).FullName;
            if (currentUser == "Alice")
                dir += @"\Rec\Alice\";
            else if (currentUser == "Bob")
                dir += @"\Rec\Bob\";
            else
                dir += @"\Rec\";

            foreach (string file in Directory.GetFiles(dir))
            {
                listMessages.Items.Add(file.Remove(file.Length - 4).Substring(file.LastIndexOf("\\") + 1));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var path = dir + listMessages.GetItemText(listMessages.SelectedItem) + ".txt";

            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                int line = 0;
                while ((s = sr.ReadLine()) != null)
                {
                    if(line == 0)
                        var1 = s.ToString();
                    else if (line == 1)
                        var2 = s.ToString();
                    else if (line == 2)
                        var3 = Convert.FromBase64String(s);
                    else if (line == 3)
                        var4 = Convert.FromBase64String(s);
                    else if (line == 4)
                        var5 = Convert.FromBase64String(s);
                    line++;
                }
                sr.Close();
            }

            textMsg1.Text = var1;
            textMsg2.Text = var2;
            textDecMsg1.Text = Decrypt(var1, var3, var5);
            textDecMsg2.Text = Decrypt(var2, var4, var5);

        }
        
        public static string Decrypt(string cryptedString, byte[] key, byte[] iv)
        {
            string desKey;
            //read DES key back
            string dir = Directory.GetParent(Directory.GetParent(Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory)).FullName).FullName + "\\Rec";
            string path = dir + @"\Keys.txt";
            System.IO.StreamReader sw = new System.IO.StreamReader(path);
            desKey = sw.ReadLine();
            sw.Close();

            Console.WriteLine("DES Key: " + desKey);

            if (String.IsNullOrEmpty(cryptedString))
            {
                throw new ArgumentNullException("The string which needs to be decrypted can not be null.");
            }

            DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
            MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(cryptedString));
            CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoProvider.CreateDecryptor(key, iv), CryptoStreamMode.Read);
            StreamReader reader = new StreamReader(cryptoStream);
            return reader.ReadToEnd();
        }
    }
}
