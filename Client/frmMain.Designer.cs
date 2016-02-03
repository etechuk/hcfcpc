namespace Client
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
            this.ms = new DevComponents.DotNetBar.Metro.MetroShell();
            this.pBookings = new DevComponents.DotNetBar.Metro.MetroTabPanel();
            this.pBookingsList = new DevComponents.DotNetBar.PanelEx();
            this.pBookingsListTools = new DevComponents.DotNetBar.PanelEx();
            this.btnListCompanyReset = new DevComponents.DotNetBar.ButtonX();
            this.txtListCompany = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblListBookings = new DevComponents.DotNetBar.LabelX();
            this.lblBookingsListCompany = new DevComponents.DotNetBar.LabelX();
            this.nbBookingsList = new DevComponents.DotNetBar.NavigationBar();
            this.biBookingsListDay = new DevComponents.DotNetBar.ButtonItem();
            this.biBookingsListWeek = new DevComponents.DotNetBar.ButtonItem();
            this.biBookingsListMonth = new DevComponents.DotNetBar.ButtonItem();
            this.biBookingsListYear = new DevComponents.DotNetBar.ButtonItem();
            this.biBookingsListGrid = new DevComponents.DotNetBar.ButtonItem();
            this.biBookingsList = new DevComponents.DotNetBar.ButtonItem();
            this.gBookings = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.mBookings = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mBookingsAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mBookingsRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.mBookingsS1 = new System.Windows.Forms.ToolStripSeparator();
            this.mBookingsComplete = new System.Windows.Forms.ToolStripMenuItem();
            this.gBookingsChk = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gBookingsJob = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gBookingsDates = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gBookingsStart = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gBookingsFinish = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gBookingsName = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gBookingsRooms = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gBookingsCompany = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gBookingsPhone = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gBookingsEmail = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gBookingsRoomLayout = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.pBookingsGrid = new DevComponents.DotNetBar.PanelEx();
            this.rgBookings = new unvell.ReoGrid.ReoGridControl();
            this.mBookingsGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mBookingsGridAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mBookingsGridRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.mBookingsGridS1 = new System.Windows.Forms.ToolStripSeparator();
            this.mBookingsGridComplete = new System.Windows.Forms.ToolStripMenuItem();
            this.pBookingsGridTools = new DevComponents.DotNetBar.PanelEx();
            this.btnGridCompanyReset = new DevComponents.DotNetBar.ButtonX();
            this.txtGridCompany = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblGridBookings = new DevComponents.DotNetBar.LabelX();
            this.lblBookingsGridCompany = new DevComponents.DotNetBar.LabelX();
            this.nbBookingsGrid = new DevComponents.DotNetBar.NavigationBar();
            this.biBookingsGridDay = new DevComponents.DotNetBar.ButtonItem();
            this.biBookingsGridWeek = new DevComponents.DotNetBar.ButtonItem();
            this.biBookingsGridMonth = new DevComponents.DotNetBar.ButtonItem();
            this.biBookingsGridYear = new DevComponents.DotNetBar.ButtonItem();
            this.biBookingsGrid = new DevComponents.DotNetBar.ButtonItem();
            this.biBookingsGridList = new DevComponents.DotNetBar.ButtonItem();
            this.pBookingsCalendar = new DevComponents.DotNetBar.PanelEx();
            this.pBookingsCalendarTools = new DevComponents.DotNetBar.PanelEx();
            this.lblCalendarBookings = new DevComponents.DotNetBar.LabelX();
            this.nbBookings = new DevComponents.DotNetBar.NavigationBar();
            this.biBookingsViewDay = new DevComponents.DotNetBar.ButtonItem();
            this.biBookingsViewWeek = new DevComponents.DotNetBar.ButtonItem();
            this.biBookingsViewMonth = new DevComponents.DotNetBar.ButtonItem();
            this.biBookingsViewYear = new DevComponents.DotNetBar.ButtonItem();
            this.biBookingsViewGrid = new DevComponents.DotNetBar.ButtonItem();
            this.biBookingsViewList = new DevComponents.DotNetBar.ButtonItem();
            this.dnBookings = new DevComponents.DotNetBar.Schedule.DateNavigator();
            this.cvBookings = new DevComponents.DotNetBar.Schedule.CalendarView();
            this.pEnquiries = new DevComponents.DotNetBar.Metro.MetroTabPanel();
            this.scEnquiries = new DevComponents.DotNetBar.Controls.CollapsibleSplitContainer();
            this.pEnquiriesGrid = new DevComponents.DotNetBar.PanelEx();
            this.pEnquiriesGridTools = new DevComponents.DotNetBar.PanelEx();
            this.btnEnquiriesListCompany = new DevComponents.DotNetBar.ButtonX();
            this.txtEnquiriesListCompany = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblGridEnquiries = new DevComponents.DotNetBar.LabelX();
            this.lblEnquiriesCompany = new DevComponents.DotNetBar.LabelX();
            this.gEnquiries = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.gEnquiriesChk = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gEnquiriesJob = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gEnquiriesDates = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gEnquiriesStart = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gEnquiriesFinish = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gEnquiriesName = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gEnquiriesRooms = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gEnquiriesCompany = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gEnquiriesPhone = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gEnquiriesEmail = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gEnquiriesLayout = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.pEnquiry = new DevComponents.DotNetBar.PanelEx();
            this.pCourses = new DevComponents.DotNetBar.Metro.MetroTabPanel();
            this.scCourses = new DevComponents.DotNetBar.Controls.CollapsibleSplitContainer();
            this.gCourses = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.gCoursesChk = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gCoursesID = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gCoursesName = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gCoursesCert = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gCoursesDuration = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gCoursesPrice = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.pCourse = new DevComponents.DotNetBar.PanelEx();
            this.pCompanies = new DevComponents.DotNetBar.Metro.MetroTabPanel();
            this.scCompanies = new DevComponents.DotNetBar.Controls.CollapsibleSplitContainer();
            this.gCompanies = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.gCompaniesChk = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gCompaniesID = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gCompaniesName = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gCompaniesContact = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gCompaniesPhone = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gCompaniesEmail = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gCompaniesAddress = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gCompaniesReg = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gCompaniesVat = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.pCompany = new DevComponents.DotNetBar.PanelEx();
            this.pContacts = new DevComponents.DotNetBar.Metro.MetroTabPanel();
            this.scContacts = new DevComponents.DotNetBar.Controls.CollapsibleSplitContainer();
            this.gContacts = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.gContactsChk = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gContactsID = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gContactsTitle = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gContactsNameFirst = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gContactsNameLast = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gContactsCompany = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gContactsPhone = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gContactsEmail = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gContactsAddress = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.pContact = new DevComponents.DotNetBar.PanelEx();
            this.comboBoxEx1 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbxiContactTitleMr = new DevComponents.Editors.ComboItem();
            this.cbxiContactTitleMrs = new DevComponents.Editors.ComboItem();
            this.cbxiContactTitleMiss = new DevComponents.Editors.ComboItem();
            this.cbxiContactTitleMs = new DevComponents.Editors.ComboItem();
            this.cbxiContactTitleMaster = new DevComponents.Editors.ComboItem();
            this.cbxiContactTitleDr = new DevComponents.Editors.ComboItem();
            this.cbxiContactTitleProf = new DevComponents.Editors.ComboItem();
            this.cbxiContactTitleOfc = new DevComponents.Editors.ComboItem();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtContactNameLast = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtContactNameFirst = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtContactCompany = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtContactEmail = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblContactPhone = new DevComponents.DotNetBar.LabelX();
            this.txtContactPhone = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblContactName = new DevComponents.DotNetBar.LabelX();
            this.lblContactCompany = new DevComponents.DotNetBar.LabelX();
            this.ab = new DevComponents.DotNetBar.Metro.MetroAppButton();
            this.bsv = new DevComponents.DotNetBar.SuperTabControl();
            this.bsvTpPrint = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.bsvTiPrint = new DevComponents.DotNetBar.SuperTabItem();
            this.bsvTiHlp = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.bsvTiHelp = new DevComponents.DotNetBar.SuperTabItem();
            this.btnOptions = new DevComponents.DotNetBar.ButtonItem();
            this.btnExit = new DevComponents.DotNetBar.ButtonItem();
            this.mtBookings = new DevComponents.DotNetBar.Metro.MetroTabItem();
            this.mtEnquiries = new DevComponents.DotNetBar.Metro.MetroTabItem();
            this.mtCourses = new DevComponents.DotNetBar.Metro.MetroTabItem();
            this.mtCompanies = new DevComponents.DotNetBar.Metro.MetroTabItem();
            this.mtContacts = new DevComponents.DotNetBar.Metro.MetroTabItem();
            this.btnDummy = new DevComponents.DotNetBar.ButtonItem();
            this.sm = new DevComponents.DotNetBar.StyleManager(this.components);
            this.sb = new DevComponents.DotNetBar.Metro.MetroStatusBar();
            this.lblStatus = new DevComponents.DotNetBar.LabelItem();
            this.mTools = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mToolsTemplates = new System.Windows.Forms.ToolStripMenuItem();
            this.mToolsS1 = new System.Windows.Forms.ToolStripSeparator();
            this.mToolsUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.mBookingsList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mBookingsListAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mBookingsListRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.mBookingsListS1 = new System.Windows.Forms.ToolStripSeparator();
            this.mBookingsListComplete = new System.Windows.Forms.ToolStripMenuItem();
            this.mContacts = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mContactsAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mContactsRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.mEnquiries = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mEnquiriesAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mEnquiriesRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.mCourses = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mCoursesAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mCoursesRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.mCompanies = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mCompaniesAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mCompaniesRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.mEnquiriesS1 = new System.Windows.Forms.ToolStripSeparator();
            this.mEnquiriesBooking = new System.Windows.Forms.ToolStripMenuItem();
            this.lblContactEmail = new DevComponents.DotNetBar.LabelX();
            this.ms.SuspendLayout();
            this.pBookings.SuspendLayout();
            this.pBookingsList.SuspendLayout();
            this.pBookingsListTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbBookingsList)).BeginInit();
            this.mBookings.SuspendLayout();
            this.pBookingsGrid.SuspendLayout();
            this.mBookingsGrid.SuspendLayout();
            this.pBookingsGridTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbBookingsGrid)).BeginInit();
            this.pBookingsCalendar.SuspendLayout();
            this.pBookingsCalendarTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbBookings)).BeginInit();
            this.pEnquiries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scEnquiries)).BeginInit();
            this.scEnquiries.Panel1.SuspendLayout();
            this.scEnquiries.Panel2.SuspendLayout();
            this.scEnquiries.SuspendLayout();
            this.pEnquiriesGrid.SuspendLayout();
            this.pEnquiriesGridTools.SuspendLayout();
            this.pCourses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scCourses)).BeginInit();
            this.scCourses.Panel1.SuspendLayout();
            this.scCourses.Panel2.SuspendLayout();
            this.scCourses.SuspendLayout();
            this.pCompanies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scCompanies)).BeginInit();
            this.scCompanies.Panel1.SuspendLayout();
            this.scCompanies.Panel2.SuspendLayout();
            this.scCompanies.SuspendLayout();
            this.pContacts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scContacts)).BeginInit();
            this.scContacts.Panel1.SuspendLayout();
            this.scContacts.Panel2.SuspendLayout();
            this.scContacts.SuspendLayout();
            this.pContact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsv)).BeginInit();
            this.bsv.SuspendLayout();
            this.mTools.SuspendLayout();
            this.mBookingsList.SuspendLayout();
            this.mContacts.SuspendLayout();
            this.mEnquiries.SuspendLayout();
            this.mCourses.SuspendLayout();
            this.mCompanies.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms
            // 
            this.ms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.ms.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ms.CanCustomize = false;
            this.ms.CaptionFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ms.CaptionVisible = true;
            this.ms.Controls.Add(this.pContacts);
            this.ms.Controls.Add(this.pCompanies);
            this.ms.Controls.Add(this.pCourses);
            this.ms.Controls.Add(this.pEnquiries);
            this.ms.Controls.Add(this.pBookings);
            this.ms.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ms.ForeColor = System.Drawing.Color.Black;
            this.ms.HelpButtonText = "Help";
            this.ms.HelpButtonVisible = false;
            this.ms.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ab,
            this.mtBookings,
            this.mtEnquiries,
            this.mtCourses,
            this.mtCompanies,
            this.mtContacts});
            this.ms.KeyTipsFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ms.Location = new System.Drawing.Point(0, 0);
            this.ms.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ms.Name = "ms";
            this.ms.QuickToolbarItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnDummy});
            this.ms.SettingsButtonText = "Tools";
            this.ms.SettingsButtonVisible = false;
            this.ms.Size = new System.Drawing.Size(960, 596);
            this.ms.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            this.ms.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            this.ms.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
            this.ms.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            this.ms.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            this.ms.SystemText.QatDialogAddButton = "&Add >>";
            this.ms.SystemText.QatDialogCancelButton = "Cancel";
            this.ms.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            this.ms.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            this.ms.SystemText.QatDialogOkButton = "OK";
            this.ms.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            this.ms.SystemText.QatDialogRemoveButton = "&Remove";
            this.ms.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            this.ms.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            this.ms.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            this.ms.TabIndex = 0;
            this.ms.TabStripFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ms.SelectedTabChanged += new System.EventHandler(this.ms_SelectedTabChanged);
            // 
            // pBookings
            // 
            this.pBookings.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pBookings.Controls.Add(this.pBookingsList);
            this.pBookings.Controls.Add(this.pBookingsGrid);
            this.pBookings.Controls.Add(this.pBookingsCalendar);
            this.pBookings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBookings.Location = new System.Drawing.Point(0, 61);
            this.pBookings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pBookings.Name = "pBookings";
            this.pBookings.Padding = new System.Windows.Forms.Padding(3, 0, 3, 4);
            this.pBookings.Size = new System.Drawing.Size(960, 535);
            // 
            // 
            // 
            this.pBookings.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pBookings.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pBookings.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pBookings.TabIndex = 1;
            this.pBookings.Visible = false;
            // 
            // pBookingsList
            // 
            this.pBookingsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pBookingsList.CanvasColor = System.Drawing.SystemColors.Control;
            this.pBookingsList.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pBookingsList.Controls.Add(this.pBookingsListTools);
            this.pBookingsList.Controls.Add(this.gBookings);
            this.pBookingsList.DisabledBackColor = System.Drawing.Color.Empty;
            this.pBookingsList.Location = new System.Drawing.Point(37, 356);
            this.pBookingsList.Name = "pBookingsList";
            this.pBookingsList.Size = new System.Drawing.Size(880, 172);
            this.pBookingsList.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pBookingsList.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pBookingsList.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pBookingsList.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pBookingsList.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pBookingsList.Style.GradientAngle = 90;
            this.pBookingsList.TabIndex = 11;
            this.pBookingsList.Visible = false;
            // 
            // pBookingsListTools
            // 
            this.pBookingsListTools.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pBookingsListTools.CanvasColor = System.Drawing.SystemColors.Control;
            this.pBookingsListTools.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pBookingsListTools.Controls.Add(this.btnListCompanyReset);
            this.pBookingsListTools.Controls.Add(this.txtListCompany);
            this.pBookingsListTools.Controls.Add(this.lblListBookings);
            this.pBookingsListTools.Controls.Add(this.lblBookingsListCompany);
            this.pBookingsListTools.Controls.Add(this.nbBookingsList);
            this.pBookingsListTools.DisabledBackColor = System.Drawing.Color.Empty;
            this.pBookingsListTools.Location = new System.Drawing.Point(0, 0);
            this.pBookingsListTools.Name = "pBookingsListTools";
            this.pBookingsListTools.Size = new System.Drawing.Size(880, 35);
            this.pBookingsListTools.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pBookingsListTools.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pBookingsListTools.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pBookingsListTools.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pBookingsListTools.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pBookingsListTools.Style.GradientAngle = 90;
            this.pBookingsListTools.TabIndex = 4;
            // 
            // btnListCompanyReset
            // 
            this.btnListCompanyReset.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnListCompanyReset.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnListCompanyReset.Location = new System.Drawing.Point(312, 5);
            this.btnListCompanyReset.Name = "btnListCompanyReset";
            this.btnListCompanyReset.Size = new System.Drawing.Size(25, 25);
            this.btnListCompanyReset.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnListCompanyReset.TabIndex = 28;
            this.btnListCompanyReset.Click += new System.EventHandler(this.btnListCompanyReset_Click);
            // 
            // txtListCompany
            // 
            this.txtListCompany.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtListCompany.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtListCompany.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtListCompany.Border.Class = "TextBoxBorder";
            this.txtListCompany.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtListCompany.DisabledBackColor = System.Drawing.Color.White;
            this.txtListCompany.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtListCompany.ForeColor = System.Drawing.Color.Black;
            this.txtListCompany.Location = new System.Drawing.Point(64, 5);
            this.txtListCompany.Name = "txtListCompany";
            this.txtListCompany.PreventEnterBeep = true;
            this.txtListCompany.Size = new System.Drawing.Size(244, 25);
            this.txtListCompany.TabIndex = 27;
            // 
            // lblListBookings
            // 
            this.lblListBookings.AutoSize = true;
            // 
            // 
            // 
            this.lblListBookings.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblListBookings.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListBookings.ForeColor = System.Drawing.Color.Black;
            this.lblListBookings.Location = new System.Drawing.Point(348, 9);
            this.lblListBookings.Name = "lblListBookings";
            this.lblListBookings.Size = new System.Drawing.Size(77, 17);
            this.lblListBookings.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblListBookings.TabIndex = 26;
            this.lblListBookings.Text = "Total bookings:";
            // 
            // lblBookingsListCompany
            // 
            this.lblBookingsListCompany.AutoSize = true;
            // 
            // 
            // 
            this.lblBookingsListCompany.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblBookingsListCompany.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingsListCompany.ForeColor = System.Drawing.Color.Black;
            this.lblBookingsListCompany.Location = new System.Drawing.Point(7, 9);
            this.lblBookingsListCompany.Name = "lblBookingsListCompany";
            this.lblBookingsListCompany.Size = new System.Drawing.Size(51, 17);
            this.lblBookingsListCompany.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblBookingsListCompany.TabIndex = 24;
            this.lblBookingsListCompany.Text = "Company:";
            // 
            // nbBookingsList
            // 
            this.nbBookingsList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nbBookingsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nbBookingsList.BackgroundStyle.BackColor1.Color = System.Drawing.SystemColors.Control;
            this.nbBookingsList.BackgroundStyle.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.nbBookingsList.BackgroundStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.nbBookingsList.ConfigureItemVisible = false;
            this.nbBookingsList.ForeColor = System.Drawing.Color.Black;
            this.nbBookingsList.ItemPaddingBottom = 2;
            this.nbBookingsList.ItemPaddingTop = 2;
            this.nbBookingsList.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.biBookingsListDay,
            this.biBookingsListWeek,
            this.biBookingsListMonth,
            this.biBookingsListYear,
            this.biBookingsListGrid,
            this.biBookingsList});
            this.nbBookingsList.Location = new System.Drawing.Point(698, 2);
            this.nbBookingsList.Name = "nbBookingsList";
            this.nbBookingsList.Size = new System.Drawing.Size(180, 30);
            this.nbBookingsList.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.nbBookingsList.TabIndex = 12;
            this.nbBookingsList.Text = "navigationBar2";
            // 
            // biBookingsListDay
            // 
            this.biBookingsListDay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.biBookingsListDay.Image = ((System.Drawing.Image)(resources.GetObject("biBookingsListDay.Image")));
            this.biBookingsListDay.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.biBookingsListDay.Name = "biBookingsListDay";
            this.biBookingsListDay.OptionGroup = "navBar";
            this.biBookingsListDay.Text = "Day view";
            this.biBookingsListDay.Click += new System.EventHandler(this.biBookingsViewDay_Click);
            // 
            // biBookingsListWeek
            // 
            this.biBookingsListWeek.Cursor = System.Windows.Forms.Cursors.Hand;
            this.biBookingsListWeek.Image = ((System.Drawing.Image)(resources.GetObject("biBookingsListWeek.Image")));
            this.biBookingsListWeek.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.biBookingsListWeek.Name = "biBookingsListWeek";
            this.biBookingsListWeek.OptionGroup = "navBar";
            this.biBookingsListWeek.Text = "Week view";
            this.biBookingsListWeek.Click += new System.EventHandler(this.biBookingsViewWeek_Click);
            // 
            // biBookingsListMonth
            // 
            this.biBookingsListMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.biBookingsListMonth.Image = ((System.Drawing.Image)(resources.GetObject("biBookingsListMonth.Image")));
            this.biBookingsListMonth.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.biBookingsListMonth.Name = "biBookingsListMonth";
            this.biBookingsListMonth.OptionGroup = "navBar";
            this.biBookingsListMonth.Text = "Month view";
            this.biBookingsListMonth.Click += new System.EventHandler(this.biBookingsViewMonth_Click);
            // 
            // biBookingsListYear
            // 
            this.biBookingsListYear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.biBookingsListYear.Image = ((System.Drawing.Image)(resources.GetObject("biBookingsListYear.Image")));
            this.biBookingsListYear.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.biBookingsListYear.Name = "biBookingsListYear";
            this.biBookingsListYear.OptionGroup = "navBar";
            this.biBookingsListYear.Text = "Year view";
            this.biBookingsListYear.Click += new System.EventHandler(this.biBookingsViewYear_Click);
            // 
            // biBookingsListGrid
            // 
            this.biBookingsListGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.biBookingsListGrid.Image = ((System.Drawing.Image)(resources.GetObject("biBookingsListGrid.Image")));
            this.biBookingsListGrid.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.biBookingsListGrid.Name = "biBookingsListGrid";
            this.biBookingsListGrid.OptionGroup = "navBar";
            this.biBookingsListGrid.Text = "Grid view";
            this.biBookingsListGrid.Click += new System.EventHandler(this.biBookingsViewGrid_Click);
            // 
            // biBookingsList
            // 
            this.biBookingsList.Checked = true;
            this.biBookingsList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.biBookingsList.Image = ((System.Drawing.Image)(resources.GetObject("biBookingsList.Image")));
            this.biBookingsList.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.biBookingsList.Name = "biBookingsList";
            this.biBookingsList.OptionGroup = "navBar";
            this.biBookingsList.Text = "List view";
            // 
            // gBookings
            // 
            this.gBookings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gBookings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gBookings.ContextMenuStrip = this.mBookings;
            this.gBookings.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.gBookings.ForeColor = System.Drawing.Color.Black;
            this.gBookings.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.gBookings.Location = new System.Drawing.Point(0, 34);
            this.gBookings.Name = "gBookings";
            // 
            // 
            // 
            this.gBookings.PrimaryGrid.AllowEdit = false;
            this.gBookings.PrimaryGrid.Columns.Add(this.gBookingsChk);
            this.gBookings.PrimaryGrid.Columns.Add(this.gBookingsJob);
            this.gBookings.PrimaryGrid.Columns.Add(this.gBookingsDates);
            this.gBookings.PrimaryGrid.Columns.Add(this.gBookingsStart);
            this.gBookings.PrimaryGrid.Columns.Add(this.gBookingsFinish);
            this.gBookings.PrimaryGrid.Columns.Add(this.gBookingsName);
            this.gBookings.PrimaryGrid.Columns.Add(this.gBookingsRooms);
            this.gBookings.PrimaryGrid.Columns.Add(this.gBookingsCompany);
            this.gBookings.PrimaryGrid.Columns.Add(this.gBookingsPhone);
            this.gBookings.PrimaryGrid.Columns.Add(this.gBookingsEmail);
            this.gBookings.PrimaryGrid.Columns.Add(this.gBookingsRoomLayout);
            this.gBookings.PrimaryGrid.MultiSelect = false;
            this.gBookings.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row;
            this.gBookings.PrimaryGrid.ShowRowHeaders = false;
            this.gBookings.PrimaryGrid.UseAlternateRowStyle = true;
            this.gBookings.Size = new System.Drawing.Size(880, 138);
            this.gBookings.TabIndex = 0;
            this.gBookings.Text = "superGridControl1";
            this.gBookings.RowActivated += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridRowActivatedEventArgs>(this.gBookings_RowActivated);
            // 
            // mBookings
            // 
            this.mBookings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mBookingsAdd,
            this.mBookingsRemove,
            this.mBookingsS1,
            this.mBookingsComplete});
            this.mBookings.Name = "contextMenuStrip1";
            this.mBookings.Size = new System.Drawing.Size(169, 76);
            // 
            // mBookingsAdd
            // 
            this.mBookingsAdd.Name = "mBookingsAdd";
            this.mBookingsAdd.Size = new System.Drawing.Size(168, 22);
            this.mBookingsAdd.Text = "Add booking...";
            this.mBookingsAdd.Click += new System.EventHandler(this.mBookingsAdd_Click);
            // 
            // mBookingsRemove
            // 
            this.mBookingsRemove.Name = "mBookingsRemove";
            this.mBookingsRemove.Size = new System.Drawing.Size(168, 22);
            this.mBookingsRemove.Text = "Remove booking";
            this.mBookingsRemove.Click += new System.EventHandler(this.mBookingsRemove_Click);
            // 
            // mBookingsS1
            // 
            this.mBookingsS1.Name = "mBookingsS1";
            this.mBookingsS1.Size = new System.Drawing.Size(165, 6);
            // 
            // mBookingsComplete
            // 
            this.mBookingsComplete.Name = "mBookingsComplete";
            this.mBookingsComplete.Size = new System.Drawing.Size(168, 22);
            this.mBookingsComplete.Text = "Mark as complete";
            this.mBookingsComplete.Click += new System.EventHandler(this.mBookingsComplete_Click);
            // 
            // gBookingsChk
            // 
            this.gBookingsChk.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.None;
            this.gBookingsChk.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridCheckBoxXEditControl);
            this.gBookingsChk.MinimumWidth = 32;
            this.gBookingsChk.Name = "";
            this.gBookingsChk.Width = 32;
            // 
            // gBookingsJob
            // 
            this.gBookingsJob.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.None;
            this.gBookingsJob.HeaderText = "BID";
            this.gBookingsJob.MinimumWidth = 60;
            this.gBookingsJob.Name = "Job";
            this.gBookingsJob.Width = 60;
            // 
            // gBookingsDates
            // 
            this.gBookingsDates.HeaderText = "Dates";
            this.gBookingsDates.Name = "Dates";
            // 
            // gBookingsStart
            // 
            this.gBookingsStart.HeaderText = "Start";
            this.gBookingsStart.Name = "Start";
            // 
            // gBookingsFinish
            // 
            this.gBookingsFinish.HeaderText = "Finish";
            this.gBookingsFinish.Name = "Finish";
            // 
            // gBookingsName
            // 
            this.gBookingsName.HeaderText = "Event Name";
            this.gBookingsName.Name = "Name";
            // 
            // gBookingsRooms
            // 
            this.gBookingsRooms.HeaderText = "Rooms";
            this.gBookingsRooms.Name = "Rooms";
            // 
            // gBookingsCompany
            // 
            this.gBookingsCompany.HeaderText = "Company";
            this.gBookingsCompany.Name = "Company";
            // 
            // gBookingsPhone
            // 
            this.gBookingsPhone.HeaderText = "Phone";
            this.gBookingsPhone.Name = "Phone";
            // 
            // gBookingsEmail
            // 
            this.gBookingsEmail.HeaderText = "E-mail Address";
            this.gBookingsEmail.Name = "Email";
            // 
            // gBookingsRoomLayout
            // 
            this.gBookingsRoomLayout.HeaderText = "Room Layout";
            this.gBookingsRoomLayout.Name = "RoomLayout";
            // 
            // pBookingsGrid
            // 
            this.pBookingsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pBookingsGrid.CanvasColor = System.Drawing.SystemColors.Control;
            this.pBookingsGrid.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pBookingsGrid.Controls.Add(this.rgBookings);
            this.pBookingsGrid.Controls.Add(this.pBookingsGridTools);
            this.pBookingsGrid.DisabledBackColor = System.Drawing.Color.Empty;
            this.pBookingsGrid.Location = new System.Drawing.Point(37, 190);
            this.pBookingsGrid.Name = "pBookingsGrid";
            this.pBookingsGrid.Size = new System.Drawing.Size(880, 160);
            this.pBookingsGrid.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pBookingsGrid.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pBookingsGrid.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pBookingsGrid.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pBookingsGrid.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pBookingsGrid.Style.GradientAngle = 90;
            this.pBookingsGrid.TabIndex = 7;
            this.pBookingsGrid.Visible = false;
            // 
            // rgBookings
            // 
            this.rgBookings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rgBookings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rgBookings.ColumnHeaderContextMenuStrip = null;
            this.rgBookings.ContextMenuStrip = this.mBookingsGrid;
            this.rgBookings.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgBookings.ForeColor = System.Drawing.Color.Black;
            this.rgBookings.LeadHeaderContextMenuStrip = null;
            this.rgBookings.Location = new System.Drawing.Point(0, 35);
            this.rgBookings.Name = "rgBookings";
            this.rgBookings.RowHeaderContextMenuStrip = null;
            this.rgBookings.Script = null;
            this.rgBookings.SheetTabContextMenuStrip = null;
            this.rgBookings.SheetTabControlNewButtonVisible = false;
            this.rgBookings.SheetTabControlWidth = 294;
            this.rgBookings.SheetTabNewButtonVisible = false;
            this.rgBookings.SheetTabWidth = 294;
            this.rgBookings.Size = new System.Drawing.Size(880, 126);
            this.rgBookings.TabIndex = 13;
            this.rgBookings.DoubleClick += new System.EventHandler(this.rgBookings_DoubleClick);
            // 
            // mBookingsGrid
            // 
            this.mBookingsGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mBookingsGridAdd,
            this.mBookingsGridRemove,
            this.mBookingsGridS1,
            this.mBookingsGridComplete});
            this.mBookingsGrid.Name = "contextMenuStrip1";
            this.mBookingsGrid.Size = new System.Drawing.Size(169, 76);
            // 
            // mBookingsGridAdd
            // 
            this.mBookingsGridAdd.Name = "mBookingsGridAdd";
            this.mBookingsGridAdd.Size = new System.Drawing.Size(168, 22);
            this.mBookingsGridAdd.Text = "Add booking...";
            this.mBookingsGridAdd.Click += new System.EventHandler(this.mBookingsGridAdd_Click);
            // 
            // mBookingsGridRemove
            // 
            this.mBookingsGridRemove.Name = "mBookingsGridRemove";
            this.mBookingsGridRemove.Size = new System.Drawing.Size(168, 22);
            this.mBookingsGridRemove.Text = "Remove booking";
            this.mBookingsGridRemove.Click += new System.EventHandler(this.mBookingsGridRemove_Click);
            // 
            // mBookingsGridS1
            // 
            this.mBookingsGridS1.Name = "mBookingsGridS1";
            this.mBookingsGridS1.Size = new System.Drawing.Size(165, 6);
            // 
            // mBookingsGridComplete
            // 
            this.mBookingsGridComplete.Name = "mBookingsGridComplete";
            this.mBookingsGridComplete.Size = new System.Drawing.Size(168, 22);
            this.mBookingsGridComplete.Text = "Mark as complete";
            this.mBookingsGridComplete.Click += new System.EventHandler(this.mBookingsGridComplete_Click);
            // 
            // pBookingsGridTools
            // 
            this.pBookingsGridTools.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pBookingsGridTools.CanvasColor = System.Drawing.SystemColors.Control;
            this.pBookingsGridTools.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pBookingsGridTools.Controls.Add(this.btnGridCompanyReset);
            this.pBookingsGridTools.Controls.Add(this.txtGridCompany);
            this.pBookingsGridTools.Controls.Add(this.lblGridBookings);
            this.pBookingsGridTools.Controls.Add(this.lblBookingsGridCompany);
            this.pBookingsGridTools.Controls.Add(this.nbBookingsGrid);
            this.pBookingsGridTools.DisabledBackColor = System.Drawing.Color.Empty;
            this.pBookingsGridTools.Location = new System.Drawing.Point(0, 0);
            this.pBookingsGridTools.Name = "pBookingsGridTools";
            this.pBookingsGridTools.Size = new System.Drawing.Size(880, 35);
            this.pBookingsGridTools.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pBookingsGridTools.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pBookingsGridTools.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pBookingsGridTools.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pBookingsGridTools.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pBookingsGridTools.Style.GradientAngle = 90;
            this.pBookingsGridTools.TabIndex = 0;
            // 
            // btnGridCompanyReset
            // 
            this.btnGridCompanyReset.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGridCompanyReset.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnGridCompanyReset.Location = new System.Drawing.Point(312, 5);
            this.btnGridCompanyReset.Name = "btnGridCompanyReset";
            this.btnGridCompanyReset.Size = new System.Drawing.Size(25, 25);
            this.btnGridCompanyReset.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnGridCompanyReset.TabIndex = 25;
            this.btnGridCompanyReset.Click += new System.EventHandler(this.btnGridCompanyReset_Click);
            // 
            // txtGridCompany
            // 
            this.txtGridCompany.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtGridCompany.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtGridCompany.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtGridCompany.Border.Class = "TextBoxBorder";
            this.txtGridCompany.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtGridCompany.DisabledBackColor = System.Drawing.Color.White;
            this.txtGridCompany.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGridCompany.ForeColor = System.Drawing.Color.Black;
            this.txtGridCompany.Location = new System.Drawing.Point(64, 5);
            this.txtGridCompany.Name = "txtGridCompany";
            this.txtGridCompany.PreventEnterBeep = true;
            this.txtGridCompany.Size = new System.Drawing.Size(244, 25);
            this.txtGridCompany.TabIndex = 24;
            // 
            // lblGridBookings
            // 
            this.lblGridBookings.AutoSize = true;
            // 
            // 
            // 
            this.lblGridBookings.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblGridBookings.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGridBookings.ForeColor = System.Drawing.Color.Black;
            this.lblGridBookings.Location = new System.Drawing.Point(348, 9);
            this.lblGridBookings.Name = "lblGridBookings";
            this.lblGridBookings.Size = new System.Drawing.Size(77, 17);
            this.lblGridBookings.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblGridBookings.TabIndex = 23;
            this.lblGridBookings.Text = "Total bookings:";
            // 
            // lblBookingsGridCompany
            // 
            this.lblBookingsGridCompany.AutoSize = true;
            // 
            // 
            // 
            this.lblBookingsGridCompany.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblBookingsGridCompany.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingsGridCompany.ForeColor = System.Drawing.Color.Black;
            this.lblBookingsGridCompany.Location = new System.Drawing.Point(7, 9);
            this.lblBookingsGridCompany.Name = "lblBookingsGridCompany";
            this.lblBookingsGridCompany.Size = new System.Drawing.Size(51, 17);
            this.lblBookingsGridCompany.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblBookingsGridCompany.TabIndex = 12;
            this.lblBookingsGridCompany.Text = "Company:";
            // 
            // nbBookingsGrid
            // 
            this.nbBookingsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nbBookingsGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nbBookingsGrid.BackgroundStyle.BackColor1.Color = System.Drawing.SystemColors.Control;
            this.nbBookingsGrid.BackgroundStyle.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.nbBookingsGrid.BackgroundStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.nbBookingsGrid.ConfigureItemVisible = false;
            this.nbBookingsGrid.ForeColor = System.Drawing.Color.Black;
            this.nbBookingsGrid.ItemPaddingBottom = 2;
            this.nbBookingsGrid.ItemPaddingTop = 2;
            this.nbBookingsGrid.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.biBookingsGridDay,
            this.biBookingsGridWeek,
            this.biBookingsGridMonth,
            this.biBookingsGridYear,
            this.biBookingsGrid,
            this.biBookingsGridList});
            this.nbBookingsGrid.Location = new System.Drawing.Point(698, 2);
            this.nbBookingsGrid.Name = "nbBookingsGrid";
            this.nbBookingsGrid.Size = new System.Drawing.Size(180, 30);
            this.nbBookingsGrid.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.nbBookingsGrid.TabIndex = 11;
            this.nbBookingsGrid.Text = "navigationBar1";
            // 
            // biBookingsGridDay
            // 
            this.biBookingsGridDay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.biBookingsGridDay.Image = ((System.Drawing.Image)(resources.GetObject("biBookingsGridDay.Image")));
            this.biBookingsGridDay.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.biBookingsGridDay.Name = "biBookingsGridDay";
            this.biBookingsGridDay.OptionGroup = "navBar";
            this.biBookingsGridDay.Text = "Day view";
            this.biBookingsGridDay.Click += new System.EventHandler(this.biBookingsViewDay_Click);
            // 
            // biBookingsGridWeek
            // 
            this.biBookingsGridWeek.Cursor = System.Windows.Forms.Cursors.Hand;
            this.biBookingsGridWeek.Image = ((System.Drawing.Image)(resources.GetObject("biBookingsGridWeek.Image")));
            this.biBookingsGridWeek.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.biBookingsGridWeek.Name = "biBookingsGridWeek";
            this.biBookingsGridWeek.OptionGroup = "navBar";
            this.biBookingsGridWeek.Text = "Week view";
            this.biBookingsGridWeek.Click += new System.EventHandler(this.biBookingsViewWeek_Click);
            // 
            // biBookingsGridMonth
            // 
            this.biBookingsGridMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.biBookingsGridMonth.Image = ((System.Drawing.Image)(resources.GetObject("biBookingsGridMonth.Image")));
            this.biBookingsGridMonth.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.biBookingsGridMonth.Name = "biBookingsGridMonth";
            this.biBookingsGridMonth.OptionGroup = "navBar";
            this.biBookingsGridMonth.Text = "Month view";
            this.biBookingsGridMonth.Click += new System.EventHandler(this.biBookingsViewMonth_Click);
            // 
            // biBookingsGridYear
            // 
            this.biBookingsGridYear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.biBookingsGridYear.Image = ((System.Drawing.Image)(resources.GetObject("biBookingsGridYear.Image")));
            this.biBookingsGridYear.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.biBookingsGridYear.Name = "biBookingsGridYear";
            this.biBookingsGridYear.OptionGroup = "navBar";
            this.biBookingsGridYear.Text = "Year view";
            this.biBookingsGridYear.Click += new System.EventHandler(this.biBookingsViewYear_Click);
            // 
            // biBookingsGrid
            // 
            this.biBookingsGrid.Checked = true;
            this.biBookingsGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.biBookingsGrid.Image = ((System.Drawing.Image)(resources.GetObject("biBookingsGrid.Image")));
            this.biBookingsGrid.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.biBookingsGrid.Name = "biBookingsGrid";
            this.biBookingsGrid.OptionGroup = "navBar";
            this.biBookingsGrid.Text = "Grid view";
            // 
            // biBookingsGridList
            // 
            this.biBookingsGridList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.biBookingsGridList.Image = ((System.Drawing.Image)(resources.GetObject("biBookingsGridList.Image")));
            this.biBookingsGridList.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.biBookingsGridList.Name = "biBookingsGridList";
            this.biBookingsGridList.OptionGroup = "navBar";
            this.biBookingsGridList.Text = "List view";
            this.biBookingsGridList.Click += new System.EventHandler(this.biBookingsViewList_Click);
            // 
            // pBookingsCalendar
            // 
            this.pBookingsCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pBookingsCalendar.CanvasColor = System.Drawing.SystemColors.Control;
            this.pBookingsCalendar.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pBookingsCalendar.Controls.Add(this.pBookingsCalendarTools);
            this.pBookingsCalendar.Controls.Add(this.cvBookings);
            this.pBookingsCalendar.DisabledBackColor = System.Drawing.Color.Empty;
            this.pBookingsCalendar.Location = new System.Drawing.Point(37, 6);
            this.pBookingsCalendar.Name = "pBookingsCalendar";
            this.pBookingsCalendar.Size = new System.Drawing.Size(880, 178);
            this.pBookingsCalendar.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pBookingsCalendar.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pBookingsCalendar.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pBookingsCalendar.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pBookingsCalendar.Style.GradientAngle = 90;
            this.pBookingsCalendar.TabIndex = 0;
            this.pBookingsCalendar.Visible = false;
            // 
            // pBookingsCalendarTools
            // 
            this.pBookingsCalendarTools.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pBookingsCalendarTools.CanvasColor = System.Drawing.SystemColors.Control;
            this.pBookingsCalendarTools.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pBookingsCalendarTools.Controls.Add(this.lblCalendarBookings);
            this.pBookingsCalendarTools.Controls.Add(this.nbBookings);
            this.pBookingsCalendarTools.Controls.Add(this.dnBookings);
            this.pBookingsCalendarTools.DisabledBackColor = System.Drawing.Color.Empty;
            this.pBookingsCalendarTools.Location = new System.Drawing.Point(0, 0);
            this.pBookingsCalendarTools.Name = "pBookingsCalendarTools";
            this.pBookingsCalendarTools.Size = new System.Drawing.Size(880, 35);
            this.pBookingsCalendarTools.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pBookingsCalendarTools.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pBookingsCalendarTools.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pBookingsCalendarTools.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pBookingsCalendarTools.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pBookingsCalendarTools.Style.GradientAngle = 90;
            this.pBookingsCalendarTools.TabIndex = 5;
            // 
            // lblCalendarBookings
            // 
            this.lblCalendarBookings.AutoSize = true;
            // 
            // 
            // 
            this.lblCalendarBookings.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCalendarBookings.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalendarBookings.ForeColor = System.Drawing.Color.Black;
            this.lblCalendarBookings.Location = new System.Drawing.Point(348, 8);
            this.lblCalendarBookings.Name = "lblCalendarBookings";
            this.lblCalendarBookings.Size = new System.Drawing.Size(77, 17);
            this.lblCalendarBookings.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblCalendarBookings.TabIndex = 24;
            this.lblCalendarBookings.Text = "Total bookings:";
            // 
            // nbBookings
            // 
            this.nbBookings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nbBookings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nbBookings.BackgroundStyle.BackColor1.Color = System.Drawing.SystemColors.Control;
            this.nbBookings.BackgroundStyle.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.nbBookings.BackgroundStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.nbBookings.ConfigureItemVisible = false;
            this.nbBookings.ForeColor = System.Drawing.Color.Black;
            this.nbBookings.ItemPaddingBottom = 2;
            this.nbBookings.ItemPaddingTop = 2;
            this.nbBookings.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.biBookingsViewDay,
            this.biBookingsViewWeek,
            this.biBookingsViewMonth,
            this.biBookingsViewYear,
            this.biBookingsViewGrid,
            this.biBookingsViewList});
            this.nbBookings.Location = new System.Drawing.Point(698, 2);
            this.nbBookings.Name = "nbBookings";
            this.nbBookings.Size = new System.Drawing.Size(180, 30);
            this.nbBookings.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.nbBookings.TabIndex = 10;
            this.nbBookings.Text = "navigationBar1";
            // 
            // biBookingsViewDay
            // 
            this.biBookingsViewDay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.biBookingsViewDay.Image = ((System.Drawing.Image)(resources.GetObject("biBookingsViewDay.Image")));
            this.biBookingsViewDay.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.biBookingsViewDay.Name = "biBookingsViewDay";
            this.biBookingsViewDay.OptionGroup = "navBar";
            this.biBookingsViewDay.Text = "Day view";
            this.biBookingsViewDay.Click += new System.EventHandler(this.biBookingsViewDay_Click);
            // 
            // biBookingsViewWeek
            // 
            this.biBookingsViewWeek.Cursor = System.Windows.Forms.Cursors.Hand;
            this.biBookingsViewWeek.Image = ((System.Drawing.Image)(resources.GetObject("biBookingsViewWeek.Image")));
            this.biBookingsViewWeek.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.biBookingsViewWeek.Name = "biBookingsViewWeek";
            this.biBookingsViewWeek.OptionGroup = "navBar";
            this.biBookingsViewWeek.Text = "Week view";
            this.biBookingsViewWeek.Click += new System.EventHandler(this.biBookingsViewWeek_Click);
            // 
            // biBookingsViewMonth
            // 
            this.biBookingsViewMonth.Checked = true;
            this.biBookingsViewMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.biBookingsViewMonth.Image = ((System.Drawing.Image)(resources.GetObject("biBookingsViewMonth.Image")));
            this.biBookingsViewMonth.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.biBookingsViewMonth.Name = "biBookingsViewMonth";
            this.biBookingsViewMonth.OptionGroup = "navBar";
            this.biBookingsViewMonth.Text = "Month view";
            this.biBookingsViewMonth.Click += new System.EventHandler(this.biBookingsViewMonth_Click);
            // 
            // biBookingsViewYear
            // 
            this.biBookingsViewYear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.biBookingsViewYear.Image = ((System.Drawing.Image)(resources.GetObject("biBookingsViewYear.Image")));
            this.biBookingsViewYear.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.biBookingsViewYear.Name = "biBookingsViewYear";
            this.biBookingsViewYear.OptionGroup = "navBar";
            this.biBookingsViewYear.Text = "Year view";
            this.biBookingsViewYear.Click += new System.EventHandler(this.biBookingsViewYear_Click);
            // 
            // biBookingsViewGrid
            // 
            this.biBookingsViewGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.biBookingsViewGrid.Image = ((System.Drawing.Image)(resources.GetObject("biBookingsViewGrid.Image")));
            this.biBookingsViewGrid.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.biBookingsViewGrid.Name = "biBookingsViewGrid";
            this.biBookingsViewGrid.OptionGroup = "navBar";
            this.biBookingsViewGrid.Text = "Grid view";
            this.biBookingsViewGrid.Click += new System.EventHandler(this.biBookingsViewGrid_Click);
            // 
            // biBookingsViewList
            // 
            this.biBookingsViewList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.biBookingsViewList.Image = ((System.Drawing.Image)(resources.GetObject("biBookingsViewList.Image")));
            this.biBookingsViewList.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.biBookingsViewList.Name = "biBookingsViewList";
            this.biBookingsViewList.OptionGroup = "navBar";
            this.biBookingsViewList.Text = "List view";
            this.biBookingsViewList.Click += new System.EventHandler(this.biBookingsViewList_Click);
            // 
            // dnBookings
            // 
            this.dnBookings.CalendarView = this.cvBookings;
            this.dnBookings.CanvasColor = System.Drawing.SystemColors.Control;
            this.dnBookings.DisabledBackColor = System.Drawing.Color.Empty;
            this.dnBookings.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dnBookings.Location = new System.Drawing.Point(0, 2);
            this.dnBookings.Name = "dnBookings";
            this.dnBookings.Size = new System.Drawing.Size(308, 30);
            this.dnBookings.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dnBookings.TabIndex = 9;
            this.dnBookings.Text = "dateNavigator1";
            // 
            // cvBookings
            // 
            this.cvBookings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cvBookings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.cvBookings.BackgroundStyle.BackColor = System.Drawing.Color.White;
            this.cvBookings.BackgroundStyle.BackColor2 = System.Drawing.Color.White;
            this.cvBookings.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cvBookings.BackgroundStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cvBookings.ContainerControlProcessDialogKey = true;
            this.cvBookings.ContextMenuStrip = this.mBookings;
            this.cvBookings.EnableDragCopy = false;
            this.cvBookings.EnableDragDrop = false;
            this.cvBookings.ForeColor = System.Drawing.Color.Black;
            this.cvBookings.HighlightCurrentDay = true;
            this.cvBookings.Is24HourFormat = true;
            this.cvBookings.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.cvBookings.Location = new System.Drawing.Point(0, 34);
            this.cvBookings.MultiUserTabHeight = 21;
            this.cvBookings.Name = "cvBookings";
            this.cvBookings.SelectedView = DevComponents.DotNetBar.Schedule.eCalendarView.Month;
            this.cvBookings.Size = new System.Drawing.Size(880, 144);
            this.cvBookings.TabIndex = 4;
            this.cvBookings.TimeIndicator.BorderColor = System.Drawing.Color.Empty;
            this.cvBookings.TimeIndicator.Tag = null;
            this.cvBookings.TimeSlotDuration = 30;
            this.cvBookings.ItemClick += new System.EventHandler(this.cvBookings_ItemClick);
            this.cvBookings.ItemDoubleClick += new System.Windows.Forms.MouseEventHandler(this.cvBookings_ItemDoubleClick);
            this.cvBookings.MouseEnter += new System.EventHandler(this.cvBookings_MouseEnter);
            this.cvBookings.MouseLeave += new System.EventHandler(this.cvBookings_MouseLeave);
            // 
            // pEnquiries
            // 
            this.pEnquiries.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pEnquiries.Controls.Add(this.scEnquiries);
            this.pEnquiries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pEnquiries.Location = new System.Drawing.Point(0, 61);
            this.pEnquiries.Name = "pEnquiries";
            this.pEnquiries.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.pEnquiries.Size = new System.Drawing.Size(960, 535);
            // 
            // 
            // 
            this.pEnquiries.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pEnquiries.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pEnquiries.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pEnquiries.TabIndex = 5;
            this.pEnquiries.Visible = false;
            // 
            // scEnquiries
            // 
            this.scEnquiries.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scEnquiries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.scEnquiries.ButtonPosition = DevComponents.DotNetBar.Controls.eSplitterButtonPosition.Center;
            this.scEnquiries.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.scEnquiries.ForeColor = System.Drawing.Color.Black;
            this.scEnquiries.IsSplitterFixed = true;
            this.scEnquiries.Location = new System.Drawing.Point(0, 0);
            this.scEnquiries.Name = "scEnquiries";
            this.scEnquiries.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scEnquiries.Panel1
            // 
            this.scEnquiries.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.scEnquiries.Panel1.Controls.Add(this.pEnquiriesGrid);
            this.scEnquiries.Panel1.ForeColor = System.Drawing.Color.Black;
            // 
            // scEnquiries.Panel2
            // 
            this.scEnquiries.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.scEnquiries.Panel2.Controls.Add(this.pEnquiry);
            this.scEnquiries.Panel2.ForeColor = System.Drawing.Color.Black;
            this.scEnquiries.Size = new System.Drawing.Size(960, 536);
            this.scEnquiries.SplitterDistance = 180;
            this.scEnquiries.SplitterWidth = 20;
            this.scEnquiries.TabIndex = 26;
            // 
            // pEnquiriesGrid
            // 
            this.pEnquiriesGrid.CanvasColor = System.Drawing.SystemColors.Control;
            this.pEnquiriesGrid.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pEnquiriesGrid.Controls.Add(this.pEnquiriesGridTools);
            this.pEnquiriesGrid.Controls.Add(this.gEnquiries);
            this.pEnquiriesGrid.DisabledBackColor = System.Drawing.Color.Empty;
            this.pEnquiriesGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pEnquiriesGrid.Location = new System.Drawing.Point(0, 0);
            this.pEnquiriesGrid.Name = "pEnquiriesGrid";
            this.pEnquiriesGrid.Size = new System.Drawing.Size(960, 180);
            this.pEnquiriesGrid.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pEnquiriesGrid.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pEnquiriesGrid.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pEnquiriesGrid.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pEnquiriesGrid.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pEnquiriesGrid.Style.GradientAngle = 90;
            this.pEnquiriesGrid.TabIndex = 26;
            // 
            // pEnquiriesGridTools
            // 
            this.pEnquiriesGridTools.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pEnquiriesGridTools.CanvasColor = System.Drawing.SystemColors.Control;
            this.pEnquiriesGridTools.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pEnquiriesGridTools.Controls.Add(this.btnEnquiriesListCompany);
            this.pEnquiriesGridTools.Controls.Add(this.txtEnquiriesListCompany);
            this.pEnquiriesGridTools.Controls.Add(this.lblGridEnquiries);
            this.pEnquiriesGridTools.Controls.Add(this.lblEnquiriesCompany);
            this.pEnquiriesGridTools.DisabledBackColor = System.Drawing.Color.Empty;
            this.pEnquiriesGridTools.Location = new System.Drawing.Point(0, 0);
            this.pEnquiriesGridTools.Name = "pEnquiriesGridTools";
            this.pEnquiriesGridTools.Size = new System.Drawing.Size(960, 35);
            this.pEnquiriesGridTools.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pEnquiriesGridTools.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pEnquiriesGridTools.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pEnquiriesGridTools.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pEnquiriesGridTools.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pEnquiriesGridTools.Style.GradientAngle = 90;
            this.pEnquiriesGridTools.TabIndex = 4;
            // 
            // btnEnquiriesListCompany
            // 
            this.btnEnquiriesListCompany.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEnquiriesListCompany.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEnquiriesListCompany.Location = new System.Drawing.Point(312, 5);
            this.btnEnquiriesListCompany.Name = "btnEnquiriesListCompany";
            this.btnEnquiriesListCompany.Size = new System.Drawing.Size(25, 25);
            this.btnEnquiriesListCompany.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEnquiriesListCompany.TabIndex = 28;
            // 
            // txtEnquiriesListCompany
            // 
            this.txtEnquiriesListCompany.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtEnquiriesListCompany.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtEnquiriesListCompany.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtEnquiriesListCompany.Border.Class = "TextBoxBorder";
            this.txtEnquiriesListCompany.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtEnquiriesListCompany.DisabledBackColor = System.Drawing.Color.White;
            this.txtEnquiriesListCompany.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnquiriesListCompany.ForeColor = System.Drawing.Color.Black;
            this.txtEnquiriesListCompany.Location = new System.Drawing.Point(64, 5);
            this.txtEnquiriesListCompany.Name = "txtEnquiriesListCompany";
            this.txtEnquiriesListCompany.PreventEnterBeep = true;
            this.txtEnquiriesListCompany.Size = new System.Drawing.Size(244, 25);
            this.txtEnquiriesListCompany.TabIndex = 27;
            // 
            // lblGridEnquiries
            // 
            this.lblGridEnquiries.AutoSize = true;
            // 
            // 
            // 
            this.lblGridEnquiries.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblGridEnquiries.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGridEnquiries.ForeColor = System.Drawing.Color.Black;
            this.lblGridEnquiries.Location = new System.Drawing.Point(351, 9);
            this.lblGridEnquiries.Name = "lblGridEnquiries";
            this.lblGridEnquiries.Size = new System.Drawing.Size(76, 17);
            this.lblGridEnquiries.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblGridEnquiries.TabIndex = 26;
            this.lblGridEnquiries.Text = "Total enquiries:";
            // 
            // lblEnquiriesCompany
            // 
            this.lblEnquiriesCompany.AutoSize = true;
            // 
            // 
            // 
            this.lblEnquiriesCompany.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblEnquiriesCompany.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnquiriesCompany.ForeColor = System.Drawing.Color.Black;
            this.lblEnquiriesCompany.Location = new System.Drawing.Point(7, 9);
            this.lblEnquiriesCompany.Name = "lblEnquiriesCompany";
            this.lblEnquiriesCompany.Size = new System.Drawing.Size(51, 17);
            this.lblEnquiriesCompany.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblEnquiriesCompany.TabIndex = 24;
            this.lblEnquiriesCompany.Text = "Company:";
            // 
            // gEnquiries
            // 
            this.gEnquiries.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gEnquiries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gEnquiries.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.gEnquiries.ForeColor = System.Drawing.Color.Black;
            this.gEnquiries.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.gEnquiries.Location = new System.Drawing.Point(0, 34);
            this.gEnquiries.Name = "gEnquiries";
            // 
            // 
            // 
            this.gEnquiries.PrimaryGrid.AllowEdit = false;
            this.gEnquiries.PrimaryGrid.Columns.Add(this.gEnquiriesChk);
            this.gEnquiries.PrimaryGrid.Columns.Add(this.gEnquiriesJob);
            this.gEnquiries.PrimaryGrid.Columns.Add(this.gEnquiriesDates);
            this.gEnquiries.PrimaryGrid.Columns.Add(this.gEnquiriesStart);
            this.gEnquiries.PrimaryGrid.Columns.Add(this.gEnquiriesFinish);
            this.gEnquiries.PrimaryGrid.Columns.Add(this.gEnquiriesName);
            this.gEnquiries.PrimaryGrid.Columns.Add(this.gEnquiriesRooms);
            this.gEnquiries.PrimaryGrid.Columns.Add(this.gEnquiriesCompany);
            this.gEnquiries.PrimaryGrid.Columns.Add(this.gEnquiriesPhone);
            this.gEnquiries.PrimaryGrid.Columns.Add(this.gEnquiriesEmail);
            this.gEnquiries.PrimaryGrid.Columns.Add(this.gEnquiriesLayout);
            this.gEnquiries.PrimaryGrid.MultiSelect = false;
            this.gEnquiries.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row;
            this.gEnquiries.PrimaryGrid.ShowRowHeaders = false;
            this.gEnquiries.PrimaryGrid.UseAlternateRowStyle = true;
            this.gEnquiries.Size = new System.Drawing.Size(960, 146);
            this.gEnquiries.TabIndex = 0;
            this.gEnquiries.Text = "superGridControl1";
            // 
            // gEnquiriesChk
            // 
            this.gEnquiriesChk.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.None;
            this.gEnquiriesChk.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridCheckBoxXEditControl);
            this.gEnquiriesChk.MinimumWidth = 32;
            this.gEnquiriesChk.Name = "";
            this.gEnquiriesChk.Width = 32;
            // 
            // gEnquiriesJob
            // 
            this.gEnquiriesJob.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.None;
            this.gEnquiriesJob.HeaderText = "EID";
            this.gEnquiriesJob.MinimumWidth = 60;
            this.gEnquiriesJob.Name = "Job";
            this.gEnquiriesJob.Width = 60;
            // 
            // gEnquiriesDates
            // 
            this.gEnquiriesDates.HeaderText = "Dates";
            this.gEnquiriesDates.Name = "Dates";
            // 
            // gEnquiriesStart
            // 
            this.gEnquiriesStart.HeaderText = "Start";
            this.gEnquiriesStart.Name = "Start";
            // 
            // gEnquiriesFinish
            // 
            this.gEnquiriesFinish.HeaderText = "Finish";
            this.gEnquiriesFinish.Name = "Finish";
            // 
            // gEnquiriesName
            // 
            this.gEnquiriesName.HeaderText = "Event Name";
            this.gEnquiriesName.Name = "Name";
            // 
            // gEnquiriesRooms
            // 
            this.gEnquiriesRooms.HeaderText = "Rooms";
            this.gEnquiriesRooms.Name = "Rooms";
            // 
            // gEnquiriesCompany
            // 
            this.gEnquiriesCompany.HeaderText = "Company";
            this.gEnquiriesCompany.Name = "Company";
            // 
            // gEnquiriesPhone
            // 
            this.gEnquiriesPhone.HeaderText = "Phone";
            this.gEnquiriesPhone.Name = "Phone";
            // 
            // gEnquiriesEmail
            // 
            this.gEnquiriesEmail.HeaderText = "E-mail Address";
            this.gEnquiriesEmail.Name = "Email";
            // 
            // gEnquiriesLayout
            // 
            this.gEnquiriesLayout.HeaderText = "Room Layout";
            this.gEnquiriesLayout.Name = "RoomLayout";
            // 
            // pEnquiry
            // 
            this.pEnquiry.CanvasColor = System.Drawing.SystemColors.Control;
            this.pEnquiry.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pEnquiry.DisabledBackColor = System.Drawing.Color.Empty;
            this.pEnquiry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pEnquiry.Location = new System.Drawing.Point(0, 0);
            this.pEnquiry.Name = "pEnquiry";
            this.pEnquiry.Size = new System.Drawing.Size(960, 336);
            this.pEnquiry.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pEnquiry.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pEnquiry.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pEnquiry.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pEnquiry.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pEnquiry.Style.GradientAngle = 90;
            this.pEnquiry.TabIndex = 4;
            // 
            // pCourses
            // 
            this.pCourses.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pCourses.Controls.Add(this.scCourses);
            this.pCourses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pCourses.Location = new System.Drawing.Point(0, 61);
            this.pCourses.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pCourses.Name = "pCourses";
            this.pCourses.Padding = new System.Windows.Forms.Padding(3, 0, 3, 4);
            this.pCourses.Size = new System.Drawing.Size(960, 535);
            // 
            // 
            // 
            this.pCourses.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pCourses.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pCourses.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pCourses.TabIndex = 2;
            this.pCourses.Visible = false;
            // 
            // scCourses
            // 
            this.scCourses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scCourses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.scCourses.ButtonPosition = DevComponents.DotNetBar.Controls.eSplitterButtonPosition.Center;
            this.scCourses.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.scCourses.ForeColor = System.Drawing.Color.Black;
            this.scCourses.IsSplitterFixed = true;
            this.scCourses.Location = new System.Drawing.Point(0, 0);
            this.scCourses.Name = "scCourses";
            this.scCourses.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scCourses.Panel1
            // 
            this.scCourses.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.scCourses.Panel1.Controls.Add(this.gCourses);
            this.scCourses.Panel1.ForeColor = System.Drawing.Color.Black;
            // 
            // scCourses.Panel2
            // 
            this.scCourses.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.scCourses.Panel2.Controls.Add(this.pCourse);
            this.scCourses.Panel2.ForeColor = System.Drawing.Color.Black;
            this.scCourses.Size = new System.Drawing.Size(960, 535);
            this.scCourses.SplitterDistance = 180;
            this.scCourses.SplitterWidth = 20;
            this.scCourses.TabIndex = 2;
            // 
            // gCourses
            // 
            this.gCourses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gCourses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gCourses.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.gCourses.ForeColor = System.Drawing.Color.Black;
            this.gCourses.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.gCourses.Location = new System.Drawing.Point(0, 0);
            this.gCourses.Name = "gCourses";
            // 
            // 
            // 
            this.gCourses.PrimaryGrid.AllowEdit = false;
            this.gCourses.PrimaryGrid.Columns.Add(this.gCoursesChk);
            this.gCourses.PrimaryGrid.Columns.Add(this.gCoursesID);
            this.gCourses.PrimaryGrid.Columns.Add(this.gCoursesName);
            this.gCourses.PrimaryGrid.Columns.Add(this.gCoursesCert);
            this.gCourses.PrimaryGrid.Columns.Add(this.gCoursesDuration);
            this.gCourses.PrimaryGrid.Columns.Add(this.gCoursesPrice);
            this.gCourses.PrimaryGrid.MultiSelect = false;
            this.gCourses.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row;
            this.gCourses.PrimaryGrid.ShowRowHeaders = false;
            this.gCourses.PrimaryGrid.UseAlternateRowStyle = true;
            this.gCourses.Size = new System.Drawing.Size(960, 180);
            this.gCourses.TabIndex = 2;
            this.gCourses.Text = "superGridControl1";
            // 
            // gCoursesChk
            // 
            this.gCoursesChk.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.None;
            this.gCoursesChk.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridCheckBoxXEditControl);
            this.gCoursesChk.MinimumWidth = 32;
            this.gCoursesChk.Name = "";
            this.gCoursesChk.Width = 32;
            // 
            // gCoursesID
            // 
            this.gCoursesID.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.None;
            this.gCoursesID.HeaderText = "ID";
            this.gCoursesID.MinimumWidth = 60;
            this.gCoursesID.Name = "ID";
            this.gCoursesID.Width = 60;
            // 
            // gCoursesName
            // 
            this.gCoursesName.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            this.gCoursesName.HeaderText = "Name";
            this.gCoursesName.MinimumWidth = 300;
            this.gCoursesName.Name = "Name";
            this.gCoursesName.Width = 300;
            // 
            // gCoursesCert
            // 
            this.gCoursesCert.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.None;
            this.gCoursesCert.HeaderText = "Certification";
            this.gCoursesCert.MinimumWidth = 150;
            this.gCoursesCert.Name = "Certification";
            this.gCoursesCert.Width = 150;
            // 
            // gCoursesDuration
            // 
            this.gCoursesDuration.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.None;
            this.gCoursesDuration.HeaderText = "Duration";
            this.gCoursesDuration.MinimumWidth = 250;
            this.gCoursesDuration.Name = "Duration";
            this.gCoursesDuration.Width = 250;
            // 
            // gCoursesPrice
            // 
            this.gCoursesPrice.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.None;
            this.gCoursesPrice.HeaderText = "Pricing";
            this.gCoursesPrice.MinimumWidth = 250;
            this.gCoursesPrice.Name = "Pricing";
            this.gCoursesPrice.Width = 250;
            // 
            // pCourse
            // 
            this.pCourse.CanvasColor = System.Drawing.SystemColors.Control;
            this.pCourse.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pCourse.DisabledBackColor = System.Drawing.Color.Empty;
            this.pCourse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pCourse.Location = new System.Drawing.Point(0, 0);
            this.pCourse.Name = "pCourse";
            this.pCourse.Size = new System.Drawing.Size(960, 335);
            this.pCourse.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pCourse.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pCourse.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pCourse.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pCourse.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pCourse.Style.GradientAngle = 90;
            this.pCourse.TabIndex = 8;
            // 
            // pCompanies
            // 
            this.pCompanies.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pCompanies.Controls.Add(this.scCompanies);
            this.pCompanies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pCompanies.Location = new System.Drawing.Point(0, 61);
            this.pCompanies.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pCompanies.Name = "pCompanies";
            this.pCompanies.Padding = new System.Windows.Forms.Padding(3, 0, 3, 4);
            this.pCompanies.Size = new System.Drawing.Size(960, 535);
            // 
            // 
            // 
            this.pCompanies.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pCompanies.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pCompanies.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pCompanies.TabIndex = 3;
            this.pCompanies.Visible = false;
            // 
            // scCompanies
            // 
            this.scCompanies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scCompanies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.scCompanies.ButtonPosition = DevComponents.DotNetBar.Controls.eSplitterButtonPosition.Center;
            this.scCompanies.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.scCompanies.ForeColor = System.Drawing.Color.Black;
            this.scCompanies.IsSplitterFixed = true;
            this.scCompanies.Location = new System.Drawing.Point(0, 0);
            this.scCompanies.Name = "scCompanies";
            this.scCompanies.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scCompanies.Panel1
            // 
            this.scCompanies.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.scCompanies.Panel1.Controls.Add(this.gCompanies);
            this.scCompanies.Panel1.ForeColor = System.Drawing.Color.Black;
            // 
            // scCompanies.Panel2
            // 
            this.scCompanies.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.scCompanies.Panel2.Controls.Add(this.pCompany);
            this.scCompanies.Panel2.ForeColor = System.Drawing.Color.Black;
            this.scCompanies.Size = new System.Drawing.Size(960, 535);
            this.scCompanies.SplitterDistance = 180;
            this.scCompanies.SplitterWidth = 20;
            this.scCompanies.TabIndex = 0;
            // 
            // gCompanies
            // 
            this.gCompanies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gCompanies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gCompanies.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.gCompanies.ForeColor = System.Drawing.Color.Black;
            this.gCompanies.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.gCompanies.Location = new System.Drawing.Point(0, 0);
            this.gCompanies.Name = "gCompanies";
            // 
            // 
            // 
            this.gCompanies.PrimaryGrid.AllowEdit = false;
            this.gCompanies.PrimaryGrid.Columns.Add(this.gCompaniesChk);
            this.gCompanies.PrimaryGrid.Columns.Add(this.gCompaniesID);
            this.gCompanies.PrimaryGrid.Columns.Add(this.gCompaniesName);
            this.gCompanies.PrimaryGrid.Columns.Add(this.gCompaniesContact);
            this.gCompanies.PrimaryGrid.Columns.Add(this.gCompaniesPhone);
            this.gCompanies.PrimaryGrid.Columns.Add(this.gCompaniesEmail);
            this.gCompanies.PrimaryGrid.Columns.Add(this.gCompaniesAddress);
            this.gCompanies.PrimaryGrid.Columns.Add(this.gCompaniesReg);
            this.gCompanies.PrimaryGrid.Columns.Add(this.gCompaniesVat);
            this.gCompanies.PrimaryGrid.MultiSelect = false;
            this.gCompanies.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row;
            this.gCompanies.PrimaryGrid.ShowRowHeaders = false;
            this.gCompanies.PrimaryGrid.UseAlternateRowStyle = true;
            this.gCompanies.Size = new System.Drawing.Size(960, 180);
            this.gCompanies.TabIndex = 2;
            this.gCompanies.Text = "superGridControl1";
            // 
            // gCompaniesChk
            // 
            this.gCompaniesChk.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.None;
            this.gCompaniesChk.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridCheckBoxXEditControl);
            this.gCompaniesChk.MinimumWidth = 32;
            this.gCompaniesChk.Name = "";
            this.gCompaniesChk.Width = 32;
            // 
            // gCompaniesID
            // 
            this.gCompaniesID.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.None;
            this.gCompaniesID.HeaderText = "ID";
            this.gCompaniesID.MinimumWidth = 60;
            this.gCompaniesID.Name = "ID";
            this.gCompaniesID.Width = 60;
            // 
            // gCompaniesName
            // 
            this.gCompaniesName.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            this.gCompaniesName.HeaderText = "Name";
            this.gCompaniesName.MinimumWidth = 200;
            this.gCompaniesName.Name = "Name";
            // 
            // gCompaniesContact
            // 
            this.gCompaniesContact.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.None;
            this.gCompaniesContact.HeaderText = "Contact";
            this.gCompaniesContact.MinimumWidth = 150;
            this.gCompaniesContact.Name = "Contact";
            this.gCompaniesContact.Width = 150;
            // 
            // gCompaniesPhone
            // 
            this.gCompaniesPhone.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.None;
            this.gCompaniesPhone.HeaderText = "Phone";
            this.gCompaniesPhone.MinimumWidth = 125;
            this.gCompaniesPhone.Name = "Phone";
            this.gCompaniesPhone.Width = 125;
            // 
            // gCompaniesEmail
            // 
            this.gCompaniesEmail.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.None;
            this.gCompaniesEmail.HeaderText = "E-mail Address";
            this.gCompaniesEmail.MinimumWidth = 250;
            this.gCompaniesEmail.Name = "Email";
            this.gCompaniesEmail.Width = 250;
            // 
            // gCompaniesAddress
            // 
            this.gCompaniesAddress.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.None;
            this.gCompaniesAddress.HeaderText = "Address";
            this.gCompaniesAddress.MinimumWidth = 250;
            this.gCompaniesAddress.Name = "Address";
            this.gCompaniesAddress.Width = 250;
            // 
            // gCompaniesReg
            // 
            this.gCompaniesReg.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.None;
            this.gCompaniesReg.HeaderText = "Reg. No.";
            this.gCompaniesReg.MinimumWidth = 100;
            this.gCompaniesReg.Name = "Reg";
            // 
            // gCompaniesVat
            // 
            this.gCompaniesVat.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.None;
            this.gCompaniesVat.HeaderText = "VAT No.";
            this.gCompaniesVat.MinimumWidth = 100;
            this.gCompaniesVat.Name = "VAT";
            // 
            // pCompany
            // 
            this.pCompany.CanvasColor = System.Drawing.SystemColors.Control;
            this.pCompany.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pCompany.DisabledBackColor = System.Drawing.Color.Empty;
            this.pCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pCompany.Location = new System.Drawing.Point(0, 0);
            this.pCompany.Name = "pCompany";
            this.pCompany.Size = new System.Drawing.Size(960, 335);
            this.pCompany.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pCompany.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pCompany.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pCompany.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pCompany.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pCompany.Style.GradientAngle = 90;
            this.pCompany.TabIndex = 8;
            // 
            // pContacts
            // 
            this.pContacts.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pContacts.Controls.Add(this.scContacts);
            this.pContacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContacts.Location = new System.Drawing.Point(0, 61);
            this.pContacts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pContacts.Name = "pContacts";
            this.pContacts.Padding = new System.Windows.Forms.Padding(3, 0, 3, 4);
            this.pContacts.Size = new System.Drawing.Size(960, 535);
            // 
            // 
            // 
            this.pContacts.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pContacts.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pContacts.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pContacts.TabIndex = 4;
            // 
            // scContacts
            // 
            this.scContacts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scContacts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.scContacts.ButtonPosition = DevComponents.DotNetBar.Controls.eSplitterButtonPosition.Center;
            this.scContacts.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.scContacts.ForeColor = System.Drawing.Color.Black;
            this.scContacts.IsSplitterFixed = true;
            this.scContacts.Location = new System.Drawing.Point(0, 0);
            this.scContacts.Name = "scContacts";
            this.scContacts.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scContacts.Panel1
            // 
            this.scContacts.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.scContacts.Panel1.Controls.Add(this.gContacts);
            this.scContacts.Panel1.ForeColor = System.Drawing.Color.Black;
            // 
            // scContacts.Panel2
            // 
            this.scContacts.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.scContacts.Panel2.Controls.Add(this.pContact);
            this.scContacts.Panel2.ForeColor = System.Drawing.Color.Black;
            this.scContacts.Size = new System.Drawing.Size(960, 535);
            this.scContacts.SplitterDistance = 180;
            this.scContacts.SplitterWidth = 20;
            this.scContacts.TabIndex = 1;
            // 
            // gContacts
            // 
            this.gContacts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gContacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gContacts.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.gContacts.ForeColor = System.Drawing.Color.Black;
            this.gContacts.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.gContacts.Location = new System.Drawing.Point(0, 0);
            this.gContacts.Name = "gContacts";
            // 
            // 
            // 
            this.gContacts.PrimaryGrid.AllowEdit = false;
            this.gContacts.PrimaryGrid.Columns.Add(this.gContactsChk);
            this.gContacts.PrimaryGrid.Columns.Add(this.gContactsID);
            this.gContacts.PrimaryGrid.Columns.Add(this.gContactsTitle);
            this.gContacts.PrimaryGrid.Columns.Add(this.gContactsNameFirst);
            this.gContacts.PrimaryGrid.Columns.Add(this.gContactsNameLast);
            this.gContacts.PrimaryGrid.Columns.Add(this.gContactsCompany);
            this.gContacts.PrimaryGrid.Columns.Add(this.gContactsPhone);
            this.gContacts.PrimaryGrid.Columns.Add(this.gContactsEmail);
            this.gContacts.PrimaryGrid.Columns.Add(this.gContactsAddress);
            this.gContacts.PrimaryGrid.MultiSelect = false;
            this.gContacts.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row;
            this.gContacts.PrimaryGrid.ShowRowHeaders = false;
            this.gContacts.PrimaryGrid.UseAlternateRowStyle = true;
            this.gContacts.Size = new System.Drawing.Size(960, 180);
            this.gContacts.TabIndex = 2;
            this.gContacts.RowClick += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridRowClickEventArgs>(this.gContacts_RowClick);
            // 
            // gContactsChk
            // 
            this.gContactsChk.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.None;
            this.gContactsChk.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridCheckBoxXEditControl);
            this.gContactsChk.MinimumWidth = 32;
            this.gContactsChk.Name = "";
            this.gContactsChk.Width = 32;
            // 
            // gContactsID
            // 
            this.gContactsID.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.None;
            this.gContactsID.HeaderText = "ID";
            this.gContactsID.MinimumWidth = 60;
            this.gContactsID.Name = "ID";
            this.gContactsID.Width = 60;
            // 
            // gContactsTitle
            // 
            this.gContactsTitle.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.None;
            this.gContactsTitle.HeaderText = "Title";
            this.gContactsTitle.MinimumWidth = 75;
            this.gContactsTitle.Name = "NameTitle";
            this.gContactsTitle.Width = 75;
            // 
            // gContactsNameFirst
            // 
            this.gContactsNameFirst.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.None;
            this.gContactsNameFirst.HeaderText = "First Name";
            this.gContactsNameFirst.MinimumWidth = 100;
            this.gContactsNameFirst.Name = "NameFirst";
            // 
            // gContactsNameLast
            // 
            this.gContactsNameLast.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.None;
            this.gContactsNameLast.HeaderText = "Last Name";
            this.gContactsNameLast.MinimumWidth = 150;
            this.gContactsNameLast.Name = "NameLast";
            this.gContactsNameLast.Width = 150;
            // 
            // gContactsCompany
            // 
            this.gContactsCompany.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.None;
            this.gContactsCompany.HeaderText = "Company";
            this.gContactsCompany.MinimumWidth = 150;
            this.gContactsCompany.Name = "Company";
            this.gContactsCompany.Width = 150;
            // 
            // gContactsPhone
            // 
            this.gContactsPhone.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.None;
            this.gContactsPhone.HeaderText = "Phone";
            this.gContactsPhone.MinimumWidth = 125;
            this.gContactsPhone.Name = "Phone";
            this.gContactsPhone.Width = 125;
            // 
            // gContactsEmail
            // 
            this.gContactsEmail.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.None;
            this.gContactsEmail.HeaderText = "E-mail Address";
            this.gContactsEmail.MinimumWidth = 250;
            this.gContactsEmail.Name = "Email";
            this.gContactsEmail.Width = 250;
            // 
            // gContactsAddress
            // 
            this.gContactsAddress.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            this.gContactsAddress.HeaderText = "Address";
            this.gContactsAddress.MinimumWidth = 250;
            this.gContactsAddress.Name = "Address";
            this.gContactsAddress.Width = 250;
            // 
            // pContact
            // 
            this.pContact.CanvasColor = System.Drawing.SystemColors.Control;
            this.pContact.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pContact.Controls.Add(this.lblContactEmail);
            this.pContact.Controls.Add(this.comboBoxEx1);
            this.pContact.Controls.Add(this.textBoxX1);
            this.pContact.Controls.Add(this.labelX1);
            this.pContact.Controls.Add(this.txtContactNameLast);
            this.pContact.Controls.Add(this.txtContactNameFirst);
            this.pContact.Controls.Add(this.txtContactCompany);
            this.pContact.Controls.Add(this.txtContactEmail);
            this.pContact.Controls.Add(this.lblContactPhone);
            this.pContact.Controls.Add(this.txtContactPhone);
            this.pContact.Controls.Add(this.lblContactName);
            this.pContact.Controls.Add(this.lblContactCompany);
            this.pContact.DisabledBackColor = System.Drawing.Color.Empty;
            this.pContact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContact.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pContact.Location = new System.Drawing.Point(0, 0);
            this.pContact.Name = "pContact";
            this.pContact.Size = new System.Drawing.Size(960, 335);
            this.pContact.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pContact.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pContact.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pContact.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pContact.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pContact.Style.GradientAngle = 90;
            this.pContact.TabIndex = 8;
            // 
            // comboBoxEx1
            // 
            this.comboBoxEx1.DisplayMember = "Text";
            this.comboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx1.ForeColor = System.Drawing.Color.Black;
            this.comboBoxEx1.FormattingEnabled = true;
            this.comboBoxEx1.ItemHeight = 19;
            this.comboBoxEx1.Items.AddRange(new object[] {
            this.cbxiContactTitleMr,
            this.cbxiContactTitleMrs,
            this.cbxiContactTitleMiss,
            this.cbxiContactTitleMs,
            this.cbxiContactTitleMaster,
            this.cbxiContactTitleDr,
            this.cbxiContactTitleProf,
            this.cbxiContactTitleOfc});
            this.comboBoxEx1.Location = new System.Drawing.Point(297, 53);
            this.comboBoxEx1.Name = "comboBoxEx1";
            this.comboBoxEx1.Size = new System.Drawing.Size(197, 25);
            this.comboBoxEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxEx1.TabIndex = 29;
            // 
            // cbxiContactTitleMr
            // 
            this.cbxiContactTitleMr.Text = "Mr";
            this.cbxiContactTitleMr.Value = "mr";
            // 
            // cbxiContactTitleMrs
            // 
            this.cbxiContactTitleMrs.Text = "Mrs";
            this.cbxiContactTitleMrs.Value = "mrs";
            // 
            // cbxiContactTitleMiss
            // 
            this.cbxiContactTitleMiss.Text = "Miss";
            this.cbxiContactTitleMiss.Value = "miss";
            // 
            // cbxiContactTitleMs
            // 
            this.cbxiContactTitleMs.Text = "Ms";
            this.cbxiContactTitleMs.Value = "ms";
            // 
            // cbxiContactTitleMaster
            // 
            this.cbxiContactTitleMaster.Text = "Master";
            this.cbxiContactTitleMaster.Value = "master";
            // 
            // cbxiContactTitleDr
            // 
            this.cbxiContactTitleDr.Text = "Doctor (Dr)";
            this.cbxiContactTitleDr.Value = "dr";
            // 
            // cbxiContactTitleProf
            // 
            this.cbxiContactTitleProf.Text = "Professor (Prof)";
            this.cbxiContactTitleProf.Value = "prof";
            // 
            // cbxiContactTitleOfc
            // 
            this.cbxiContactTitleOfc.Text = "Office (Ofc)";
            this.cbxiContactTitleOfc.Value = "ofc";
            // 
            // textBoxX1
            // 
            this.textBoxX1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.textBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX1.DisabledBackColor = System.Drawing.Color.White;
            this.textBoxX1.ForeColor = System.Drawing.Color.Black;
            this.textBoxX1.Location = new System.Drawing.Point(149, 53);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.PreventEnterBeep = true;
            this.textBoxX1.Size = new System.Drawing.Size(142, 25);
            this.textBoxX1.TabIndex = 28;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(23, 53);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(120, 23);
            this.labelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.labelX1.TabIndex = 27;
            this.labelX1.Text = "Name Title:";
            // 
            // txtContactNameLast
            // 
            this.txtContactNameLast.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtContactNameLast.Border.Class = "TextBoxBorder";
            this.txtContactNameLast.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtContactNameLast.DisabledBackColor = System.Drawing.Color.White;
            this.txtContactNameLast.ForeColor = System.Drawing.Color.Black;
            this.txtContactNameLast.Location = new System.Drawing.Point(297, 84);
            this.txtContactNameLast.Name = "txtContactNameLast";
            this.txtContactNameLast.PreventEnterBeep = true;
            this.txtContactNameLast.Size = new System.Drawing.Size(197, 25);
            this.txtContactNameLast.TabIndex = 26;
            // 
            // txtContactNameFirst
            // 
            this.txtContactNameFirst.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtContactNameFirst.Border.Class = "TextBoxBorder";
            this.txtContactNameFirst.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtContactNameFirst.DisabledBackColor = System.Drawing.Color.White;
            this.txtContactNameFirst.ForeColor = System.Drawing.Color.Black;
            this.txtContactNameFirst.Location = new System.Drawing.Point(149, 84);
            this.txtContactNameFirst.Name = "txtContactNameFirst";
            this.txtContactNameFirst.PreventEnterBeep = true;
            this.txtContactNameFirst.Size = new System.Drawing.Size(142, 25);
            this.txtContactNameFirst.TabIndex = 25;
            // 
            // txtContactCompany
            // 
            this.txtContactCompany.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtContactCompany.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtContactCompany.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtContactCompany.Border.Class = "TextBoxBorder";
            this.txtContactCompany.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtContactCompany.DisabledBackColor = System.Drawing.Color.White;
            this.txtContactCompany.ForeColor = System.Drawing.Color.Black;
            this.txtContactCompany.Location = new System.Drawing.Point(149, 22);
            this.txtContactCompany.Name = "txtContactCompany";
            this.txtContactCompany.PreventEnterBeep = true;
            this.txtContactCompany.Size = new System.Drawing.Size(345, 25);
            this.txtContactCompany.TabIndex = 24;
            // 
            // txtContactEmail
            // 
            this.txtContactEmail.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtContactEmail.Border.Class = "TextBoxBorder";
            this.txtContactEmail.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtContactEmail.DisabledBackColor = System.Drawing.Color.White;
            this.txtContactEmail.ForeColor = System.Drawing.Color.Black;
            this.txtContactEmail.Location = new System.Drawing.Point(149, 146);
            this.txtContactEmail.Name = "txtContactEmail";
            this.txtContactEmail.PreventEnterBeep = true;
            this.txtContactEmail.Size = new System.Drawing.Size(345, 25);
            this.txtContactEmail.TabIndex = 21;
            // 
            // lblContactPhone
            // 
            this.lblContactPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblContactPhone.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblContactPhone.ForeColor = System.Drawing.Color.Black;
            this.lblContactPhone.Location = new System.Drawing.Point(23, 115);
            this.lblContactPhone.Name = "lblContactPhone";
            this.lblContactPhone.Size = new System.Drawing.Size(120, 23);
            this.lblContactPhone.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblContactPhone.TabIndex = 20;
            this.lblContactPhone.Text = "Phone Number:";
            // 
            // txtContactPhone
            // 
            this.txtContactPhone.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtContactPhone.Border.Class = "TextBoxBorder";
            this.txtContactPhone.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtContactPhone.DisabledBackColor = System.Drawing.Color.White;
            this.txtContactPhone.ForeColor = System.Drawing.Color.Black;
            this.txtContactPhone.Location = new System.Drawing.Point(149, 115);
            this.txtContactPhone.Name = "txtContactPhone";
            this.txtContactPhone.PreventEnterBeep = true;
            this.txtContactPhone.Size = new System.Drawing.Size(142, 25);
            this.txtContactPhone.TabIndex = 19;
            // 
            // lblContactName
            // 
            this.lblContactName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblContactName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblContactName.ForeColor = System.Drawing.Color.Black;
            this.lblContactName.Location = new System.Drawing.Point(23, 84);
            this.lblContactName.Name = "lblContactName";
            this.lblContactName.Size = new System.Drawing.Size(120, 23);
            this.lblContactName.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblContactName.TabIndex = 18;
            this.lblContactName.Text = "Name First/Last:";
            // 
            // lblContactCompany
            // 
            this.lblContactCompany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblContactCompany.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblContactCompany.ForeColor = System.Drawing.Color.Black;
            this.lblContactCompany.Location = new System.Drawing.Point(23, 22);
            this.lblContactCompany.Name = "lblContactCompany";
            this.lblContactCompany.Size = new System.Drawing.Size(120, 23);
            this.lblContactCompany.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblContactCompany.TabIndex = 17;
            this.lblContactCompany.Text = "Company:";
            // 
            // ab
            // 
            this.ab.AutoExpandOnClick = true;
            this.ab.BackstageTab = this.bsv;
            this.ab.CanCustomize = false;
            this.ab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ab.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.ab.ImagePaddingHorizontal = 0;
            this.ab.ImagePaddingVertical = 0;
            this.ab.Name = "ab";
            this.ab.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.ab.ShowSubItems = false;
            this.ab.Text = "&File";
            // 
            // bsv
            // 
            this.bsv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bsv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.bsv.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.bsv.ControlBox.MenuBox.Name = "";
            this.bsv.ControlBox.Name = "";
            this.bsv.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.bsv.ControlBox.MenuBox,
            this.bsv.ControlBox.CloseBox});
            this.bsv.ControlBox.Visible = false;
            this.bsv.Controls.Add(this.bsvTpPrint);
            this.bsv.Controls.Add(this.bsvTiHlp);
            this.bsv.ForeColor = System.Drawing.Color.Black;
            this.bsv.ItemPadding.Left = 6;
            this.bsv.ItemPadding.Right = 4;
            this.bsv.ItemPadding.Top = 4;
            this.bsv.Location = new System.Drawing.Point(0, 59);
            this.bsv.Name = "bsv";
            this.bsv.ReorderTabsEnabled = false;
            this.bsv.SelectedTabFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bsv.SelectedTabIndex = 1;
            this.bsv.Size = new System.Drawing.Size(958, 560);
            this.bsv.TabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Left;
            this.bsv.TabFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsv.TabHorizontalSpacing = 16;
            this.bsv.TabIndex = 2;
            this.bsv.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.bsvTiPrint,
            this.bsvTiHelp,
            this.btnOptions,
            this.btnExit});
            this.bsv.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.Office2010BackstageBlue;
            this.bsv.TabVerticalSpacing = 8;
            // 
            // bsvTpPrint
            // 
            this.bsvTpPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bsvTpPrint.Location = new System.Drawing.Point(236, 0);
            this.bsvTpPrint.Name = "bsvTpPrint";
            this.bsvTpPrint.Size = new System.Drawing.Size(722, 560);
            this.bsvTpPrint.TabIndex = 3;
            this.bsvTpPrint.TabItem = this.bsvTiPrint;
            // 
            // bsvTiPrint
            // 
            this.bsvTiPrint.AttachedControl = this.bsvTpPrint;
            this.bsvTiPrint.GlobalItem = false;
            this.bsvTiPrint.KeyTips = "P";
            this.bsvTiPrint.Name = "bsvTiPrint";
            this.bsvTiPrint.Text = "Print";
            // 
            // bsvTiHlp
            // 
            this.bsvTiHlp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bsvTiHlp.BackgroundImage")));
            this.bsvTiHlp.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.BottomRight;
            this.bsvTiHlp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bsvTiHlp.Location = new System.Drawing.Point(97, 0);
            this.bsvTiHlp.Name = "bsvTiHlp";
            this.bsvTiHlp.Size = new System.Drawing.Size(861, 560);
            this.bsvTiHlp.TabIndex = 4;
            this.bsvTiHlp.TabItem = this.bsvTiHelp;
            // 
            // bsvTiHelp
            // 
            this.bsvTiHelp.AttachedControl = this.bsvTiHlp;
            this.bsvTiHelp.GlobalItem = false;
            this.bsvTiHelp.KeyTips = "H";
            this.bsvTiHelp.Name = "bsvTiHelp";
            this.bsvTiHelp.Text = "Help";
            // 
            // btnOptions
            // 
            this.btnOptions.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnOptions.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOptions.Image")));
            this.btnOptions.ImagePaddingHorizontal = 18;
            this.btnOptions.ImagePaddingVertical = 10;
            this.btnOptions.KeyTips = "T";
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Stretch = true;
            this.btnOptions.Text = "Options";
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // btnExit
            // 
            this.btnExit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnExit.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImagePaddingHorizontal = 18;
            this.btnExit.ImagePaddingVertical = 10;
            this.btnExit.KeyTips = "X";
            this.btnExit.Name = "btnExit";
            this.btnExit.Stretch = true;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // mtBookings
            // 
            this.mtBookings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtBookings.Name = "mtBookings";
            this.mtBookings.Panel = this.pBookings;
            this.mtBookings.RibbonWordWrap = false;
            this.mtBookings.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.mtBookings.Text = "Bookings";
            // 
            // mtEnquiries
            // 
            this.mtEnquiries.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtEnquiries.Name = "mtEnquiries";
            this.mtEnquiries.Panel = this.pEnquiries;
            this.mtEnquiries.Text = "Enquiries";
            // 
            // mtCourses
            // 
            this.mtCourses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtCourses.Name = "mtCourses";
            this.mtCourses.Panel = this.pCourses;
            this.mtCourses.RibbonWordWrap = false;
            this.mtCourses.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.mtCourses.Text = "Courses";
            // 
            // mtCompanies
            // 
            this.mtCompanies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtCompanies.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.mtCompanies.Name = "mtCompanies";
            this.mtCompanies.Panel = this.pCompanies;
            this.mtCompanies.RibbonWordWrap = false;
            this.mtCompanies.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.mtCompanies.Text = "Companies";
            // 
            // mtContacts
            // 
            this.mtContacts.CanCustomize = false;
            this.mtContacts.Checked = true;
            this.mtContacts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtContacts.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.mtContacts.Name = "mtContacts";
            this.mtContacts.Panel = this.pContacts;
            this.mtContacts.RibbonWordWrap = false;
            this.mtContacts.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.mtContacts.Text = "Contacts";
            // 
            // btnDummy
            // 
            this.btnDummy.Name = "btnDummy";
            this.btnDummy.Text = "B1";
            // 
            // sm
            // 
            this.sm.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2016;
            this.sm.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // sb
            // 
            this.sb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.sb.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.sb.ContainerControlProcessDialogKey = true;
            this.sb.DragDropSupport = true;
            this.sb.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sb.ForeColor = System.Drawing.Color.Black;
            this.sb.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.lblStatus});
            this.sb.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.sb.Location = new System.Drawing.Point(1, 597);
            this.sb.Name = "sb";
            this.sb.Size = new System.Drawing.Size(958, 22);
            this.sb.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Stretch = true;
            this.lblStatus.Text = "Ready";
            // 
            // mTools
            // 
            this.mTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mToolsTemplates,
            this.mToolsS1,
            this.mToolsUsers});
            this.mTools.Name = "cmTools";
            this.mTools.Size = new System.Drawing.Size(138, 54);
            // 
            // mToolsTemplates
            // 
            this.mToolsTemplates.Name = "mToolsTemplates";
            this.mToolsTemplates.Size = new System.Drawing.Size(137, 22);
            this.mToolsTemplates.Text = "Templates...";
            // 
            // mToolsS1
            // 
            this.mToolsS1.Name = "mToolsS1";
            this.mToolsS1.Size = new System.Drawing.Size(134, 6);
            // 
            // mToolsUsers
            // 
            this.mToolsUsers.Name = "mToolsUsers";
            this.mToolsUsers.Size = new System.Drawing.Size(137, 22);
            this.mToolsUsers.Text = "Users...";
            // 
            // mBookingsList
            // 
            this.mBookingsList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mBookingsListAdd,
            this.mBookingsListRemove,
            this.mBookingsListS1,
            this.mBookingsListComplete});
            this.mBookingsList.Name = "contextMenuStrip1";
            this.mBookingsList.Size = new System.Drawing.Size(169, 76);
            // 
            // mBookingsListAdd
            // 
            this.mBookingsListAdd.Name = "mBookingsListAdd";
            this.mBookingsListAdd.Size = new System.Drawing.Size(168, 22);
            this.mBookingsListAdd.Text = "Add booking...";
            this.mBookingsListAdd.Click += new System.EventHandler(this.mBookingsListAdd_Click);
            // 
            // mBookingsListRemove
            // 
            this.mBookingsListRemove.Name = "mBookingsListRemove";
            this.mBookingsListRemove.Size = new System.Drawing.Size(168, 22);
            this.mBookingsListRemove.Text = "Remove booking";
            this.mBookingsListRemove.Click += new System.EventHandler(this.mBookingsListRemove_Click);
            // 
            // mBookingsListS1
            // 
            this.mBookingsListS1.Name = "mBookingsListS1";
            this.mBookingsListS1.Size = new System.Drawing.Size(165, 6);
            // 
            // mBookingsListComplete
            // 
            this.mBookingsListComplete.Name = "mBookingsListComplete";
            this.mBookingsListComplete.Size = new System.Drawing.Size(168, 22);
            this.mBookingsListComplete.Text = "Mark as complete";
            this.mBookingsListComplete.Click += new System.EventHandler(this.mBookingsListComplete_Click);
            // 
            // mContacts
            // 
            this.mContacts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mContactsAdd,
            this.mContactsRemove});
            this.mContacts.Name = "mContacts";
            this.mContacts.Size = new System.Drawing.Size(161, 48);
            // 
            // mContactsAdd
            // 
            this.mContactsAdd.Name = "mContactsAdd";
            this.mContactsAdd.Size = new System.Drawing.Size(160, 22);
            this.mContactsAdd.Text = "Add contact";
            this.mContactsAdd.Click += new System.EventHandler(this.mContactsAdd_Click);
            // 
            // mContactsRemove
            // 
            this.mContactsRemove.Name = "mContactsRemove";
            this.mContactsRemove.Size = new System.Drawing.Size(160, 22);
            this.mContactsRemove.Text = "Remove contact";
            this.mContactsRemove.Click += new System.EventHandler(this.mContactsRemove_Click);
            // 
            // mEnquiries
            // 
            this.mEnquiries.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mEnquiriesAdd,
            this.mEnquiriesRemove,
            this.mEnquiriesS1,
            this.mEnquiriesBooking});
            this.mEnquiries.Name = "mContacts";
            this.mEnquiries.Size = new System.Drawing.Size(165, 76);
            // 
            // mEnquiriesAdd
            // 
            this.mEnquiriesAdd.Name = "mEnquiriesAdd";
            this.mEnquiriesAdd.Size = new System.Drawing.Size(164, 22);
            this.mEnquiriesAdd.Text = "Add enquiry";
            // 
            // mEnquiriesRemove
            // 
            this.mEnquiriesRemove.Name = "mEnquiriesRemove";
            this.mEnquiriesRemove.Size = new System.Drawing.Size(164, 22);
            this.mEnquiriesRemove.Text = "Remove enquiry";
            // 
            // mCourses
            // 
            this.mCourses.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mCoursesAdd,
            this.mCoursesRemove});
            this.mCourses.Name = "mContacts";
            this.mCourses.Size = new System.Drawing.Size(156, 48);
            // 
            // mCoursesAdd
            // 
            this.mCoursesAdd.Name = "mCoursesAdd";
            this.mCoursesAdd.Size = new System.Drawing.Size(155, 22);
            this.mCoursesAdd.Text = "Add course";
            // 
            // mCoursesRemove
            // 
            this.mCoursesRemove.Name = "mCoursesRemove";
            this.mCoursesRemove.Size = new System.Drawing.Size(155, 22);
            this.mCoursesRemove.Text = "Remove course";
            // 
            // mCompanies
            // 
            this.mCompanies.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mCompaniesAdd,
            this.mCompaniesRemove});
            this.mCompanies.Name = "mContacts";
            this.mCompanies.Size = new System.Drawing.Size(171, 48);
            // 
            // mCompaniesAdd
            // 
            this.mCompaniesAdd.Name = "mCompaniesAdd";
            this.mCompaniesAdd.Size = new System.Drawing.Size(170, 22);
            this.mCompaniesAdd.Text = "Add company";
            // 
            // mCompaniesRemove
            // 
            this.mCompaniesRemove.Name = "mCompaniesRemove";
            this.mCompaniesRemove.Size = new System.Drawing.Size(170, 22);
            this.mCompaniesRemove.Text = "Remove company";
            // 
            // mEnquiriesS1
            // 
            this.mEnquiriesS1.Name = "mEnquiriesS1";
            this.mEnquiriesS1.Size = new System.Drawing.Size(161, 6);
            // 
            // mEnquiriesBooking
            // 
            this.mEnquiriesBooking.Name = "mEnquiriesBooking";
            this.mEnquiriesBooking.Size = new System.Drawing.Size(164, 22);
            this.mEnquiriesBooking.Text = "Create booking...";
            // 
            // lblContactEmail
            // 
            this.lblContactEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblContactEmail.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblContactEmail.ForeColor = System.Drawing.Color.Black;
            this.lblContactEmail.Location = new System.Drawing.Point(23, 146);
            this.lblContactEmail.Name = "lblContactEmail";
            this.lblContactEmail.Size = new System.Drawing.Size(120, 23);
            this.lblContactEmail.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblContactEmail.TabIndex = 30;
            this.lblContactEmail.Text = "Phone Number:";
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(960, 620);
            this.Controls.Add(this.bsv);
            this.Controls.Add(this.sb);
            this.Controls.Add(this.ms);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(960, 620);
            this.Name = "frmMain";
            this.Text = "HCF Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.ms.ResumeLayout(false);
            this.ms.PerformLayout();
            this.pBookings.ResumeLayout(false);
            this.pBookingsList.ResumeLayout(false);
            this.pBookingsListTools.ResumeLayout(false);
            this.pBookingsListTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbBookingsList)).EndInit();
            this.mBookings.ResumeLayout(false);
            this.pBookingsGrid.ResumeLayout(false);
            this.mBookingsGrid.ResumeLayout(false);
            this.pBookingsGridTools.ResumeLayout(false);
            this.pBookingsGridTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbBookingsGrid)).EndInit();
            this.pBookingsCalendar.ResumeLayout(false);
            this.pBookingsCalendarTools.ResumeLayout(false);
            this.pBookingsCalendarTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbBookings)).EndInit();
            this.pEnquiries.ResumeLayout(false);
            this.scEnquiries.Panel1.ResumeLayout(false);
            this.scEnquiries.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scEnquiries)).EndInit();
            this.scEnquiries.ResumeLayout(false);
            this.pEnquiriesGrid.ResumeLayout(false);
            this.pEnquiriesGridTools.ResumeLayout(false);
            this.pEnquiriesGridTools.PerformLayout();
            this.pCourses.ResumeLayout(false);
            this.scCourses.Panel1.ResumeLayout(false);
            this.scCourses.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scCourses)).EndInit();
            this.scCourses.ResumeLayout(false);
            this.pCompanies.ResumeLayout(false);
            this.scCompanies.Panel1.ResumeLayout(false);
            this.scCompanies.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scCompanies)).EndInit();
            this.scCompanies.ResumeLayout(false);
            this.pContacts.ResumeLayout(false);
            this.scContacts.Panel1.ResumeLayout(false);
            this.scContacts.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scContacts)).EndInit();
            this.scContacts.ResumeLayout(false);
            this.pContact.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsv)).EndInit();
            this.bsv.ResumeLayout(false);
            this.mTools.ResumeLayout(false);
            this.mBookingsList.ResumeLayout(false);
            this.mContacts.ResumeLayout(false);
            this.mEnquiries.ResumeLayout(false);
            this.mCourses.ResumeLayout(false);
            this.mCompanies.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Metro.MetroShell ms;
        private DevComponents.DotNetBar.Metro.MetroAppButton ab;
        private DevComponents.DotNetBar.StyleManager sm;
        private DevComponents.DotNetBar.Metro.MetroTabPanel pCompanies;
        private DevComponents.DotNetBar.Metro.MetroTabPanel pContacts;
        private DevComponents.DotNetBar.Metro.MetroTabItem mtCompanies;
        private DevComponents.DotNetBar.Metro.MetroTabItem mtContacts;
        private DevComponents.DotNetBar.Metro.MetroTabItem mtCourses;
        private DevComponents.DotNetBar.Metro.MetroTabItem mtBookings;
        private DevComponents.DotNetBar.Metro.MetroTabPanel pCourses;
        private DevComponents.DotNetBar.Metro.MetroTabPanel pBookings;
        private DevComponents.DotNetBar.Metro.MetroStatusBar sb;
        private DevComponents.DotNetBar.LabelItem lblStatus;
        private System.Windows.Forms.ContextMenuStrip mTools;
        private DevComponents.DotNetBar.PanelEx pBookingsList;
        private DevComponents.DotNetBar.PanelEx pBookingsGrid;
        private unvell.ReoGrid.ReoGridControl rgBookings;
        private DevComponents.DotNetBar.PanelEx pBookingsGridTools;
        private DevComponents.DotNetBar.PanelEx pBookingsCalendar;
        private DevComponents.DotNetBar.Schedule.CalendarView cvBookings;
        private DevComponents.DotNetBar.PanelEx pBookingsListTools;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl gBookings;
        private DevComponents.DotNetBar.Metro.MetroTabPanel pEnquiries;
        private DevComponents.DotNetBar.Metro.MetroTabItem mtEnquiries;
        private DevComponents.DotNetBar.PanelEx pBookingsCalendarTools;
        private DevComponents.DotNetBar.NavigationBar nbBookings;
        private DevComponents.DotNetBar.ButtonItem biBookingsViewDay;
        private DevComponents.DotNetBar.ButtonItem biBookingsViewWeek;
        private DevComponents.DotNetBar.ButtonItem biBookingsViewMonth;
        private DevComponents.DotNetBar.ButtonItem biBookingsViewYear;
        private DevComponents.DotNetBar.ButtonItem biBookingsViewGrid;
        private DevComponents.DotNetBar.ButtonItem biBookingsViewList;
        private DevComponents.DotNetBar.Schedule.DateNavigator dnBookings;
        private DevComponents.DotNetBar.NavigationBar nbBookingsList;
        private DevComponents.DotNetBar.ButtonItem biBookingsListDay;
        private DevComponents.DotNetBar.ButtonItem biBookingsListWeek;
        private DevComponents.DotNetBar.ButtonItem biBookingsListMonth;
        private DevComponents.DotNetBar.ButtonItem biBookingsListYear;
        private DevComponents.DotNetBar.ButtonItem biBookingsListGrid;
        private DevComponents.DotNetBar.ButtonItem biBookingsList;
        private DevComponents.DotNetBar.NavigationBar nbBookingsGrid;
        private DevComponents.DotNetBar.ButtonItem biBookingsGridDay;
        private DevComponents.DotNetBar.ButtonItem biBookingsGridWeek;
        private DevComponents.DotNetBar.ButtonItem biBookingsGridMonth;
        private DevComponents.DotNetBar.ButtonItem biBookingsGridYear;
        private DevComponents.DotNetBar.ButtonItem biBookingsGrid;
        private DevComponents.DotNetBar.ButtonItem biBookingsGridList;
        private DevComponents.DotNetBar.LabelX lblBookingsGridCompany;
        private DevComponents.DotNetBar.LabelX lblGridBookings;
        private DevComponents.DotNetBar.LabelX lblListBookings;
        private DevComponents.DotNetBar.LabelX lblBookingsListCompany;
        private DevComponents.DotNetBar.LabelX lblCalendarBookings;
        private System.Windows.Forms.ToolStripMenuItem mToolsTemplates;
        private System.Windows.Forms.ToolStripSeparator mToolsS1;
        private System.Windows.Forms.ToolStripMenuItem mToolsUsers;
        private DevComponents.DotNetBar.SuperTabControl bsv;
        private DevComponents.DotNetBar.SuperTabControlPanel bsvTiHlp;
        private DevComponents.DotNetBar.SuperTabItem bsvTiHelp;
        private DevComponents.DotNetBar.SuperTabControlPanel bsvTpPrint;
        private DevComponents.DotNetBar.SuperTabItem bsvTiPrint;
        private DevComponents.DotNetBar.ButtonItem btnExit;
        private DevComponents.DotNetBar.ButtonItem btnOptions;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gBookingsChk;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gBookingsJob;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gBookingsDates;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gBookingsStart;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gBookingsFinish;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gBookingsName;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gBookingsRooms;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gBookingsCompany;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gBookingsPhone;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gBookingsEmail;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gBookingsRoomLayout;
        private System.Windows.Forms.ContextMenuStrip mBookings;
        private System.Windows.Forms.ToolStripMenuItem mBookingsAdd;
        private System.Windows.Forms.ToolStripMenuItem mBookingsRemove;
        private System.Windows.Forms.ToolStripSeparator mBookingsS1;
        private System.Windows.Forms.ToolStripMenuItem mBookingsComplete;
        private DevComponents.DotNetBar.ButtonItem btnDummy;
        private DevComponents.DotNetBar.Controls.CollapsibleSplitContainer scCompanies;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl gCompanies;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gCompaniesChk;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gCompaniesID;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gCompaniesName;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gCompaniesContact;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gCompaniesPhone;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gCompaniesEmail;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gCompaniesAddress;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gCompaniesReg;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gCompaniesVat;
        private DevComponents.DotNetBar.Controls.CollapsibleSplitContainer scContacts;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl gContacts;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gContactsChk;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gContactsID;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gContactsTitle;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gContactsNameFirst;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gContactsNameLast;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gContactsCompany;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gContactsPhone;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gContactsEmail;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gContactsAddress;
        private DevComponents.DotNetBar.Controls.CollapsibleSplitContainer scCourses;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl gCourses;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gCoursesChk;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gCoursesID;
        private DevComponents.DotNetBar.Controls.CollapsibleSplitContainer scEnquiries;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gEnquiriesLayout;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gEnquiriesEmail;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gEnquiriesPhone;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gEnquiriesCompany;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gEnquiriesRooms;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gEnquiriesName;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gEnquiriesFinish;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gEnquiriesStart;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gEnquiriesDates;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gEnquiriesJob;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gEnquiriesChk;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl gEnquiries;
        private DevComponents.DotNetBar.LabelX lblEnquiriesCompany;
        private DevComponents.DotNetBar.LabelX lblGridEnquiries;
        private DevComponents.DotNetBar.PanelEx pEnquiriesGridTools;
        private DevComponents.DotNetBar.PanelEx pEnquiriesGrid;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gCoursesName;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gCoursesCert;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gCoursesDuration;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gCoursesPrice;
        private System.Windows.Forms.ContextMenuStrip mBookingsGrid;
        private System.Windows.Forms.ToolStripMenuItem mBookingsGridAdd;
        private System.Windows.Forms.ToolStripMenuItem mBookingsGridRemove;
        private System.Windows.Forms.ToolStripSeparator mBookingsGridS1;
        private System.Windows.Forms.ToolStripMenuItem mBookingsGridComplete;
        private System.Windows.Forms.ContextMenuStrip mBookingsList;
        private System.Windows.Forms.ToolStripMenuItem mBookingsListAdd;
        private System.Windows.Forms.ToolStripMenuItem mBookingsListRemove;
        private System.Windows.Forms.ToolStripSeparator mBookingsListS1;
        private System.Windows.Forms.ToolStripMenuItem mBookingsListComplete;
        private DevComponents.DotNetBar.Controls.TextBoxX txtGridCompany;
        private DevComponents.DotNetBar.Controls.TextBoxX txtListCompany;
        private DevComponents.DotNetBar.ButtonX btnListCompanyReset;
        private DevComponents.DotNetBar.ButtonX btnGridCompanyReset;
        private DevComponents.DotNetBar.PanelEx pEnquiry;
        private DevComponents.DotNetBar.PanelEx pCourse;
        private DevComponents.DotNetBar.PanelEx pCompany;
        private DevComponents.DotNetBar.PanelEx pContact;
        private DevComponents.DotNetBar.Controls.TextBoxX txtContactNameFirst;
        private DevComponents.DotNetBar.Controls.TextBoxX txtContactCompany;
        private DevComponents.DotNetBar.Controls.TextBoxX txtContactEmail;
        private DevComponents.DotNetBar.LabelX lblContactPhone;
        private DevComponents.DotNetBar.Controls.TextBoxX txtContactPhone;
        private DevComponents.DotNetBar.LabelX lblContactName;
        private DevComponents.DotNetBar.LabelX lblContactCompany;
        private DevComponents.DotNetBar.Controls.TextBoxX txtContactNameLast;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx1;
        private DevComponents.Editors.ComboItem cbxiContactTitleMr;
        private DevComponents.Editors.ComboItem cbxiContactTitleMrs;
        private DevComponents.Editors.ComboItem cbxiContactTitleMiss;
        private DevComponents.Editors.ComboItem cbxiContactTitleMs;
        private DevComponents.Editors.ComboItem cbxiContactTitleMaster;
        private DevComponents.Editors.ComboItem cbxiContactTitleDr;
        private DevComponents.Editors.ComboItem cbxiContactTitleProf;
        private DevComponents.Editors.ComboItem cbxiContactTitleOfc;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.ContextMenuStrip mContacts;
        private System.Windows.Forms.ToolStripMenuItem mContactsAdd;
        private System.Windows.Forms.ToolStripMenuItem mContactsRemove;
        private DevComponents.DotNetBar.ButtonX btnEnquiriesListCompany;
        private DevComponents.DotNetBar.Controls.TextBoxX txtEnquiriesListCompany;
        private System.Windows.Forms.ContextMenuStrip mEnquiries;
        private System.Windows.Forms.ToolStripMenuItem mEnquiriesAdd;
        private System.Windows.Forms.ToolStripMenuItem mEnquiriesRemove;
        private System.Windows.Forms.ToolStripSeparator mEnquiriesS1;
        private System.Windows.Forms.ToolStripMenuItem mEnquiriesBooking;
        private System.Windows.Forms.ContextMenuStrip mCourses;
        private System.Windows.Forms.ToolStripMenuItem mCoursesAdd;
        private System.Windows.Forms.ToolStripMenuItem mCoursesRemove;
        private System.Windows.Forms.ContextMenuStrip mCompanies;
        private System.Windows.Forms.ToolStripMenuItem mCompaniesAdd;
        private System.Windows.Forms.ToolStripMenuItem mCompaniesRemove;
        private DevComponents.DotNetBar.LabelX lblContactEmail;
    }
}