namespace IACS_User_Management
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsSpacer = new System.Windows.Forms.ToolStripLabel();
            this.tsStatusLabel = new System.Windows.Forms.ToolStripLabel();
            this.tcControls = new System.Windows.Forms.TabControl();
            this.tabOrganization = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cBoxAddPanel = new System.Windows.Forms.CheckBox();
            this.btCreateIt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNewOrgName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvOrganizations = new System.Windows.Forms.ListView();
            this.colOrg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ilOrgIcon = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tabOperator = new System.Windows.Forms.TabPage();
            this.gbOperators = new System.Windows.Forms.GroupBox();
            this.lblPrivGroups = new System.Windows.Forms.Label();
            this.cbPrivGroups = new System.Windows.Forms.ComboBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.tbFullName = new System.Windows.Forms.TextBox();
            this.btCreateOperator = new System.Windows.Forms.Button();
            this.lblScreenName = new System.Windows.Forms.Label();
            this.tbScreenName = new System.Windows.Forms.TextBox();
            this.gbOperatorList = new System.Windows.Forms.GroupBox();
            this.lvOperators = new System.Windows.Forms.ListView();
            this.colDummy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colScrName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPriviligeGroup = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsOperatorRightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteThisOperatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblOperatorInstructions = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gbReportList = new System.Windows.Forms.GroupBox();
            this.lbReports = new System.Windows.Forms.ListBox();
            this.gbReportDetail = new System.Windows.Forms.GroupBox();
            this.lbReportDetail = new System.Windows.Forms.ListBox();
            this.sfdSaveReport = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tcControls.SuspendLayout();
            this.tabOrganization.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabOperator.SuspendLayout();
            this.gbOperators.SuspendLayout();
            this.gbOperatorList.SuspendLayout();
            this.cmsOperatorRightClick.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbReportList.SuspendLayout();
            this.gbReportDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(688, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.fileToolStripMenuItem.Text = "Configuration";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSpacer,
            this.tsStatusLabel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 491);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(688, 36);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsSpacer
            // 
            this.tsSpacer.Name = "tsSpacer";
            this.tsSpacer.Size = new System.Drawing.Size(10, 33);
            this.tsSpacer.Text = " ";
            // 
            // tsStatusLabel
            // 
            this.tsStatusLabel.AutoSize = false;
            this.tsStatusLabel.Name = "tsStatusLabel";
            this.tsStatusLabel.Size = new System.Drawing.Size(665, 47);
            this.tsStatusLabel.Text = "Idle.";
            this.tsStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsStatusLabel.Click += new System.EventHandler(this.tsStatusLabel_Click);
            // 
            // tcControls
            // 
            this.tcControls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcControls.Controls.Add(this.tabOrganization);
            this.tcControls.Controls.Add(this.tabOperator);
            this.tcControls.Controls.Add(this.tabPage1);
            this.tcControls.Location = new System.Drawing.Point(12, 37);
            this.tcControls.Name = "tcControls";
            this.tcControls.SelectedIndex = 0;
            this.tcControls.Size = new System.Drawing.Size(664, 451);
            this.tcControls.TabIndex = 2;
            this.tcControls.Selected += new System.Windows.Forms.TabControlEventHandler(this.tcControls_Selected);
            // 
            // tabOrganization
            // 
            this.tabOrganization.Controls.Add(this.groupBox2);
            this.tabOrganization.Controls.Add(this.groupBox1);
            this.tabOrganization.Controls.Add(this.label1);
            this.tabOrganization.Location = new System.Drawing.Point(4, 22);
            this.tabOrganization.Name = "tabOrganization";
            this.tabOrganization.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrganization.Size = new System.Drawing.Size(656, 425);
            this.tabOrganization.TabIndex = 0;
            this.tabOrganization.Text = "Organization Management";
            this.tabOrganization.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.cBoxAddPanel);
            this.groupBox2.Controls.Add(this.btCreateIt);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbNewOrgName);
            this.groupBox2.Location = new System.Drawing.Point(17, 327);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(625, 91);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create a new Organization:";
            // 
            // cBoxAddPanel
            // 
            this.cBoxAddPanel.Checked = true;
            this.cBoxAddPanel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cBoxAddPanel.Location = new System.Drawing.Point(59, 48);
            this.cBoxAddPanel.Name = "cBoxAddPanel";
            this.cBoxAddPanel.Size = new System.Drawing.Size(373, 37);
            this.cBoxAddPanel.TabIndex = 3;
            this.cBoxAddPanel.Text = "Add a Super 2 Panel map to this new Organization ( The name of the map file will " +
    "be the OrgName_Map.jpg )";
            this.cBoxAddPanel.UseVisualStyleBackColor = true;
            // 
            // btCreateIt
            // 
            this.btCreateIt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCreateIt.Location = new System.Drawing.Point(535, 62);
            this.btCreateIt.Name = "btCreateIt";
            this.btCreateIt.Size = new System.Drawing.Size(84, 23);
            this.btCreateIt.TabIndex = 2;
            this.btCreateIt.Text = "Create it!";
            this.btCreateIt.UseVisualStyleBackColor = true;
            this.btCreateIt.Click += new System.EventHandler(this.btCreateIt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // tbNewOrgName
            // 
            this.tbNewOrgName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNewOrgName.Location = new System.Drawing.Point(59, 22);
            this.tbNewOrgName.Name = "tbNewOrgName";
            this.tbNewOrgName.Size = new System.Drawing.Size(560, 20);
            this.tbNewOrgName.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lvOrganizations);
            this.groupBox1.Location = new System.Drawing.Point(17, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(625, 246);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Organizations:";
            // 
            // lvOrganizations
            // 
            this.lvOrganizations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvOrganizations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvOrganizations.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colOrg});
            this.lvOrganizations.FullRowSelect = true;
            this.lvOrganizations.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvOrganizations.Location = new System.Drawing.Point(6, 19);
            this.lvOrganizations.Name = "lvOrganizations";
            this.lvOrganizations.Size = new System.Drawing.Size(613, 221);
            this.lvOrganizations.SmallImageList = this.ilOrgIcon;
            this.lvOrganizations.TabIndex = 0;
            this.lvOrganizations.UseCompatibleStateImageBehavior = false;
            this.lvOrganizations.View = System.Windows.Forms.View.Details;
            this.lvOrganizations.SelectedIndexChanged += new System.EventHandler(this.lvOrganizations_SelectedIndexChanged);
            this.lvOrganizations.Resize += new System.EventHandler(this.lvOrganizations_Resize);
            // 
            // colOrg
            // 
            this.colOrg.Text = "Organization";
            this.colOrg.Width = 575;
            // 
            // ilOrgIcon
            // 
            this.ilOrgIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilOrgIcon.ImageStream")));
            this.ilOrgIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.ilOrgIcon.Images.SetKeyName(0, "edit-group.ico");
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.AliceBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(1, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(652, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabOperator
            // 
            this.tabOperator.Controls.Add(this.gbOperators);
            this.tabOperator.Controls.Add(this.gbOperatorList);
            this.tabOperator.Controls.Add(this.lblOperatorInstructions);
            this.tabOperator.Location = new System.Drawing.Point(4, 22);
            this.tabOperator.Name = "tabOperator";
            this.tabOperator.Padding = new System.Windows.Forms.Padding(3);
            this.tabOperator.Size = new System.Drawing.Size(656, 425);
            this.tabOperator.TabIndex = 1;
            this.tabOperator.Text = "Operator Management";
            this.tabOperator.UseVisualStyleBackColor = true;
            this.tabOperator.Click += new System.EventHandler(this.tabOperator_Click);
            // 
            // gbOperators
            // 
            this.gbOperators.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbOperators.Controls.Add(this.lblPrivGroups);
            this.gbOperators.Controls.Add(this.cbPrivGroups);
            this.gbOperators.Controls.Add(this.lblFullName);
            this.gbOperators.Controls.Add(this.tbFullName);
            this.gbOperators.Controls.Add(this.btCreateOperator);
            this.gbOperators.Controls.Add(this.lblScreenName);
            this.gbOperators.Controls.Add(this.tbScreenName);
            this.gbOperators.Location = new System.Drawing.Point(18, 283);
            this.gbOperators.Name = "gbOperators";
            this.gbOperators.Size = new System.Drawing.Size(625, 136);
            this.gbOperators.TabIndex = 5;
            this.gbOperators.TabStop = false;
            this.gbOperators.Text = "Create a new Operator";
            // 
            // lblPrivGroups
            // 
            this.lblPrivGroups.AutoSize = true;
            this.lblPrivGroups.Location = new System.Drawing.Point(15, 77);
            this.lblPrivGroups.Name = "lblPrivGroups";
            this.lblPrivGroups.Size = new System.Drawing.Size(87, 13);
            this.lblPrivGroups.TabIndex = 6;
            this.lblPrivGroups.Text = "Privilage Groups:";
            // 
            // cbPrivGroups
            // 
            this.cbPrivGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPrivGroups.FormattingEnabled = true;
            this.cbPrivGroups.Location = new System.Drawing.Point(108, 74);
            this.cbPrivGroups.Name = "cbPrivGroups";
            this.cbPrivGroups.Size = new System.Drawing.Size(511, 21);
            this.cbPrivGroups.TabIndex = 5;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(45, 51);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(57, 13);
            this.lblFullName.TabIndex = 4;
            this.lblFullName.Text = "Full Name:";
            // 
            // tbFullName
            // 
            this.tbFullName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFullName.Location = new System.Drawing.Point(108, 47);
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.Size = new System.Drawing.Size(511, 20);
            this.tbFullName.TabIndex = 3;
            // 
            // btCreateOperator
            // 
            this.btCreateOperator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btCreateOperator.Location = new System.Drawing.Point(535, 101);
            this.btCreateOperator.Name = "btCreateOperator";
            this.btCreateOperator.Size = new System.Drawing.Size(84, 23);
            this.btCreateOperator.TabIndex = 2;
            this.btCreateOperator.Text = "Create it!";
            this.btCreateOperator.UseVisualStyleBackColor = true;
            this.btCreateOperator.Click += new System.EventHandler(this.btCreateOperator_Click);
            // 
            // lblScreenName
            // 
            this.lblScreenName.AutoSize = true;
            this.lblScreenName.Location = new System.Drawing.Point(27, 22);
            this.lblScreenName.Name = "lblScreenName";
            this.lblScreenName.Size = new System.Drawing.Size(75, 13);
            this.lblScreenName.TabIndex = 1;
            this.lblScreenName.Text = "Screen Name:";
            // 
            // tbScreenName
            // 
            this.tbScreenName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbScreenName.Location = new System.Drawing.Point(108, 21);
            this.tbScreenName.Name = "tbScreenName";
            this.tbScreenName.Size = new System.Drawing.Size(511, 20);
            this.tbScreenName.TabIndex = 0;
            // 
            // gbOperatorList
            // 
            this.gbOperatorList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbOperatorList.Controls.Add(this.lvOperators);
            this.gbOperatorList.Location = new System.Drawing.Point(18, 77);
            this.gbOperatorList.Name = "gbOperatorList";
            this.gbOperatorList.Size = new System.Drawing.Size(625, 200);
            this.gbOperatorList.TabIndex = 4;
            this.gbOperatorList.TabStop = false;
            this.gbOperatorList.Text = "Operators";
            // 
            // lvOperators
            // 
            this.lvOperators.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvOperators.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvOperators.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colDummy,
            this.colScrName,
            this.colFullName,
            this.colPriviligeGroup});
            this.lvOperators.ContextMenuStrip = this.cmsOperatorRightClick;
            this.lvOperators.FullRowSelect = true;
            this.lvOperators.Location = new System.Drawing.Point(6, 19);
            this.lvOperators.Name = "lvOperators";
            this.lvOperators.Size = new System.Drawing.Size(613, 175);
            this.lvOperators.TabIndex = 0;
            this.lvOperators.UseCompatibleStateImageBehavior = false;
            this.lvOperators.View = System.Windows.Forms.View.Details;
            // 
            // colDummy
            // 
            this.colDummy.Text = "";
            this.colDummy.Width = 0;
            // 
            // colScrName
            // 
            this.colScrName.Text = "Screen Name";
            this.colScrName.Width = 150;
            // 
            // colFullName
            // 
            this.colFullName.Text = "Full Name";
            this.colFullName.Width = 180;
            // 
            // colPriviligeGroup
            // 
            this.colPriviligeGroup.Text = "Privilige Group";
            this.colPriviligeGroup.Width = 250;
            // 
            // cmsOperatorRightClick
            // 
            this.cmsOperatorRightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteThisOperatorToolStripMenuItem});
            this.cmsOperatorRightClick.Name = "cmsOperatorRightClick";
            this.cmsOperatorRightClick.Size = new System.Drawing.Size(178, 26);
            // 
            // deleteThisOperatorToolStripMenuItem
            // 
            this.deleteThisOperatorToolStripMenuItem.Name = "deleteThisOperatorToolStripMenuItem";
            this.deleteThisOperatorToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.deleteThisOperatorToolStripMenuItem.Text = "Delete this operator";
            this.deleteThisOperatorToolStripMenuItem.Click += new System.EventHandler(this.deleteThisOperatorToolStripMenuItem_Click);
            // 
            // lblOperatorInstructions
            // 
            this.lblOperatorInstructions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOperatorInstructions.BackColor = System.Drawing.Color.AliceBlue;
            this.lblOperatorInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperatorInstructions.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblOperatorInstructions.Location = new System.Drawing.Point(2, 5);
            this.lblOperatorInstructions.Name = "lblOperatorInstructions";
            this.lblOperatorInstructions.Size = new System.Drawing.Size(652, 69);
            this.lblOperatorInstructions.TabIndex = 3;
            this.lblOperatorInstructions.Text = "The list below displays all the available  OPERATORS. Creating a new operator her" +
    "e will cause a new operator to be created in CA3000 by manipulating the database" +
    " directly.";
            this.lblOperatorInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gbReportDetail);
            this.tabPage1.Controls.Add(this.gbReportList);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(656, 425);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Reports";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gbReportList
            // 
            this.gbReportList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbReportList.Controls.Add(this.lbReports);
            this.gbReportList.Location = new System.Drawing.Point(6, 6);
            this.gbReportList.Name = "gbReportList";
            this.gbReportList.Size = new System.Drawing.Size(200, 413);
            this.gbReportList.TabIndex = 0;
            this.gbReportList.TabStop = false;
            this.gbReportList.Text = "Select Report";
            // 
            // lbReports
            // 
            this.lbReports.FormattingEnabled = true;
            this.lbReports.Items.AddRange(new object[] {
            "Cards in Organization"});
            this.lbReports.Location = new System.Drawing.Point(6, 19);
            this.lbReports.Name = "lbReports";
            this.lbReports.Size = new System.Drawing.Size(188, 381);
            this.lbReports.TabIndex = 0;
            this.lbReports.Click += new System.EventHandler(this.lbReports_Click);
            // 
            // gbReportDetail
            // 
            this.gbReportDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbReportDetail.Controls.Add(this.lbReportDetail);
            this.gbReportDetail.Location = new System.Drawing.Point(212, 6);
            this.gbReportDetail.Name = "gbReportDetail";
            this.gbReportDetail.Size = new System.Drawing.Size(438, 413);
            this.gbReportDetail.TabIndex = 1;
            this.gbReportDetail.TabStop = false;
            this.gbReportDetail.Text = "Report Detail";
            // 
            // lbReportDetail
            // 
            this.lbReportDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbReportDetail.FormattingEnabled = true;
            this.lbReportDetail.Location = new System.Drawing.Point(6, 19);
            this.lbReportDetail.Name = "lbReportDetail";
            this.lbReportDetail.Size = new System.Drawing.Size(426, 381);
            this.lbReportDetail.TabIndex = 0;
            this.lbReportDetail.Click += new System.EventHandler(this.lbReportDetail_Click);
            this.lbReportDetail.DoubleClick += new System.EventHandler(this.lbReportDetail_DoubleClick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(688, 529);
            this.Controls.Add(this.tcControls);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IACS User Management";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tcControls.ResumeLayout(false);
            this.tabOrganization.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabOperator.ResumeLayout(false);
            this.gbOperators.ResumeLayout(false);
            this.gbOperators.PerformLayout();
            this.gbOperatorList.ResumeLayout(false);
            this.cmsOperatorRightClick.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gbReportList.ResumeLayout(false);
            this.gbReportDetail.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tsSpacer;
        private System.Windows.Forms.ToolStripLabel tsStatusLabel;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.TabControl tcControls;
        private System.Windows.Forms.TabPage tabOrganization;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabOperator;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btCreateIt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNewOrgName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbOperators;
        private System.Windows.Forms.Button btCreateOperator;
        private System.Windows.Forms.Label lblScreenName;
        private System.Windows.Forms.TextBox tbScreenName;
        private System.Windows.Forms.GroupBox gbOperatorList;
        private System.Windows.Forms.Label lblOperatorInstructions;
        private System.Windows.Forms.ComboBox cbPrivGroups;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox tbFullName;
        private System.Windows.Forms.Label lblPrivGroups;
        private System.Windows.Forms.ListView lvOperators;
        private System.Windows.Forms.ColumnHeader colDummy;
        private System.Windows.Forms.ColumnHeader colScrName;
        private System.Windows.Forms.ColumnHeader colFullName;
        private System.Windows.Forms.ColumnHeader colPriviligeGroup;
        private System.Windows.Forms.ContextMenuStrip cmsOperatorRightClick;
        private System.Windows.Forms.ToolStripMenuItem deleteThisOperatorToolStripMenuItem;
        private System.Windows.Forms.CheckBox cBoxAddPanel;
        private System.Windows.Forms.ListView lvOrganizations;
        private System.Windows.Forms.ColumnHeader colOrg;
        private System.Windows.Forms.ImageList ilOrgIcon;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox gbReportDetail;
        private System.Windows.Forms.ListBox lbReportDetail;
        private System.Windows.Forms.GroupBox gbReportList;
        private System.Windows.Forms.ListBox lbReports;
        private System.Windows.Forms.SaveFileDialog sfdSaveReport;
    }
}

