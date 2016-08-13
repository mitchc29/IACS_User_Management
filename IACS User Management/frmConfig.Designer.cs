namespace IACS_User_Management
{
    partial class frmConfig
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
            this.btOk = new System.Windows.Forms.Button();
            this.bgSqlDetails = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSqlUserPassword = new System.Windows.Forms.TextBox();
            this.tbSqlUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbArchiveDbName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLiveDbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbServerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bgSqlDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(355, 260);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 0;
            this.btOk.Text = "Ok";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // bgSqlDetails
            // 
            this.bgSqlDetails.Controls.Add(this.label6);
            this.bgSqlDetails.Controls.Add(this.label5);
            this.bgSqlDetails.Controls.Add(this.tbSqlUserPassword);
            this.bgSqlDetails.Controls.Add(this.tbSqlUser);
            this.bgSqlDetails.Controls.Add(this.label4);
            this.bgSqlDetails.Controls.Add(this.tbArchiveDbName);
            this.bgSqlDetails.Controls.Add(this.label3);
            this.bgSqlDetails.Controls.Add(this.tbLiveDbName);
            this.bgSqlDetails.Controls.Add(this.label2);
            this.bgSqlDetails.Controls.Add(this.tbServerName);
            this.bgSqlDetails.Location = new System.Drawing.Point(12, 46);
            this.bgSqlDetails.Name = "bgSqlDetails";
            this.bgSqlDetails.Size = new System.Drawing.Size(418, 208);
            this.bgSqlDetails.TabIndex = 1;
            this.bgSqlDetails.TabStop = false;
            this.bgSqlDetails.Text = "SQL Server Database Details";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "SQL User Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "SQL User:";
            // 
            // tbSqlUserPassword
            // 
            this.tbSqlUserPassword.Location = new System.Drawing.Point(114, 150);
            this.tbSqlUserPassword.Name = "tbSqlUserPassword";
            this.tbSqlUserPassword.PasswordChar = '*';
            this.tbSqlUserPassword.Size = new System.Drawing.Size(290, 20);
            this.tbSqlUserPassword.TabIndex = 7;
            // 
            // tbSqlUser
            // 
            this.tbSqlUser.Location = new System.Drawing.Point(114, 124);
            this.tbSqlUser.Name = "tbSqlUser";
            this.tbSqlUser.Size = new System.Drawing.Size(290, 20);
            this.tbSqlUser.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Archive DB Name";
            // 
            // tbArchiveDbName
            // 
            this.tbArchiveDbName.Location = new System.Drawing.Point(114, 98);
            this.tbArchiveDbName.Name = "tbArchiveDbName";
            this.tbArchiveDbName.Size = new System.Drawing.Size(290, 20);
            this.tbArchiveDbName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Live DB Name";
            // 
            // tbLiveDbName
            // 
            this.tbLiveDbName.Location = new System.Drawing.Point(114, 72);
            this.tbLiveDbName.Name = "tbLiveDbName";
            this.tbLiveDbName.Size = new System.Drawing.Size(290, 20);
            this.tbLiveDbName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Server Name:";
            // 
            // tbServerName
            // 
            this.tbServerName.Location = new System.Drawing.Point(114, 46);
            this.tbServerName.Name = "tbServerName";
            this.tbServerName.Size = new System.Drawing.Size(290, 20);
            this.tbServerName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "This application must access a SQL server to create thes changes. Please enter th" +
    "e SQL database details below.";
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(442, 295);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bgSqlDetails);
            this.Controls.Add(this.btOk);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuration";
            this.Load += new System.EventHandler(this.frmConfig_Load);
            this.Shown += new System.EventHandler(this.frmConfig_Shown);
            this.bgSqlDetails.ResumeLayout(false);
            this.bgSqlDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.GroupBox bgSqlDetails;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSqlUserPassword;
        private System.Windows.Forms.TextBox tbSqlUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbArchiveDbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLiveDbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbServerName;
        private System.Windows.Forms.Label label1;
    }
}