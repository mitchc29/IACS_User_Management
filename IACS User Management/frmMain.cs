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
    public partial class frmMain : Form
    {
        private String appFilesPath;
        private String iniFilePath;
        private SqlAbstractionLayer liveDbManager;
        private SqlAbstractionLayer archiveDbManager;
        private Configuration config = new Configuration();

        public frmMain()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfig cfg = new frmConfig();
            cfg.LoadConfig(ref config);
            cfg.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            appFilesPath    = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\IACS User Management";
            iniFilePath     = appFilesPath + @"\config.ini";
            String errMsg   = "";

            if (!Directory.Exists(appFilesPath))
            {
                try
                {
                    Directory.CreateDirectory(appFilesPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not create the application files folder at: " + appFilesPath + 
                        ". This is likely a user premissions problem. This program can not continue until this is resolved. (" + ex.Message + ")", 
                        "IACS User Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }

            if (!File.Exists(iniFilePath))
            {
                InIFileControler ini    = new InIFileControler(iniFilePath);

                if (!ini.ClearINI(ref errMsg))
                {
                    MessageBox.Show("Could not create the application's ini file at: " + iniFilePath +
                        ". This is likely a user premissions problem. This program can not continue until this is resolved. (" + errMsg + ")",
                        "IACS User Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }

            DialogResult result = DialogResult.OK;
            while (!GetConfiguration(ref config, ref errMsg))
            {
                result = MessageBox.Show("There was a problem starting this application. The error returnes is: \n\n" + errMsg + 
                    "\n\nPlease take a moment to enter the necessary configuration information.", "IACS User Management", 
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                if (result.Equals(DialogResult.Cancel)) { break; }

                if (config.Equals(null)) { config = new Configuration(); }

                frmConfig newFrmConfog = new frmConfig();
                newFrmConfog.LoadConfig(ref config);
                newFrmConfog.ShowDialog();
            }

            if (result.ToString().Equals("Cancel")) { this.WindowState = FormWindowState.Minimized; Application.Exit(); }

            liveDbManager       = new SqlAbstractionLayer(config.databaseServerName, config.liveDatabaseName,    config.databaseUserName, config.databaseUserPassword);
            archiveDbManager    = new SqlAbstractionLayer(config.databaseServerName, config.archiveDatabaseName, config.databaseUserName, config.databaseUserPassword);

            if (!RefreshPartitionsListBox())
            {
                frmConfig fconfig = new frmConfig();
                fconfig.Show();
            }
        }

        private bool RefreshPartitionsListBox()
        {
            List<String> partitions = new List<String>();
            ListViewItem lvi;
            String errMsg = "";

            if (!liveDbManager.GetPartitionList(ref partitions, ref errMsg))
            {
                return false;
            }
            else
            {
                bool alternateRow = false;
                lvOrganizations.Items.Clear();
                foreach (String partition in partitions)
                {
                    if (!partition.ToLower().Equals("none"))
                    {
                        lvi = new ListViewItem(partition, 0);
                        lvi.BackColor   = (alternateRow) ? Color.AliceBlue : Color.White;
                        alternateRow    = (alternateRow) ? false : true;

                        lvOrganizations.Items.Add(lvi);
                    }
                }
            }
            return true;
        }

        private bool GetConfiguration(ref Configuration _config, ref String errMsg)
        {

            InIFileControler ini                = new InIFileControler(iniFilePath);
            Dictionary<String, String> entries  = new Dictionary<String, String>();

            if (!File.Exists(iniFilePath))
            {
                ini.ClearINI();
                return false;
            }

            if (config == null)
            {
                config = new Configuration();
            }

            ini.ReadAllEntries(ref entries, ref errMsg);

            foreach (KeyValuePair<String, String> entry in entries)
            {
                if (entry.Key.ToLower().Equals("archivedatabasename"))    { _config.archiveDatabaseName     = entry.Value; }
                if (entry.Key.ToLower().Equals("livedatabasename"))       { _config.liveDatabaseName        = entry.Value; }
                if (entry.Key.ToLower().Equals("databaseservername"))     { _config.databaseServerName      = entry.Value; }
                if (entry.Key.ToLower().Equals("databaseusername"))       { _config.databaseUserName        = entry.Value; }
                if (entry.Key.ToLower().Equals("databaseuserpassword"))   { _config.databaseUserPassword    = entry.Value; }
            }

            if (entries.Count < 5)
            {
                errMsg = "Missing configuration information!";
                return false;
            }

            return true;
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            if (this.Width > 44)
            {
                tsStatusLabel.Width = (this.Width - 44);
            }
        }

        private void tsStatusLabel_Click(object sender, EventArgs e)
        {

        }

        private void btCreateIt_Click(object sender, EventArgs e)
        {
            //liveDbManager.CreateMap("TestMap", ref mapId, ref errMsg);
            //archiveDbManager.CreatPanel("test Descript", "test", "Client2", 0, ref errMsg);

            String errMsg = "";
            int mapId = -1;

            if (liveDbManager == null) { return; }
            if (archiveDbManager == null) { return; }

            if (tbNewOrgName.Text.Trim().Equals(""))
            {
                MessageBox.Show("You must fill in the name of the Organization.", "IACS User Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            String item = "";
            foreach (ListViewItem i in lvOrganizations.Items)
            {
                item = i.Text;
                if (item.ToLower().Trim().Equals(tbNewOrgName.Text.Trim().ToLower()))
                {
                    MessageBox.Show("An Organization with that name already exists in the database! Please try another.",
                        "IACS User Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // We're good to go. Beginning Org creation...
            String orgName = tbNewOrgName.Text.Trim();

            // Live database:
            tsStatusLabel.Text = "Updating live database...";
            if (!liveDbManager.CreatePartition(orgName, ref errMsg))
            {
                MessageBox.Show("Could create this partition in the live database! Please have a look at your configuration settings, and try again.", "IACS User Management",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!liveDbManager.CreateOperatorPrivilage(orgName, ref errMsg))
            {
                MessageBox.Show("Could create an operator privilage in the live database for this Organization! Please have a look at your configuration settings, and try again.", "IACS User Management",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!liveDbManager.CreateSphere(orgName, ref errMsg))
            {
                MessageBox.Show("Sphere creation failed for this Organization. Please contact your system administrator.", "IACS User Management",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cBoxAddPanel.Checked)
            {
                if (!liveDbManager.CreateMap(orgName + "_Map", ref mapId, ref errMsg))
                {
                    MessageBox.Show("Map creation failed for this Organization. Please contact your system administrator.", "IACS User Management",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!liveDbManager.CreatPanel(orgName + "_Panel1", orgName, orgName, mapId, ref errMsg))
                {
                    MessageBox.Show("Panel creation failed for this Organization. Please contact your system administrator. ( " + errMsg + " )", "IACS User Management",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Archive database:
            tsStatusLabel.Text = "Updating archive database...";
            if (!archiveDbManager.CreatePartition(orgName, ref errMsg))
            {
                MessageBox.Show("Could create this partition in the live database! Please have a look at your configuration settings, and try again.", "IACS User Management",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!archiveDbManager.CreateOperatorPrivilage(orgName, ref errMsg))
            {
                MessageBox.Show("Could create an operator privilage in the live database for this Organization! Please have a look at your configuration settings, and try again.", "IACS User Management",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!archiveDbManager.CreateSphere(orgName, ref errMsg))
            {
                MessageBox.Show("Sphere creation failed for this Organization. Please contact your system administrator.", "IACS User Management",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cBoxAddPanel.Checked)
            {
                if (!archiveDbManager.CreatPanel(orgName + "_Panel1", orgName, orgName, mapId, ref errMsg))
                {
                    MessageBox.Show("Panel creation failed for this Organization. Please contact your system administrator.", "IACS User Management",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            tsStatusLabel.Text = "Idle.";
            RefreshPartitionsListBox();
        }

        private void btCreateOperator_Click(object sender, EventArgs e)
        {
            List<String> colNames               = new List<String>();
            Dictionary<String, String> where    = new Dictionary<String, String>();
            String errMsg                       = "";

            if (liveDbManager    == null) { return; }
            if (archiveDbManager == null) { return; }

            if(tbScreenName.Text.Trim().Equals("") || tbFullName.Text.Trim().Equals("")) 
            {
                MessageBox.Show("You must fill in the Screen Name field, the Full Name Field, and choose an Organization.", "IACS User Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (ListViewItem item in lvOperators.Items)
            {
                if (item.SubItems[1].Text.ToLower().Trim().Equals(tbScreenName.Text.ToLower().Trim()))
                {
                    MessageBox.Show("An Operator with that screen name already exists in the database! Please try another screen name.", 
                        "IACS User Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            tsStatusLabel.Text = "Updating live database...";
            if (!liveDbManager.CreateOperator(tbScreenName.Text.Trim(), tbFullName.Text.Trim(), cbPrivGroups.Text, ref errMsg))
            {
                MessageBox.Show("Could not add this operator to the live database! Please have a look at your configuration settings, and try again.", "IACS User Management", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tsStatusLabel.Text = "Live database update complete...";
            tsStatusLabel.Text = "Updating archive database...";

            if (!archiveDbManager.CreateOperator(tbScreenName.Text.Trim(), tbFullName.Text.Trim(), cbPrivGroups.Text, ref errMsg))
            {
                MessageBox.Show("Could not add this operator to the archive database! Please have a look at your configuration settings, and try again.", "IACS User Management",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tsStatusLabel.Text = "Idle.";

            RefreshOperatorTab();

            tbScreenName.Text           = "";
            tbFullName.Text             = "";
        }

        private void RefreshOperatorTab()
        {
            List<String> colNames = new List<String>();
            Dictionary<String, String> where = new Dictionary<String, String>();
            List<Object[]> rows = null;
            List<Object[]> privRows = null;
            String errMsg = "";
            ListViewItem lvi;

            if (liveDbManager == null) { return; }

            lvOperators.Items.Clear();
            cbPrivGroups.Items.Clear();

            tsStatusLabel.Text = "Getting Operator list...";

            new System.Threading.Thread(delegate()
            {
                colNames.Add("ScrName");
                colNames.Add("Name");
                colNames.Add("Priv");

                if (!(liveDbManager.GetRows("dbo.Oper", colNames, null, ref rows, ref errMsg) ?
                     (Func<bool>)(() =>
                     {
                         bool alternateRow = false;

                         this.Invoke((MethodInvoker)delegate() { lvOperators.BeginUpdate(); });

                         foreach (Object[] row in rows)
                         {
                             lvi = new ListViewItem("");
                             lvi.SubItems.Add(row[0].ToString());
                             lvi.SubItems.Add(row[1].ToString());

                             colNames.Clear();
                             colNames.Add("Priv");
                             where.Clear();
                             where.Add("NoPriv", row[2].ToString());

                             if (privRows == null) { privRows = new List<Object[]>(); }
                             privRows.Clear();

                             if (liveDbManager.GetRows("dbo.privileg", colNames, where, ref privRows, ref errMsg))
                             {
                                 if (privRows.Count > 0)
                                 {
                                     this.Invoke((MethodInvoker)delegate() { lvi.SubItems.Add(privRows[0][0].ToString()); });
                                 }
                             }

                             lvi.BackColor  = (alternateRow) ? Color.AliceBlue : Color.White;
                             alternateRow   = (alternateRow) ? false : true;

                             this.Invoke((MethodInvoker)delegate() { lvOperators.Items.Add(lvi); });
                         }

                         this.Invoke((MethodInvoker)delegate() { lvOperators.EndUpdate(); tsStatusLabel.Text = "Idle."; });
                         return true;
                     }) : (Func<bool>)(() =>
                     {
                         this.Invoke((MethodInvoker)delegate() { tsStatusLabel.Text = "Could not retrieve the operator list."; });
                         return false;
                     }))())
                {
                    // creation error handler here.
                }
            }).Start();

            // Get and populate the cbPrivGroups combo box (off the UI thread):
            new System.Threading.Thread(delegate()
            {
                List<Object[]> cbPrivRows = new List<Object[]>();
                if (liveDbManager.GetRows("dbo.privileg", null, null, ref cbPrivRows, ref errMsg))
                {
                    // Clear it first: It may already be populated with a stale list:
                    this.Invoke((MethodInvoker)delegate() { cbPrivGroups.Items.Clear(); });

                    // Get all the Privilage Groups, and add them to the combo box:
                    if (cbPrivRows.Count > 0)
                    {
                        foreach (Object[] row in cbPrivRows)
                        {
                            this.Invoke((MethodInvoker)delegate() { cbPrivGroups.Items.Add(row[1].ToString()); });
                        }

                        // Set the selected index so that the top item is selected in the combo box by default:
                        this.Invoke((MethodInvoker)delegate() { cbPrivGroups.SelectedIndex = 0; });
                    }
                }
            }).Start();
        }

        private void tcControls_Selected(object sender, TabControlEventArgs e)
        {
            if (tcControls.SelectedIndex == 1)
            {
                RefreshOperatorTab();
            }
        }

        private void tabOperator_Click(object sender, EventArgs e)
        {

        }

        private void deleteThisOperatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvOperators.SelectedIndices.Count > 0)
            {
                ListViewItem item = lvOperators.Items[lvOperators.SelectedIndices[0]];
                Dictionary<String, String> where    = new Dictionary<String, String>();
                String errMsg                       = "";

                DialogResult result = MessageBox.Show("Do you really want to delete " + item.SubItems[2].Text + "?\n\nThis will be a perminant change, and can not be undone!",
                    "IACS User Management", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(result.Equals(DialogResult.No)) { return; }

                where.Add("ScrName", item.SubItems[1].Text);
                where.Add("Name", item.SubItems[2].Text);

                if (!liveDbManager.DeleteRows("dbo.Oper", where, ref errMsg))
                {
                    MessageBox.Show("Could not delete this operator from the live database! Please have a look at your configuration settings, and try again.", "IACS User Management",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!archiveDbManager.DeleteRows("dbo.Oper", where, ref errMsg))
                {
                    MessageBox.Show("Could not delete this operator from the archive database! This operator will need to be removed manualy!", "IACS User Management",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                RefreshOperatorTab();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String number = "205";
            int zeros = 12;

            zeros = zeros - number.Length;

            for (int count = 0; count < zeros; count++)
            {
                number = "0" + number;
            }

            MessageBox.Show(number.Length.ToString() + ", " + number);

        }

        private void lvOrganizations_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvOrganizations_Resize(object sender, EventArgs e)
        {
            if (lvOrganizations.Width > 25)
            {
                lvOrganizations.Columns[0].Width = lvOrganizations.Width - 25;
            }
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lbReports_Click(object sender, EventArgs e)
        {
            if (lbReports.SelectedIndex > -1)
            {
                if (lbReports.SelectedItem.ToString().Equals("Cards in Organization"))
                {
                    List<String> partitions = new List<String>();
                    if (!GetPartitions(ref partitions))
                    {
                        // error handling
                    }
                }
            }
        }

        private bool GetPartitions(ref List<String> partitions)
        {
            partitions = new List<String>();
            ListViewItem lvi;
            String errMsg = "";

            if (!liveDbManager.GetPartitionList(ref partitions, ref errMsg))
            {
                return false;
            }
            else
            {
                //bool alternateRow = false;
                lbReportDetail.Items.Clear();
                foreach (String partition in partitions)
                {
                    if (!partition.ToLower().Equals("none"))
                    {
                        lvi = new ListViewItem(partition, 0);
                        //lvi.BackColor = (alternateRow) ? Color.AliceBlue : Color.White;
                        //alternateRow = (alternateRow) ? false : true;

                        lbReportDetail.Items.Add(partition);
                    }
                }
            }

            return true;
        }

        private void DoReport(String report, String detail)
        {
            String csv = "";
            String errMsg = "";
            if (!liveDbManager.GetCardInfoByOrg(detail, ref csv, ref errMsg))
            {
                MessageBox.Show("Report Failed!", "Report Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //MessageBox.Show(csv, "CSV", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sfdSaveReport.DefaultExt = "csv";
                sfdSaveReport.AddExtension = true;
                sfdSaveReport.FileName += "BadgeByOrgReport";
                sfdSaveReport.ShowDialog();
                String filePath = sfdSaveReport.FileName;

                try
                {
                    File.WriteAllText(filePath, csv);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Could not save file!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                MessageBox.Show("File saved to: \v\v" + filePath, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lbReportDetail_Click(object sender, EventArgs e)
        {
            
        }

        private void lbReportDetail_DoubleClick(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult retVal = MessageBox.Show("Run the report " + lbReports.SelectedItem.ToString() + ", " + lbReportDetail.SelectedItem.ToString() + "?", "Run This Report?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (retVal == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }

            DoReport(lbReports.SelectedItem.ToString(), lbReportDetail.SelectedItem.ToString());
        }
    }
}
