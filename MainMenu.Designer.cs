﻿namespace DigitalCertifiedMail
{
    partial class MainMenu
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
            this.title = new System.Windows.Forms.Label();
            this.btnNewMsg = new System.Windows.Forms.Button();
            this.btnViewMsgs = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.userList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(107, 53);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(95, 25);
            this.title.TabIndex = 0;
            this.title.Text = "Welcome!";
            // 
            // btnNewMsg
            // 
            this.btnNewMsg.Enabled = false;
            this.btnNewMsg.Location = new System.Drawing.Point(58, 173);
            this.btnNewMsg.Name = "btnNewMsg";
            this.btnNewMsg.Size = new System.Drawing.Size(194, 28);
            this.btnNewMsg.TabIndex = 1;
            this.btnNewMsg.Text = "Send a Message";
            this.btnNewMsg.UseVisualStyleBackColor = true;
            this.btnNewMsg.Click += new System.EventHandler(this.btnNewMsg_Click);
            // 
            // btnViewMsgs
            // 
            this.btnViewMsgs.Enabled = false;
            this.btnViewMsgs.Location = new System.Drawing.Point(58, 218);
            this.btnViewMsgs.Name = "btnViewMsgs";
            this.btnViewMsgs.Size = new System.Drawing.Size(194, 28);
            this.btnViewMsgs.TabIndex = 2;
            this.btnViewMsgs.Text = "View Messages";
            this.btnViewMsgs.UseVisualStyleBackColor = true;
            this.btnViewMsgs.Click += new System.EventHandler(this.btnViewMsgs_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(58, 299);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(194, 28);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // userList
            // 
            this.userList.FormattingEnabled = true;
            this.userList.Items.AddRange(new object[] {
            "Alice",
            "Bob"});
            this.userList.Location = new System.Drawing.Point(58, 90);
            this.userList.Name = "userList";
            this.userList.Size = new System.Drawing.Size(194, 28);
            this.userList.TabIndex = 4;
            this.userList.SelectedIndexChanged += new System.EventHandler(this.userList_SelectedIndexChanged);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 377);
            this.Controls.Add(this.userList);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnViewMsgs);
            this.Controls.Add(this.btnNewMsg);
            this.Controls.Add(this.title);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button btnNewMsg;
        private System.Windows.Forms.Button btnViewMsgs;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox userList;
    }
}