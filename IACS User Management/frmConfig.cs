using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace IACS_User_Management
{
    public partial class frmConfig : Form
    {
        private String appFilesPath;
        private String iniFilePath;
        private Configuration cfg;
        public frmConfig()
        {
            InitializeComponent();
        }

        private void frmConfig_Load(object sender, EventArgs e)
        {
            appFilesPath    = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\IACS User Management";
            iniFilePath     = appFilesPath + @"\config.ini";
        }

        public void LoadConfig(ref Configuration _cfg)
        {
            cfg = _cfg;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            String errMsg = "";

            if (tbArchiveDbName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Please enter an archive database name.", "IACS User Management", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }

            if (tbLiveDbName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Please enter a live database name.", "IACS User Management", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }

            if (tbServerName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Please enter a server database name.", "IACS User Management", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }

            if (tbSqlUser.Text.Trim().Equals(""))
            {
                MessageBox.Show("Please enter a SQL user name.", "IACS User Management", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }

            if (tbSqlUserPassword.Text.Trim().Equals(""))
            {
                MessageBox.Show("Please enter the SQL user's password.", "IACS User Management", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }

            InIFileControler ini = new InIFileControler(iniFilePath);

            if (!File.Exists(iniFilePath))
            {
                if (!ini.ClearINI(ref errMsg))
                {
                    MessageBox.Show("Could not write to the ini file at: " + iniFilePath + ". This is probably a permissions problem." +
                        " The error returned is:\n\n" + errMsg +
                        "\n\nThis program can not continue until you resolve this issue.", 
                        "IACS User Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            ini.WriteEntry("archivedatabasename", tbArchiveDbName.Text.Trim());
            ini.WriteEntry("livedatabasename", tbLiveDbName.Text.Trim());
            ini.WriteEntry("databaseservername", tbServerName.Text.Trim());
            ini.WriteEntry("databaseusername", tbSqlUser.Text.Trim());
            ini.WriteEntry("databaseuserpassword", tbSqlUserPassword.Text.Trim());

            DateTime timeout = new DateTime();
            timeout = DateTime.Now.AddSeconds(1);

            this.Enabled = false;
            while (DateTime.Now < timeout)
            {
                Application.DoEvents();
            }

            this.Close();
        }

        private void frmConfig_Shown(object sender, EventArgs e)
        {
            if (!cfg.Equals(null))
            {
                tbArchiveDbName.Text    = cfg.archiveDatabaseName;
                tbLiveDbName.Text       = cfg.liveDatabaseName;
                tbServerName.Text       = cfg.databaseServerName;
                tbSqlUser.Text          = cfg.databaseUserName;
                tbSqlUserPassword.Text  = cfg.databaseUserPassword;
            }
        }
    }
}
