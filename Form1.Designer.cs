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
            this.textDecrypted = new System.Windows.Forms.TextBox();
            this.labelHelp = new System.Windows.Forms.Label();
            this.labelDecrypted = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.Location = new System.Drawing.Point(345, 240);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(121, 36);
            this.btnEncrypt.TabIndex = 3;
            this.btnEncrypt.Text = "Encrypt -->\r\n";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypt.Location = new System.Drawing.Point(345, 319);
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
            this.btnSend.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(656, 482);
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
            this.labelMessage.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.Location = new System.Drawing.Point(29, 117);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(71, 21);
            this.labelMessage.TabIndex = 8;
            this.labelMessage.Text = "Message";
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFrom.Location = new System.Drawing.Point(29, 31);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(46, 21);
            this.labelFrom.TabIndex = 10;
            this.labelFrom.Text = "From";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTo.Location = new System.Drawing.Point(470, 31);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(25, 21);
            this.labelTo.TabIndex = 11;
            this.labelTo.Text = "To";
            // 
            // textTo
            // 
            this.textTo.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTo.FormattingEnabled = true;
            this.textTo.Items.AddRange(new object[] {
            "receiver@gmail.com"});
            this.textTo.Location = new System.Drawing.Point(474, 65);
            this.textTo.Name = "textTo";
            this.textTo.Size = new System.Drawing.Size(303, 29);
            this.textTo.TabIndex = 13;
            // 
            // textFrom
            // 
            this.textFrom.BackColor = System.Drawing.SystemColors.Window;
            this.textFrom.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.textFrom.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFrom.FormattingEnabled = true;
            this.textFrom.Items.AddRange(new object[] {
            "sender@gmail.com"});
            this.textFrom.Location = new System.Drawing.Point(33, 65);
            this.textFrom.Name = "textFrom";
            this.textFrom.Size = new System.Drawing.Size(303, 29);
            this.textFrom.TabIndex = 12;
            // 
            // textMessage
            // 
            this.textMessage.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMessage.Location = new System.Drawing.Point(33, 156);
            this.textMessage.Multiline = true;
            this.textMessage.Name = "textMessage";
            this.textMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textMessage.Size = new System.Drawing.Size(303, 280);
            this.textMessage.TabIndex = 0;
            this.textMessage.TextChanged += new System.EventHandler(this.textMessage_TextChanged);
            // 
            // textDecrypted
            // 
            this.textDecrypted.Enabled = false;
            this.textDecrypted.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDecrypted.Location = new System.Drawing.Point(474, 156);
            this.textDecrypted.Multiline = true;
            this.textDecrypted.Name = "textDecrypted";
            this.textDecrypted.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textDecrypted.Size = new System.Drawing.Size(303, 280);
            this.textDecrypted.TabIndex = 14;
            this.textDecrypted.TextChanged += new System.EventHandler(this.textDecrypted_TextChanged);
            // 
            // labelHelp
            // 
            this.labelHelp.AutoSize = true;
            this.labelHelp.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHelp.Location = new System.Drawing.Point(29, 466);
            this.labelHelp.Name = "labelHelp";
            this.labelHelp.Size = new System.Drawing.Size(555, 63);
            this.labelHelp.TabIndex = 15;
            this.labelHelp.Text = "After a message is encrypted, press \"Decrypt\" to edit the message.\r\nAn email addr" +
    "ess in the \"From\" and \"To\" boxes, as well as text in the \"Decrypted\r\nMessage\" te" +
    "xtbox, is required to send a message.";
            // 
            // labelDecrypted
            // 
            this.labelDecrypted.AutoSize = true;
            this.labelDecrypted.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDecrypted.Location = new System.Drawing.Point(470, 117);
            this.labelDecrypted.Name = "labelDecrypted";
            this.labelDecrypted.Size = new System.Drawing.Size(146, 21);
            this.labelDecrypted.TabIndex = 16;
            this.labelDecrypted.Text = "Decrypted Message";
            // 
            // Messenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 558);
            this.Controls.Add(this.labelDecrypted);
            this.Controls.Add(this.labelHelp);
            this.Controls.Add(this.textDecrypted);
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
        private System.Windows.Forms.TextBox textDecrypted;
        private System.Windows.Forms.Label labelHelp;
        private System.Windows.Forms.Label labelDecrypted;
    }
}

