namespace Client
{
    partial class frmBooking
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
            this.sm = new DevComponents.DotNetBar.StyleManager(this.components);
            this.tc = new DevComponents.DotNetBar.SuperTabControl();
            this.tpContact = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.tvRooms = new System.Windows.Forms.TreeView();
            this.txtContact = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtCompany = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnContacts = new DevComponents.DotNetBar.ButtonX();
            this.btnCompanies = new DevComponents.DotNetBar.ButtonX();
            this.txtLayout = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblLayout = new DevComponents.DotNetBar.LabelX();
            this.lblRooms = new DevComponents.DotNetBar.LabelX();
            this.txtEmail = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblPhone = new DevComponents.DotNetBar.LabelX();
            this.txtPhone = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblContact = new DevComponents.DotNetBar.LabelX();
            this.lblCompany = new DevComponents.DotNetBar.LabelX();
            this.tiContact = new DevComponents.DotNetBar.SuperTabItem();
            this.tpEvent = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.lblDelegates = new DevComponents.DotNetBar.LabelX();
            this.cbxDelegates = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.dtTimeAccessTo = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.lblTimeAcessTo = new DevComponents.DotNetBar.LabelX();
            this.dtTimeAccessFrom = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.lblTimeAccess = new DevComponents.DotNetBar.LabelX();
            this.lblName = new DevComponents.DotNetBar.LabelX();
            this.txtName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dtTimeTo = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.lblTimeTo = new DevComponents.DotNetBar.LabelX();
            this.dtTimeFrom = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dtDateTo = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.lblDateTo = new DevComponents.DotNetBar.LabelX();
            this.dtDateFrom = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.lblDatesTimes = new DevComponents.DotNetBar.LabelX();
            this.tiEvent = new DevComponents.DotNetBar.SuperTabItem();
            this.tpRequirements = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.txtLunchDiet = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblLunchDiet = new DevComponents.DotNetBar.LabelX();
            this.lblLunchTime = new DevComponents.DotNetBar.LabelX();
            this.dtLunchTime = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.lblLunchAttendees = new DevComponents.DotNetBar.LabelX();
            this.cbxLunchAttendees = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtLunchMenu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblLunchMenu = new DevComponents.DotNetBar.LabelX();
            this.txtRefreshmentTimes = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblRefTimes = new DevComponents.DotNetBar.LabelX();
            this.lblLunch = new DevComponents.DotNetBar.LabelX();
            this.swLunch = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.lblRefreshments = new DevComponents.DotNetBar.LabelX();
            this.swRefreshments = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.txtEquipment = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblEquipment = new DevComponents.DotNetBar.LabelX();
            this.tiRequirements = new DevComponents.DotNetBar.SuperTabItem();
            this.tpComments = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.btnCommentSave = new DevComponents.DotNetBar.ButtonX();
            this.btnCommentCancel = new DevComponents.DotNetBar.ButtonX();
            this.gComments = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.mComments = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mCommentsAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.gCommentsAdded = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gCommentsBy = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gCommentsComment = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.txtComment = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tiComments = new DevComponents.DotNetBar.SuperTabItem();
            this.tpInvoicing = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.lblInvoicingPO = new DevComponents.DotNetBar.LabelX();
            this.txtPurchaseOrder = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblInvoicingMethod = new DevComponents.DotNetBar.LabelX();
            this.cbxPaymentMethod = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbxiBacs = new DevComponents.Editors.ComboItem();
            this.cbxiCash = new DevComponents.Editors.ComboItem();
            this.cbxiCheque = new DevComponents.Editors.ComboItem();
            this.cbxiCard = new DevComponents.Editors.ComboItem();
            this.txtInvoiceAddress = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblInvoicingAddress = new DevComponents.DotNetBar.LabelX();
            this.tiInvoicing = new DevComponents.DotNetBar.SuperTabItem();
            this.tpDocuments = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.lblFileAccessedVal = new DevComponents.DotNetBar.LabelX();
            this.lblFileAccessed = new DevComponents.DotNetBar.LabelX();
            this.lblFileModifiedVal = new DevComponents.DotNetBar.LabelX();
            this.lblFileModified = new DevComponents.DotNetBar.LabelX();
            this.lblFileSizeVal = new DevComponents.DotNetBar.LabelX();
            this.lblFileSize = new DevComponents.DotNetBar.LabelX();
            this.lblFileLocationVal = new DevComponents.DotNetBar.LabelX();
            this.lblFileLocation = new DevComponents.DotNetBar.LabelX();
            this.lblFileNameVal = new DevComponents.DotNetBar.LabelX();
            this.lblFileName = new DevComponents.DotNetBar.LabelX();
            this.lvDocuments = new System.Windows.Forms.ListView();
            this.chFilename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDocumentAdd = new DevComponents.DotNetBar.ButtonX();
            this.tiDocuments = new DevComponents.DotNetBar.SuperTabItem();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.lblUsers = new DevComponents.DotNetBar.LabelX();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.tc)).BeginInit();
            this.tc.SuspendLayout();
            this.tpContact.SuspendLayout();
            this.tpEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtTimeAccessTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTimeAccessFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTimeTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTimeFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDateTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDateFrom)).BeginInit();
            this.tpRequirements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtLunchTime)).BeginInit();
            this.tpComments.SuspendLayout();
            this.mComments.SuspendLayout();
            this.tpInvoicing.SuspendLayout();
            this.tpDocuments.SuspendLayout();
            this.SuspendLayout();
            // 
            // sm
            // 
            this.sm.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2016;
            this.sm.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // tc
            // 
            this.tc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tc.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.tc.ControlBox.MenuBox.Name = "";
            this.tc.ControlBox.Name = "";
            this.tc.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.tc.ControlBox.MenuBox,
            this.tc.ControlBox.CloseBox});
            this.tc.ControlBox.Visible = false;
            this.tc.Controls.Add(this.tpContact);
            this.tc.Controls.Add(this.tpEvent);
            this.tc.Controls.Add(this.tpRequirements);
            this.tc.Controls.Add(this.tpComments);
            this.tc.Controls.Add(this.tpInvoicing);
            this.tc.Controls.Add(this.tpDocuments);
            this.tc.ForeColor = System.Drawing.Color.Black;
            this.tc.Location = new System.Drawing.Point(12, 19);
            this.tc.Name = "tc";
            this.tc.ReorderTabsEnabled = false;
            this.tc.SelectedTabFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.tc.SelectedTabIndex = 0;
            this.tc.Size = new System.Drawing.Size(616, 360);
            this.tc.TabFont = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tc.TabIndex = 1;
            this.tc.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.tiContact,
            this.tiEvent,
            this.tiRequirements,
            this.tiComments,
            this.tiInvoicing,
            this.tiDocuments});
            this.tc.TabStop = false;
            this.tc.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.VisualStudio2008Dock;
            // 
            // tpContact
            // 
            this.tpContact.Controls.Add(this.tvRooms);
            this.tpContact.Controls.Add(this.txtContact);
            this.tpContact.Controls.Add(this.txtCompany);
            this.tpContact.Controls.Add(this.btnContacts);
            this.tpContact.Controls.Add(this.btnCompanies);
            this.tpContact.Controls.Add(this.txtLayout);
            this.tpContact.Controls.Add(this.lblLayout);
            this.tpContact.Controls.Add(this.lblRooms);
            this.tpContact.Controls.Add(this.txtEmail);
            this.tpContact.Controls.Add(this.lblPhone);
            this.tpContact.Controls.Add(this.txtPhone);
            this.tpContact.Controls.Add(this.lblContact);
            this.tpContact.Controls.Add(this.lblCompany);
            this.tpContact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpContact.Location = new System.Drawing.Point(0, 30);
            this.tpContact.Name = "tpContact";
            this.tpContact.Size = new System.Drawing.Size(616, 330);
            this.tpContact.TabIndex = 1;
            this.tpContact.TabItem = this.tiContact;
            // 
            // tvRooms
            // 
            this.tvRooms.BackColor = System.Drawing.Color.White;
            this.tvRooms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tvRooms.CheckBoxes = true;
            this.tvRooms.ForeColor = System.Drawing.Color.Black;
            this.tvRooms.FullRowSelect = true;
            this.tvRooms.HideSelection = false;
            this.tvRooms.Location = new System.Drawing.Point(14, 144);
            this.tvRooms.Name = "tvRooms";
            this.tvRooms.Size = new System.Drawing.Size(291, 171);
            this.tvRooms.TabIndex = 17;
            this.tvRooms.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvRooms_AfterCheck);
            // 
            // txtContact
            // 
            this.txtContact.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtContact.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtContact.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtContact.Border.Class = "TextBoxBorder";
            this.txtContact.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtContact.DisabledBackColor = System.Drawing.Color.White;
            this.txtContact.ForeColor = System.Drawing.Color.Black;
            this.txtContact.Location = new System.Drawing.Point(140, 49);
            this.txtContact.Name = "txtContact";
            this.txtContact.PreventEnterBeep = true;
            this.txtContact.Size = new System.Drawing.Size(431, 25);
            this.txtContact.TabIndex = 16;
            // 
            // txtCompany
            // 
            this.txtCompany.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCompany.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCompany.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtCompany.Border.Class = "TextBoxBorder";
            this.txtCompany.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCompany.DisabledBackColor = System.Drawing.Color.White;
            this.txtCompany.ForeColor = System.Drawing.Color.Black;
            this.txtCompany.Location = new System.Drawing.Point(140, 18);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.PreventEnterBeep = true;
            this.txtCompany.Size = new System.Drawing.Size(431, 25);
            this.txtCompany.TabIndex = 15;
            this.txtCompany.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCompany_KeyDown);
            // 
            // btnContacts
            // 
            this.btnContacts.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnContacts.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnContacts.Location = new System.Drawing.Point(577, 49);
            this.btnContacts.Name = "btnContacts";
            this.btnContacts.Size = new System.Drawing.Size(25, 25);
            this.btnContacts.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnContacts.TabIndex = 14;
            this.btnContacts.Click += new System.EventHandler(this.btnContacts_Click);
            // 
            // btnCompanies
            // 
            this.btnCompanies.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCompanies.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCompanies.Location = new System.Drawing.Point(577, 18);
            this.btnCompanies.Name = "btnCompanies";
            this.btnCompanies.Size = new System.Drawing.Size(25, 25);
            this.btnCompanies.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCompanies.TabIndex = 13;
            this.btnCompanies.Click += new System.EventHandler(this.btnCompanies_Click);
            // 
            // txtLayout
            // 
            this.txtLayout.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtLayout.Border.Class = "TextBoxBorder";
            this.txtLayout.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtLayout.DisabledBackColor = System.Drawing.Color.White;
            this.txtLayout.ForeColor = System.Drawing.Color.Black;
            this.txtLayout.Location = new System.Drawing.Point(311, 144);
            this.txtLayout.Multiline = true;
            this.txtLayout.Name = "txtLayout";
            this.txtLayout.PreventEnterBeep = true;
            this.txtLayout.Size = new System.Drawing.Size(291, 171);
            this.txtLayout.TabIndex = 11;
            // 
            // lblLayout
            // 
            this.lblLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblLayout.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblLayout.ForeColor = System.Drawing.Color.Black;
            this.lblLayout.Location = new System.Drawing.Point(311, 119);
            this.lblLayout.Name = "lblLayout";
            this.lblLayout.Size = new System.Drawing.Size(120, 23);
            this.lblLayout.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblLayout.TabIndex = 10;
            this.lblLayout.Text = "Room Layout:";
            // 
            // lblRooms
            // 
            this.lblRooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblRooms.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblRooms.ForeColor = System.Drawing.Color.Black;
            this.lblRooms.Location = new System.Drawing.Point(14, 119);
            this.lblRooms.Name = "lblRooms";
            this.lblRooms.Size = new System.Drawing.Size(120, 23);
            this.lblRooms.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblRooms.TabIndex = 8;
            this.lblRooms.Text = "Room(s) Booked:";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtEmail.Border.Class = "TextBoxBorder";
            this.txtEmail.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtEmail.DisabledBackColor = System.Drawing.Color.White;
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(288, 80);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PreventEnterBeep = true;
            this.txtEmail.Size = new System.Drawing.Size(314, 25);
            this.txtEmail.TabIndex = 6;
            // 
            // lblPhone
            // 
            this.lblPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblPhone.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblPhone.ForeColor = System.Drawing.Color.Black;
            this.lblPhone.Location = new System.Drawing.Point(14, 80);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(120, 23);
            this.lblPhone.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "Phone/E-mail:";
            // 
            // txtPhone
            // 
            this.txtPhone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtPhone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtPhone.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPhone.Border.Class = "TextBoxBorder";
            this.txtPhone.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPhone.DisabledBackColor = System.Drawing.Color.White;
            this.txtPhone.ForeColor = System.Drawing.Color.Black;
            this.txtPhone.Location = new System.Drawing.Point(140, 80);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PreventEnterBeep = true;
            this.txtPhone.Size = new System.Drawing.Size(142, 25);
            this.txtPhone.TabIndex = 4;
            // 
            // lblContact
            // 
            this.lblContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblContact.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblContact.ForeColor = System.Drawing.Color.Black;
            this.lblContact.Location = new System.Drawing.Point(14, 49);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(120, 23);
            this.lblContact.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblContact.TabIndex = 2;
            this.lblContact.Text = "Primary Contact:";
            // 
            // lblCompany
            // 
            this.lblCompany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblCompany.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCompany.ForeColor = System.Drawing.Color.Black;
            this.lblCompany.Location = new System.Drawing.Point(14, 18);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(120, 23);
            this.lblCompany.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblCompany.TabIndex = 0;
            this.lblCompany.Text = "Company:";
            // 
            // tiContact
            // 
            this.tiContact.AttachedControl = this.tpContact;
            this.tiContact.GlobalItem = false;
            this.tiContact.Name = "tiContact";
            this.tiContact.Text = "  Contact/Room";
            // 
            // tpEvent
            // 
            this.tpEvent.Controls.Add(this.lblDelegates);
            this.tpEvent.Controls.Add(this.cbxDelegates);
            this.tpEvent.Controls.Add(this.dtTimeAccessTo);
            this.tpEvent.Controls.Add(this.lblTimeAcessTo);
            this.tpEvent.Controls.Add(this.dtTimeAccessFrom);
            this.tpEvent.Controls.Add(this.lblTimeAccess);
            this.tpEvent.Controls.Add(this.lblName);
            this.tpEvent.Controls.Add(this.txtName);
            this.tpEvent.Controls.Add(this.dtTimeTo);
            this.tpEvent.Controls.Add(this.lblTimeTo);
            this.tpEvent.Controls.Add(this.dtTimeFrom);
            this.tpEvent.Controls.Add(this.dtDateTo);
            this.tpEvent.Controls.Add(this.lblDateTo);
            this.tpEvent.Controls.Add(this.dtDateFrom);
            this.tpEvent.Controls.Add(this.lblDatesTimes);
            this.tpEvent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpEvent.Location = new System.Drawing.Point(0, 30);
            this.tpEvent.Name = "tpEvent";
            this.tpEvent.Size = new System.Drawing.Size(616, 330);
            this.tpEvent.TabIndex = 0;
            this.tpEvent.TabItem = this.tiEvent;
            // 
            // lblDelegates
            // 
            this.lblDelegates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblDelegates.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDelegates.ForeColor = System.Drawing.Color.Black;
            this.lblDelegates.Location = new System.Drawing.Point(14, 121);
            this.lblDelegates.Name = "lblDelegates";
            this.lblDelegates.Size = new System.Drawing.Size(120, 23);
            this.lblDelegates.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblDelegates.TabIndex = 19;
            this.lblDelegates.Text = "No.. of Delegates:";
            // 
            // cbxDelegates
            // 
            this.cbxDelegates.DisplayMember = "Text";
            this.cbxDelegates.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxDelegates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDelegates.ForeColor = System.Drawing.Color.Black;
            this.cbxDelegates.FormattingEnabled = true;
            this.cbxDelegates.ItemHeight = 19;
            this.cbxDelegates.Location = new System.Drawing.Point(140, 121);
            this.cbxDelegates.Name = "cbxDelegates";
            this.cbxDelegates.Size = new System.Drawing.Size(102, 25);
            this.cbxDelegates.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxDelegates.TabIndex = 18;
            // 
            // dtTimeAccessTo
            // 
            this.dtTimeAccessTo.AllowEmptyState = false;
            this.dtTimeAccessTo.AutoAdvance = true;
            this.dtTimeAccessTo.AutoSelectDate = true;
            this.dtTimeAccessTo.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.dtTimeAccessTo.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtTimeAccessTo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtTimeAccessTo.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtTimeAccessTo.ButtonDropDown.Visible = true;
            this.dtTimeAccessTo.ButtonFreeText.Checked = true;
            this.dtTimeAccessTo.CustomFormat = "HH:mm";
            this.dtTimeAccessTo.DateTimeSelectorVisibility = DevComponents.Editors.DateTimeAdv.eDateTimeSelectorVisibility.TimeSelector;
            this.dtTimeAccessTo.DefaultInputValues = false;
            this.dtTimeAccessTo.ForeColor = System.Drawing.Color.Black;
            this.dtTimeAccessTo.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.dtTimeAccessTo.FreeTextEntryMode = true;
            this.dtTimeAccessTo.IsPopupCalendarOpen = false;
            this.dtTimeAccessTo.Location = new System.Drawing.Point(501, 49);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dtTimeAccessTo.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtTimeAccessTo.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtTimeAccessTo.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtTimeAccessTo.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtTimeAccessTo.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtTimeAccessTo.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtTimeAccessTo.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtTimeAccessTo.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtTimeAccessTo.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtTimeAccessTo.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtTimeAccessTo.MonthCalendar.DisplayMonth = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.dtTimeAccessTo.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.dtTimeAccessTo.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtTimeAccessTo.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtTimeAccessTo.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtTimeAccessTo.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtTimeAccessTo.MonthCalendar.TodayButtonVisible = true;
            this.dtTimeAccessTo.MonthCalendar.Visible = false;
            this.dtTimeAccessTo.Name = "dtTimeAccessTo";
            this.dtTimeAccessTo.Size = new System.Drawing.Size(69, 25);
            this.dtTimeAccessTo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtTimeAccessTo.TabIndex = 17;
            this.dtTimeAccessTo.TimeSelectorTimeFormat = DevComponents.Editors.DateTimeAdv.eTimeSelectorFormat.Time24H;
            // 
            // lblTimeAcessTo
            // 
            this.lblTimeAcessTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblTimeAcessTo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTimeAcessTo.ForeColor = System.Drawing.Color.Black;
            this.lblTimeAcessTo.Location = new System.Drawing.Point(475, 49);
            this.lblTimeAcessTo.Name = "lblTimeAcessTo";
            this.lblTimeAcessTo.Size = new System.Drawing.Size(20, 23);
            this.lblTimeAcessTo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblTimeAcessTo.TabIndex = 16;
            this.lblTimeAcessTo.Text = "to";
            this.lblTimeAcessTo.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // dtTimeAccessFrom
            // 
            this.dtTimeAccessFrom.AllowEmptyState = false;
            this.dtTimeAccessFrom.AutoAdvance = true;
            this.dtTimeAccessFrom.AutoSelectDate = true;
            this.dtTimeAccessFrom.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.dtTimeAccessFrom.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtTimeAccessFrom.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtTimeAccessFrom.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtTimeAccessFrom.ButtonDropDown.Visible = true;
            this.dtTimeAccessFrom.ButtonFreeText.Checked = true;
            this.dtTimeAccessFrom.CustomFormat = "HH:mm";
            this.dtTimeAccessFrom.DateTimeSelectorVisibility = DevComponents.Editors.DateTimeAdv.eDateTimeSelectorVisibility.TimeSelector;
            this.dtTimeAccessFrom.DefaultInputValues = false;
            this.dtTimeAccessFrom.ForeColor = System.Drawing.Color.Black;
            this.dtTimeAccessFrom.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.dtTimeAccessFrom.FreeTextEntryMode = true;
            this.dtTimeAccessFrom.IsPopupCalendarOpen = false;
            this.dtTimeAccessFrom.Location = new System.Drawing.Point(400, 49);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dtTimeAccessFrom.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtTimeAccessFrom.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtTimeAccessFrom.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtTimeAccessFrom.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtTimeAccessFrom.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtTimeAccessFrom.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtTimeAccessFrom.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtTimeAccessFrom.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtTimeAccessFrom.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtTimeAccessFrom.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtTimeAccessFrom.MonthCalendar.DisplayMonth = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.dtTimeAccessFrom.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.dtTimeAccessFrom.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtTimeAccessFrom.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtTimeAccessFrom.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtTimeAccessFrom.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtTimeAccessFrom.MonthCalendar.TodayButtonVisible = true;
            this.dtTimeAccessFrom.MonthCalendar.Visible = false;
            this.dtTimeAccessFrom.Name = "dtTimeAccessFrom";
            this.dtTimeAccessFrom.Size = new System.Drawing.Size(69, 25);
            this.dtTimeAccessFrom.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtTimeAccessFrom.TabIndex = 15;
            this.dtTimeAccessFrom.TimeSelectorTimeFormat = DevComponents.Editors.DateTimeAdv.eTimeSelectorFormat.Time24H;
            // 
            // lblTimeAccess
            // 
            this.lblTimeAccess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblTimeAccess.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTimeAccess.ForeColor = System.Drawing.Color.Black;
            this.lblTimeAccess.Location = new System.Drawing.Point(261, 49);
            this.lblTimeAccess.Name = "lblTimeAccess";
            this.lblTimeAccess.Size = new System.Drawing.Size(115, 23);
            this.lblTimeAccess.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblTimeAccess.TabIndex = 14;
            this.lblTimeAccess.Text = "Access Times:";
            this.lblTimeAccess.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(14, 89);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(120, 23);
            this.lblName.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblName.TabIndex = 13;
            this.lblName.Text = "Event Name:";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtName.Border.Class = "TextBoxBorder";
            this.txtName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtName.DisabledBackColor = System.Drawing.Color.White;
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(140, 89);
            this.txtName.Name = "txtName";
            this.txtName.PreventEnterBeep = true;
            this.txtName.Size = new System.Drawing.Size(430, 25);
            this.txtName.TabIndex = 12;
            // 
            // dtTimeTo
            // 
            this.dtTimeTo.AllowEmptyState = false;
            this.dtTimeTo.AutoAdvance = true;
            this.dtTimeTo.AutoSelectDate = true;
            this.dtTimeTo.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.dtTimeTo.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtTimeTo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtTimeTo.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtTimeTo.ButtonDropDown.Visible = true;
            this.dtTimeTo.ButtonFreeText.Checked = true;
            this.dtTimeTo.CustomFormat = "HH:mm";
            this.dtTimeTo.DateTimeSelectorVisibility = DevComponents.Editors.DateTimeAdv.eDateTimeSelectorVisibility.TimeSelector;
            this.dtTimeTo.ForeColor = System.Drawing.Color.Black;
            this.dtTimeTo.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.dtTimeTo.FreeTextEntryMode = true;
            this.dtTimeTo.IsPopupCalendarOpen = false;
            this.dtTimeTo.Location = new System.Drawing.Point(501, 18);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dtTimeTo.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtTimeTo.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtTimeTo.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtTimeTo.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtTimeTo.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtTimeTo.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtTimeTo.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtTimeTo.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtTimeTo.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtTimeTo.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtTimeTo.MonthCalendar.DisplayMonth = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.dtTimeTo.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.dtTimeTo.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtTimeTo.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtTimeTo.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtTimeTo.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtTimeTo.MonthCalendar.TodayButtonVisible = true;
            this.dtTimeTo.MonthCalendar.Visible = false;
            this.dtTimeTo.Name = "dtTimeTo";
            this.dtTimeTo.Size = new System.Drawing.Size(69, 25);
            this.dtTimeTo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtTimeTo.TabIndex = 11;
            this.dtTimeTo.TimeSelectorTimeFormat = DevComponents.Editors.DateTimeAdv.eTimeSelectorFormat.Time24H;
            // 
            // lblTimeTo
            // 
            this.lblTimeTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblTimeTo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTimeTo.ForeColor = System.Drawing.Color.Black;
            this.lblTimeTo.Location = new System.Drawing.Point(475, 18);
            this.lblTimeTo.Name = "lblTimeTo";
            this.lblTimeTo.Size = new System.Drawing.Size(20, 23);
            this.lblTimeTo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblTimeTo.TabIndex = 10;
            this.lblTimeTo.Text = "to";
            this.lblTimeTo.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // dtTimeFrom
            // 
            this.dtTimeFrom.AllowEmptyState = false;
            this.dtTimeFrom.AutoAdvance = true;
            this.dtTimeFrom.AutoSelectDate = true;
            this.dtTimeFrom.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.dtTimeFrom.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtTimeFrom.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtTimeFrom.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtTimeFrom.ButtonDropDown.Visible = true;
            this.dtTimeFrom.ButtonFreeText.Checked = true;
            this.dtTimeFrom.CustomFormat = "HH:mm";
            this.dtTimeFrom.DateTimeSelectorVisibility = DevComponents.Editors.DateTimeAdv.eDateTimeSelectorVisibility.TimeSelector;
            this.dtTimeFrom.ForeColor = System.Drawing.Color.Black;
            this.dtTimeFrom.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.dtTimeFrom.FreeTextEntryMode = true;
            this.dtTimeFrom.IsPopupCalendarOpen = false;
            this.dtTimeFrom.Location = new System.Drawing.Point(400, 18);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dtTimeFrom.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtTimeFrom.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtTimeFrom.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtTimeFrom.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtTimeFrom.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtTimeFrom.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtTimeFrom.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtTimeFrom.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtTimeFrom.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtTimeFrom.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtTimeFrom.MonthCalendar.DisplayMonth = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.dtTimeFrom.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.dtTimeFrom.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtTimeFrom.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtTimeFrom.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtTimeFrom.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtTimeFrom.MonthCalendar.TodayButtonVisible = true;
            this.dtTimeFrom.MonthCalendar.Visible = false;
            this.dtTimeFrom.Name = "dtTimeFrom";
            this.dtTimeFrom.Size = new System.Drawing.Size(69, 25);
            this.dtTimeFrom.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtTimeFrom.TabIndex = 9;
            this.dtTimeFrom.TimeSelectorTimeFormat = DevComponents.Editors.DateTimeAdv.eTimeSelectorFormat.Time24H;
            // 
            // dtDateTo
            // 
            this.dtDateTo.AllowEmptyState = false;
            this.dtDateTo.AutoAdvance = true;
            this.dtDateTo.AutoSelectDate = true;
            this.dtDateTo.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.dtDateTo.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtDateTo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtDateTo.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtDateTo.ButtonDropDown.Visible = true;
            this.dtDateTo.CustomFormat = "dd/MM/yyyy";
            this.dtDateTo.DateTimeSelectorVisibility = DevComponents.Editors.DateTimeAdv.eDateTimeSelectorVisibility.DateSelector;
            this.dtDateTo.ForeColor = System.Drawing.Color.Black;
            this.dtDateTo.IsPopupCalendarOpen = false;
            this.dtDateTo.Location = new System.Drawing.Point(274, 18);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dtDateTo.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtDateTo.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtDateTo.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtDateTo.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtDateTo.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtDateTo.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtDateTo.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtDateTo.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtDateTo.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtDateTo.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtDateTo.MonthCalendar.DisplayMonth = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.dtDateTo.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.dtDateTo.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtDateTo.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtDateTo.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtDateTo.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtDateTo.MonthCalendar.TodayButtonVisible = true;
            this.dtDateTo.Name = "dtDateTo";
            this.dtDateTo.Size = new System.Drawing.Size(102, 25);
            this.dtDateTo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtDateTo.TabIndex = 8;
            // 
            // lblDateTo
            // 
            this.lblDateTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblDateTo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDateTo.ForeColor = System.Drawing.Color.Black;
            this.lblDateTo.Location = new System.Drawing.Point(248, 18);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(20, 23);
            this.lblDateTo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblDateTo.TabIndex = 7;
            this.lblDateTo.Text = "to";
            this.lblDateTo.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // dtDateFrom
            // 
            this.dtDateFrom.AllowEmptyState = false;
            this.dtDateFrom.AutoAdvance = true;
            this.dtDateFrom.AutoSelectDate = true;
            this.dtDateFrom.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.dtDateFrom.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtDateFrom.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtDateFrom.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtDateFrom.ButtonDropDown.Visible = true;
            this.dtDateFrom.CustomFormat = "dd/MM/yyyy";
            this.dtDateFrom.DateTimeSelectorVisibility = DevComponents.Editors.DateTimeAdv.eDateTimeSelectorVisibility.DateSelector;
            this.dtDateFrom.ForeColor = System.Drawing.Color.Black;
            this.dtDateFrom.IsPopupCalendarOpen = false;
            this.dtDateFrom.Location = new System.Drawing.Point(140, 18);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dtDateFrom.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtDateFrom.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtDateFrom.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtDateFrom.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtDateFrom.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtDateFrom.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtDateFrom.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtDateFrom.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtDateFrom.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtDateFrom.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtDateFrom.MonthCalendar.DisplayMonth = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.dtDateFrom.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.dtDateFrom.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtDateFrom.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtDateFrom.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtDateFrom.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtDateFrom.MonthCalendar.TodayButtonVisible = true;
            this.dtDateFrom.Name = "dtDateFrom";
            this.dtDateFrom.Size = new System.Drawing.Size(102, 25);
            this.dtDateFrom.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtDateFrom.TabIndex = 6;
            this.dtDateFrom.ValueChanged += new System.EventHandler(this.dtDateFrom_ValueChanged);
            // 
            // lblDatesTimes
            // 
            this.lblDatesTimes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblDatesTimes.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDatesTimes.ForeColor = System.Drawing.Color.Black;
            this.lblDatesTimes.Location = new System.Drawing.Point(14, 18);
            this.lblDatesTimes.Name = "lblDatesTimes";
            this.lblDatesTimes.Size = new System.Drawing.Size(120, 23);
            this.lblDatesTimes.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblDatesTimes.TabIndex = 1;
            this.lblDatesTimes.Text = "Dates and Times:";
            // 
            // tiEvent
            // 
            this.tiEvent.AttachedControl = this.tpEvent;
            this.tiEvent.GlobalItem = false;
            this.tiEvent.Name = "tiEvent";
            this.tiEvent.Text = "  Event";
            // 
            // tpRequirements
            // 
            this.tpRequirements.Controls.Add(this.txtLunchDiet);
            this.tpRequirements.Controls.Add(this.lblLunchDiet);
            this.tpRequirements.Controls.Add(this.lblLunchTime);
            this.tpRequirements.Controls.Add(this.dtLunchTime);
            this.tpRequirements.Controls.Add(this.lblLunchAttendees);
            this.tpRequirements.Controls.Add(this.cbxLunchAttendees);
            this.tpRequirements.Controls.Add(this.txtLunchMenu);
            this.tpRequirements.Controls.Add(this.lblLunchMenu);
            this.tpRequirements.Controls.Add(this.txtRefreshmentTimes);
            this.tpRequirements.Controls.Add(this.lblRefTimes);
            this.tpRequirements.Controls.Add(this.lblLunch);
            this.tpRequirements.Controls.Add(this.swLunch);
            this.tpRequirements.Controls.Add(this.lblRefreshments);
            this.tpRequirements.Controls.Add(this.swRefreshments);
            this.tpRequirements.Controls.Add(this.txtEquipment);
            this.tpRequirements.Controls.Add(this.lblEquipment);
            this.tpRequirements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpRequirements.Location = new System.Drawing.Point(0, 30);
            this.tpRequirements.Name = "tpRequirements";
            this.tpRequirements.Size = new System.Drawing.Size(616, 330);
            this.tpRequirements.TabIndex = 0;
            this.tpRequirements.TabItem = this.tiRequirements;
            // 
            // txtLunchDiet
            // 
            this.txtLunchDiet.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtLunchDiet.Border.Class = "TextBoxBorder";
            this.txtLunchDiet.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtLunchDiet.DisabledBackColor = System.Drawing.Color.White;
            this.txtLunchDiet.ForeColor = System.Drawing.Color.Black;
            this.txtLunchDiet.Location = new System.Drawing.Point(140, 151);
            this.txtLunchDiet.Multiline = true;
            this.txtLunchDiet.Name = "txtLunchDiet";
            this.txtLunchDiet.PreventEnterBeep = true;
            this.txtLunchDiet.Size = new System.Drawing.Size(462, 164);
            this.txtLunchDiet.TabIndex = 26;
            // 
            // lblLunchDiet
            // 
            this.lblLunchDiet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblLunchDiet.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblLunchDiet.ForeColor = System.Drawing.Color.Black;
            this.lblLunchDiet.Location = new System.Drawing.Point(14, 151);
            this.lblLunchDiet.Name = "lblLunchDiet";
            this.lblLunchDiet.Size = new System.Drawing.Size(120, 23);
            this.lblLunchDiet.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblLunchDiet.TabIndex = 25;
            this.lblLunchDiet.Text = "Dietary Needs:";
            // 
            // lblLunchTime
            // 
            this.lblLunchTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblLunchTime.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblLunchTime.ForeColor = System.Drawing.Color.Black;
            this.lblLunchTime.Location = new System.Drawing.Point(225, 120);
            this.lblLunchTime.Name = "lblLunchTime";
            this.lblLunchTime.Size = new System.Drawing.Size(45, 23);
            this.lblLunchTime.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblLunchTime.TabIndex = 24;
            this.lblLunchTime.Text = "Time:";
            // 
            // dtLunchTime
            // 
            this.dtLunchTime.AllowEmptyState = false;
            this.dtLunchTime.AutoAdvance = true;
            this.dtLunchTime.AutoSelectDate = true;
            this.dtLunchTime.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.dtLunchTime.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtLunchTime.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtLunchTime.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtLunchTime.ButtonDropDown.Visible = true;
            this.dtLunchTime.ButtonFreeText.Checked = true;
            this.dtLunchTime.CustomFormat = "HH:mm";
            this.dtLunchTime.DateTimeSelectorVisibility = DevComponents.Editors.DateTimeAdv.eDateTimeSelectorVisibility.TimeSelector;
            this.dtLunchTime.ForeColor = System.Drawing.Color.Black;
            this.dtLunchTime.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.dtLunchTime.FreeTextEntryMode = true;
            this.dtLunchTime.IsPopupCalendarOpen = false;
            this.dtLunchTime.Location = new System.Drawing.Point(276, 120);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dtLunchTime.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtLunchTime.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtLunchTime.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtLunchTime.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtLunchTime.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtLunchTime.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtLunchTime.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtLunchTime.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtLunchTime.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtLunchTime.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtLunchTime.MonthCalendar.DisplayMonth = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.dtLunchTime.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.dtLunchTime.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtLunchTime.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtLunchTime.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtLunchTime.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtLunchTime.MonthCalendar.TodayButtonVisible = true;
            this.dtLunchTime.MonthCalendar.Visible = false;
            this.dtLunchTime.Name = "dtLunchTime";
            this.dtLunchTime.Size = new System.Drawing.Size(69, 25);
            this.dtLunchTime.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtLunchTime.TabIndex = 23;
            this.dtLunchTime.TimeSelectorTimeFormat = DevComponents.Editors.DateTimeAdv.eTimeSelectorFormat.Time24H;
            // 
            // lblLunchAttendees
            // 
            this.lblLunchAttendees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblLunchAttendees.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblLunchAttendees.ForeColor = System.Drawing.Color.Black;
            this.lblLunchAttendees.Location = new System.Drawing.Point(14, 120);
            this.lblLunchAttendees.Name = "lblLunchAttendees";
            this.lblLunchAttendees.Size = new System.Drawing.Size(120, 23);
            this.lblLunchAttendees.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblLunchAttendees.TabIndex = 21;
            this.lblLunchAttendees.Text = "Lunch Attendees:";
            // 
            // cbxLunchAttendees
            // 
            this.cbxLunchAttendees.DisplayMember = "Text";
            this.cbxLunchAttendees.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxLunchAttendees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLunchAttendees.ForeColor = System.Drawing.Color.Black;
            this.cbxLunchAttendees.FormattingEnabled = true;
            this.cbxLunchAttendees.ItemHeight = 19;
            this.cbxLunchAttendees.Location = new System.Drawing.Point(140, 120);
            this.cbxLunchAttendees.Name = "cbxLunchAttendees";
            this.cbxLunchAttendees.Size = new System.Drawing.Size(66, 25);
            this.cbxLunchAttendees.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxLunchAttendees.TabIndex = 20;
            // 
            // txtLunchMenu
            // 
            this.txtLunchMenu.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtLunchMenu.Border.Class = "TextBoxBorder";
            this.txtLunchMenu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtLunchMenu.DisabledBackColor = System.Drawing.Color.White;
            this.txtLunchMenu.ForeColor = System.Drawing.Color.Black;
            this.txtLunchMenu.Location = new System.Drawing.Point(276, 89);
            this.txtLunchMenu.Name = "txtLunchMenu";
            this.txtLunchMenu.PreventEnterBeep = true;
            this.txtLunchMenu.Size = new System.Drawing.Size(326, 25);
            this.txtLunchMenu.TabIndex = 15;
            // 
            // lblLunchMenu
            // 
            this.lblLunchMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblLunchMenu.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblLunchMenu.ForeColor = System.Drawing.Color.Black;
            this.lblLunchMenu.Location = new System.Drawing.Point(225, 89);
            this.lblLunchMenu.Name = "lblLunchMenu";
            this.lblLunchMenu.Size = new System.Drawing.Size(45, 23);
            this.lblLunchMenu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblLunchMenu.TabIndex = 14;
            this.lblLunchMenu.Text = "Menu:";
            // 
            // txtRefreshmentTimes
            // 
            this.txtRefreshmentTimes.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtRefreshmentTimes.Border.Class = "TextBoxBorder";
            this.txtRefreshmentTimes.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtRefreshmentTimes.DisabledBackColor = System.Drawing.Color.White;
            this.txtRefreshmentTimes.ForeColor = System.Drawing.Color.Black;
            this.txtRefreshmentTimes.Location = new System.Drawing.Point(276, 58);
            this.txtRefreshmentTimes.Name = "txtRefreshmentTimes";
            this.txtRefreshmentTimes.PreventEnterBeep = true;
            this.txtRefreshmentTimes.Size = new System.Drawing.Size(326, 25);
            this.txtRefreshmentTimes.TabIndex = 13;
            // 
            // lblRefTimes
            // 
            this.lblRefTimes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblRefTimes.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblRefTimes.ForeColor = System.Drawing.Color.Black;
            this.lblRefTimes.Location = new System.Drawing.Point(225, 58);
            this.lblRefTimes.Name = "lblRefTimes";
            this.lblRefTimes.Size = new System.Drawing.Size(45, 23);
            this.lblRefTimes.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblRefTimes.TabIndex = 12;
            this.lblRefTimes.Text = "Times:";
            // 
            // lblLunch
            // 
            this.lblLunch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblLunch.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblLunch.ForeColor = System.Drawing.Color.Black;
            this.lblLunch.Location = new System.Drawing.Point(14, 89);
            this.lblLunch.Name = "lblLunch";
            this.lblLunch.Size = new System.Drawing.Size(120, 23);
            this.lblLunch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblLunch.TabIndex = 11;
            this.lblLunch.Text = "Lunch required?";
            // 
            // swLunch
            // 
            this.swLunch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.swLunch.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.swLunch.ForeColor = System.Drawing.Color.Black;
            this.swLunch.Location = new System.Drawing.Point(140, 89);
            this.swLunch.Name = "swLunch";
            this.swLunch.OffText = "No";
            this.swLunch.OnText = "Yes";
            this.swLunch.Size = new System.Drawing.Size(66, 23);
            this.swLunch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.swLunch.TabIndex = 10;
            // 
            // lblRefreshments
            // 
            this.lblRefreshments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblRefreshments.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblRefreshments.ForeColor = System.Drawing.Color.Black;
            this.lblRefreshments.Location = new System.Drawing.Point(14, 58);
            this.lblRefreshments.Name = "lblRefreshments";
            this.lblRefreshments.Size = new System.Drawing.Size(120, 23);
            this.lblRefreshments.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblRefreshments.TabIndex = 9;
            this.lblRefreshments.Text = "Refreshments?";
            // 
            // swRefreshments
            // 
            this.swRefreshments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.swRefreshments.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.swRefreshments.ForeColor = System.Drawing.Color.Black;
            this.swRefreshments.Location = new System.Drawing.Point(140, 58);
            this.swRefreshments.Name = "swRefreshments";
            this.swRefreshments.OffText = "No";
            this.swRefreshments.OnText = "Yes";
            this.swRefreshments.Size = new System.Drawing.Size(66, 23);
            this.swRefreshments.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.swRefreshments.TabIndex = 8;
            // 
            // txtEquipment
            // 
            this.txtEquipment.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtEquipment.Border.Class = "TextBoxBorder";
            this.txtEquipment.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtEquipment.DisabledBackColor = System.Drawing.Color.White;
            this.txtEquipment.ForeColor = System.Drawing.Color.Black;
            this.txtEquipment.Location = new System.Drawing.Point(140, 18);
            this.txtEquipment.Name = "txtEquipment";
            this.txtEquipment.PreventEnterBeep = true;
            this.txtEquipment.Size = new System.Drawing.Size(462, 25);
            this.txtEquipment.TabIndex = 7;
            // 
            // lblEquipment
            // 
            this.lblEquipment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblEquipment.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblEquipment.ForeColor = System.Drawing.Color.Black;
            this.lblEquipment.Location = new System.Drawing.Point(14, 18);
            this.lblEquipment.Name = "lblEquipment";
            this.lblEquipment.Size = new System.Drawing.Size(120, 23);
            this.lblEquipment.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblEquipment.TabIndex = 1;
            this.lblEquipment.Text = "Equipment:";
            // 
            // tiRequirements
            // 
            this.tiRequirements.AttachedControl = this.tpRequirements;
            this.tiRequirements.GlobalItem = false;
            this.tiRequirements.Name = "tiRequirements";
            this.tiRequirements.Text = "  Requirements";
            // 
            // tpComments
            // 
            this.tpComments.Controls.Add(this.btnCommentSave);
            this.tpComments.Controls.Add(this.btnCommentCancel);
            this.tpComments.Controls.Add(this.gComments);
            this.tpComments.Controls.Add(this.txtComment);
            this.tpComments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpComments.Location = new System.Drawing.Point(0, 30);
            this.tpComments.Name = "tpComments";
            this.tpComments.Size = new System.Drawing.Size(616, 330);
            this.tpComments.TabIndex = 0;
            this.tpComments.TabItem = this.tiComments;
            // 
            // btnCommentSave
            // 
            this.btnCommentSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCommentSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCommentSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCommentSave.Enabled = false;
            this.btnCommentSave.Location = new System.Drawing.Point(489, 282);
            this.btnCommentSave.Name = "btnCommentSave";
            this.btnCommentSave.Size = new System.Drawing.Size(111, 34);
            this.btnCommentSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCommentSave.TabIndex = 30;
            this.btnCommentSave.Text = "Save Comment";
            this.btnCommentSave.Click += new System.EventHandler(this.btnCommentSave_Click);
            // 
            // btnCommentCancel
            // 
            this.btnCommentCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCommentCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCommentCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCommentCancel.Enabled = false;
            this.btnCommentCancel.Location = new System.Drawing.Point(16, 282);
            this.btnCommentCancel.Name = "btnCommentCancel";
            this.btnCommentCancel.Size = new System.Drawing.Size(111, 34);
            this.btnCommentCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCommentCancel.TabIndex = 31;
            this.btnCommentCancel.Text = "Cancel Comment";
            this.btnCommentCancel.Click += new System.EventHandler(this.btnCommentCancel_Click);
            // 
            // gComments
            // 
            this.gComments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gComments.ContextMenuStrip = this.mComments;
            this.gComments.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.gComments.ForeColor = System.Drawing.Color.Black;
            this.gComments.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.gComments.Location = new System.Drawing.Point(16, 18);
            this.gComments.Name = "gComments";
            // 
            // 
            // 
            this.gComments.PrimaryGrid.AllowEdit = false;
            this.gComments.PrimaryGrid.Columns.Add(this.gCommentsAdded);
            this.gComments.PrimaryGrid.Columns.Add(this.gCommentsBy);
            this.gComments.PrimaryGrid.Columns.Add(this.gCommentsComment);
            this.gComments.PrimaryGrid.MultiSelect = false;
            this.gComments.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row;
            this.gComments.PrimaryGrid.ShowRowHeaders = false;
            this.gComments.PrimaryGrid.UseAlternateRowStyle = true;
            this.gComments.Size = new System.Drawing.Size(584, 164);
            this.gComments.TabIndex = 28;
            this.gComments.Text = "superGridControl1";
            this.gComments.RowActivated += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridRowActivatedEventArgs>(this.gComments_RowActivated);
            this.gComments.RowClick += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridRowClickEventArgs>(this.gComments_RowClick);
            this.gComments.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gComments_MouseClick);
            // 
            // mComments
            // 
            this.mComments.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mComments.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mCommentsAdd});
            this.mComments.Name = "mComments";
            this.mComments.Size = new System.Drawing.Size(153, 48);
            // 
            // mCommentsAdd
            // 
            this.mCommentsAdd.Name = "mCommentsAdd";
            this.mCommentsAdd.Size = new System.Drawing.Size(152, 22);
            this.mCommentsAdd.Text = "Add comment";
            this.mCommentsAdd.Click += new System.EventHandler(this.mCommentsAdd_Click);
            // 
            // gCommentsAdded
            // 
            this.gCommentsAdded.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.None;
            this.gCommentsAdded.HeaderText = "Added";
            this.gCommentsAdded.MinimumWidth = 125;
            this.gCommentsAdded.Name = "Added";
            this.gCommentsAdded.Width = 125;
            // 
            // gCommentsBy
            // 
            this.gCommentsBy.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.None;
            this.gCommentsBy.HeaderText = "By";
            this.gCommentsBy.MinimumWidth = 125;
            this.gCommentsBy.Name = "By";
            this.gCommentsBy.Width = 125;
            // 
            // gCommentsComment
            // 
            this.gCommentsComment.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            this.gCommentsComment.HeaderText = "Comment";
            this.gCommentsComment.Name = "Comment";
            // 
            // txtComment
            // 
            this.txtComment.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtComment.Border.Class = "TextBoxBorder";
            this.txtComment.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtComment.DisabledBackColor = System.Drawing.Color.White;
            this.txtComment.Enabled = false;
            this.txtComment.ForeColor = System.Drawing.Color.Black;
            this.txtComment.Location = new System.Drawing.Point(16, 188);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.PreventEnterBeep = true;
            this.txtComment.Size = new System.Drawing.Size(584, 88);
            this.txtComment.TabIndex = 27;
            // 
            // tiComments
            // 
            this.tiComments.AttachedControl = this.tpComments;
            this.tiComments.GlobalItem = false;
            this.tiComments.Name = "tiComments";
            this.tiComments.Text = "  Comments";
            // 
            // tpInvoicing
            // 
            this.tpInvoicing.Controls.Add(this.lblInvoicingPO);
            this.tpInvoicing.Controls.Add(this.txtPurchaseOrder);
            this.tpInvoicing.Controls.Add(this.lblInvoicingMethod);
            this.tpInvoicing.Controls.Add(this.cbxPaymentMethod);
            this.tpInvoicing.Controls.Add(this.txtInvoiceAddress);
            this.tpInvoicing.Controls.Add(this.lblInvoicingAddress);
            this.tpInvoicing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpInvoicing.Location = new System.Drawing.Point(0, 30);
            this.tpInvoicing.Name = "tpInvoicing";
            this.tpInvoicing.Size = new System.Drawing.Size(616, 330);
            this.tpInvoicing.TabIndex = 0;
            this.tpInvoicing.TabItem = this.tiInvoicing;
            // 
            // lblInvoicingPO
            // 
            this.lblInvoicingPO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblInvoicingPO.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblInvoicingPO.ForeColor = System.Drawing.Color.Black;
            this.lblInvoicingPO.Location = new System.Drawing.Point(14, 187);
            this.lblInvoicingPO.Name = "lblInvoicingPO";
            this.lblInvoicingPO.Size = new System.Drawing.Size(120, 23);
            this.lblInvoicingPO.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblInvoicingPO.TabIndex = 23;
            this.lblInvoicingPO.Text = "Purchase Order:";
            // 
            // txtPurchaseOrder
            // 
            this.txtPurchaseOrder.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPurchaseOrder.Border.Class = "TextBoxBorder";
            this.txtPurchaseOrder.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPurchaseOrder.DisabledBackColor = System.Drawing.Color.White;
            this.txtPurchaseOrder.ForeColor = System.Drawing.Color.Black;
            this.txtPurchaseOrder.Location = new System.Drawing.Point(140, 187);
            this.txtPurchaseOrder.Name = "txtPurchaseOrder";
            this.txtPurchaseOrder.PreventEnterBeep = true;
            this.txtPurchaseOrder.Size = new System.Drawing.Size(229, 25);
            this.txtPurchaseOrder.TabIndex = 22;
            // 
            // lblInvoicingMethod
            // 
            this.lblInvoicingMethod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblInvoicingMethod.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblInvoicingMethod.ForeColor = System.Drawing.Color.Black;
            this.lblInvoicingMethod.Location = new System.Drawing.Point(14, 156);
            this.lblInvoicingMethod.Name = "lblInvoicingMethod";
            this.lblInvoicingMethod.Size = new System.Drawing.Size(120, 23);
            this.lblInvoicingMethod.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblInvoicingMethod.TabIndex = 21;
            this.lblInvoicingMethod.Text = "Payment Method:";
            // 
            // cbxPaymentMethod
            // 
            this.cbxPaymentMethod.DisplayMember = "Text";
            this.cbxPaymentMethod.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPaymentMethod.ForeColor = System.Drawing.Color.Black;
            this.cbxPaymentMethod.FormattingEnabled = true;
            this.cbxPaymentMethod.ItemHeight = 19;
            this.cbxPaymentMethod.Items.AddRange(new object[] {
            this.cbxiBacs,
            this.cbxiCash,
            this.cbxiCheque,
            this.cbxiCard});
            this.cbxPaymentMethod.Location = new System.Drawing.Point(140, 156);
            this.cbxPaymentMethod.Name = "cbxPaymentMethod";
            this.cbxPaymentMethod.Size = new System.Drawing.Size(229, 25);
            this.cbxPaymentMethod.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxPaymentMethod.TabIndex = 20;
            // 
            // cbxiBacs
            // 
            this.cbxiBacs.Text = "BACS";
            // 
            // cbxiCash
            // 
            this.cbxiCash.Text = "Cash";
            // 
            // cbxiCheque
            // 
            this.cbxiCheque.Text = "Cheque";
            // 
            // cbxiCard
            // 
            this.cbxiCard.Text = "Debit/Credit Card";
            // 
            // txtInvoiceAddress
            // 
            this.txtInvoiceAddress.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtInvoiceAddress.Border.Class = "TextBoxBorder";
            this.txtInvoiceAddress.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtInvoiceAddress.DisabledBackColor = System.Drawing.Color.White;
            this.txtInvoiceAddress.ForeColor = System.Drawing.Color.Black;
            this.txtInvoiceAddress.Location = new System.Drawing.Point(140, 18);
            this.txtInvoiceAddress.Multiline = true;
            this.txtInvoiceAddress.Name = "txtInvoiceAddress";
            this.txtInvoiceAddress.PreventEnterBeep = true;
            this.txtInvoiceAddress.Size = new System.Drawing.Size(460, 132);
            this.txtInvoiceAddress.TabIndex = 9;
            // 
            // lblInvoicingAddress
            // 
            this.lblInvoicingAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblInvoicingAddress.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblInvoicingAddress.ForeColor = System.Drawing.Color.Black;
            this.lblInvoicingAddress.Location = new System.Drawing.Point(14, 18);
            this.lblInvoicingAddress.Name = "lblInvoicingAddress";
            this.lblInvoicingAddress.Size = new System.Drawing.Size(120, 23);
            this.lblInvoicingAddress.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblInvoicingAddress.TabIndex = 8;
            this.lblInvoicingAddress.Text = "Invoice Address:";
            // 
            // tiInvoicing
            // 
            this.tiInvoicing.AttachedControl = this.tpInvoicing;
            this.tiInvoicing.GlobalItem = false;
            this.tiInvoicing.Name = "tiInvoicing";
            this.tiInvoicing.Text = "  Invoicing";
            // 
            // tpDocuments
            // 
            this.tpDocuments.Controls.Add(this.lblFileAccessedVal);
            this.tpDocuments.Controls.Add(this.lblFileAccessed);
            this.tpDocuments.Controls.Add(this.lblFileModifiedVal);
            this.tpDocuments.Controls.Add(this.lblFileModified);
            this.tpDocuments.Controls.Add(this.lblFileSizeVal);
            this.tpDocuments.Controls.Add(this.lblFileSize);
            this.tpDocuments.Controls.Add(this.lblFileLocationVal);
            this.tpDocuments.Controls.Add(this.lblFileLocation);
            this.tpDocuments.Controls.Add(this.lblFileNameVal);
            this.tpDocuments.Controls.Add(this.lblFileName);
            this.tpDocuments.Controls.Add(this.lvDocuments);
            this.tpDocuments.Controls.Add(this.btnDocumentAdd);
            this.tpDocuments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpDocuments.Location = new System.Drawing.Point(0, 30);
            this.tpDocuments.Name = "tpDocuments";
            this.tpDocuments.Size = new System.Drawing.Size(616, 330);
            this.tpDocuments.TabIndex = 0;
            this.tpDocuments.TabItem = this.tiDocuments;
            // 
            // lblFileAccessedVal
            // 
            this.lblFileAccessedVal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblFileAccessedVal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblFileAccessedVal.ForeColor = System.Drawing.Color.Black;
            this.lblFileAccessedVal.Location = new System.Drawing.Point(303, 243);
            this.lblFileAccessedVal.Name = "lblFileAccessedVal";
            this.lblFileAccessedVal.Size = new System.Drawing.Size(279, 23);
            this.lblFileAccessedVal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblFileAccessedVal.TabIndex = 17;
            this.lblFileAccessedVal.Text = "...";
            // 
            // lblFileAccessed
            // 
            this.lblFileAccessed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblFileAccessed.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblFileAccessed.ForeColor = System.Drawing.Color.Black;
            this.lblFileAccessed.Location = new System.Drawing.Point(303, 218);
            this.lblFileAccessed.Name = "lblFileAccessed";
            this.lblFileAccessed.Size = new System.Drawing.Size(279, 23);
            this.lblFileAccessed.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblFileAccessed.TabIndex = 16;
            this.lblFileAccessed.Text = "Last accessed:";
            // 
            // lblFileModifiedVal
            // 
            this.lblFileModifiedVal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblFileModifiedVal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblFileModifiedVal.ForeColor = System.Drawing.Color.Black;
            this.lblFileModifiedVal.Location = new System.Drawing.Point(303, 193);
            this.lblFileModifiedVal.Name = "lblFileModifiedVal";
            this.lblFileModifiedVal.Size = new System.Drawing.Size(279, 23);
            this.lblFileModifiedVal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblFileModifiedVal.TabIndex = 15;
            this.lblFileModifiedVal.Text = "...";
            // 
            // lblFileModified
            // 
            this.lblFileModified.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblFileModified.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblFileModified.ForeColor = System.Drawing.Color.Black;
            this.lblFileModified.Location = new System.Drawing.Point(303, 168);
            this.lblFileModified.Name = "lblFileModified";
            this.lblFileModified.Size = new System.Drawing.Size(279, 23);
            this.lblFileModified.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblFileModified.TabIndex = 14;
            this.lblFileModified.Text = "Last modified:";
            // 
            // lblFileSizeVal
            // 
            this.lblFileSizeVal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblFileSizeVal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblFileSizeVal.ForeColor = System.Drawing.Color.Black;
            this.lblFileSizeVal.Location = new System.Drawing.Point(303, 143);
            this.lblFileSizeVal.Name = "lblFileSizeVal";
            this.lblFileSizeVal.Size = new System.Drawing.Size(279, 23);
            this.lblFileSizeVal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblFileSizeVal.TabIndex = 13;
            this.lblFileSizeVal.Text = "...";
            // 
            // lblFileSize
            // 
            this.lblFileSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblFileSize.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblFileSize.ForeColor = System.Drawing.Color.Black;
            this.lblFileSize.Location = new System.Drawing.Point(303, 118);
            this.lblFileSize.Name = "lblFileSize";
            this.lblFileSize.Size = new System.Drawing.Size(279, 23);
            this.lblFileSize.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblFileSize.TabIndex = 12;
            this.lblFileSize.Text = "File size:";
            // 
            // lblFileLocationVal
            // 
            this.lblFileLocationVal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblFileLocationVal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblFileLocationVal.ForeColor = System.Drawing.Color.Black;
            this.lblFileLocationVal.Location = new System.Drawing.Point(303, 93);
            this.lblFileLocationVal.Name = "lblFileLocationVal";
            this.lblFileLocationVal.Size = new System.Drawing.Size(279, 23);
            this.lblFileLocationVal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblFileLocationVal.TabIndex = 11;
            this.lblFileLocationVal.Text = "...";
            // 
            // lblFileLocation
            // 
            this.lblFileLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblFileLocation.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblFileLocation.ForeColor = System.Drawing.Color.Black;
            this.lblFileLocation.Location = new System.Drawing.Point(303, 68);
            this.lblFileLocation.Name = "lblFileLocation";
            this.lblFileLocation.Size = new System.Drawing.Size(279, 23);
            this.lblFileLocation.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblFileLocation.TabIndex = 10;
            this.lblFileLocation.Text = "Location:";
            // 
            // lblFileNameVal
            // 
            this.lblFileNameVal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblFileNameVal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblFileNameVal.ForeColor = System.Drawing.Color.Black;
            this.lblFileNameVal.Location = new System.Drawing.Point(303, 43);
            this.lblFileNameVal.Name = "lblFileNameVal";
            this.lblFileNameVal.Size = new System.Drawing.Size(279, 23);
            this.lblFileNameVal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblFileNameVal.TabIndex = 9;
            this.lblFileNameVal.Text = "...";
            // 
            // lblFileName
            // 
            this.lblFileName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblFileName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblFileName.ForeColor = System.Drawing.Color.Black;
            this.lblFileName.Location = new System.Drawing.Point(303, 18);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(279, 23);
            this.lblFileName.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblFileName.TabIndex = 8;
            this.lblFileName.Text = "Filename:";
            // 
            // lvDocuments
            // 
            this.lvDocuments.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvDocuments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvDocuments.BackColor = System.Drawing.Color.White;
            this.lvDocuments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvDocuments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chFilename});
            this.lvDocuments.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lvDocuments.ForeColor = System.Drawing.Color.Black;
            this.lvDocuments.FullRowSelect = true;
            this.lvDocuments.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvDocuments.HideSelection = false;
            this.lvDocuments.Location = new System.Drawing.Point(16, 18);
            this.lvDocuments.MultiSelect = false;
            this.lvDocuments.Name = "lvDocuments";
            this.lvDocuments.Size = new System.Drawing.Size(272, 272);
            this.lvDocuments.TabIndex = 7;
            this.lvDocuments.UseCompatibleStateImageBehavior = false;
            this.lvDocuments.View = System.Windows.Forms.View.Details;
            this.lvDocuments.ItemActivate += new System.EventHandler(this.lvDocuments_ItemActivate);
            // 
            // chFilename
            // 
            this.chFilename.Text = "Filename";
            this.chFilename.Width = 224;
            // 
            // btnDocumentAdd
            // 
            this.btnDocumentAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDocumentAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDocumentAdd.Location = new System.Drawing.Point(96, 295);
            this.btnDocumentAdd.Name = "btnDocumentAdd";
            this.btnDocumentAdd.Size = new System.Drawing.Size(110, 29);
            this.btnDocumentAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDocumentAdd.TabIndex = 6;
            this.btnDocumentAdd.Text = "Add document";
            this.btnDocumentAdd.Click += new System.EventHandler(this.btnDocumentAdd_Click);
            // 
            // tiDocuments
            // 
            this.tiDocuments.AttachedControl = this.tpDocuments;
            this.tiDocuments.GlobalItem = false;
            this.tiDocuments.Name = "tiDocuments";
            this.tiDocuments.Text = "  Documents";
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Location = new System.Drawing.Point(12, 396);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 34);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save Changes";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Location = new System.Drawing.Point(527, 396);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 34);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblUsers
            // 
            this.lblUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblUsers.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblUsers.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsers.ForeColor = System.Drawing.Color.Black;
            this.lblUsers.Location = new System.Drawing.Point(120, 396);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(401, 34);
            this.lblUsers.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblUsers.TabIndex = 4;
            this.lblUsers.Text = "Added by:\r\nEdited by:";
            this.lblUsers.TextAlignment = System.Drawing.StringAlignment.Center;
            this.lblUsers.Visible = false;
            // 
            // ofd
            // 
            this.ofd.Filter = "PDF files (*.pdf)|*.pdf|Image files (*.jpg, *.png)|*.jpg;*.png;*.gif|Word documen" +
    "ts (*.doc, *.docx)|*.doc;*.docx|Excel documents (*.xls, *.xlsx)|*.xls;*.xlsx";
            this.ofd.Title = "Find Documents";
            // 
            // frmBooking
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CaptionFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ClientSize = new System.Drawing.Size(640, 442);
            this.Controls.Add(this.lblUsers);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tc);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(640, 458);
            this.Name = "frmBooking";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Booking";
            ((System.ComponentModel.ISupportInitialize)(this.tc)).EndInit();
            this.tc.ResumeLayout(false);
            this.tpContact.ResumeLayout(false);
            this.tpEvent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtTimeAccessTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTimeAccessFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTimeTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTimeFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDateTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDateFrom)).EndInit();
            this.tpRequirements.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtLunchTime)).EndInit();
            this.tpComments.ResumeLayout(false);
            this.mComments.ResumeLayout(false);
            this.tpInvoicing.ResumeLayout(false);
            this.tpDocuments.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.StyleManager sm;
        private DevComponents.DotNetBar.SuperTabControl tc;
        private DevComponents.DotNetBar.SuperTabControlPanel tpContact;
        private DevComponents.DotNetBar.SuperTabItem tiContact;
        private DevComponents.DotNetBar.SuperTabControlPanel tpDocuments;
        private DevComponents.DotNetBar.SuperTabItem tiDocuments;
        private DevComponents.DotNetBar.SuperTabControlPanel tpInvoicing;
        private DevComponents.DotNetBar.SuperTabItem tiInvoicing;
        private DevComponents.DotNetBar.SuperTabControlPanel tpComments;
        private DevComponents.DotNetBar.SuperTabItem tiComments;
        private DevComponents.DotNetBar.SuperTabControlPanel tpRequirements;
        private DevComponents.DotNetBar.SuperTabItem tiRequirements;
        private DevComponents.DotNetBar.SuperTabControlPanel tpEvent;
        private DevComponents.DotNetBar.SuperTabItem tiEvent;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.LabelX lblUsers;
        private DevComponents.DotNetBar.LabelX lblCompany;
        private DevComponents.DotNetBar.LabelX lblContact;
        private DevComponents.DotNetBar.Controls.TextBoxX txtEmail;
        private DevComponents.DotNetBar.LabelX lblPhone;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPhone;
        private DevComponents.DotNetBar.Controls.TextBoxX txtLayout;
        private DevComponents.DotNetBar.LabelX lblLayout;
        private DevComponents.DotNetBar.LabelX lblRooms;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtDateTo;
        private DevComponents.DotNetBar.LabelX lblDateTo;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtDateFrom;
        private DevComponents.DotNetBar.LabelX lblDatesTimes;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtTimeTo;
        private DevComponents.DotNetBar.LabelX lblTimeTo;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtTimeFrom;
        private DevComponents.DotNetBar.LabelX lblName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtName;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtTimeAccessTo;
        private DevComponents.DotNetBar.LabelX lblTimeAcessTo;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtTimeAccessFrom;
        private DevComponents.DotNetBar.LabelX lblTimeAccess;
        private DevComponents.DotNetBar.LabelX lblDelegates;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxDelegates;
        private DevComponents.DotNetBar.Controls.TextBoxX txtEquipment;
        private DevComponents.DotNetBar.LabelX lblEquipment;
        private DevComponents.DotNetBar.LabelX lblLunchAttendees;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxLunchAttendees;
        private DevComponents.DotNetBar.Controls.TextBoxX txtLunchMenu;
        private DevComponents.DotNetBar.LabelX lblLunchMenu;
        private DevComponents.DotNetBar.Controls.TextBoxX txtRefreshmentTimes;
        private DevComponents.DotNetBar.LabelX lblRefTimes;
        private DevComponents.DotNetBar.LabelX lblLunch;
        private DevComponents.DotNetBar.Controls.SwitchButton swLunch;
        private DevComponents.DotNetBar.LabelX lblRefreshments;
        private DevComponents.DotNetBar.Controls.SwitchButton swRefreshments;
        private DevComponents.DotNetBar.LabelX lblLunchTime;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtLunchTime;
        private DevComponents.DotNetBar.Controls.TextBoxX txtLunchDiet;
        private DevComponents.DotNetBar.LabelX lblLunchDiet;
        private DevComponents.DotNetBar.Controls.TextBoxX txtComment;
        private DevComponents.DotNetBar.LabelX lblInvoicingPO;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPurchaseOrder;
        private DevComponents.DotNetBar.LabelX lblInvoicingMethod;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxPaymentMethod;
        private DevComponents.Editors.ComboItem cbxiBacs;
        private DevComponents.Editors.ComboItem cbxiCash;
        private DevComponents.Editors.ComboItem cbxiCheque;
        private DevComponents.Editors.ComboItem cbxiCard;
        private DevComponents.DotNetBar.Controls.TextBoxX txtInvoiceAddress;
        private DevComponents.DotNetBar.LabelX lblInvoicingAddress;
        private System.Windows.Forms.ListView lvDocuments;
        private System.Windows.Forms.ColumnHeader chFilename;
        private DevComponents.DotNetBar.ButtonX btnDocumentAdd;
        private DevComponents.DotNetBar.ButtonX btnContacts;
        private DevComponents.DotNetBar.ButtonX btnCompanies;
        private System.Windows.Forms.OpenFileDialog ofd;
        private DevComponents.DotNetBar.LabelX lblFileAccessedVal;
        private DevComponents.DotNetBar.LabelX lblFileAccessed;
        private DevComponents.DotNetBar.LabelX lblFileModifiedVal;
        private DevComponents.DotNetBar.LabelX lblFileModified;
        private DevComponents.DotNetBar.LabelX lblFileSizeVal;
        private DevComponents.DotNetBar.LabelX lblFileSize;
        private DevComponents.DotNetBar.LabelX lblFileLocationVal;
        private DevComponents.DotNetBar.LabelX lblFileLocation;
        private DevComponents.DotNetBar.LabelX lblFileNameVal;
        private DevComponents.DotNetBar.LabelX lblFileName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCompany;
        private DevComponents.DotNetBar.Controls.TextBoxX txtContact;
        private System.Windows.Forms.TreeView tvRooms;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl gComments;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gCommentsAdded;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gCommentsBy;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gCommentsComment;
        private System.Windows.Forms.ContextMenuStrip mComments;
        private System.Windows.Forms.ToolStripMenuItem mCommentsAdd;
        private DevComponents.DotNetBar.ButtonX btnCommentCancel;
        private DevComponents.DotNetBar.ButtonX btnCommentSave;
    }
}