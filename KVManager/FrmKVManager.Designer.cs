namespace KVManager
{
    partial class FrmKVManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKVManager));
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdMain = new System.Windows.Forms.OpenFileDialog();
            this.bsAdmins = new System.Windows.Forms.BindingSource(this.components);
            this._dsAdmins = new KVManager.dsAdmins();
            this.grpAdminDetails = new System.Windows.Forms.GroupBox();
            this.cboGroup = new System.Windows.Forms.ComboBox();
            this.bsGroups = new System.Windows.Forms.BindingSource(this.components);
            this._dsGroups = new KVManager.dsGroups();
            this.cboAuthType = new System.Windows.Forms.ComboBox();
            this.numImmunity = new System.Windows.Forms.NumericUpDown();
            this.lblAuth = new System.Windows.Forms.Label();
            this.lblImmunity = new System.Windows.Forms.Label();
            this.lblIdentity = new System.Windows.Forms.Label();
            this.txtIdentity = new System.Windows.Forms.TextBox();
            this.lblGroup = new System.Windows.Forms.Label();
            this.dgvAdminList = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tscMain = new System.Windows.Forms.ToolStripContainer();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpAdmin = new System.Windows.Forms.TabPage();
            this.acAdminFlags = new KVManager.AccessFlags();
            this.tpGroup = new System.Windows.Forms.TabPage();
            this.grpOverrides = new System.Windows.Forms.GroupBox();
            this.dgvOverrides = new System.Windows.Forms.DataGridView();
            this.keyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsFKGroup_Overrides = new System.Windows.Forms.BindingSource(this.components);
            this.numGroupImmunity = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.acGroupFlags = new KVManager.AccessFlags();
            this.dgvGroupList = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.sfdMain = new System.Windows.Forms.SaveFileDialog();
            this.mnuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsAdmins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._dsAdmins)).BeginInit();
            this.grpAdminDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._dsGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numImmunity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminList)).BeginInit();
            this.tscMain.ContentPanel.SuspendLayout();
            this.tscMain.TopToolStripPanel.SuspendLayout();
            this.tscMain.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tpAdmin.SuspendLayout();
            this.tpGroup.SuspendLayout();
            this.grpOverrides.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverrides)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFKGroup_Overrides)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGroupImmunity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupList)).BeginInit();
            this.tsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Dock = System.Windows.Forms.DockStyle.None;
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(512, 24);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.openToolStripMenuItem.Text = "&Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.saveToolStripMenuItem.Text = "Save &As...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // bsAdmins
            // 
            this.bsAdmins.DataMember = "dtAdmins";
            this.bsAdmins.DataSource = this._dsAdmins;
            this.bsAdmins.PositionChanged += new System.EventHandler(this.bsAdmins_PositionChanged);
            // 
            // _dsAdmins
            // 
            this._dsAdmins.DataSetName = "dsAdmins";
            this._dsAdmins.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grpAdminDetails
            // 
            this.grpAdminDetails.Controls.Add(this.cboGroup);
            this.grpAdminDetails.Controls.Add(this.cboAuthType);
            this.grpAdminDetails.Controls.Add(this.numImmunity);
            this.grpAdminDetails.Controls.Add(this.lblAuth);
            this.grpAdminDetails.Controls.Add(this.lblImmunity);
            this.grpAdminDetails.Controls.Add(this.lblIdentity);
            this.grpAdminDetails.Controls.Add(this.txtIdentity);
            this.grpAdminDetails.Controls.Add(this.lblGroup);
            this.grpAdminDetails.Location = new System.Drawing.Point(125, 6);
            this.grpAdminDetails.Name = "grpAdminDetails";
            this.grpAdminDetails.Size = new System.Drawing.Size(217, 130);
            this.grpAdminDetails.TabIndex = 1;
            this.grpAdminDetails.TabStop = false;
            this.grpAdminDetails.Text = "Admin Details:";
            // 
            // cboGroup
            // 
            this.cboGroup.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAdmins, "group", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cboGroup.DataSource = this.bsGroups;
            this.cboGroup.DisplayMember = "name";
            this.cboGroup.FormattingEnabled = true;
            this.cboGroup.Location = new System.Drawing.Point(75, 72);
            this.cboGroup.Name = "cboGroup";
            this.cboGroup.Size = new System.Drawing.Size(131, 21);
            this.cboGroup.TabIndex = 5;
            this.cboGroup.ValueMember = "name";
            // 
            // bsGroups
            // 
            this.bsGroups.DataMember = "dtGroups";
            this.bsGroups.DataSource = this._dsGroups;
            this.bsGroups.PositionChanged += new System.EventHandler(this.bsGroups_PositionChanged);
            // 
            // _dsGroups
            // 
            this._dsGroups.DataSetName = "dsGroups";
            this._dsGroups.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cboAuthType
            // 
            this.cboAuthType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAdmins, "authType", true));
            this.cboAuthType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAuthType.FormattingEnabled = true;
            this.cboAuthType.Items.AddRange(new object[] {
            "steam",
            "name",
            "ip"});
            this.cboAuthType.Location = new System.Drawing.Point(75, 19);
            this.cboAuthType.Name = "cboAuthType";
            this.cboAuthType.Size = new System.Drawing.Size(70, 21);
            this.cboAuthType.TabIndex = 1;
            // 
            // numImmunity
            // 
            this.numImmunity.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsAdmins, "immunity", true));
            this.numImmunity.Location = new System.Drawing.Point(75, 98);
            this.numImmunity.Name = "numImmunity";
            this.numImmunity.Size = new System.Drawing.Size(46, 20);
            this.numImmunity.TabIndex = 7;
            // 
            // lblAuth
            // 
            this.lblAuth.AutoSize = true;
            this.lblAuth.Location = new System.Drawing.Point(10, 22);
            this.lblAuth.Name = "lblAuth";
            this.lblAuth.Size = new System.Drawing.Size(59, 13);
            this.lblAuth.TabIndex = 0;
            this.lblAuth.Text = "Auth Type:";
            // 
            // lblImmunity
            // 
            this.lblImmunity.AutoSize = true;
            this.lblImmunity.Location = new System.Drawing.Point(10, 100);
            this.lblImmunity.Name = "lblImmunity";
            this.lblImmunity.Size = new System.Drawing.Size(51, 13);
            this.lblImmunity.TabIndex = 6;
            this.lblImmunity.Text = "Immunity:";
            // 
            // lblIdentity
            // 
            this.lblIdentity.AutoSize = true;
            this.lblIdentity.Location = new System.Drawing.Point(10, 49);
            this.lblIdentity.Name = "lblIdentity";
            this.lblIdentity.Size = new System.Drawing.Size(44, 13);
            this.lblIdentity.TabIndex = 2;
            this.lblIdentity.Text = "Identity:";
            // 
            // txtIdentity
            // 
            this.txtIdentity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAdmins, "identity", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtIdentity.Location = new System.Drawing.Point(75, 46);
            this.txtIdentity.MaxLength = 50;
            this.txtIdentity.Name = "txtIdentity";
            this.txtIdentity.Size = new System.Drawing.Size(131, 20);
            this.txtIdentity.TabIndex = 3;
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new System.Drawing.Point(10, 75);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(39, 13);
            this.lblGroup.TabIndex = 4;
            this.lblGroup.Text = "Group:";
            // 
            // dgvAdminList
            // 
            this.dgvAdminList.AllowUserToAddRows = false;
            this.dgvAdminList.AllowUserToDeleteRows = false;
            this.dgvAdminList.AllowUserToResizeRows = false;
            this.dgvAdminList.AutoGenerateColumns = false;
            this.dgvAdminList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdminList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn});
            this.dgvAdminList.DataSource = this.bsAdmins;
            this.dgvAdminList.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvAdminList.Location = new System.Drawing.Point(3, 3);
            this.dgvAdminList.Name = "dgvAdminList";
            this.dgvAdminList.RowHeadersVisible = false;
            this.dgvAdminList.Size = new System.Drawing.Size(116, 443);
            this.dgvAdminList.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Admin Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // tscMain
            // 
            // 
            // tscMain.ContentPanel
            // 
            this.tscMain.ContentPanel.AutoScroll = true;
            this.tscMain.ContentPanel.Controls.Add(this.tcMain);
            this.tscMain.ContentPanel.Size = new System.Drawing.Size(512, 475);
            this.tscMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tscMain.Location = new System.Drawing.Point(0, 0);
            this.tscMain.Name = "tscMain";
            this.tscMain.Size = new System.Drawing.Size(512, 524);
            this.tscMain.TabIndex = 11;
            this.tscMain.Text = "toolStripContainer1";
            // 
            // tscMain.TopToolStripPanel
            // 
            this.tscMain.TopToolStripPanel.Controls.Add(this.mnuMain);
            this.tscMain.TopToolStripPanel.Controls.Add(this.tsMain);
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpAdmin);
            this.tcMain.Controls.Add(this.tpGroup);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(512, 475);
            this.tcMain.TabIndex = 0;
            this.tcMain.SelectedIndexChanged += new System.EventHandler(this.tcMain_SelectedIndexChanged);
            // 
            // tpAdmin
            // 
            this.tpAdmin.Controls.Add(this.dgvAdminList);
            this.tpAdmin.Controls.Add(this.acAdminFlags);
            this.tpAdmin.Controls.Add(this.grpAdminDetails);
            this.tpAdmin.Location = new System.Drawing.Point(4, 22);
            this.tpAdmin.Name = "tpAdmin";
            this.tpAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.tpAdmin.Size = new System.Drawing.Size(504, 449);
            this.tpAdmin.TabIndex = 0;
            this.tpAdmin.Text = "Admins";
            this.tpAdmin.UseVisualStyleBackColor = true;
            // 
            // acAdminFlags
            // 
            this.acAdminFlags.DataBindings.Add(new System.Windows.Forms.Binding("FlagString", this.bsAdmins, "flags", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.acAdminFlags.FlagString = "";
            this.acAdminFlags.Location = new System.Drawing.Point(125, 142);
            this.acAdminFlags.Name = "acAdminFlags";
            this.acAdminFlags.Size = new System.Drawing.Size(371, 274);
            this.acAdminFlags.TabIndex = 2;
            // 
            // tpGroup
            // 
            this.tpGroup.AutoScroll = true;
            this.tpGroup.Controls.Add(this.grpOverrides);
            this.tpGroup.Controls.Add(this.numGroupImmunity);
            this.tpGroup.Controls.Add(this.label1);
            this.tpGroup.Controls.Add(this.acGroupFlags);
            this.tpGroup.Controls.Add(this.dgvGroupList);
            this.tpGroup.Location = new System.Drawing.Point(4, 22);
            this.tpGroup.Name = "tpGroup";
            this.tpGroup.Padding = new System.Windows.Forms.Padding(3);
            this.tpGroup.Size = new System.Drawing.Size(504, 449);
            this.tpGroup.TabIndex = 1;
            this.tpGroup.Text = "Groups";
            this.tpGroup.UseVisualStyleBackColor = true;
            // 
            // grpOverrides
            // 
            this.grpOverrides.Controls.Add(this.dgvOverrides);
            this.grpOverrides.Location = new System.Drawing.Point(129, 309);
            this.grpOverrides.Name = "grpOverrides";
            this.grpOverrides.Size = new System.Drawing.Size(268, 135);
            this.grpOverrides.TabIndex = 4;
            this.grpOverrides.TabStop = false;
            this.grpOverrides.Text = "Overrides:";
            // 
            // dgvOverrides
            // 
            this.dgvOverrides.AutoGenerateColumns = false;
            this.dgvOverrides.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOverrides.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.keyDataGridViewTextBoxColumn,
            this.value});
            this.dgvOverrides.DataSource = this.bsFKGroup_Overrides;
            this.dgvOverrides.Location = new System.Drawing.Point(6, 19);
            this.dgvOverrides.Name = "dgvOverrides";
            this.dgvOverrides.RowHeadersWidth = 20;
            this.dgvOverrides.Size = new System.Drawing.Size(256, 110);
            this.dgvOverrides.TabIndex = 0;
            // 
            // keyDataGridViewTextBoxColumn
            // 
            this.keyDataGridViewTextBoxColumn.DataPropertyName = "key";
            this.keyDataGridViewTextBoxColumn.HeaderText = "Command / Group";
            this.keyDataGridViewTextBoxColumn.Name = "keyDataGridViewTextBoxColumn";
            // 
            // value
            // 
            this.value.DataPropertyName = "value";
            this.value.HeaderText = "Allow / Deny";
            this.value.Items.AddRange(new object[] {
            "allow",
            "deny"});
            this.value.Name = "value";
            // 
            // bsFKGroup_Overrides
            // 
            this.bsFKGroup_Overrides.DataMember = "FK_dtGroups_dtOverrides";
            this.bsFKGroup_Overrides.DataSource = this.bsGroups;
            // 
            // numGroupImmunity
            // 
            this.numGroupImmunity.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsGroups, "immunity", true));
            this.numGroupImmunity.Location = new System.Drawing.Point(183, 6);
            this.numGroupImmunity.Name = "numGroupImmunity";
            this.numGroupImmunity.Size = new System.Drawing.Size(46, 20);
            this.numGroupImmunity.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Immunity:";
            // 
            // acGroupFlags
            // 
            this.acGroupFlags.DataBindings.Add(new System.Windows.Forms.Binding("FlagString", this.bsGroups, "flags", true));
            this.acGroupFlags.FlagString = "";
            this.acGroupFlags.Location = new System.Drawing.Point(129, 32);
            this.acGroupFlags.Name = "acGroupFlags";
            this.acGroupFlags.Size = new System.Drawing.Size(367, 271);
            this.acGroupFlags.TabIndex = 3;
            // 
            // dgvGroupList
            // 
            this.dgvGroupList.AllowUserToAddRows = false;
            this.dgvGroupList.AllowUserToDeleteRows = false;
            this.dgvGroupList.AllowUserToResizeRows = false;
            this.dgvGroupList.AutoGenerateColumns = false;
            this.dgvGroupList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroupList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1});
            this.dgvGroupList.DataSource = this.bsGroups;
            this.dgvGroupList.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvGroupList.Location = new System.Drawing.Point(3, 3);
            this.dgvGroupList.Name = "dgvGroupList";
            this.dgvGroupList.RowHeadersVisible = false;
            this.dgvGroupList.Size = new System.Drawing.Size(116, 443);
            this.dgvGroupList.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Group Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // tsMain
            // 
            this.tsMain.Dock = System.Windows.Forms.DockStyle.None;
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.tsbDelete});
            this.tsMain.Location = new System.Drawing.Point(3, 24);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(58, 25);
            this.tsMain.TabIndex = 1;
            // 
            // tsbAdd
            // 
            this.tsbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAdd.Image = global::KVManager.Properties.Resources.AddTable;
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(23, 22);
            this.tsbAdd.Text = "Add an admin or group.";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelete.Image = global::KVManager.Properties.Resources.Delete;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(23, 22);
            this.tsbDelete.Text = "Delete the current admin or group.";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // sfdMain
            // 
            this.sfdMain.Filter = "Admin Config Files|admins.cfg";
            // 
            // FrmKVManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 524);
            this.Controls.Add(this.tscMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMain;
            this.MaximizeBox = false;
            this.Name = "FrmKVManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Key Value Manager";
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsAdmins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._dsAdmins)).EndInit();
            this.grpAdminDetails.ResumeLayout(false);
            this.grpAdminDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._dsGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numImmunity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminList)).EndInit();
            this.tscMain.ContentPanel.ResumeLayout(false);
            this.tscMain.TopToolStripPanel.ResumeLayout(false);
            this.tscMain.TopToolStripPanel.PerformLayout();
            this.tscMain.ResumeLayout(false);
            this.tscMain.PerformLayout();
            this.tcMain.ResumeLayout(false);
            this.tpAdmin.ResumeLayout(false);
            this.tpGroup.ResumeLayout(false);
            this.tpGroup.PerformLayout();
            this.grpOverrides.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverrides)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFKGroup_Overrides)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGroupImmunity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupList)).EndInit();
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog ofdMain;
        private System.Windows.Forms.Label lblAuth;
        private System.Windows.Forms.ComboBox cboAuthType;
        private System.Windows.Forms.Label lblIdentity;
        private System.Windows.Forms.TextBox txtIdentity;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.NumericUpDown numImmunity;
        private System.Windows.Forms.Label lblImmunity;
        private System.Windows.Forms.GroupBox grpAdminDetails;
        private System.Windows.Forms.ToolStripContainer tscMain;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripButton tsbAdd;        
        private System.Windows.Forms.DataGridView dgvAdminList;        
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private dsAdmins _dsAdmins;
        private System.Windows.Forms.BindingSource bsAdmins;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private AccessFlags acAdminFlags;
        private System.Windows.Forms.SaveFileDialog sfdMain;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpAdmin;
        private System.Windows.Forms.TabPage tpGroup;
        private System.Windows.Forms.DataGridView dgvGroupList;
        private System.Windows.Forms.BindingSource bsGroups;
        private dsGroups _dsGroups;
        private System.Windows.Forms.NumericUpDown numGroupImmunity;
        private System.Windows.Forms.Label label1;
        private AccessFlags acGroupFlags;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.GroupBox grpOverrides;
        private System.Windows.Forms.DataGridView dgvOverrides;
        private System.Windows.Forms.BindingSource bsFKGroup_Overrides;
        private System.Windows.Forms.DataGridViewTextBoxColumn keyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn value;
        private System.Windows.Forms.ComboBox cboGroup;
    }
}

