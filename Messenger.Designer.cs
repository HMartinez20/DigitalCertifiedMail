namespace DigitalCertifiedMail
{
    partial class Messenger
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.textTo = new System.Windows.Forms.ComboBox();
            this.textFrom = new System.Windows.Forms.ComboBox();
            this.textMessage = new System.Windows.Forms.TextBox();
            this.textEncrypted = new System.Windows.Forms.TextBox();
            this.labelHelp = new System.Windows.Forms.Label();
            this.labelEncrypted = new System.Windows.Forms.Label();
            this.textBogus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textEncBogus = new System.Windows.Forms.TextBox();
            this.labelEncryptedBogus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.Location = new System.Drawing.Point(296, 163);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(121, 36);
            this.btnEncrypt.TabIndex = 3;
            this.btnEncrypt.Text = "Encrypt -->";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypt.Location = new System.Drawing.Point(296, 223);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(121, 36);
            this.btnDecrypt.TabIndex = 4;
            this.btnDecrypt.Text = "<-- Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnSend
            // 
            this.btnSend.Enabled = false;
            this.btnSend.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(565, 608);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(121, 36);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.Location = new System.Drawing.Point(23, 93);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(67, 20);
            this.labelMessage.TabIndex = 8;
            this.labelMessage.Text = "Message";
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFrom.Location = new System.Drawing.Point(23, 21);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(42, 20);
            this.labelFrom.TabIndex = 10;
            this.labelFrom.Text = "From";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTo.Location = new System.Drawing.Point(419, 21);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(24, 20);
            this.labelTo.TabIndex = 11;
            this.labelTo.Text = "To";
            // 
            // textTo
            // 
            this.textTo.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTo.FormattingEnabled = true;
            this.textTo.Items.AddRange(new object[] {
            "alice.cryptography@gmail.com",
            "bob.cryptography@gmail.com"});
            this.textTo.Location = new System.Drawing.Point(423, 45);
            this.textTo.Name = "textTo";
            this.textTo.Size = new System.Drawing.Size(263, 28);
            this.textTo.TabIndex = 13;
            // 
            // textFrom
            // 
            this.textFrom.BackColor = System.Drawing.SystemColors.Window;
            this.textFrom.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.textFrom.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFrom.FormattingEnabled = true;
            this.textFrom.Items.AddRange(new object[] {
            "alice.cryptography@gmail.com",
            "bob.cryptography@gmail.com"});
            this.textFrom.Location = new System.Drawing.Point(27, 45);
            this.textFrom.Name = "textFrom";
            this.textFrom.Size = new System.Drawing.Size(263, 28);
            this.textFrom.TabIndex = 12;
            // 
            // textMessage
            // 
            this.textMessage.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMessage.Location = new System.Drawing.Point(27, 117);
            this.textMessage.Multiline = true;
            this.textMessage.Name = "textMessage";
            this.textMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textMessage.Size = new System.Drawing.Size(263, 196);
            this.textMessage.TabIndex = 0;
            // 
            // textEncrypted
            // 
            this.textEncrypted.Enabled = false;
            this.textEncrypted.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEncrypted.Location = new System.Drawing.Point(423, 117);
            this.textEncrypted.Multiline = true;
            this.textEncrypted.Name = "textEncrypted";
            this.textEncrypted.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textEncrypted.Size = new System.Drawing.Size(263, 196);
            this.textEncrypted.TabIndex = 14;
            this.textEncrypted.TextChanged += new System.EventHandler(this.textEncrypted_TextChanged);
            // 
            // labelHelp
            // 
            this.labelHelp.AutoSize = true;
            this.labelHelp.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHelp.Location = new System.Drawing.Point(23, 593);
            this.labelHelp.Name = "labelHelp";
            this.labelHelp.Size = new System.Drawing.Size(510, 60);
            this.labelHelp.TabIndex = 15;
            this.labelHelp.Text = "After a message is encrypted, press \"Decrypt\" to edit the message. An email\r\naddr" +
    "ess in the \"From\" and \"To\" boxes, as well as text in the \"Decrypted \r\nMessage\" t" +
    "extbox, is required to send a message.";
            // 
            // labelEncrypted
            // 
            this.labelEncrypted.AutoSize = true;
            this.labelEncrypted.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEncrypted.Location = new System.Drawing.Point(419, 93);
            this.labelEncrypted.Name = "labelEncrypted";
            this.labelEncrypted.Size = new System.Drawing.Size(137, 20);
            this.labelEncrypted.TabIndex = 16;
            this.labelEncrypted.Text = "Encrypted Message";
            // 
            // textBogus
            // 
            this.textBogus.Enabled = false;
            this.textBogus.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBogus.Location = new System.Drawing.Point(27, 354);
            this.textBogus.Multiline = true;
            this.textBogus.Name = "textBogus";
            this.textBogus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBogus.Size = new System.Drawing.Size(263, 196);
            this.textBogus.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Bogus Message";
            // 
            // textEncBogus
            // 
            this.textEncBogus.Enabled = false;
            this.textEncBogus.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEncBogus.Location = new System.Drawing.Point(423, 354);
            this.textEncBogus.Multiline = true;
            this.textEncBogus.Name = "textEncBogus";
            this.textEncBogus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textEncBogus.Size = new System.Drawing.Size(263, 196);
            this.textEncBogus.TabIndex = 19;
            // 
            // labelEncryptedBogus
            // 
            this.labelEncryptedBogus.AutoSize = true;
            this.labelEncryptedBogus.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEncryptedBogus.Location = new System.Drawing.Point(419, 330);
            this.labelEncryptedBogus.Name = "labelEncryptedBogus";
            this.labelEncryptedBogus.Size = new System.Drawing.Size(182, 20);
            this.labelEncryptedBogus.TabIndex = 20;
            this.labelEncryptedBogus.Text = "Encrypted Bogus Message";
            // 
            // Messenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 677);
            this.Controls.Add(this.labelEncryptedBogus);
            this.Controls.Add(this.textEncBogus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBogus);
            this.Controls.Add(this.labelEncrypted);
            this.Controls.Add(this.labelHelp);
            this.Controls.Add(this.textEncrypted);
            this.Controls.Add(this.textTo);
            this.Controls.Add(this.textFrom);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.textMessage);
            this.Name = "Messenger";
            this.Text = "Messenger";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.ComboBox textFrom;
        private System.Windows.Forms.ComboBox textTo;
        private System.Windows.Forms.TextBox textEncrypted;
        private System.Windows.Forms.Label labelHelp;
        private System.Windows.Forms.Label labelEncrypted;
        private System.Windows.Forms.TextBox textBogus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textEncBogus;
        private System.Windows.Forms.Label labelEncryptedBogus;
    }
}

