namespace DigitalCertifiedMail
{
    partial class Inbox
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
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.textMsg2 = new System.Windows.Forms.TextBox();
            this.textDecMsg2 = new System.Windows.Forms.TextBox();
            this.textDecMsg1 = new System.Windows.Forms.TextBox();
            this.labelMessage1 = new System.Windows.Forms.Label();
            this.textMsg1 = new System.Windows.Forms.TextBox();
            this.labelMessage2 = new System.Windows.Forms.Label();
            this.labelDecMsg2 = new System.Windows.Forms.Label();
            this.labelDecMsg1 = new System.Windows.Forms.Label();
            this.listMessages = new System.Windows.Forms.ListBox();
            this.labelInbox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(32, 436);
            this.btnDecrypt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(263, 60);
            this.btnDecrypt.TabIndex = 0;
            this.btnDecrypt.Text = "Decrypt Message";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.button1_Click);
            // 
            // textMsg2
            // 
            this.textMsg2.Location = new System.Drawing.Point(321, 300);
            this.textMsg2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textMsg2.Multiline = true;
            this.textMsg2.Name = "textMsg2";
            this.textMsg2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textMsg2.Size = new System.Drawing.Size(263, 196);
            this.textMsg2.TabIndex = 2;
            // 
            // textDecMsg2
            // 
            this.textDecMsg2.Location = new System.Drawing.Point(609, 300);
            this.textDecMsg2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textDecMsg2.Multiline = true;
            this.textDecMsg2.Name = "textDecMsg2";
            this.textDecMsg2.ReadOnly = true;
            this.textDecMsg2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textDecMsg2.Size = new System.Drawing.Size(263, 196);
            this.textDecMsg2.TabIndex = 3;
            // 
            // textDecMsg1
            // 
            this.textDecMsg1.Location = new System.Drawing.Point(609, 52);
            this.textDecMsg1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textDecMsg1.Multiline = true;
            this.textDecMsg1.Name = "textDecMsg1";
            this.textDecMsg1.ReadOnly = true;
            this.textDecMsg1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textDecMsg1.Size = new System.Drawing.Size(263, 196);
            this.textDecMsg1.TabIndex = 4;
            // 
            // labelMessage1
            // 
            this.labelMessage1.AutoSize = true;
            this.labelMessage1.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage1.Location = new System.Drawing.Point(317, 27);
            this.labelMessage1.Name = "labelMessage1";
            this.labelMessage1.Size = new System.Drawing.Size(98, 20);
            this.labelMessage1.TabIndex = 10;
            this.labelMessage1.Text = "Message One";
            // 
            // textMsg1
            // 
            this.textMsg1.Location = new System.Drawing.Point(321, 52);
            this.textMsg1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textMsg1.Multiline = true;
            this.textMsg1.Name = "textMsg1";
            this.textMsg1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textMsg1.Size = new System.Drawing.Size(263, 196);
            this.textMsg1.TabIndex = 1;
            // 
            // labelMessage2
            // 
            this.labelMessage2.AutoSize = true;
            this.labelMessage2.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage2.Location = new System.Drawing.Point(317, 275);
            this.labelMessage2.Name = "labelMessage2";
            this.labelMessage2.Size = new System.Drawing.Size(98, 20);
            this.labelMessage2.TabIndex = 11;
            this.labelMessage2.Text = "Message Two";
            // 
            // labelDecMsg2
            // 
            this.labelDecMsg2.AutoSize = true;
            this.labelDecMsg2.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDecMsg2.Location = new System.Drawing.Point(605, 275);
            this.labelDecMsg2.Name = "labelDecMsg2";
            this.labelDecMsg2.Size = new System.Drawing.Size(171, 20);
            this.labelDecMsg2.TabIndex = 13;
            this.labelDecMsg2.Text = "Decrypted Message Two";
            // 
            // labelDecMsg1
            // 
            this.labelDecMsg1.AutoSize = true;
            this.labelDecMsg1.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDecMsg1.Location = new System.Drawing.Point(605, 27);
            this.labelDecMsg1.Name = "labelDecMsg1";
            this.labelDecMsg1.Size = new System.Drawing.Size(171, 20);
            this.labelDecMsg1.TabIndex = 12;
            this.labelDecMsg1.Text = "Decrypted Message One";
            // 
            // listMessages
            // 
            this.listMessages.FormattingEnabled = true;
            this.listMessages.ItemHeight = 20;
            this.listMessages.Location = new System.Drawing.Point(32, 52);
            this.listMessages.Name = "listMessages";
            this.listMessages.ScrollAlwaysVisible = true;
            this.listMessages.Size = new System.Drawing.Size(263, 364);
            this.listMessages.TabIndex = 14;
            // 
            // labelInbox
            // 
            this.labelInbox.AutoSize = true;
            this.labelInbox.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInbox.Location = new System.Drawing.Point(27, 22);
            this.labelInbox.Name = "labelInbox";
            this.labelInbox.Size = new System.Drawing.Size(61, 25);
            this.labelInbox.TabIndex = 15;
            this.labelInbox.Text = "Inbox";
            // 
            // Inbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 534);
            this.Controls.Add(this.labelInbox);
            this.Controls.Add(this.listMessages);
            this.Controls.Add(this.labelDecMsg2);
            this.Controls.Add(this.labelDecMsg1);
            this.Controls.Add(this.labelMessage2);
            this.Controls.Add(this.labelMessage1);
            this.Controls.Add(this.textDecMsg1);
            this.Controls.Add(this.textDecMsg2);
            this.Controls.Add(this.textMsg2);
            this.Controls.Add(this.textMsg1);
            this.Controls.Add(this.btnDecrypt);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Inbox";
            this.Text = "Inbox";
            this.Load += new System.EventHandler(this.Inbox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.TextBox textMsg2;
        private System.Windows.Forms.TextBox textDecMsg2;
        private System.Windows.Forms.TextBox textDecMsg1;
        private System.Windows.Forms.Label labelMessage1;
        private System.Windows.Forms.TextBox textMsg1;
        private System.Windows.Forms.Label labelMessage2;
        private System.Windows.Forms.Label labelDecMsg2;
        private System.Windows.Forms.Label labelDecMsg1;
        private System.Windows.Forms.ListBox listMessages;
        private System.Windows.Forms.Label labelInbox;
    }
}