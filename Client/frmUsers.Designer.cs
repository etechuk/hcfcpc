namespace Client
{
    partial class frmUsers
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
            this.tv = new System.Windows.Forms.TreeView();
            this.m = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mUserAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mUserRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.sc = new DevComponents.DotNetBar.SuperTabControl();
            this.tpG = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.cbxStatus = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbxiStatusEn = new DevComponents.Editors.ComboItem();
            this.cbxiStatusDi = new DevComponents.Editors.ComboItem();
            this.cbxiStatusBa = new DevComponents.Editors.ComboItem();
            this.cbxGroup = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbxiGroupUser = new DevComponents.Editors.ComboItem();
            this.cbxiGroupAdmin = new DevComponents.Editors.ComboItem();
            this.cbxiGroupSuper = new DevComponents.Editors.ComboItem();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnPass = new DevComponents.DotNetBar.ButtonX();
            this.txtPass = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtUser = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblUser = new DevComponents.DotNetBar.LabelX();
            this.txtAddress = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblAddress = new DevComponents.DotNetBar.LabelX();
            this.lblEmail = new DevComponents.DotNetBar.LabelX();
            this.cbxNameTitle = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbxiContactTitleMr = new DevComponents.Editors.ComboItem();
            this.cbxiContactTitleMrs = new DevComponents.Editors.ComboItem();
            this.cbxiContactTitleMiss = new DevComponents.Editors.ComboItem();
            this.cbxiContactTitleMs = new DevComponents.Editors.ComboItem();
            this.cbxiContactTitleMaster = new DevComponents.Editors.ComboItem();
            this.cbxiContactTitleDr = new DevComponents.Editors.ComboItem();
            this.cbxiContactTitleProf = new DevComponents.Editors.ComboItem();
            this.cbxiContactTitleOfc = new DevComponents.Editors.ComboItem();
            this.txtNameTitle = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblTitle = new DevComponents.DotNetBar.LabelX();
            this.txtNameLast = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtNameFirst = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtEmail = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblPhone = new DevComponents.DotNetBar.LabelX();
            this.txtPhone = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblName = new DevComponents.DotNetBar.LabelX();
            this.tiG = new DevComponents.DotNetBar.SuperTabItem();
            this.tpN = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.txtNotes = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tiN = new DevComponents.DotNetBar.SuperTabItem();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.m.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sc)).BeginInit();
            this.sc.SuspendLayout();
            this.tpG.SuspendLayout();
            this.tpN.SuspendLayout();
            this.SuspendLayout();
            // 
            // tv
            // 
            this.tv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tv.BackColor = System.Drawing.Color.White;
            this.tv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tv.ContextMenuStrip = this.m;
            this.tv.ForeColor = System.Drawing.Color.Black;
            this.tv.FullRowSelect = true;
            this.tv.HideSelection = false;
            this.tv.Indent = 20;
            this.tv.Location = new System.Drawing.Point(12, 18);
            this.tv.Name = "tv";
            this.tv.ShowLines = false;
            this.tv.ShowPlusMinus = false;
            this.tv.Size = new System.Drawing.Size(250, 391);
            this.tv.TabIndex = 0;
            this.tv.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tv_NodeMouseClick);
            this.tv.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tv_NodeMouseDoubleClick);
            // 
            // m
            // 
            this.m.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.m.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mUserAdd,
            this.mUserRemove});
            this.m.Name = "m";
            this.m.Size = new System.Drawing.Size(143, 48);
            // 
            // mUserAdd
            // 
            this.mUserAdd.Name = "mUserAdd";
            this.mUserAdd.Size = new System.Drawing.Size(142, 22);
            this.mUserAdd.Text = "Add user";
            this.mUserAdd.Click += new System.EventHandler(this.mUserAdd_Click);
            // 
            // mUserRemove
            // 
            this.mUserRemove.Name = "mUserRemove";
            this.mUserRemove.Size = new System.Drawing.Size(142, 22);
            this.mUserRemove.Text = "Remove user";
            this.mUserRemove.Click += new System.EventHandler(this.mUserRemove_Click);
            // 
            // sc
            // 
            this.sc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.sc.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.sc.ControlBox.MenuBox.Name = "";
            this.sc.ControlBox.Name = "";
            this.sc.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.sc.ControlBox.MenuBox,
            this.sc.ControlBox.CloseBox});
            this.sc.ControlBox.Visible = false;
            this.sc.Controls.Add(this.tpG);
            this.sc.Controls.Add(this.tpN);
            this.sc.ForeColor = System.Drawing.Color.Black;
            this.sc.Location = new System.Drawing.Point(278, 18);
            this.sc.Name = "sc";
            this.sc.ReorderTabsEnabled = true;
            this.sc.SelectedTabFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.sc.SelectedTabIndex = 0;
            this.sc.Size = new System.Drawing.Size(505, 351);
            this.sc.TabFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sc.TabIndex = 1;
            this.sc.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.tiG,
            this.tiN});
            this.sc.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.VisualStudio2008Dock;
            // 
            // tpG
            // 
            this.tpG.Controls.Add(this.cbxStatus);
            this.tpG.Controls.Add(this.cbxGroup);
            this.tpG.Controls.Add(this.labelX1);
            this.tpG.Controls.Add(this.btnPass);
            this.tpG.Controls.Add(this.txtPass);
            this.tpG.Controls.Add(this.txtUser);
            this.tpG.Controls.Add(this.lblUser);
            this.tpG.Controls.Add(this.txtAddress);
            this.tpG.Controls.Add(this.lblAddress);
            this.tpG.Controls.Add(this.lblEmail);
            this.tpG.Controls.Add(this.cbxNameTitle);
            this.tpG.Controls.Add(this.txtNameTitle);
            this.tpG.Controls.Add(this.lblTitle);
            this.tpG.Controls.Add(this.txtNameLast);
            this.tpG.Controls.Add(this.txtNameFirst);
            this.tpG.Controls.Add(this.txtEmail);
            this.tpG.Controls.Add(this.lblPhone);
            this.tpG.Controls.Add(this.txtPhone);
            this.tpG.Controls.Add(this.lblName);
            this.tpG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpG.Location = new System.Drawing.Point(0, 30);
            this.tpG.Name = "tpG";
            this.tpG.Size = new System.Drawing.Size(505, 321);
            this.tpG.TabIndex = 1;
            this.tpG.TabItem = this.tiG;
            // 
            // cbxStatus
            // 
            this.cbxStatus.DisplayMember = "Text";
            this.cbxStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxStatus.Enabled = false;
            this.cbxStatus.ForeColor = System.Drawing.Color.Black;
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.ItemHeight = 19;
            this.cbxStatus.Items.AddRange(new object[] {
            this.cbxiStatusEn,
            this.cbxiStatusDi,
            this.cbxiStatusBa});
            this.cbxStatus.Location = new System.Drawing.Point(299, 51);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(191, 25);
            this.cbxStatus.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxStatus.TabIndex = 4;
            // 
            // cbxiStatusEn
            // 
            this.cbxiStatusEn.Text = "Enabled";
            this.cbxiStatusEn.Value = "1";
            // 
            // cbxiStatusDi
            // 
            this.cbxiStatusDi.Text = "Disabled";
            this.cbxiStatusDi.Value = "2";
            // 
            // cbxiStatusBa
            // 
            this.cbxiStatusBa.Text = "Banned";
            this.cbxiStatusBa.Value = "3";
            // 
            // cbxGroup
            // 
            this.cbxGroup.DisplayMember = "Text";
            this.cbxGroup.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxGroup.Enabled = false;
            this.cbxGroup.ForeColor = System.Drawing.Color.Black;
            this.cbxGroup.FormattingEnabled = true;
            this.cbxGroup.ItemHeight = 19;
            this.cbxGroup.Items.AddRange(new object[] {
            this.cbxiGroupUser,
            this.cbxiGroupAdmin,
            this.cbxiGroupSuper});
            this.cbxGroup.Location = new System.Drawing.Point(151, 51);
            this.cbxGroup.Name = "cbxGroup";
            this.cbxGroup.Size = new System.Drawing.Size(142, 25);
            this.cbxGroup.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxGroup.TabIndex = 3;
            // 
            // cbxiGroupUser
            // 
            this.cbxiGroupUser.Text = "General User";
            this.cbxiGroupUser.Value = "1";
            // 
            // cbxiGroupAdmin
            // 
            this.cbxiGroupAdmin.Text = "Administrator";
            this.cbxiGroupAdmin.Value = "2";
            // 
            // cbxiGroupSuper
            // 
            this.cbxiGroupSuper.Text = "Super-Admin";
            this.cbxiGroupSuper.Value = "3";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(14, 51);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(131, 23);
            this.labelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.labelX1.TabIndex = 423;
            this.labelX1.Text = "User Group/Status:";
            // 
            // btnPass
            // 
            this.btnPass.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPass.BackColor = System.Drawing.Color.White;
            this.btnPass.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPass.Enabled = false;
            this.btnPass.FocusCuesEnabled = false;
            this.btnPass.Location = new System.Drawing.Point(465, 20);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(25, 25);
            this.btnPass.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPass.TabIndex = 0;
            this.btnPass.TabStop = false;
            this.btnPass.Click += new System.EventHandler(this.btnPass_Click);
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPass.Border.Class = "TextBoxBorder";
            this.txtPass.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPass.DisabledBackColor = System.Drawing.Color.White;
            this.txtPass.Enabled = false;
            this.txtPass.ForeColor = System.Drawing.Color.Black;
            this.txtPass.Location = new System.Drawing.Point(299, 20);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.PreventEnterBeep = true;
            this.txtPass.Size = new System.Drawing.Size(160, 25);
            this.txtPass.TabIndex = 2;
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtUser.Border.Class = "TextBoxBorder";
            this.txtUser.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtUser.DisabledBackColor = System.Drawing.Color.White;
            this.txtUser.Enabled = false;
            this.txtUser.ForeColor = System.Drawing.Color.Black;
            this.txtUser.Location = new System.Drawing.Point(151, 20);
            this.txtUser.Name = "txtUser";
            this.txtUser.PreventEnterBeep = true;
            this.txtUser.Size = new System.Drawing.Size(142, 25);
            this.txtUser.TabIndex = 1;
            // 
            // lblUser
            // 
            this.lblUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblUser.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblUser.ForeColor = System.Drawing.Color.Black;
            this.lblUser.Location = new System.Drawing.Point(14, 20);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(131, 23);
            this.lblUser.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblUser.TabIndex = 420;
            this.lblUser.Text = "Username/Password:";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtAddress.Border.Class = "TextBoxBorder";
            this.txtAddress.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtAddress.DisabledBackColor = System.Drawing.Color.White;
            this.txtAddress.Enabled = false;
            this.txtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.Location = new System.Drawing.Point(151, 215);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PreventEnterBeep = true;
            this.txtAddress.Size = new System.Drawing.Size(339, 87);
            this.txtAddress.TabIndex = 11;
            // 
            // lblAddress
            // 
            this.lblAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblAddress.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblAddress.ForeColor = System.Drawing.Color.Black;
            this.lblAddress.Location = new System.Drawing.Point(14, 215);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(131, 23);
            this.lblAddress.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblAddress.TabIndex = 418;
            this.lblAddress.Text = "Address:";
            // 
            // lblEmail
            // 
            this.lblEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblEmail.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(14, 184);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(131, 23);
            this.lblEmail.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblEmail.TabIndex = 411;
            this.lblEmail.Text = "E-mail Address:";
            // 
            // cbxNameTitle
            // 
            this.cbxNameTitle.DisplayMember = "Text";
            this.cbxNameTitle.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxNameTitle.Enabled = false;
            this.cbxNameTitle.ForeColor = System.Drawing.Color.Black;
            this.cbxNameTitle.FormattingEnabled = true;
            this.cbxNameTitle.ItemHeight = 19;
            this.cbxNameTitle.Items.AddRange(new object[] {
            this.cbxiContactTitleMr,
            this.cbxiContactTitleMrs,
            this.cbxiContactTitleMiss,
            this.cbxiContactTitleMs,
            this.cbxiContactTitleMaster,
            this.cbxiContactTitleDr,
            this.cbxiContactTitleProf,
            this.cbxiContactTitleOfc});
            this.cbxNameTitle.Location = new System.Drawing.Point(299, 91);
            this.cbxNameTitle.Name = "cbxNameTitle";
            this.cbxNameTitle.Size = new System.Drawing.Size(191, 25);
            this.cbxNameTitle.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxNameTitle.TabIndex = 6;
            this.cbxNameTitle.SelectionChangeCommitted += new System.EventHandler(this.cbxNameTitle_SelectionChangeCommitted);
            // 
            // cbxiContactTitleMr
            // 
            this.cbxiContactTitleMr.Text = "Mr";
            this.cbxiContactTitleMr.Value = "Mr";
            // 
            // cbxiContactTitleMrs
            // 
            this.cbxiContactTitleMrs.Text = "Mrs";
            this.cbxiContactTitleMrs.Value = "Mrs";
            // 
            // cbxiContactTitleMiss
            // 
            this.cbxiContactTitleMiss.Text = "Miss";
            this.cbxiContactTitleMiss.Value = "Miss";
            // 
            // cbxiContactTitleMs
            // 
            this.cbxiContactTitleMs.Text = "Ms";
            this.cbxiContactTitleMs.Value = "Ms";
            // 
            // cbxiContactTitleMaster
            // 
            this.cbxiContactTitleMaster.Text = "Master";
            this.cbxiContactTitleMaster.Value = "Master";
            // 
            // cbxiContactTitleDr
            // 
            this.cbxiContactTitleDr.Text = "Doctor (Dr)";
            this.cbxiContactTitleDr.Value = "Dr";
            // 
            // cbxiContactTitleProf
            // 
            this.cbxiContactTitleProf.Text = "Professor (Prof)";
            this.cbxiContactTitleProf.Value = "Prof";
            // 
            // cbxiContactTitleOfc
            // 
            this.cbxiContactTitleOfc.Text = "Office (Ofc)";
            this.cbxiContactTitleOfc.Value = "Ofc";
            // 
            // txtNameTitle
            // 
            this.txtNameTitle.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtNameTitle.Border.Class = "TextBoxBorder";
            this.txtNameTitle.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNameTitle.DisabledBackColor = System.Drawing.Color.White;
            this.txtNameTitle.Enabled = false;
            this.txtNameTitle.ForeColor = System.Drawing.Color.Black;
            this.txtNameTitle.Location = new System.Drawing.Point(151, 91);
            this.txtNameTitle.Name = "txtNameTitle";
            this.txtNameTitle.PreventEnterBeep = true;
            this.txtNameTitle.Size = new System.Drawing.Size(142, 25);
            this.txtNameTitle.TabIndex = 5;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblTitle.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(14, 91);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(131, 23);
            this.lblTitle.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblTitle.TabIndex = 410;
            this.lblTitle.Text = "Name Title:";
            // 
            // txtNameLast
            // 
            this.txtNameLast.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtNameLast.Border.Class = "TextBoxBorder";
            this.txtNameLast.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNameLast.DisabledBackColor = System.Drawing.Color.White;
            this.txtNameLast.Enabled = false;
            this.txtNameLast.ForeColor = System.Drawing.Color.Black;
            this.txtNameLast.Location = new System.Drawing.Point(299, 122);
            this.txtNameLast.Name = "txtNameLast";
            this.txtNameLast.PreventEnterBeep = true;
            this.txtNameLast.Size = new System.Drawing.Size(191, 25);
            this.txtNameLast.TabIndex = 8;
            // 
            // txtNameFirst
            // 
            this.txtNameFirst.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtNameFirst.Border.Class = "TextBoxBorder";
            this.txtNameFirst.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNameFirst.DisabledBackColor = System.Drawing.Color.White;
            this.txtNameFirst.Enabled = false;
            this.txtNameFirst.ForeColor = System.Drawing.Color.Black;
            this.txtNameFirst.Location = new System.Drawing.Point(151, 122);
            this.txtNameFirst.Name = "txtNameFirst";
            this.txtNameFirst.PreventEnterBeep = true;
            this.txtNameFirst.Size = new System.Drawing.Size(142, 25);
            this.txtNameFirst.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtEmail.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtEmail.Border.Class = "TextBoxBorder";
            this.txtEmail.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtEmail.DisabledBackColor = System.Drawing.Color.White;
            this.txtEmail.Enabled = false;
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(151, 184);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PreventEnterBeep = true;
            this.txtEmail.Size = new System.Drawing.Size(339, 25);
            this.txtEmail.TabIndex = 10;
            // 
            // lblPhone
            // 
            this.lblPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblPhone.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblPhone.ForeColor = System.Drawing.Color.Black;
            this.lblPhone.Location = new System.Drawing.Point(14, 153);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(131, 23);
            this.lblPhone.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblPhone.TabIndex = 409;
            this.lblPhone.Text = "Phone Number:";
            // 
            // txtPhone
            // 
            this.txtPhone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtPhone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtPhone.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPhone.Border.Class = "TextBoxBorder";
            this.txtPhone.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPhone.DisabledBackColor = System.Drawing.Color.White;
            this.txtPhone.Enabled = false;
            this.txtPhone.ForeColor = System.Drawing.Color.Black;
            this.txtPhone.Location = new System.Drawing.Point(151, 153);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PreventEnterBeep = true;
            this.txtPhone.Size = new System.Drawing.Size(142, 25);
            this.txtPhone.TabIndex = 9;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(14, 122);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(131, 23);
            this.lblName.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblName.TabIndex = 408;
            this.lblName.Text = "Name First/Last:";
            // 
            // tiG
            // 
            this.tiG.AttachedControl = this.tpG;
            this.tiG.GlobalItem = false;
            this.tiG.Name = "tiG";
            this.tiG.Text = "  General";
            // 
            // tpN
            // 
            this.tpN.Controls.Add(this.txtNotes);
            this.tpN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpN.Location = new System.Drawing.Point(0, 30);
            this.tpN.Name = "tpN";
            this.tpN.Size = new System.Drawing.Size(505, 321);
            this.tpN.TabIndex = 0;
            this.tpN.TabItem = this.tiN;
            // 
            // txtNotes
            // 
            this.txtNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNotes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtNotes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNotes.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtNotes.Border.Class = "TextBoxBorder";
            this.txtNotes.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNotes.DisabledBackColor = System.Drawing.Color.White;
            this.txtNotes.Enabled = false;
            this.txtNotes.ForeColor = System.Drawing.Color.Black;
            this.txtNotes.Location = new System.Drawing.Point(15, 15);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.PreventEnterBeep = true;
            this.txtNotes.Size = new System.Drawing.Size(475, 291);
            this.txtNotes.TabIndex = 12;
            // 
            // tiN
            // 
            this.tiN.AttachedControl = this.tpN;
            this.tiN.GlobalItem = false;
            this.tiN.Name = "tiN";
            this.tiN.Text = "  Notes";
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(715, 375);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(68, 34);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(278, 375);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(68, 34);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmUsers
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CaptionFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ClientSize = new System.Drawing.Size(795, 421);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.sc);
            this.Controls.Add(this.tv);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUsers";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "User Management";
            this.m.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sc)).EndInit();
            this.sc.ResumeLayout(false);
            this.tpG.ResumeLayout(false);
            this.tpN.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tv;
        private DevComponents.DotNetBar.SuperTabControl sc;
        private DevComponents.DotNetBar.SuperTabControlPanel tpG;
        private DevComponents.DotNetBar.SuperTabItem tiG;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.SuperTabControlPanel tpN;
        private DevComponents.DotNetBar.SuperTabItem tiN;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNotes;
        private DevComponents.DotNetBar.LabelX lblEmail;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxNameTitle;
        private DevComponents.Editors.ComboItem cbxiContactTitleMr;
        private DevComponents.Editors.ComboItem cbxiContactTitleMrs;
        private DevComponents.Editors.ComboItem cbxiContactTitleMiss;
        private DevComponents.Editors.ComboItem cbxiContactTitleMs;
        private DevComponents.Editors.ComboItem cbxiContactTitleMaster;
        private DevComponents.Editors.ComboItem cbxiContactTitleDr;
        private DevComponents.Editors.ComboItem cbxiContactTitleProf;
        private DevComponents.Editors.ComboItem cbxiContactTitleOfc;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNameTitle;
        private DevComponents.DotNetBar.LabelX lblTitle;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNameLast;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNameFirst;
        private DevComponents.DotNetBar.Controls.TextBoxX txtEmail;
        private DevComponents.DotNetBar.LabelX lblPhone;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPhone;
        private DevComponents.DotNetBar.LabelX lblName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAddress;
        private DevComponents.DotNetBar.LabelX lblAddress;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPass;
        private DevComponents.DotNetBar.Controls.TextBoxX txtUser;
        private DevComponents.DotNetBar.LabelX lblUser;
        private DevComponents.DotNetBar.ButtonX btnPass;
        private System.Windows.Forms.ContextMenuStrip m;
        private System.Windows.Forms.ToolStripMenuItem mUserAdd;
        private System.Windows.Forms.ToolStripMenuItem mUserRemove;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxStatus;
        private DevComponents.Editors.ComboItem cbxiStatusEn;
        private DevComponents.Editors.ComboItem cbxiStatusDi;
        private DevComponents.Editors.ComboItem cbxiStatusBa;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxGroup;
        private DevComponents.Editors.ComboItem cbxiGroupUser;
        private DevComponents.Editors.ComboItem cbxiGroupAdmin;
        private DevComponents.Editors.ComboItem cbxiGroupSuper;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}