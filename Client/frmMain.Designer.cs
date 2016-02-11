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
            this.lblCountBookingsList = new DevComponents.DotNetBar.LabelX();
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
            this.lblCountBookingsGrid = new DevComponents.DotNetBar.LabelX();
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
            this.lblCountBookingsCalendar = new DevComponents.DotNetBar.LabelX();
            this.nbBookings = new DevComponents.DotNetBar.NavigationBar();
            this.biBookingsViewDay = new DevComponents.DotNetBar.ButtonItem();
            this.biBookingsViewWeek = new DevComponents.DotNetBar.ButtonItem();
            this.biBookingsViewMonth = new DevComponents.DotNetBar.ButtonItem();
            this.biBookingsViewYear = new DevComponents.DotNetBar.ButtonItem();
            this.biBookingsViewGrid = new DevComponents.DotNetBar.ButtonItem();
            this.biBookingsViewList = new DevComponents.DotNetBar.ButtonItem();
            this.dnBookings = new DevComponents.DotNetBar.Schedule.DateNavigator();
            this.cvBookings = new DevComponents.DotNetBar.Schedule.CalendarView();
            this.pCompanies = new DevComponents.DotNetBar.Metro.MetroTabPanel();
            this.scCompanies = new DevComponents.DotNetBar.Controls.CollapsibleSplitContainer();
            this.gCompanies = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.mCompanies = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mCompaniesAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mCompaniesRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.gCompaniesID = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gCompaniesName = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gCompaniesContact = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gCompaniesPhone = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gCompaniesEmail = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gCompaniesAddress = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gCompaniesReg = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gCompaniesVat = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.pCompany = new DevComponents.DotNetBar.PanelEx();
            this.btnCompanyCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnCompanySave = new DevComponents.DotNetBar.ButtonX();
            this.scCompany = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabControlPanel4 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.lblCompanyContact = new DevComponents.DotNetBar.LabelX();
            this.txtCompanyContact = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtCompanyAddress = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblCompanyAddress = new DevComponents.DotNetBar.LabelX();
            this.lblCompanyEmail = new DevComponents.DotNetBar.LabelX();
            this.txtCompanyTrading = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblCompanyTrading = new DevComponents.DotNetBar.LabelX();
            this.txtCompanyRegVat = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtCompanyReg = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtCompanyName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtCompanyEmail = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblCompanyPhone = new DevComponents.DotNetBar.LabelX();
            this.txtCompanyPhone = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblCompanyReg = new DevComponents.DotNetBar.LabelX();
            this.lblCompanyName = new DevComponents.DotNetBar.LabelX();
            this.tiCompanyGeneral = new DevComponents.DotNetBar.SuperTabItem();
            this.tpCompanyContacts = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.scCompaniesContacts = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.gridColumn1 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridColumn2 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridColumn3 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridColumn4 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.tiCompanyContacts = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel6 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.txtCompanyNotes = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tiCompanyNotes = new DevComponents.DotNetBar.SuperTabItem();
            this.pContacts = new DevComponents.DotNetBar.Metro.MetroTabPanel();
            this.scContacts = new DevComponents.DotNetBar.Controls.CollapsibleSplitContainer();
            this.gContacts = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.mContacts = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mContactsAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mContactsRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.gContactsID = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gContactsTitle = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gContactsNameFirst = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gContactsNameLast = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gContactsCompany = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gContactsPhone = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gContactsEmail = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gContactsAddress = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.pContact = new DevComponents.DotNetBar.PanelEx();
            this.btnContactCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnContactSave = new DevComponents.DotNetBar.ButtonX();
            this.scContact = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabControlPanel1 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.txtContactAddress = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblContactAddress = new DevComponents.DotNetBar.LabelX();
            this.lblContactEmail = new DevComponents.DotNetBar.LabelX();
            this.cbxContactNameTitle = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbxiContactTitleMr = new DevComponents.Editors.ComboItem();
            this.cbxiContactTitleMrs = new DevComponents.Editors.ComboItem();
            this.cbxiContactTitleMiss = new DevComponents.Editors.ComboItem();
            this.cbxiContactTitleMs = new DevComponents.Editors.ComboItem();
            this.cbxiContactTitleMaster = new DevComponents.Editors.ComboItem();
            this.cbxiContactTitleDr = new DevComponents.Editors.ComboItem();
            this.cbxiContactTitleProf = new DevComponents.Editors.ComboItem();
            this.cbxiContactTitleOfc = new DevComponents.Editors.ComboItem();
            this.txtContactNameTitle = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtContactNameLast = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtContactNameFirst = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtContactCompany = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtContactEmail = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblContactPhone = new DevComponents.DotNetBar.LabelX();
            this.txtContactPhone = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblContactName = new DevComponents.DotNetBar.LabelX();
            this.lblContactCompany = new DevComponents.DotNetBar.LabelX();
            this.tiContactGeneral = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel3 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.lblContactFileAccessVal = new DevComponents.DotNetBar.LabelX();
            this.lblContactFileAccess = new DevComponents.DotNetBar.LabelX();
            this.lblContactFileModVal = new DevComponents.DotNetBar.LabelX();
            this.lblContactFileMod = new DevComponents.DotNetBar.LabelX();
            this.lblContactFileSizeVal = new DevComponents.DotNetBar.LabelX();
            this.lblContactFileSize = new DevComponents.DotNetBar.LabelX();
            this.lblContactFileLocVal = new DevComponents.DotNetBar.LabelX();
            this.lblContactFileLoc = new DevComponents.DotNetBar.LabelX();
            this.lblContactFileNameVal = new DevComponents.DotNetBar.LabelX();
            this.lblContactFileName = new DevComponents.DotNetBar.LabelX();
            this.lvContactDocuments = new System.Windows.Forms.ListView();
            this.chFilename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnContactDocumentAdd = new DevComponents.DotNetBar.ButtonX();
            this.tiContactDocs = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel2 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.txtContactNotes = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tiContactNotes = new DevComponents.DotNetBar.SuperTabItem();
            this.pEnquiries = new DevComponents.DotNetBar.Metro.MetroTabPanel();
            this.scEnquiries = new DevComponents.DotNetBar.Controls.CollapsibleSplitContainer();
            this.pEnquiriesGrid = new DevComponents.DotNetBar.PanelEx();
            this.pEnquiriesGridTools = new DevComponents.DotNetBar.PanelEx();
            this.btnEnquiriesListCompany = new DevComponents.DotNetBar.ButtonX();
            this.txtEnquiriesListCompany = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblCountEnquiries = new DevComponents.DotNetBar.LabelX();
            this.lblEnquiriesCompany = new DevComponents.DotNetBar.LabelX();
            this.gEnquiries = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.mEnquiries = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mEnquiriesAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mEnquiriesRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.mEnquiriesS1 = new System.Windows.Forms.ToolStripSeparator();
            this.mEnquiriesBooking = new System.Windows.Forms.ToolStripMenuItem();
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
            this.btnEnquiryCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnEnquirySave = new DevComponents.DotNetBar.ButtonX();
            this.scEnquiry = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabControlPanel8 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.lblEnquiryNumberVal = new DevComponents.DotNetBar.LabelX();
            this.lblEnquiryNumber = new DevComponents.DotNetBar.LabelX();
            this.lblEnquiryInfo = new DevComponents.DotNetBar.LabelX();
            this.txtEnquiryInfo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblEnquiryReferrer = new DevComponents.DotNetBar.LabelX();
            this.txtEnquiryReferrer = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbxEnquiryType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblEnquiryType = new DevComponents.DotNetBar.LabelX();
            this.lblEnquiryEmail = new DevComponents.DotNetBar.LabelX();
            this.txtEnquiryEmail = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblEnquiryPhone = new DevComponents.DotNetBar.LabelX();
            this.txtEnquiryPhone = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtEnquiryCompany = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblEnquiryCompany = new DevComponents.DotNetBar.LabelX();
            this.txtEnquiryName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblEnquiryName = new DevComponents.DotNetBar.LabelX();
            this.tiEnquiryGeneral = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel10 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.lblEnquiryFileAccessVal = new DevComponents.DotNetBar.LabelX();
            this.lblEnquiryFileAccess = new DevComponents.DotNetBar.LabelX();
            this.lblEnquiryFileModVal = new DevComponents.DotNetBar.LabelX();
            this.lblEnquiryFileMod = new DevComponents.DotNetBar.LabelX();
            this.lblEnquiryFileSizeVal = new DevComponents.DotNetBar.LabelX();
            this.lblEnquiryFileSize = new DevComponents.DotNetBar.LabelX();
            this.lblEnquiryFileLocVal = new DevComponents.DotNetBar.LabelX();
            this.lblEnquiryFileLoc = new DevComponents.DotNetBar.LabelX();
            this.lblEnquiryFileNameVal = new DevComponents.DotNetBar.LabelX();
            this.lblEnquiryFileName = new DevComponents.DotNetBar.LabelX();
            this.lvEnquiryDocs = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEnquiryDocs = new DevComponents.DotNetBar.ButtonX();
            this.tiEnquiryDocs = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel5 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.lblEnquiryInfoWanted = new DevComponents.DotNetBar.LabelX();
            this.txtEnquiryInfoWanted = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lvEnquiryCourses = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblEnquiryCourses = new DevComponents.DotNetBar.LabelX();
            this.tiEnquiryInfo = new DevComponents.DotNetBar.SuperTabItem();
            this.pCourses = new DevComponents.DotNetBar.Metro.MetroTabPanel();
            this.scCourses = new DevComponents.DotNetBar.Controls.CollapsibleSplitContainer();
            this.gCourses = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.mCourses = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mCoursesAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mCoursesRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.gCoursesID = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gCoursesName = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gCoursesCert = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gCoursesDuration = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gCoursesPrice = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.pCourse = new DevComponents.DotNetBar.PanelEx();
            this.btnCourseCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnCourseSave = new DevComponents.DotNetBar.ButtonX();
            this.scCourse = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabControlPanel7 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.txtCoursePricing = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblCoursePrice = new DevComponents.DotNetBar.LabelX();
            this.txtCourseDuration = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblCourseDuration = new DevComponents.DotNetBar.LabelX();
            this.txtCourseCert = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblCourseCert = new DevComponents.DotNetBar.LabelX();
            this.txtCourseName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblCourseName = new DevComponents.DotNetBar.LabelX();
            this.tiCourseGeneral = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel9 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.txtCourseDetails = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tiCourseDetails = new DevComponents.DotNetBar.SuperTabItem();
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
            this.biToolsGridViews = new DevComponents.DotNetBar.ButtonItem();
            this.biToolsTemplate = new DevComponents.DotNetBar.ButtonItem();
            this.biToolsUser = new DevComponents.DotNetBar.ButtonItem();
            this.biToolsRooms = new DevComponents.DotNetBar.ButtonItem();
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
            this.pCompanies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scCompanies)).BeginInit();
            this.scCompanies.Panel1.SuspendLayout();
            this.scCompanies.Panel2.SuspendLayout();
            this.scCompanies.SuspendLayout();
            this.mCompanies.SuspendLayout();
            this.pCompany.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scCompany)).BeginInit();
            this.scCompany.SuspendLayout();
            this.superTabControlPanel4.SuspendLayout();
            this.tpCompanyContacts.SuspendLayout();
            this.superTabControlPanel6.SuspendLayout();
            this.pContacts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scContacts)).BeginInit();
            this.scContacts.Panel1.SuspendLayout();
            this.scContacts.Panel2.SuspendLayout();
            this.scContacts.SuspendLayout();
            this.mContacts.SuspendLayout();
            this.pContact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scContact)).BeginInit();
            this.scContact.SuspendLayout();
            this.superTabControlPanel1.SuspendLayout();
            this.superTabControlPanel3.SuspendLayout();
            this.superTabControlPanel2.SuspendLayout();
            this.pEnquiries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scEnquiries)).BeginInit();
            this.scEnquiries.Panel1.SuspendLayout();
            this.scEnquiries.Panel2.SuspendLayout();
            this.scEnquiries.SuspendLayout();
            this.pEnquiriesGrid.SuspendLayout();
            this.pEnquiriesGridTools.SuspendLayout();
            this.mEnquiries.SuspendLayout();
            this.pEnquiry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scEnquiry)).BeginInit();
            this.scEnquiry.SuspendLayout();
            this.superTabControlPanel8.SuspendLayout();
            this.superTabControlPanel10.SuspendLayout();
            this.superTabControlPanel5.SuspendLayout();
            this.pCourses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scCourses)).BeginInit();
            this.scCourses.Panel1.SuspendLayout();
            this.scCourses.Panel2.SuspendLayout();
            this.scCourses.SuspendLayout();
            this.mCourses.SuspendLayout();
            this.pCourse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scCourse)).BeginInit();
            this.scCourse.SuspendLayout();
            this.superTabControlPanel7.SuspendLayout();
            this.superTabControlPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsv)).BeginInit();
            this.bsv.SuspendLayout();
            this.mTools.SuspendLayout();
            this.mBookingsList.SuspendLayout();
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
            this.ms.CaptionFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ms.CaptionVisible = true;
            this.ms.Controls.Add(this.pBookings);
            this.ms.Controls.Add(this.pEnquiries);
            this.ms.Controls.Add(this.pCourses);
            this.ms.Controls.Add(this.pCompanies);
            this.ms.Controls.Add(this.pContacts);
            this.ms.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
            this.ms.KeyTipsFont = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
            this.ms.TabStripFont = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
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
            this.pBookingsListTools.Controls.Add(this.lblCountBookingsList);
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
            this.btnListCompanyReset.TabStop = false;
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
            this.txtListCompany.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtListCompany.ForeColor = System.Drawing.Color.Black;
            this.txtListCompany.Location = new System.Drawing.Point(64, 5);
            this.txtListCompany.Name = "txtListCompany";
            this.txtListCompany.PreventEnterBeep = true;
            this.txtListCompany.Size = new System.Drawing.Size(244, 25);
            this.txtListCompany.TabIndex = 27;
            this.txtListCompany.TabStop = false;
            // 
            // lblCountBookingsList
            // 
            this.lblCountBookingsList.AutoSize = true;
            // 
            // 
            // 
            this.lblCountBookingsList.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCountBookingsList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCountBookingsList.ForeColor = System.Drawing.Color.Black;
            this.lblCountBookingsList.Location = new System.Drawing.Point(348, 8);
            this.lblCountBookingsList.Name = "lblCountBookingsList";
            this.lblCountBookingsList.Size = new System.Drawing.Size(84, 18);
            this.lblCountBookingsList.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblCountBookingsList.TabIndex = 26;
            this.lblCountBookingsList.Text = "Total bookings:";
            // 
            // lblBookingsListCompany
            // 
            this.lblBookingsListCompany.AutoSize = true;
            // 
            // 
            // 
            this.lblBookingsListCompany.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblBookingsListCompany.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblBookingsListCompany.ForeColor = System.Drawing.Color.Black;
            this.lblBookingsListCompany.Location = new System.Drawing.Point(7, 9);
            this.lblBookingsListCompany.Name = "lblBookingsListCompany";
            this.lblBookingsListCompany.Size = new System.Drawing.Size(56, 18);
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
            this.nbBookingsList.TabStop = false;
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
            this.gBookings.PrimaryGrid.CheckBoxes = true;
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
            this.gBookings.TabStop = false;
            this.gBookings.RowActivated += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridRowActivatedEventArgs>(this.gBookings_RowActivated);
            this.gBookings.RowClick += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridRowClickEventArgs>(this.gBookings_RowClick);
            this.gBookings.RowDoubleClick += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridRowDoubleClickEventArgs>(this.gBookings_RowDoubleClick);
            // 
            // mBookings
            // 
            this.mBookings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
            this.gBookingsDates.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.None;
            this.gBookingsDates.HeaderText = "Dates";
            this.gBookingsDates.MinimumWidth = 150;
            this.gBookingsDates.Name = "Dates";
            this.gBookingsDates.Width = 150;
            // 
            // gBookingsStart
            // 
            this.gBookingsStart.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.None;
            this.gBookingsStart.HeaderText = "Start";
            this.gBookingsStart.MinimumWidth = 60;
            this.gBookingsStart.Name = "Start";
            this.gBookingsStart.Width = 60;
            // 
            // gBookingsFinish
            // 
            this.gBookingsFinish.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.None;
            this.gBookingsFinish.HeaderText = "Finish";
            this.gBookingsFinish.MinimumWidth = 60;
            this.gBookingsFinish.Name = "Finish";
            this.gBookingsFinish.Width = 60;
            // 
            // gBookingsName
            // 
            this.gBookingsName.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            this.gBookingsName.HeaderText = "Event Name";
            this.gBookingsName.MinimumWidth = 300;
            this.gBookingsName.Name = "Name";
            this.gBookingsName.Width = 300;
            // 
            // gBookingsRooms
            // 
            this.gBookingsRooms.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.None;
            this.gBookingsRooms.HeaderText = "Rooms";
            this.gBookingsRooms.MinimumWidth = 300;
            this.gBookingsRooms.Name = "Rooms";
            this.gBookingsRooms.Width = 300;
            // 
            // gBookingsCompany
            // 
            this.gBookingsCompany.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.None;
            this.gBookingsCompany.HeaderText = "Company";
            this.gBookingsCompany.MinimumWidth = 200;
            this.gBookingsCompany.Name = "Company";
            this.gBookingsCompany.Width = 200;
            // 
            // gBookingsPhone
            // 
            this.gBookingsPhone.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.None;
            this.gBookingsPhone.HeaderText = "Phone";
            this.gBookingsPhone.MinimumWidth = 100;
            this.gBookingsPhone.Name = "Phone";
            // 
            // gBookingsEmail
            // 
            this.gBookingsEmail.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.None;
            this.gBookingsEmail.HeaderText = "E-mail Address";
            this.gBookingsEmail.MinimumWidth = 150;
            this.gBookingsEmail.Name = "Email";
            this.gBookingsEmail.Width = 150;
            // 
            // gBookingsRoomLayout
            // 
            this.gBookingsRoomLayout.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.None;
            this.gBookingsRoomLayout.HeaderText = "Room Layout";
            this.gBookingsRoomLayout.MinimumWidth = 200;
            this.gBookingsRoomLayout.Name = "RoomLayout";
            this.gBookingsRoomLayout.Width = 200;
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
            this.rgBookings.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.rgBookings.ForeColor = System.Drawing.Color.Black;
            this.rgBookings.LeadHeaderContextMenuStrip = null;
            this.rgBookings.Location = new System.Drawing.Point(0, 35);
            this.rgBookings.Name = "rgBookings";
            this.rgBookings.RowHeaderContextMenuStrip = null;
            this.rgBookings.Script = null;
            this.rgBookings.SheetTabContextMenuStrip = null;
            this.rgBookings.SheetTabNewButtonVisible = false;
            this.rgBookings.SheetTabVisible = true;
            this.rgBookings.SheetTabWidth = 294;
            this.rgBookings.Size = new System.Drawing.Size(880, 126);
            this.rgBookings.TabIndex = 13;
            this.rgBookings.TabStop = false;
            this.rgBookings.DoubleClick += new System.EventHandler(this.rgBookings_DoubleClick);
            // 
            // mBookingsGrid
            // 
            this.mBookingsGrid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
            this.pBookingsGridTools.Controls.Add(this.lblCountBookingsGrid);
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
            this.btnGridCompanyReset.TabStop = false;
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
            this.txtGridCompany.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtGridCompany.ForeColor = System.Drawing.Color.Black;
            this.txtGridCompany.Location = new System.Drawing.Point(64, 5);
            this.txtGridCompany.Name = "txtGridCompany";
            this.txtGridCompany.PreventEnterBeep = true;
            this.txtGridCompany.Size = new System.Drawing.Size(244, 25);
            this.txtGridCompany.TabIndex = 24;
            this.txtGridCompany.TabStop = false;
            // 
            // lblCountBookingsGrid
            // 
            this.lblCountBookingsGrid.AutoSize = true;
            // 
            // 
            // 
            this.lblCountBookingsGrid.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCountBookingsGrid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCountBookingsGrid.ForeColor = System.Drawing.Color.Black;
            this.lblCountBookingsGrid.Location = new System.Drawing.Point(348, 8);
            this.lblCountBookingsGrid.Name = "lblCountBookingsGrid";
            this.lblCountBookingsGrid.Size = new System.Drawing.Size(84, 18);
            this.lblCountBookingsGrid.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblCountBookingsGrid.TabIndex = 23;
            this.lblCountBookingsGrid.Text = "Total bookings:";
            // 
            // lblBookingsGridCompany
            // 
            this.lblBookingsGridCompany.AutoSize = true;
            // 
            // 
            // 
            this.lblBookingsGridCompany.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblBookingsGridCompany.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblBookingsGridCompany.ForeColor = System.Drawing.Color.Black;
            this.lblBookingsGridCompany.Location = new System.Drawing.Point(7, 9);
            this.lblBookingsGridCompany.Name = "lblBookingsGridCompany";
            this.lblBookingsGridCompany.Size = new System.Drawing.Size(56, 18);
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
            this.nbBookingsGrid.TabStop = false;
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
            this.pBookingsCalendarTools.Controls.Add(this.lblCountBookingsCalendar);
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
            // lblCountBookingsCalendar
            // 
            this.lblCountBookingsCalendar.AutoSize = true;
            // 
            // 
            // 
            this.lblCountBookingsCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCountBookingsCalendar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCountBookingsCalendar.ForeColor = System.Drawing.Color.Black;
            this.lblCountBookingsCalendar.Location = new System.Drawing.Point(348, 8);
            this.lblCountBookingsCalendar.Name = "lblCountBookingsCalendar";
            this.lblCountBookingsCalendar.Size = new System.Drawing.Size(84, 18);
            this.lblCountBookingsCalendar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblCountBookingsCalendar.TabIndex = 24;
            this.lblCountBookingsCalendar.Text = "Total bookings:";
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
            this.nbBookings.TabStop = false;
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
            this.dnBookings.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
            this.cvBookings.TabStop = false;
            this.cvBookings.TimeIndicator.BorderColor = System.Drawing.Color.Empty;
            this.cvBookings.TimeIndicator.Tag = null;
            this.cvBookings.TimeSlotDuration = 30;
            this.cvBookings.ItemClick += new System.EventHandler(this.cvBookings_ItemClick);
            this.cvBookings.ItemDoubleClick += new System.Windows.Forms.MouseEventHandler(this.cvBookings_ItemDoubleClick);
            this.cvBookings.MouseEnter += new System.EventHandler(this.cvBookings_MouseEnter);
            this.cvBookings.MouseLeave += new System.EventHandler(this.cvBookings_MouseLeave);
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
            this.gCompanies.ContextMenuStrip = this.mCompanies;
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
            this.gCompanies.PrimaryGrid.CheckBoxes = true;
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
            this.gCompanies.TabStop = false;
            this.gCompanies.RowActivated += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridRowActivatedEventArgs>(this.gCompanies_RowActivated);
            this.gCompanies.RowClick += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridRowClickEventArgs>(this.gCompanies_RowClick);
            this.gCompanies.RowDoubleClick += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridRowDoubleClickEventArgs>(this.gCompanies_RowDoubleClick);
            // 
            // mCompanies
            // 
            this.mCompanies.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
            this.mCompaniesAdd.Click += new System.EventHandler(this.mCompaniesAdd_Click);
            // 
            // mCompaniesRemove
            // 
            this.mCompaniesRemove.Name = "mCompaniesRemove";
            this.mCompaniesRemove.Size = new System.Drawing.Size(170, 22);
            this.mCompaniesRemove.Text = "Remove company";
            this.mCompaniesRemove.Click += new System.EventHandler(this.mCompaniesRemove_Click);
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
            this.pCompany.Controls.Add(this.btnCompanyCancel);
            this.pCompany.Controls.Add(this.btnCompanySave);
            this.pCompany.Controls.Add(this.scCompany);
            this.pCompany.DisabledBackColor = System.Drawing.Color.Empty;
            this.pCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pCompany.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
            // btnCompanyCancel
            // 
            this.btnCompanyCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCompanyCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCompanyCancel.Enabled = false;
            this.btnCompanyCancel.Location = new System.Drawing.Point(21, 21);
            this.btnCompanyCancel.Name = "btnCompanyCancel";
            this.btnCompanyCancel.Size = new System.Drawing.Size(74, 29);
            this.btnCompanyCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCompanyCancel.TabIndex = 311;
            this.btnCompanyCancel.Text = "Cancel";
            this.btnCompanyCancel.Click += new System.EventHandler(this.btnCompanyCancel_Click);
            // 
            // btnCompanySave
            // 
            this.btnCompanySave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCompanySave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCompanySave.Enabled = false;
            this.btnCompanySave.Location = new System.Drawing.Point(21, 56);
            this.btnCompanySave.Name = "btnCompanySave";
            this.btnCompanySave.Size = new System.Drawing.Size(74, 29);
            this.btnCompanySave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCompanySave.TabIndex = 310;
            this.btnCompanySave.Text = "Save";
            this.btnCompanySave.Click += new System.EventHandler(this.btnCompanySave_Click);
            // 
            // scCompany
            // 
            this.scCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scCompany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.scCompany.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.scCompany.ControlBox.MenuBox.Name = "";
            this.scCompany.ControlBox.Name = "";
            this.scCompany.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.scCompany.ControlBox.MenuBox,
            this.scCompany.ControlBox.CloseBox});
            this.scCompany.ControlBox.Visible = false;
            this.scCompany.Controls.Add(this.superTabControlPanel4);
            this.scCompany.Controls.Add(this.superTabControlPanel6);
            this.scCompany.Controls.Add(this.tpCompanyContacts);
            this.scCompany.ForeColor = System.Drawing.Color.Black;
            this.scCompany.Location = new System.Drawing.Point(114, 21);
            this.scCompany.Name = "scCompany";
            this.scCompany.ReorderTabsEnabled = true;
            this.scCompany.SelectedTabFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.scCompany.SelectedTabIndex = 0;
            this.scCompany.Size = new System.Drawing.Size(826, 294);
            this.scCompany.TabFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scCompany.TabIndex = 21;
            this.scCompany.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.tiCompanyGeneral,
            this.tiCompanyNotes,
            this.tiCompanyContacts});
            this.scCompany.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.VisualStudio2008Dock;
            // 
            // superTabControlPanel4
            // 
            this.superTabControlPanel4.Controls.Add(this.lblCompanyContact);
            this.superTabControlPanel4.Controls.Add(this.txtCompanyContact);
            this.superTabControlPanel4.Controls.Add(this.txtCompanyAddress);
            this.superTabControlPanel4.Controls.Add(this.lblCompanyAddress);
            this.superTabControlPanel4.Controls.Add(this.lblCompanyEmail);
            this.superTabControlPanel4.Controls.Add(this.txtCompanyTrading);
            this.superTabControlPanel4.Controls.Add(this.lblCompanyTrading);
            this.superTabControlPanel4.Controls.Add(this.txtCompanyRegVat);
            this.superTabControlPanel4.Controls.Add(this.txtCompanyReg);
            this.superTabControlPanel4.Controls.Add(this.txtCompanyName);
            this.superTabControlPanel4.Controls.Add(this.txtCompanyEmail);
            this.superTabControlPanel4.Controls.Add(this.lblCompanyPhone);
            this.superTabControlPanel4.Controls.Add(this.txtCompanyPhone);
            this.superTabControlPanel4.Controls.Add(this.lblCompanyReg);
            this.superTabControlPanel4.Controls.Add(this.lblCompanyName);
            this.superTabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.superTabControlPanel4.Location = new System.Drawing.Point(0, 30);
            this.superTabControlPanel4.Name = "superTabControlPanel4";
            this.superTabControlPanel4.Size = new System.Drawing.Size(826, 264);
            this.superTabControlPanel4.TabIndex = 1;
            this.superTabControlPanel4.TabItem = this.tiCompanyGeneral;
            // 
            // lblCompanyContact
            // 
            this.lblCompanyContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblCompanyContact.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCompanyContact.ForeColor = System.Drawing.Color.Black;
            this.lblCompanyContact.Location = new System.Drawing.Point(24, 179);
            this.lblCompanyContact.Name = "lblCompanyContact";
            this.lblCompanyContact.Size = new System.Drawing.Size(120, 23);
            this.lblCompanyContact.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblCompanyContact.TabIndex = 46;
            this.lblCompanyContact.Text = "Primary Contact:";
            // 
            // txtCompanyContact
            // 
            this.txtCompanyContact.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCompanyContact.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCompanyContact.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtCompanyContact.Border.Class = "TextBoxBorder";
            this.txtCompanyContact.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCompanyContact.DisabledBackColor = System.Drawing.Color.White;
            this.txtCompanyContact.Enabled = false;
            this.txtCompanyContact.ForeColor = System.Drawing.Color.Black;
            this.txtCompanyContact.Location = new System.Drawing.Point(150, 179);
            this.txtCompanyContact.Name = "txtCompanyContact";
            this.txtCompanyContact.PreventEnterBeep = true;
            this.txtCompanyContact.Size = new System.Drawing.Size(345, 25);
            this.txtCompanyContact.TabIndex = 307;
            // 
            // txtCompanyAddress
            // 
            this.txtCompanyAddress.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtCompanyAddress.Border.Class = "TextBoxBorder";
            this.txtCompanyAddress.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCompanyAddress.DisabledBackColor = System.Drawing.Color.White;
            this.txtCompanyAddress.Enabled = false;
            this.txtCompanyAddress.ForeColor = System.Drawing.Color.Black;
            this.txtCompanyAddress.Location = new System.Drawing.Point(521, 55);
            this.txtCompanyAddress.Multiline = true;
            this.txtCompanyAddress.Name = "txtCompanyAddress";
            this.txtCompanyAddress.PreventEnterBeep = true;
            this.txtCompanyAddress.Size = new System.Drawing.Size(282, 149);
            this.txtCompanyAddress.TabIndex = 308;
            // 
            // lblCompanyAddress
            // 
            this.lblCompanyAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblCompanyAddress.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCompanyAddress.ForeColor = System.Drawing.Color.Black;
            this.lblCompanyAddress.Location = new System.Drawing.Point(521, 24);
            this.lblCompanyAddress.Name = "lblCompanyAddress";
            this.lblCompanyAddress.Size = new System.Drawing.Size(74, 23);
            this.lblCompanyAddress.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblCompanyAddress.TabIndex = 43;
            this.lblCompanyAddress.Text = "Address:";
            // 
            // lblCompanyEmail
            // 
            this.lblCompanyEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblCompanyEmail.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCompanyEmail.ForeColor = System.Drawing.Color.Black;
            this.lblCompanyEmail.Location = new System.Drawing.Point(24, 148);
            this.lblCompanyEmail.Name = "lblCompanyEmail";
            this.lblCompanyEmail.Size = new System.Drawing.Size(120, 23);
            this.lblCompanyEmail.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblCompanyEmail.TabIndex = 42;
            this.lblCompanyEmail.Text = "E-mail Address:";
            // 
            // txtCompanyTrading
            // 
            this.txtCompanyTrading.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtCompanyTrading.Border.Class = "TextBoxBorder";
            this.txtCompanyTrading.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCompanyTrading.DisabledBackColor = System.Drawing.Color.White;
            this.txtCompanyTrading.Enabled = false;
            this.txtCompanyTrading.ForeColor = System.Drawing.Color.Black;
            this.txtCompanyTrading.Location = new System.Drawing.Point(150, 55);
            this.txtCompanyTrading.Name = "txtCompanyTrading";
            this.txtCompanyTrading.PreventEnterBeep = true;
            this.txtCompanyTrading.Size = new System.Drawing.Size(345, 25);
            this.txtCompanyTrading.TabIndex = 302;
            // 
            // lblCompanyTrading
            // 
            this.lblCompanyTrading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblCompanyTrading.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCompanyTrading.ForeColor = System.Drawing.Color.Black;
            this.lblCompanyTrading.Location = new System.Drawing.Point(24, 55);
            this.lblCompanyTrading.Name = "lblCompanyTrading";
            this.lblCompanyTrading.Size = new System.Drawing.Size(120, 23);
            this.lblCompanyTrading.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblCompanyTrading.TabIndex = 39;
            this.lblCompanyTrading.Text = "Trading As:";
            // 
            // txtCompanyRegVat
            // 
            this.txtCompanyRegVat.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtCompanyRegVat.Border.Class = "TextBoxBorder";
            this.txtCompanyRegVat.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCompanyRegVat.DisabledBackColor = System.Drawing.Color.White;
            this.txtCompanyRegVat.Enabled = false;
            this.txtCompanyRegVat.ForeColor = System.Drawing.Color.Black;
            this.txtCompanyRegVat.Location = new System.Drawing.Point(298, 86);
            this.txtCompanyRegVat.Name = "txtCompanyRegVat";
            this.txtCompanyRegVat.PreventEnterBeep = true;
            this.txtCompanyRegVat.Size = new System.Drawing.Size(197, 25);
            this.txtCompanyRegVat.TabIndex = 304;
            // 
            // txtCompanyReg
            // 
            this.txtCompanyReg.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtCompanyReg.Border.Class = "TextBoxBorder";
            this.txtCompanyReg.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCompanyReg.DisabledBackColor = System.Drawing.Color.White;
            this.txtCompanyReg.Enabled = false;
            this.txtCompanyReg.ForeColor = System.Drawing.Color.Black;
            this.txtCompanyReg.Location = new System.Drawing.Point(150, 86);
            this.txtCompanyReg.Name = "txtCompanyReg";
            this.txtCompanyReg.PreventEnterBeep = true;
            this.txtCompanyReg.Size = new System.Drawing.Size(142, 25);
            this.txtCompanyReg.TabIndex = 303;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCompanyName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCompanyName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtCompanyName.Border.Class = "TextBoxBorder";
            this.txtCompanyName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCompanyName.DisabledBackColor = System.Drawing.Color.White;
            this.txtCompanyName.Enabled = false;
            this.txtCompanyName.ForeColor = System.Drawing.Color.Black;
            this.txtCompanyName.Location = new System.Drawing.Point(150, 24);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.PreventEnterBeep = true;
            this.txtCompanyName.Size = new System.Drawing.Size(345, 25);
            this.txtCompanyName.TabIndex = 301;
            // 
            // txtCompanyEmail
            // 
            this.txtCompanyEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCompanyEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCompanyEmail.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtCompanyEmail.Border.Class = "TextBoxBorder";
            this.txtCompanyEmail.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCompanyEmail.DisabledBackColor = System.Drawing.Color.White;
            this.txtCompanyEmail.Enabled = false;
            this.txtCompanyEmail.ForeColor = System.Drawing.Color.Black;
            this.txtCompanyEmail.Location = new System.Drawing.Point(150, 148);
            this.txtCompanyEmail.Name = "txtCompanyEmail";
            this.txtCompanyEmail.PreventEnterBeep = true;
            this.txtCompanyEmail.Size = new System.Drawing.Size(345, 25);
            this.txtCompanyEmail.TabIndex = 306;
            // 
            // lblCompanyPhone
            // 
            this.lblCompanyPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblCompanyPhone.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCompanyPhone.ForeColor = System.Drawing.Color.Black;
            this.lblCompanyPhone.Location = new System.Drawing.Point(24, 117);
            this.lblCompanyPhone.Name = "lblCompanyPhone";
            this.lblCompanyPhone.Size = new System.Drawing.Size(120, 23);
            this.lblCompanyPhone.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblCompanyPhone.TabIndex = 34;
            this.lblCompanyPhone.Text = "Phone Number:";
            // 
            // txtCompanyPhone
            // 
            this.txtCompanyPhone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCompanyPhone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCompanyPhone.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtCompanyPhone.Border.Class = "TextBoxBorder";
            this.txtCompanyPhone.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCompanyPhone.DisabledBackColor = System.Drawing.Color.White;
            this.txtCompanyPhone.Enabled = false;
            this.txtCompanyPhone.ForeColor = System.Drawing.Color.Black;
            this.txtCompanyPhone.Location = new System.Drawing.Point(150, 117);
            this.txtCompanyPhone.Name = "txtCompanyPhone";
            this.txtCompanyPhone.PreventEnterBeep = true;
            this.txtCompanyPhone.Size = new System.Drawing.Size(142, 25);
            this.txtCompanyPhone.TabIndex = 305;
            // 
            // lblCompanyReg
            // 
            this.lblCompanyReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblCompanyReg.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCompanyReg.ForeColor = System.Drawing.Color.Black;
            this.lblCompanyReg.Location = new System.Drawing.Point(24, 86);
            this.lblCompanyReg.Name = "lblCompanyReg";
            this.lblCompanyReg.Size = new System.Drawing.Size(120, 23);
            this.lblCompanyReg.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblCompanyReg.TabIndex = 32;
            this.lblCompanyReg.Text = "Reg No./VAT No.:";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblCompanyName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCompanyName.ForeColor = System.Drawing.Color.Black;
            this.lblCompanyName.Location = new System.Drawing.Point(24, 24);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(120, 23);
            this.lblCompanyName.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblCompanyName.TabIndex = 31;
            this.lblCompanyName.Text = "Company Name:";
            // 
            // tiCompanyGeneral
            // 
            this.tiCompanyGeneral.AttachedControl = this.superTabControlPanel4;
            this.tiCompanyGeneral.GlobalItem = false;
            this.tiCompanyGeneral.Name = "tiCompanyGeneral";
            this.tiCompanyGeneral.Text = "  General";
            // 
            // tpCompanyContacts
            // 
            this.tpCompanyContacts.Controls.Add(this.scCompaniesContacts);
            this.tpCompanyContacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpCompanyContacts.Location = new System.Drawing.Point(0, 30);
            this.tpCompanyContacts.Name = "tpCompanyContacts";
            this.tpCompanyContacts.Size = new System.Drawing.Size(826, 264);
            this.tpCompanyContacts.TabIndex = 0;
            this.tpCompanyContacts.TabItem = this.tiCompanyContacts;
            // 
            // scCompaniesContacts
            // 
            this.scCompaniesContacts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.scCompaniesContacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scCompaniesContacts.Enabled = false;
            this.scCompaniesContacts.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.scCompaniesContacts.ForeColor = System.Drawing.Color.Black;
            this.scCompaniesContacts.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.scCompaniesContacts.Location = new System.Drawing.Point(0, 0);
            this.scCompaniesContacts.Name = "scCompaniesContacts";
            // 
            // 
            // 
            this.scCompaniesContacts.PrimaryGrid.Columns.Add(this.gridColumn1);
            this.scCompaniesContacts.PrimaryGrid.Columns.Add(this.gridColumn2);
            this.scCompaniesContacts.PrimaryGrid.Columns.Add(this.gridColumn3);
            this.scCompaniesContacts.PrimaryGrid.Columns.Add(this.gridColumn4);
            this.scCompaniesContacts.PrimaryGrid.MultiSelect = false;
            this.scCompaniesContacts.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row;
            this.scCompaniesContacts.PrimaryGrid.ShowRowHeaders = false;
            this.scCompaniesContacts.PrimaryGrid.UseAlternateRowStyle = true;
            this.scCompaniesContacts.Size = new System.Drawing.Size(826, 264);
            this.scCompaniesContacts.TabIndex = 0;
            this.scCompaniesContacts.Visible = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Name = "gridColumn2";
            // 
            // gridColumn3
            // 
            this.gridColumn3.Name = "gridColumn3";
            // 
            // gridColumn4
            // 
            this.gridColumn4.Name = "gridColumn4";
            // 
            // tiCompanyContacts
            // 
            this.tiCompanyContacts.AttachedControl = this.tpCompanyContacts;
            this.tiCompanyContacts.GlobalItem = false;
            this.tiCompanyContacts.Name = "tiCompanyContacts";
            this.tiCompanyContacts.Text = "  Contacts";
            // 
            // superTabControlPanel6
            // 
            this.superTabControlPanel6.Controls.Add(this.txtCompanyNotes);
            this.superTabControlPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel6.Location = new System.Drawing.Point(0, 30);
            this.superTabControlPanel6.Name = "superTabControlPanel6";
            this.superTabControlPanel6.Size = new System.Drawing.Size(826, 264);
            this.superTabControlPanel6.TabIndex = 0;
            this.superTabControlPanel6.TabItem = this.tiCompanyNotes;
            // 
            // txtCompanyNotes
            // 
            this.txtCompanyNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCompanyNotes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCompanyNotes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCompanyNotes.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtCompanyNotes.Border.Class = "TextBoxBorder";
            this.txtCompanyNotes.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCompanyNotes.DisabledBackColor = System.Drawing.Color.White;
            this.txtCompanyNotes.Enabled = false;
            this.txtCompanyNotes.ForeColor = System.Drawing.Color.Black;
            this.txtCompanyNotes.Location = new System.Drawing.Point(15, 15);
            this.txtCompanyNotes.Multiline = true;
            this.txtCompanyNotes.Name = "txtCompanyNotes";
            this.txtCompanyNotes.PreventEnterBeep = true;
            this.txtCompanyNotes.Size = new System.Drawing.Size(796, 234);
            this.txtCompanyNotes.TabIndex = 309;
            // 
            // tiCompanyNotes
            // 
            this.tiCompanyNotes.AttachedControl = this.superTabControlPanel6;
            this.tiCompanyNotes.GlobalItem = false;
            this.tiCompanyNotes.Name = "tiCompanyNotes";
            this.tiCompanyNotes.Text = "  Notes";
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
            this.pContacts.Visible = false;
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
            this.gContacts.ContextMenuStrip = this.mContacts;
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
            this.gContacts.PrimaryGrid.CheckBoxes = true;
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
            this.gContacts.TabStop = false;
            this.gContacts.RowActivated += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridRowActivatedEventArgs>(this.gContacts_RowActivated);
            this.gContacts.RowClick += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridRowClickEventArgs>(this.gContacts_RowClick);
            this.gContacts.RowDoubleClick += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridRowDoubleClickEventArgs>(this.gContacts_RowDoubleClick);
            // 
            // mContacts
            // 
            this.mContacts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
            this.pContact.Controls.Add(this.btnContactCancel);
            this.pContact.Controls.Add(this.btnContactSave);
            this.pContact.Controls.Add(this.scContact);
            this.pContact.DisabledBackColor = System.Drawing.Color.Empty;
            this.pContact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContact.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
            // btnContactCancel
            // 
            this.btnContactCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnContactCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnContactCancel.Enabled = false;
            this.btnContactCancel.Location = new System.Drawing.Point(21, 21);
            this.btnContactCancel.Name = "btnContactCancel";
            this.btnContactCancel.Size = new System.Drawing.Size(74, 29);
            this.btnContactCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnContactCancel.TabIndex = 413;
            this.btnContactCancel.Text = "Cancel";
            this.btnContactCancel.Click += new System.EventHandler(this.btnContactCancel_Click);
            // 
            // btnContactSave
            // 
            this.btnContactSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnContactSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnContactSave.Enabled = false;
            this.btnContactSave.Location = new System.Drawing.Point(21, 56);
            this.btnContactSave.Name = "btnContactSave";
            this.btnContactSave.Size = new System.Drawing.Size(74, 29);
            this.btnContactSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnContactSave.TabIndex = 412;
            this.btnContactSave.Text = "Save";
            this.btnContactSave.Click += new System.EventHandler(this.btnContactSave_Click);
            // 
            // scContact
            // 
            this.scContact.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.scContact.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.scContact.ControlBox.MenuBox.Name = "";
            this.scContact.ControlBox.Name = "";
            this.scContact.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.scContact.ControlBox.MenuBox,
            this.scContact.ControlBox.CloseBox});
            this.scContact.ControlBox.Visible = false;
            this.scContact.Controls.Add(this.superTabControlPanel1);
            this.scContact.Controls.Add(this.superTabControlPanel3);
            this.scContact.Controls.Add(this.superTabControlPanel2);
            this.scContact.ForeColor = System.Drawing.Color.Black;
            this.scContact.Location = new System.Drawing.Point(114, 21);
            this.scContact.Name = "scContact";
            this.scContact.ReorderTabsEnabled = true;
            this.scContact.SelectedTabFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.scContact.SelectedTabIndex = 0;
            this.scContact.Size = new System.Drawing.Size(826, 294);
            this.scContact.TabFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scContact.TabIndex = 0;
            this.scContact.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.tiContactGeneral,
            this.tiContactNotes,
            this.tiContactDocs});
            this.scContact.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.VisualStudio2008Dock;
            // 
            // superTabControlPanel1
            // 
            this.superTabControlPanel1.Controls.Add(this.txtContactAddress);
            this.superTabControlPanel1.Controls.Add(this.lblContactAddress);
            this.superTabControlPanel1.Controls.Add(this.lblContactEmail);
            this.superTabControlPanel1.Controls.Add(this.cbxContactNameTitle);
            this.superTabControlPanel1.Controls.Add(this.txtContactNameTitle);
            this.superTabControlPanel1.Controls.Add(this.labelX1);
            this.superTabControlPanel1.Controls.Add(this.txtContactNameLast);
            this.superTabControlPanel1.Controls.Add(this.txtContactNameFirst);
            this.superTabControlPanel1.Controls.Add(this.txtContactCompany);
            this.superTabControlPanel1.Controls.Add(this.txtContactEmail);
            this.superTabControlPanel1.Controls.Add(this.lblContactPhone);
            this.superTabControlPanel1.Controls.Add(this.txtContactPhone);
            this.superTabControlPanel1.Controls.Add(this.lblContactName);
            this.superTabControlPanel1.Controls.Add(this.lblContactCompany);
            this.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel1.Location = new System.Drawing.Point(0, 30);
            this.superTabControlPanel1.Name = "superTabControlPanel1";
            this.superTabControlPanel1.Size = new System.Drawing.Size(826, 264);
            this.superTabControlPanel1.TabIndex = 1;
            this.superTabControlPanel1.TabItem = this.tiContactGeneral;
            // 
            // txtContactAddress
            // 
            this.txtContactAddress.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtContactAddress.Border.Class = "TextBoxBorder";
            this.txtContactAddress.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtContactAddress.DisabledBackColor = System.Drawing.Color.White;
            this.txtContactAddress.Enabled = false;
            this.txtContactAddress.ForeColor = System.Drawing.Color.Black;
            this.txtContactAddress.Location = new System.Drawing.Point(521, 55);
            this.txtContactAddress.Multiline = true;
            this.txtContactAddress.Name = "txtContactAddress";
            this.txtContactAddress.PreventEnterBeep = true;
            this.txtContactAddress.Size = new System.Drawing.Size(282, 118);
            this.txtContactAddress.TabIndex = 408;
            // 
            // lblContactAddress
            // 
            this.lblContactAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblContactAddress.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblContactAddress.ForeColor = System.Drawing.Color.Black;
            this.lblContactAddress.Location = new System.Drawing.Point(521, 24);
            this.lblContactAddress.Name = "lblContactAddress";
            this.lblContactAddress.Size = new System.Drawing.Size(74, 23);
            this.lblContactAddress.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblContactAddress.TabIndex = 43;
            this.lblContactAddress.Text = "Address:";
            // 
            // lblContactEmail
            // 
            this.lblContactEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblContactEmail.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblContactEmail.ForeColor = System.Drawing.Color.Black;
            this.lblContactEmail.Location = new System.Drawing.Point(24, 148);
            this.lblContactEmail.Name = "lblContactEmail";
            this.lblContactEmail.Size = new System.Drawing.Size(120, 23);
            this.lblContactEmail.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblContactEmail.TabIndex = 42;
            this.lblContactEmail.Text = "E-mail Address:";
            // 
            // cbxContactNameTitle
            // 
            this.cbxContactNameTitle.DisplayMember = "Text";
            this.cbxContactNameTitle.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxContactNameTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxContactNameTitle.Enabled = false;
            this.cbxContactNameTitle.ForeColor = System.Drawing.Color.Black;
            this.cbxContactNameTitle.FormattingEnabled = true;
            this.cbxContactNameTitle.ItemHeight = 19;
            this.cbxContactNameTitle.Items.AddRange(new object[] {
            this.cbxiContactTitleMr,
            this.cbxiContactTitleMrs,
            this.cbxiContactTitleMiss,
            this.cbxiContactTitleMs,
            this.cbxiContactTitleMaster,
            this.cbxiContactTitleDr,
            this.cbxiContactTitleProf,
            this.cbxiContactTitleOfc});
            this.cbxContactNameTitle.Location = new System.Drawing.Point(298, 55);
            this.cbxContactNameTitle.Name = "cbxContactNameTitle";
            this.cbxContactNameTitle.Size = new System.Drawing.Size(197, 25);
            this.cbxContactNameTitle.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxContactNameTitle.TabIndex = 403;
            this.cbxContactNameTitle.SelectionChangeCommitted += new System.EventHandler(this.cbxContactNameTitle_SelectionChangeCommitted_1);
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
            // txtContactNameTitle
            // 
            this.txtContactNameTitle.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtContactNameTitle.Border.Class = "TextBoxBorder";
            this.txtContactNameTitle.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtContactNameTitle.DisabledBackColor = System.Drawing.Color.White;
            this.txtContactNameTitle.Enabled = false;
            this.txtContactNameTitle.ForeColor = System.Drawing.Color.Black;
            this.txtContactNameTitle.Location = new System.Drawing.Point(150, 55);
            this.txtContactNameTitle.Name = "txtContactNameTitle";
            this.txtContactNameTitle.PreventEnterBeep = true;
            this.txtContactNameTitle.Size = new System.Drawing.Size(142, 25);
            this.txtContactNameTitle.TabIndex = 402;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(24, 55);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(120, 23);
            this.labelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.labelX1.TabIndex = 39;
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
            this.txtContactNameLast.Enabled = false;
            this.txtContactNameLast.ForeColor = System.Drawing.Color.Black;
            this.txtContactNameLast.Location = new System.Drawing.Point(298, 86);
            this.txtContactNameLast.Name = "txtContactNameLast";
            this.txtContactNameLast.PreventEnterBeep = true;
            this.txtContactNameLast.Size = new System.Drawing.Size(197, 25);
            this.txtContactNameLast.TabIndex = 405;
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
            this.txtContactNameFirst.Enabled = false;
            this.txtContactNameFirst.ForeColor = System.Drawing.Color.Black;
            this.txtContactNameFirst.Location = new System.Drawing.Point(150, 86);
            this.txtContactNameFirst.Name = "txtContactNameFirst";
            this.txtContactNameFirst.PreventEnterBeep = true;
            this.txtContactNameFirst.Size = new System.Drawing.Size(142, 25);
            this.txtContactNameFirst.TabIndex = 404;
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
            this.txtContactCompany.Enabled = false;
            this.txtContactCompany.ForeColor = System.Drawing.Color.Black;
            this.txtContactCompany.Location = new System.Drawing.Point(150, 24);
            this.txtContactCompany.Name = "txtContactCompany";
            this.txtContactCompany.PreventEnterBeep = true;
            this.txtContactCompany.Size = new System.Drawing.Size(345, 25);
            this.txtContactCompany.TabIndex = 401;
            // 
            // txtContactEmail
            // 
            this.txtContactEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtContactEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtContactEmail.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtContactEmail.Border.Class = "TextBoxBorder";
            this.txtContactEmail.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtContactEmail.DisabledBackColor = System.Drawing.Color.White;
            this.txtContactEmail.Enabled = false;
            this.txtContactEmail.ForeColor = System.Drawing.Color.Black;
            this.txtContactEmail.Location = new System.Drawing.Point(150, 148);
            this.txtContactEmail.Name = "txtContactEmail";
            this.txtContactEmail.PreventEnterBeep = true;
            this.txtContactEmail.Size = new System.Drawing.Size(345, 25);
            this.txtContactEmail.TabIndex = 407;
            // 
            // lblContactPhone
            // 
            this.lblContactPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblContactPhone.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblContactPhone.ForeColor = System.Drawing.Color.Black;
            this.lblContactPhone.Location = new System.Drawing.Point(24, 117);
            this.lblContactPhone.Name = "lblContactPhone";
            this.lblContactPhone.Size = new System.Drawing.Size(120, 23);
            this.lblContactPhone.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblContactPhone.TabIndex = 34;
            this.lblContactPhone.Text = "Phone Number:";
            // 
            // txtContactPhone
            // 
            this.txtContactPhone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtContactPhone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtContactPhone.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtContactPhone.Border.Class = "TextBoxBorder";
            this.txtContactPhone.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtContactPhone.DisabledBackColor = System.Drawing.Color.White;
            this.txtContactPhone.Enabled = false;
            this.txtContactPhone.ForeColor = System.Drawing.Color.Black;
            this.txtContactPhone.Location = new System.Drawing.Point(150, 117);
            this.txtContactPhone.Name = "txtContactPhone";
            this.txtContactPhone.PreventEnterBeep = true;
            this.txtContactPhone.Size = new System.Drawing.Size(142, 25);
            this.txtContactPhone.TabIndex = 406;
            // 
            // lblContactName
            // 
            this.lblContactName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblContactName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblContactName.ForeColor = System.Drawing.Color.Black;
            this.lblContactName.Location = new System.Drawing.Point(24, 86);
            this.lblContactName.Name = "lblContactName";
            this.lblContactName.Size = new System.Drawing.Size(120, 23);
            this.lblContactName.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblContactName.TabIndex = 32;
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
            this.lblContactCompany.Location = new System.Drawing.Point(24, 24);
            this.lblContactCompany.Name = "lblContactCompany";
            this.lblContactCompany.Size = new System.Drawing.Size(120, 23);
            this.lblContactCompany.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblContactCompany.TabIndex = 31;
            this.lblContactCompany.Text = "Company:";
            // 
            // tiContactGeneral
            // 
            this.tiContactGeneral.AttachedControl = this.superTabControlPanel1;
            this.tiContactGeneral.GlobalItem = false;
            this.tiContactGeneral.Name = "tiContactGeneral";
            this.tiContactGeneral.Text = "  General";
            // 
            // superTabControlPanel3
            // 
            this.superTabControlPanel3.Controls.Add(this.lblContactFileAccessVal);
            this.superTabControlPanel3.Controls.Add(this.lblContactFileAccess);
            this.superTabControlPanel3.Controls.Add(this.lblContactFileModVal);
            this.superTabControlPanel3.Controls.Add(this.lblContactFileMod);
            this.superTabControlPanel3.Controls.Add(this.lblContactFileSizeVal);
            this.superTabControlPanel3.Controls.Add(this.lblContactFileSize);
            this.superTabControlPanel3.Controls.Add(this.lblContactFileLocVal);
            this.superTabControlPanel3.Controls.Add(this.lblContactFileLoc);
            this.superTabControlPanel3.Controls.Add(this.lblContactFileNameVal);
            this.superTabControlPanel3.Controls.Add(this.lblContactFileName);
            this.superTabControlPanel3.Controls.Add(this.lvContactDocuments);
            this.superTabControlPanel3.Controls.Add(this.btnContactDocumentAdd);
            this.superTabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel3.Location = new System.Drawing.Point(0, 30);
            this.superTabControlPanel3.Name = "superTabControlPanel3";
            this.superTabControlPanel3.Size = new System.Drawing.Size(826, 264);
            this.superTabControlPanel3.TabIndex = 0;
            this.superTabControlPanel3.TabItem = this.tiContactDocs;
            // 
            // lblContactFileAccessVal
            // 
            this.lblContactFileAccessVal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblContactFileAccessVal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblContactFileAccessVal.ForeColor = System.Drawing.Color.Black;
            this.lblContactFileAccessVal.Location = new System.Drawing.Point(410, 131);
            this.lblContactFileAccessVal.Name = "lblContactFileAccessVal";
            this.lblContactFileAccessVal.Size = new System.Drawing.Size(403, 23);
            this.lblContactFileAccessVal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblContactFileAccessVal.TabIndex = 29;
            this.lblContactFileAccessVal.Text = "...";
            // 
            // lblContactFileAccess
            // 
            this.lblContactFileAccess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblContactFileAccess.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblContactFileAccess.ForeColor = System.Drawing.Color.Black;
            this.lblContactFileAccess.Location = new System.Drawing.Point(304, 131);
            this.lblContactFileAccess.Name = "lblContactFileAccess";
            this.lblContactFileAccess.Size = new System.Drawing.Size(100, 23);
            this.lblContactFileAccess.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblContactFileAccess.TabIndex = 28;
            this.lblContactFileAccess.Text = "Last accessed:";
            // 
            // lblContactFileModVal
            // 
            this.lblContactFileModVal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblContactFileModVal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblContactFileModVal.ForeColor = System.Drawing.Color.Black;
            this.lblContactFileModVal.Location = new System.Drawing.Point(410, 102);
            this.lblContactFileModVal.Name = "lblContactFileModVal";
            this.lblContactFileModVal.Size = new System.Drawing.Size(403, 23);
            this.lblContactFileModVal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblContactFileModVal.TabIndex = 27;
            this.lblContactFileModVal.Text = "...";
            // 
            // lblContactFileMod
            // 
            this.lblContactFileMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblContactFileMod.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblContactFileMod.ForeColor = System.Drawing.Color.Black;
            this.lblContactFileMod.Location = new System.Drawing.Point(304, 102);
            this.lblContactFileMod.Name = "lblContactFileMod";
            this.lblContactFileMod.Size = new System.Drawing.Size(100, 23);
            this.lblContactFileMod.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblContactFileMod.TabIndex = 26;
            this.lblContactFileMod.Text = "Last modified:";
            // 
            // lblContactFileSizeVal
            // 
            this.lblContactFileSizeVal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblContactFileSizeVal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblContactFileSizeVal.ForeColor = System.Drawing.Color.Black;
            this.lblContactFileSizeVal.Location = new System.Drawing.Point(410, 73);
            this.lblContactFileSizeVal.Name = "lblContactFileSizeVal";
            this.lblContactFileSizeVal.Size = new System.Drawing.Size(403, 23);
            this.lblContactFileSizeVal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblContactFileSizeVal.TabIndex = 25;
            this.lblContactFileSizeVal.Text = "...";
            // 
            // lblContactFileSize
            // 
            this.lblContactFileSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblContactFileSize.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblContactFileSize.ForeColor = System.Drawing.Color.Black;
            this.lblContactFileSize.Location = new System.Drawing.Point(304, 73);
            this.lblContactFileSize.Name = "lblContactFileSize";
            this.lblContactFileSize.Size = new System.Drawing.Size(100, 23);
            this.lblContactFileSize.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblContactFileSize.TabIndex = 24;
            this.lblContactFileSize.Text = "File size:";
            // 
            // lblContactFileLocVal
            // 
            this.lblContactFileLocVal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblContactFileLocVal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblContactFileLocVal.ForeColor = System.Drawing.Color.Black;
            this.lblContactFileLocVal.Location = new System.Drawing.Point(410, 44);
            this.lblContactFileLocVal.Name = "lblContactFileLocVal";
            this.lblContactFileLocVal.Size = new System.Drawing.Size(403, 23);
            this.lblContactFileLocVal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblContactFileLocVal.TabIndex = 23;
            this.lblContactFileLocVal.Text = "...";
            // 
            // lblContactFileLoc
            // 
            this.lblContactFileLoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblContactFileLoc.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblContactFileLoc.ForeColor = System.Drawing.Color.Black;
            this.lblContactFileLoc.Location = new System.Drawing.Point(304, 44);
            this.lblContactFileLoc.Name = "lblContactFileLoc";
            this.lblContactFileLoc.Size = new System.Drawing.Size(100, 23);
            this.lblContactFileLoc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblContactFileLoc.TabIndex = 22;
            this.lblContactFileLoc.Text = "Location:";
            // 
            // lblContactFileNameVal
            // 
            this.lblContactFileNameVal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblContactFileNameVal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblContactFileNameVal.ForeColor = System.Drawing.Color.Black;
            this.lblContactFileNameVal.Location = new System.Drawing.Point(410, 15);
            this.lblContactFileNameVal.Name = "lblContactFileNameVal";
            this.lblContactFileNameVal.Size = new System.Drawing.Size(403, 23);
            this.lblContactFileNameVal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblContactFileNameVal.TabIndex = 21;
            this.lblContactFileNameVal.Text = "...";
            // 
            // lblContactFileName
            // 
            this.lblContactFileName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblContactFileName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblContactFileName.ForeColor = System.Drawing.Color.Black;
            this.lblContactFileName.Location = new System.Drawing.Point(304, 15);
            this.lblContactFileName.Name = "lblContactFileName";
            this.lblContactFileName.Size = new System.Drawing.Size(100, 23);
            this.lblContactFileName.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblContactFileName.TabIndex = 20;
            this.lblContactFileName.Text = "Filename:";
            // 
            // lvContactDocuments
            // 
            this.lvContactDocuments.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvContactDocuments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvContactDocuments.BackColor = System.Drawing.Color.White;
            this.lvContactDocuments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvContactDocuments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chFilename});
            this.lvContactDocuments.Enabled = false;
            this.lvContactDocuments.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lvContactDocuments.ForeColor = System.Drawing.Color.Black;
            this.lvContactDocuments.FullRowSelect = true;
            this.lvContactDocuments.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvContactDocuments.HideSelection = false;
            this.lvContactDocuments.Location = new System.Drawing.Point(15, 15);
            this.lvContactDocuments.MultiSelect = false;
            this.lvContactDocuments.Name = "lvContactDocuments";
            this.lvContactDocuments.Size = new System.Drawing.Size(272, 209);
            this.lvContactDocuments.TabIndex = 410;
            this.lvContactDocuments.UseCompatibleStateImageBehavior = false;
            this.lvContactDocuments.View = System.Windows.Forms.View.Details;
            // 
            // chFilename
            // 
            this.chFilename.Text = "Filename";
            this.chFilename.Width = 224;
            // 
            // btnContactDocumentAdd
            // 
            this.btnContactDocumentAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnContactDocumentAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnContactDocumentAdd.Enabled = false;
            this.btnContactDocumentAdd.Location = new System.Drawing.Point(95, 229);
            this.btnContactDocumentAdd.Name = "btnContactDocumentAdd";
            this.btnContactDocumentAdd.Size = new System.Drawing.Size(110, 29);
            this.btnContactDocumentAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnContactDocumentAdd.TabIndex = 411;
            this.btnContactDocumentAdd.Text = "Add document";
            // 
            // tiContactDocs
            // 
            this.tiContactDocs.AttachedControl = this.superTabControlPanel3;
            this.tiContactDocs.GlobalItem = false;
            this.tiContactDocs.Name = "tiContactDocs";
            this.tiContactDocs.Text = "  Documents";
            // 
            // superTabControlPanel2
            // 
            this.superTabControlPanel2.Controls.Add(this.txtContactNotes);
            this.superTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel2.Location = new System.Drawing.Point(0, 30);
            this.superTabControlPanel2.Name = "superTabControlPanel2";
            this.superTabControlPanel2.Size = new System.Drawing.Size(826, 264);
            this.superTabControlPanel2.TabIndex = 0;
            this.superTabControlPanel2.TabItem = this.tiContactNotes;
            // 
            // txtContactNotes
            // 
            this.txtContactNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContactNotes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtContactNotes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtContactNotes.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtContactNotes.Border.Class = "TextBoxBorder";
            this.txtContactNotes.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtContactNotes.DisabledBackColor = System.Drawing.Color.White;
            this.txtContactNotes.Enabled = false;
            this.txtContactNotes.ForeColor = System.Drawing.Color.Black;
            this.txtContactNotes.Location = new System.Drawing.Point(15, 15);
            this.txtContactNotes.Multiline = true;
            this.txtContactNotes.Name = "txtContactNotes";
            this.txtContactNotes.PreventEnterBeep = true;
            this.txtContactNotes.Size = new System.Drawing.Size(796, 234);
            this.txtContactNotes.TabIndex = 409;
            // 
            // tiContactNotes
            // 
            this.tiContactNotes.AttachedControl = this.superTabControlPanel2;
            this.tiContactNotes.GlobalItem = false;
            this.tiContactNotes.Name = "tiContactNotes";
            this.tiContactNotes.Text = "  Notes";
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
            this.pEnquiriesGridTools.Controls.Add(this.lblCountEnquiries);
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
            this.btnEnquiriesListCompany.TabStop = false;
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
            this.txtEnquiriesListCompany.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEnquiriesListCompany.ForeColor = System.Drawing.Color.Black;
            this.txtEnquiriesListCompany.Location = new System.Drawing.Point(64, 5);
            this.txtEnquiriesListCompany.Name = "txtEnquiriesListCompany";
            this.txtEnquiriesListCompany.PreventEnterBeep = true;
            this.txtEnquiriesListCompany.Size = new System.Drawing.Size(244, 25);
            this.txtEnquiriesListCompany.TabIndex = 27;
            this.txtEnquiriesListCompany.TabStop = false;
            // 
            // lblCountEnquiries
            // 
            this.lblCountEnquiries.AutoSize = true;
            // 
            // 
            // 
            this.lblCountEnquiries.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCountEnquiries.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCountEnquiries.ForeColor = System.Drawing.Color.Black;
            this.lblCountEnquiries.Location = new System.Drawing.Point(348, 8);
            this.lblCountEnquiries.Name = "lblCountEnquiries";
            this.lblCountEnquiries.Size = new System.Drawing.Size(83, 18);
            this.lblCountEnquiries.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblCountEnquiries.TabIndex = 26;
            this.lblCountEnquiries.Text = "Total enquiries:";
            // 
            // lblEnquiriesCompany
            // 
            this.lblEnquiriesCompany.AutoSize = true;
            // 
            // 
            // 
            this.lblEnquiriesCompany.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblEnquiriesCompany.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblEnquiriesCompany.ForeColor = System.Drawing.Color.Black;
            this.lblEnquiriesCompany.Location = new System.Drawing.Point(7, 9);
            this.lblEnquiriesCompany.Name = "lblEnquiriesCompany";
            this.lblEnquiriesCompany.Size = new System.Drawing.Size(56, 18);
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
            this.gEnquiries.ContextMenuStrip = this.mEnquiries;
            this.gEnquiries.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.gEnquiries.ForeColor = System.Drawing.Color.Black;
            this.gEnquiries.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.gEnquiries.Location = new System.Drawing.Point(0, 34);
            this.gEnquiries.Name = "gEnquiries";
            // 
            // 
            // 
            this.gEnquiries.PrimaryGrid.AllowEdit = false;
            this.gEnquiries.PrimaryGrid.CheckBoxes = true;
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
            this.gEnquiries.TabStop = false;
            this.gEnquiries.RowActivated += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridRowActivatedEventArgs>(this.gEnquiries_RowActivated);
            this.gEnquiries.RowClick += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridRowClickEventArgs>(this.gEnquiries_RowClick);
            this.gEnquiries.RowDoubleClick += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridRowDoubleClickEventArgs>(this.gEnquiries_RowDoubleClick);
            // 
            // mEnquiries
            // 
            this.mEnquiries.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
            this.mEnquiriesAdd.Click += new System.EventHandler(this.mEnquiriesAdd_Click);
            // 
            // mEnquiriesRemove
            // 
            this.mEnquiriesRemove.Name = "mEnquiriesRemove";
            this.mEnquiriesRemove.Size = new System.Drawing.Size(164, 22);
            this.mEnquiriesRemove.Text = "Remove enquiry";
            this.mEnquiriesRemove.Click += new System.EventHandler(this.mEnquiriesRemove_Click);
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
            this.mEnquiriesBooking.Click += new System.EventHandler(this.mEnquiriesBooking_Click);
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
            this.pEnquiry.Controls.Add(this.btnEnquiryCancel);
            this.pEnquiry.Controls.Add(this.btnEnquirySave);
            this.pEnquiry.Controls.Add(this.scEnquiry);
            this.pEnquiry.DisabledBackColor = System.Drawing.Color.Empty;
            this.pEnquiry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pEnquiry.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
            // btnEnquiryCancel
            // 
            this.btnEnquiryCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEnquiryCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEnquiryCancel.Enabled = false;
            this.btnEnquiryCancel.Location = new System.Drawing.Point(21, 21);
            this.btnEnquiryCancel.Name = "btnEnquiryCancel";
            this.btnEnquiryCancel.Size = new System.Drawing.Size(74, 29);
            this.btnEnquiryCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEnquiryCancel.TabIndex = 113;
            this.btnEnquiryCancel.Text = "Cancel";
            this.btnEnquiryCancel.Click += new System.EventHandler(this.btnEnquiryCancel_Click);
            // 
            // btnEnquirySave
            // 
            this.btnEnquirySave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEnquirySave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEnquirySave.Enabled = false;
            this.btnEnquirySave.Location = new System.Drawing.Point(21, 56);
            this.btnEnquirySave.Name = "btnEnquirySave";
            this.btnEnquirySave.Size = new System.Drawing.Size(74, 29);
            this.btnEnquirySave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEnquirySave.TabIndex = 112;
            this.btnEnquirySave.Text = "Save";
            this.btnEnquirySave.Click += new System.EventHandler(this.btnEnquirySave_Click);
            // 
            // scEnquiry
            // 
            this.scEnquiry.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scEnquiry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.scEnquiry.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.scEnquiry.ControlBox.MenuBox.Name = "";
            this.scEnquiry.ControlBox.Name = "";
            this.scEnquiry.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.scEnquiry.ControlBox.MenuBox,
            this.scEnquiry.ControlBox.CloseBox});
            this.scEnquiry.ControlBox.Visible = false;
            this.scEnquiry.Controls.Add(this.superTabControlPanel8);
            this.scEnquiry.Controls.Add(this.superTabControlPanel5);
            this.scEnquiry.Controls.Add(this.superTabControlPanel10);
            this.scEnquiry.ForeColor = System.Drawing.Color.Black;
            this.scEnquiry.Location = new System.Drawing.Point(114, 21);
            this.scEnquiry.Name = "scEnquiry";
            this.scEnquiry.ReorderTabsEnabled = true;
            this.scEnquiry.SelectedTabFont = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.scEnquiry.SelectedTabIndex = 0;
            this.scEnquiry.Size = new System.Drawing.Size(826, 294);
            this.scEnquiry.TabFont = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.scEnquiry.TabIndex = 24;
            this.scEnquiry.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.tiEnquiryGeneral,
            this.tiEnquiryInfo,
            this.tiEnquiryDocs});
            this.scEnquiry.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.VisualStudio2008Dock;
            // 
            // superTabControlPanel8
            // 
            this.superTabControlPanel8.Controls.Add(this.lblEnquiryNumberVal);
            this.superTabControlPanel8.Controls.Add(this.lblEnquiryNumber);
            this.superTabControlPanel8.Controls.Add(this.lblEnquiryInfo);
            this.superTabControlPanel8.Controls.Add(this.txtEnquiryInfo);
            this.superTabControlPanel8.Controls.Add(this.lblEnquiryReferrer);
            this.superTabControlPanel8.Controls.Add(this.txtEnquiryReferrer);
            this.superTabControlPanel8.Controls.Add(this.cbxEnquiryType);
            this.superTabControlPanel8.Controls.Add(this.lblEnquiryType);
            this.superTabControlPanel8.Controls.Add(this.lblEnquiryEmail);
            this.superTabControlPanel8.Controls.Add(this.txtEnquiryEmail);
            this.superTabControlPanel8.Controls.Add(this.lblEnquiryPhone);
            this.superTabControlPanel8.Controls.Add(this.txtEnquiryPhone);
            this.superTabControlPanel8.Controls.Add(this.txtEnquiryCompany);
            this.superTabControlPanel8.Controls.Add(this.lblEnquiryCompany);
            this.superTabControlPanel8.Controls.Add(this.txtEnquiryName);
            this.superTabControlPanel8.Controls.Add(this.lblEnquiryName);
            this.superTabControlPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel8.Location = new System.Drawing.Point(0, 30);
            this.superTabControlPanel8.Name = "superTabControlPanel8";
            this.superTabControlPanel8.Size = new System.Drawing.Size(826, 264);
            this.superTabControlPanel8.TabIndex = 1;
            this.superTabControlPanel8.TabItem = this.tiEnquiryGeneral;
            // 
            // lblEnquiryNumberVal
            // 
            this.lblEnquiryNumberVal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblEnquiryNumberVal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblEnquiryNumberVal.ForeColor = System.Drawing.Color.Black;
            this.lblEnquiryNumberVal.Location = new System.Drawing.Point(150, 228);
            this.lblEnquiryNumberVal.Name = "lblEnquiryNumberVal";
            this.lblEnquiryNumberVal.Size = new System.Drawing.Size(99, 20);
            this.lblEnquiryNumberVal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblEnquiryNumberVal.TabIndex = 55;
            // 
            // lblEnquiryNumber
            // 
            this.lblEnquiryNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblEnquiryNumber.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblEnquiryNumber.ForeColor = System.Drawing.Color.Black;
            this.lblEnquiryNumber.Location = new System.Drawing.Point(24, 228);
            this.lblEnquiryNumber.Name = "lblEnquiryNumber";
            this.lblEnquiryNumber.Size = new System.Drawing.Size(107, 23);
            this.lblEnquiryNumber.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblEnquiryNumber.TabIndex = 54;
            this.lblEnquiryNumber.Text = "Enquiry Number:";
            // 
            // lblEnquiryInfo
            // 
            this.lblEnquiryInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblEnquiryInfo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblEnquiryInfo.ForeColor = System.Drawing.Color.Black;
            this.lblEnquiryInfo.Location = new System.Drawing.Point(522, 25);
            this.lblEnquiryInfo.Name = "lblEnquiryInfo";
            this.lblEnquiryInfo.Size = new System.Drawing.Size(120, 23);
            this.lblEnquiryInfo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblEnquiryInfo.TabIndex = 53;
            this.lblEnquiryInfo.Text = "Details:";
            // 
            // txtEnquiryInfo
            // 
            this.txtEnquiryInfo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtEnquiryInfo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtEnquiryInfo.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtEnquiryInfo.Border.Class = "TextBoxBorder";
            this.txtEnquiryInfo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtEnquiryInfo.DisabledBackColor = System.Drawing.Color.White;
            this.txtEnquiryInfo.Enabled = false;
            this.txtEnquiryInfo.ForeColor = System.Drawing.Color.Black;
            this.txtEnquiryInfo.Location = new System.Drawing.Point(522, 54);
            this.txtEnquiryInfo.Multiline = true;
            this.txtEnquiryInfo.Name = "txtEnquiryInfo";
            this.txtEnquiryInfo.PreventEnterBeep = true;
            this.txtEnquiryInfo.Size = new System.Drawing.Size(281, 150);
            this.txtEnquiryInfo.TabIndex = 107;
            // 
            // lblEnquiryReferrer
            // 
            this.lblEnquiryReferrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblEnquiryReferrer.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblEnquiryReferrer.ForeColor = System.Drawing.Color.Black;
            this.lblEnquiryReferrer.Location = new System.Drawing.Point(24, 179);
            this.lblEnquiryReferrer.Name = "lblEnquiryReferrer";
            this.lblEnquiryReferrer.Size = new System.Drawing.Size(120, 23);
            this.lblEnquiryReferrer.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblEnquiryReferrer.TabIndex = 51;
            this.lblEnquiryReferrer.Text = "Referred By:";
            // 
            // txtEnquiryReferrer
            // 
            this.txtEnquiryReferrer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtEnquiryReferrer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtEnquiryReferrer.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtEnquiryReferrer.Border.Class = "TextBoxBorder";
            this.txtEnquiryReferrer.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtEnquiryReferrer.DisabledBackColor = System.Drawing.Color.White;
            this.txtEnquiryReferrer.Enabled = false;
            this.txtEnquiryReferrer.ForeColor = System.Drawing.Color.Black;
            this.txtEnquiryReferrer.Location = new System.Drawing.Point(150, 179);
            this.txtEnquiryReferrer.Name = "txtEnquiryReferrer";
            this.txtEnquiryReferrer.PreventEnterBeep = true;
            this.txtEnquiryReferrer.Size = new System.Drawing.Size(345, 25);
            this.txtEnquiryReferrer.TabIndex = 106;
            // 
            // cbxEnquiryType
            // 
            this.cbxEnquiryType.DisplayMember = "Text";
            this.cbxEnquiryType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxEnquiryType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEnquiryType.Enabled = false;
            this.cbxEnquiryType.ForeColor = System.Drawing.Color.Black;
            this.cbxEnquiryType.FormattingEnabled = true;
            this.cbxEnquiryType.ItemHeight = 19;
            this.cbxEnquiryType.Location = new System.Drawing.Point(150, 148);
            this.cbxEnquiryType.Name = "cbxEnquiryType";
            this.cbxEnquiryType.Size = new System.Drawing.Size(345, 25);
            this.cbxEnquiryType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxEnquiryType.TabIndex = 105;
            // 
            // lblEnquiryType
            // 
            this.lblEnquiryType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblEnquiryType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblEnquiryType.ForeColor = System.Drawing.Color.Black;
            this.lblEnquiryType.Location = new System.Drawing.Point(24, 148);
            this.lblEnquiryType.Name = "lblEnquiryType";
            this.lblEnquiryType.Size = new System.Drawing.Size(120, 23);
            this.lblEnquiryType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblEnquiryType.TabIndex = 48;
            this.lblEnquiryType.Text = "Enquirer Type:";
            // 
            // lblEnquiryEmail
            // 
            this.lblEnquiryEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblEnquiryEmail.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblEnquiryEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEnquiryEmail.Location = new System.Drawing.Point(24, 117);
            this.lblEnquiryEmail.Name = "lblEnquiryEmail";
            this.lblEnquiryEmail.Size = new System.Drawing.Size(120, 23);
            this.lblEnquiryEmail.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblEnquiryEmail.TabIndex = 46;
            this.lblEnquiryEmail.Text = "E-mail Address:";
            // 
            // txtEnquiryEmail
            // 
            this.txtEnquiryEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtEnquiryEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtEnquiryEmail.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtEnquiryEmail.Border.Class = "TextBoxBorder";
            this.txtEnquiryEmail.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtEnquiryEmail.DisabledBackColor = System.Drawing.Color.White;
            this.txtEnquiryEmail.Enabled = false;
            this.txtEnquiryEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEnquiryEmail.Location = new System.Drawing.Point(150, 117);
            this.txtEnquiryEmail.Name = "txtEnquiryEmail";
            this.txtEnquiryEmail.PreventEnterBeep = true;
            this.txtEnquiryEmail.Size = new System.Drawing.Size(345, 25);
            this.txtEnquiryEmail.TabIndex = 104;
            // 
            // lblEnquiryPhone
            // 
            this.lblEnquiryPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblEnquiryPhone.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblEnquiryPhone.ForeColor = System.Drawing.Color.Black;
            this.lblEnquiryPhone.Location = new System.Drawing.Point(24, 86);
            this.lblEnquiryPhone.Name = "lblEnquiryPhone";
            this.lblEnquiryPhone.Size = new System.Drawing.Size(120, 23);
            this.lblEnquiryPhone.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblEnquiryPhone.TabIndex = 44;
            this.lblEnquiryPhone.Text = "Phone Number:";
            // 
            // txtEnquiryPhone
            // 
            this.txtEnquiryPhone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtEnquiryPhone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtEnquiryPhone.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtEnquiryPhone.Border.Class = "TextBoxBorder";
            this.txtEnquiryPhone.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtEnquiryPhone.DisabledBackColor = System.Drawing.Color.White;
            this.txtEnquiryPhone.Enabled = false;
            this.txtEnquiryPhone.ForeColor = System.Drawing.Color.Black;
            this.txtEnquiryPhone.Location = new System.Drawing.Point(150, 86);
            this.txtEnquiryPhone.Name = "txtEnquiryPhone";
            this.txtEnquiryPhone.PreventEnterBeep = true;
            this.txtEnquiryPhone.Size = new System.Drawing.Size(142, 25);
            this.txtEnquiryPhone.TabIndex = 103;
            // 
            // txtEnquiryCompany
            // 
            this.txtEnquiryCompany.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtEnquiryCompany.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtEnquiryCompany.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtEnquiryCompany.Border.Class = "TextBoxBorder";
            this.txtEnquiryCompany.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtEnquiryCompany.DisabledBackColor = System.Drawing.Color.White;
            this.txtEnquiryCompany.Enabled = false;
            this.txtEnquiryCompany.ForeColor = System.Drawing.Color.Black;
            this.txtEnquiryCompany.Location = new System.Drawing.Point(150, 55);
            this.txtEnquiryCompany.Name = "txtEnquiryCompany";
            this.txtEnquiryCompany.PreventEnterBeep = true;
            this.txtEnquiryCompany.Size = new System.Drawing.Size(345, 25);
            this.txtEnquiryCompany.TabIndex = 102;
            // 
            // lblEnquiryCompany
            // 
            this.lblEnquiryCompany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblEnquiryCompany.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblEnquiryCompany.ForeColor = System.Drawing.Color.Black;
            this.lblEnquiryCompany.Location = new System.Drawing.Point(24, 55);
            this.lblEnquiryCompany.Name = "lblEnquiryCompany";
            this.lblEnquiryCompany.Size = new System.Drawing.Size(107, 23);
            this.lblEnquiryCompany.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblEnquiryCompany.TabIndex = 41;
            this.lblEnquiryCompany.Text = "Company:";
            // 
            // txtEnquiryName
            // 
            this.txtEnquiryName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtEnquiryName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtEnquiryName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtEnquiryName.Border.Class = "TextBoxBorder";
            this.txtEnquiryName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtEnquiryName.DisabledBackColor = System.Drawing.Color.White;
            this.txtEnquiryName.Enabled = false;
            this.txtEnquiryName.ForeColor = System.Drawing.Color.Black;
            this.txtEnquiryName.Location = new System.Drawing.Point(150, 24);
            this.txtEnquiryName.Name = "txtEnquiryName";
            this.txtEnquiryName.PreventEnterBeep = true;
            this.txtEnquiryName.Size = new System.Drawing.Size(345, 25);
            this.txtEnquiryName.TabIndex = 101;
            // 
            // lblEnquiryName
            // 
            this.lblEnquiryName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblEnquiryName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblEnquiryName.ForeColor = System.Drawing.Color.Black;
            this.lblEnquiryName.Location = new System.Drawing.Point(24, 24);
            this.lblEnquiryName.Name = "lblEnquiryName";
            this.lblEnquiryName.Size = new System.Drawing.Size(107, 23);
            this.lblEnquiryName.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblEnquiryName.TabIndex = 39;
            this.lblEnquiryName.Text = "Enquirer Name:";
            // 
            // tiEnquiryGeneral
            // 
            this.tiEnquiryGeneral.AttachedControl = this.superTabControlPanel8;
            this.tiEnquiryGeneral.GlobalItem = false;
            this.tiEnquiryGeneral.Name = "tiEnquiryGeneral";
            this.tiEnquiryGeneral.Text = "  General";
            // 
            // superTabControlPanel10
            // 
            this.superTabControlPanel10.Controls.Add(this.lblEnquiryFileAccessVal);
            this.superTabControlPanel10.Controls.Add(this.lblEnquiryFileAccess);
            this.superTabControlPanel10.Controls.Add(this.lblEnquiryFileModVal);
            this.superTabControlPanel10.Controls.Add(this.lblEnquiryFileMod);
            this.superTabControlPanel10.Controls.Add(this.lblEnquiryFileSizeVal);
            this.superTabControlPanel10.Controls.Add(this.lblEnquiryFileSize);
            this.superTabControlPanel10.Controls.Add(this.lblEnquiryFileLocVal);
            this.superTabControlPanel10.Controls.Add(this.lblEnquiryFileLoc);
            this.superTabControlPanel10.Controls.Add(this.lblEnquiryFileNameVal);
            this.superTabControlPanel10.Controls.Add(this.lblEnquiryFileName);
            this.superTabControlPanel10.Controls.Add(this.lvEnquiryDocs);
            this.superTabControlPanel10.Controls.Add(this.btnEnquiryDocs);
            this.superTabControlPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel10.Location = new System.Drawing.Point(0, 30);
            this.superTabControlPanel10.Name = "superTabControlPanel10";
            this.superTabControlPanel10.Size = new System.Drawing.Size(826, 264);
            this.superTabControlPanel10.TabIndex = 0;
            this.superTabControlPanel10.TabItem = this.tiEnquiryDocs;
            // 
            // lblEnquiryFileAccessVal
            // 
            this.lblEnquiryFileAccessVal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblEnquiryFileAccessVal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblEnquiryFileAccessVal.ForeColor = System.Drawing.Color.Black;
            this.lblEnquiryFileAccessVal.Location = new System.Drawing.Point(410, 131);
            this.lblEnquiryFileAccessVal.Name = "lblEnquiryFileAccessVal";
            this.lblEnquiryFileAccessVal.Size = new System.Drawing.Size(403, 23);
            this.lblEnquiryFileAccessVal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblEnquiryFileAccessVal.TabIndex = 29;
            this.lblEnquiryFileAccessVal.Text = "...";
            // 
            // lblEnquiryFileAccess
            // 
            this.lblEnquiryFileAccess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblEnquiryFileAccess.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblEnquiryFileAccess.ForeColor = System.Drawing.Color.Black;
            this.lblEnquiryFileAccess.Location = new System.Drawing.Point(304, 131);
            this.lblEnquiryFileAccess.Name = "lblEnquiryFileAccess";
            this.lblEnquiryFileAccess.Size = new System.Drawing.Size(100, 23);
            this.lblEnquiryFileAccess.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblEnquiryFileAccess.TabIndex = 28;
            this.lblEnquiryFileAccess.Text = "Last accessed:";
            // 
            // lblEnquiryFileModVal
            // 
            this.lblEnquiryFileModVal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblEnquiryFileModVal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblEnquiryFileModVal.ForeColor = System.Drawing.Color.Black;
            this.lblEnquiryFileModVal.Location = new System.Drawing.Point(410, 102);
            this.lblEnquiryFileModVal.Name = "lblEnquiryFileModVal";
            this.lblEnquiryFileModVal.Size = new System.Drawing.Size(403, 23);
            this.lblEnquiryFileModVal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblEnquiryFileModVal.TabIndex = 27;
            this.lblEnquiryFileModVal.Text = "...";
            // 
            // lblEnquiryFileMod
            // 
            this.lblEnquiryFileMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblEnquiryFileMod.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblEnquiryFileMod.ForeColor = System.Drawing.Color.Black;
            this.lblEnquiryFileMod.Location = new System.Drawing.Point(304, 102);
            this.lblEnquiryFileMod.Name = "lblEnquiryFileMod";
            this.lblEnquiryFileMod.Size = new System.Drawing.Size(100, 23);
            this.lblEnquiryFileMod.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblEnquiryFileMod.TabIndex = 26;
            this.lblEnquiryFileMod.Text = "Last modified:";
            // 
            // lblEnquiryFileSizeVal
            // 
            this.lblEnquiryFileSizeVal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblEnquiryFileSizeVal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblEnquiryFileSizeVal.ForeColor = System.Drawing.Color.Black;
            this.lblEnquiryFileSizeVal.Location = new System.Drawing.Point(410, 73);
            this.lblEnquiryFileSizeVal.Name = "lblEnquiryFileSizeVal";
            this.lblEnquiryFileSizeVal.Size = new System.Drawing.Size(403, 23);
            this.lblEnquiryFileSizeVal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblEnquiryFileSizeVal.TabIndex = 25;
            this.lblEnquiryFileSizeVal.Text = "...";
            // 
            // lblEnquiryFileSize
            // 
            this.lblEnquiryFileSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblEnquiryFileSize.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblEnquiryFileSize.ForeColor = System.Drawing.Color.Black;
            this.lblEnquiryFileSize.Location = new System.Drawing.Point(304, 73);
            this.lblEnquiryFileSize.Name = "lblEnquiryFileSize";
            this.lblEnquiryFileSize.Size = new System.Drawing.Size(100, 23);
            this.lblEnquiryFileSize.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblEnquiryFileSize.TabIndex = 24;
            this.lblEnquiryFileSize.Text = "File size:";
            // 
            // lblEnquiryFileLocVal
            // 
            this.lblEnquiryFileLocVal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblEnquiryFileLocVal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblEnquiryFileLocVal.ForeColor = System.Drawing.Color.Black;
            this.lblEnquiryFileLocVal.Location = new System.Drawing.Point(410, 44);
            this.lblEnquiryFileLocVal.Name = "lblEnquiryFileLocVal";
            this.lblEnquiryFileLocVal.Size = new System.Drawing.Size(403, 23);
            this.lblEnquiryFileLocVal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblEnquiryFileLocVal.TabIndex = 23;
            this.lblEnquiryFileLocVal.Text = "...";
            // 
            // lblEnquiryFileLoc
            // 
            this.lblEnquiryFileLoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblEnquiryFileLoc.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblEnquiryFileLoc.ForeColor = System.Drawing.Color.Black;
            this.lblEnquiryFileLoc.Location = new System.Drawing.Point(304, 44);
            this.lblEnquiryFileLoc.Name = "lblEnquiryFileLoc";
            this.lblEnquiryFileLoc.Size = new System.Drawing.Size(100, 23);
            this.lblEnquiryFileLoc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblEnquiryFileLoc.TabIndex = 22;
            this.lblEnquiryFileLoc.Text = "Location:";
            // 
            // lblEnquiryFileNameVal
            // 
            this.lblEnquiryFileNameVal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblEnquiryFileNameVal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblEnquiryFileNameVal.ForeColor = System.Drawing.Color.Black;
            this.lblEnquiryFileNameVal.Location = new System.Drawing.Point(410, 15);
            this.lblEnquiryFileNameVal.Name = "lblEnquiryFileNameVal";
            this.lblEnquiryFileNameVal.Size = new System.Drawing.Size(403, 23);
            this.lblEnquiryFileNameVal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblEnquiryFileNameVal.TabIndex = 21;
            this.lblEnquiryFileNameVal.Text = "...";
            // 
            // lblEnquiryFileName
            // 
            this.lblEnquiryFileName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblEnquiryFileName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblEnquiryFileName.ForeColor = System.Drawing.Color.Black;
            this.lblEnquiryFileName.Location = new System.Drawing.Point(304, 15);
            this.lblEnquiryFileName.Name = "lblEnquiryFileName";
            this.lblEnquiryFileName.Size = new System.Drawing.Size(100, 23);
            this.lblEnquiryFileName.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblEnquiryFileName.TabIndex = 20;
            this.lblEnquiryFileName.Text = "Filename:";
            // 
            // lvEnquiryDocs
            // 
            this.lvEnquiryDocs.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvEnquiryDocs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvEnquiryDocs.BackColor = System.Drawing.Color.White;
            this.lvEnquiryDocs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvEnquiryDocs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.lvEnquiryDocs.Enabled = false;
            this.lvEnquiryDocs.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lvEnquiryDocs.ForeColor = System.Drawing.Color.Black;
            this.lvEnquiryDocs.FullRowSelect = true;
            this.lvEnquiryDocs.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvEnquiryDocs.HideSelection = false;
            this.lvEnquiryDocs.Location = new System.Drawing.Point(15, 15);
            this.lvEnquiryDocs.MultiSelect = false;
            this.lvEnquiryDocs.Name = "lvEnquiryDocs";
            this.lvEnquiryDocs.Size = new System.Drawing.Size(272, 209);
            this.lvEnquiryDocs.TabIndex = 110;
            this.lvEnquiryDocs.UseCompatibleStateImageBehavior = false;
            this.lvEnquiryDocs.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Filename";
            this.columnHeader2.Width = 224;
            // 
            // btnEnquiryDocs
            // 
            this.btnEnquiryDocs.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEnquiryDocs.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEnquiryDocs.Enabled = false;
            this.btnEnquiryDocs.Location = new System.Drawing.Point(95, 229);
            this.btnEnquiryDocs.Name = "btnEnquiryDocs";
            this.btnEnquiryDocs.Size = new System.Drawing.Size(110, 29);
            this.btnEnquiryDocs.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEnquiryDocs.TabIndex = 111;
            this.btnEnquiryDocs.Text = "Add document";
            // 
            // tiEnquiryDocs
            // 
            this.tiEnquiryDocs.AttachedControl = this.superTabControlPanel10;
            this.tiEnquiryDocs.GlobalItem = false;
            this.tiEnquiryDocs.Name = "tiEnquiryDocs";
            this.tiEnquiryDocs.Text = "  Documents";
            // 
            // superTabControlPanel5
            // 
            this.superTabControlPanel5.Controls.Add(this.lblEnquiryInfoWanted);
            this.superTabControlPanel5.Controls.Add(this.txtEnquiryInfoWanted);
            this.superTabControlPanel5.Controls.Add(this.lvEnquiryCourses);
            this.superTabControlPanel5.Controls.Add(this.lblEnquiryCourses);
            this.superTabControlPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel5.Location = new System.Drawing.Point(0, 30);
            this.superTabControlPanel5.Name = "superTabControlPanel5";
            this.superTabControlPanel5.Size = new System.Drawing.Size(826, 264);
            this.superTabControlPanel5.TabIndex = 0;
            this.superTabControlPanel5.TabItem = this.tiEnquiryInfo;
            // 
            // lblEnquiryInfoWanted
            // 
            this.lblEnquiryInfoWanted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblEnquiryInfoWanted.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblEnquiryInfoWanted.ForeColor = System.Drawing.Color.Black;
            this.lblEnquiryInfoWanted.Location = new System.Drawing.Point(378, 13);
            this.lblEnquiryInfoWanted.Name = "lblEnquiryInfoWanted";
            this.lblEnquiryInfoWanted.Size = new System.Drawing.Size(183, 23);
            this.lblEnquiryInfoWanted.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblEnquiryInfoWanted.TabIndex = 55;
            this.lblEnquiryInfoWanted.Text = "Requested Information:";
            // 
            // txtEnquiryInfoWanted
            // 
            this.txtEnquiryInfoWanted.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtEnquiryInfoWanted.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtEnquiryInfoWanted.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtEnquiryInfoWanted.Border.Class = "TextBoxBorder";
            this.txtEnquiryInfoWanted.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtEnquiryInfoWanted.DisabledBackColor = System.Drawing.Color.White;
            this.txtEnquiryInfoWanted.Enabled = false;
            this.txtEnquiryInfoWanted.ForeColor = System.Drawing.Color.Black;
            this.txtEnquiryInfoWanted.Location = new System.Drawing.Point(378, 42);
            this.txtEnquiryInfoWanted.Multiline = true;
            this.txtEnquiryInfoWanted.Name = "txtEnquiryInfoWanted";
            this.txtEnquiryInfoWanted.PreventEnterBeep = true;
            this.txtEnquiryInfoWanted.Size = new System.Drawing.Size(425, 201);
            this.txtEnquiryInfoWanted.TabIndex = 109;
            // 
            // lvEnquiryCourses
            // 
            this.lvEnquiryCourses.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvEnquiryCourses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvEnquiryCourses.BackColor = System.Drawing.Color.White;
            this.lvEnquiryCourses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvEnquiryCourses.CheckBoxes = true;
            this.lvEnquiryCourses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvEnquiryCourses.Enabled = false;
            this.lvEnquiryCourses.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lvEnquiryCourses.ForeColor = System.Drawing.Color.Black;
            this.lvEnquiryCourses.FullRowSelect = true;
            this.lvEnquiryCourses.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvEnquiryCourses.HideSelection = false;
            this.lvEnquiryCourses.Location = new System.Drawing.Point(24, 42);
            this.lvEnquiryCourses.MultiSelect = false;
            this.lvEnquiryCourses.Name = "lvEnquiryCourses";
            this.lvEnquiryCourses.Size = new System.Drawing.Size(336, 201);
            this.lvEnquiryCourses.TabIndex = 108;
            this.lvEnquiryCourses.UseCompatibleStateImageBehavior = false;
            this.lvEnquiryCourses.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Filename";
            this.columnHeader1.Width = 224;
            // 
            // lblEnquiryCourses
            // 
            this.lblEnquiryCourses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblEnquiryCourses.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblEnquiryCourses.ForeColor = System.Drawing.Color.Black;
            this.lblEnquiryCourses.Location = new System.Drawing.Point(24, 13);
            this.lblEnquiryCourses.Name = "lblEnquiryCourses";
            this.lblEnquiryCourses.Size = new System.Drawing.Size(107, 23);
            this.lblEnquiryCourses.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblEnquiryCourses.TabIndex = 40;
            this.lblEnquiryCourses.Text = "Courses:";
            // 
            // tiEnquiryInfo
            // 
            this.tiEnquiryInfo.AttachedControl = this.superTabControlPanel5;
            this.tiEnquiryInfo.GlobalItem = false;
            this.tiEnquiryInfo.Name = "tiEnquiryInfo";
            this.tiEnquiryInfo.Text = "  Courses and Info";
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
            this.gCourses.ContextMenuStrip = this.mCourses;
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
            this.gCourses.PrimaryGrid.CheckBoxes = true;
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
            this.gCourses.TabStop = false;
            this.gCourses.RowActivated += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridRowActivatedEventArgs>(this.gCourses_RowActivated);
            this.gCourses.RowClick += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridRowClickEventArgs>(this.gCourses_RowClick);
            this.gCourses.RowDoubleClick += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridRowDoubleClickEventArgs>(this.gCourses_RowDoubleClick);
            // 
            // mCourses
            // 
            this.mCourses.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
            this.mCoursesAdd.Click += new System.EventHandler(this.mCoursesAdd_Click);
            // 
            // mCoursesRemove
            // 
            this.mCoursesRemove.Name = "mCoursesRemove";
            this.mCoursesRemove.Size = new System.Drawing.Size(155, 22);
            this.mCoursesRemove.Text = "Remove course";
            this.mCoursesRemove.Click += new System.EventHandler(this.mCoursesRemove_Click);
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
            this.pCourse.Controls.Add(this.btnCourseCancel);
            this.pCourse.Controls.Add(this.btnCourseSave);
            this.pCourse.Controls.Add(this.scCourse);
            this.pCourse.DisabledBackColor = System.Drawing.Color.Empty;
            this.pCourse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pCourse.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
            // btnCourseCancel
            // 
            this.btnCourseCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCourseCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCourseCancel.Enabled = false;
            this.btnCourseCancel.Location = new System.Drawing.Point(21, 21);
            this.btnCourseCancel.Name = "btnCourseCancel";
            this.btnCourseCancel.Size = new System.Drawing.Size(74, 29);
            this.btnCourseCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCourseCancel.TabIndex = 207;
            this.btnCourseCancel.Text = "Cancel";
            this.btnCourseCancel.Click += new System.EventHandler(this.btnCourseCancel_Click);
            // 
            // btnCourseSave
            // 
            this.btnCourseSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCourseSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCourseSave.Enabled = false;
            this.btnCourseSave.Location = new System.Drawing.Point(21, 56);
            this.btnCourseSave.Name = "btnCourseSave";
            this.btnCourseSave.Size = new System.Drawing.Size(74, 29);
            this.btnCourseSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCourseSave.SymbolSize = 206F;
            this.btnCourseSave.TabIndex = 25;
            this.btnCourseSave.Text = "Save";
            this.btnCourseSave.Click += new System.EventHandler(this.btnCourseSave_Click);
            // 
            // scCourse
            // 
            this.scCourse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.scCourse.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.scCourse.ControlBox.MenuBox.Name = "";
            this.scCourse.ControlBox.Name = "";
            this.scCourse.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.scCourse.ControlBox.MenuBox,
            this.scCourse.ControlBox.CloseBox});
            this.scCourse.ControlBox.Visible = false;
            this.scCourse.Controls.Add(this.superTabControlPanel7);
            this.scCourse.Controls.Add(this.superTabControlPanel9);
            this.scCourse.ForeColor = System.Drawing.Color.Black;
            this.scCourse.Location = new System.Drawing.Point(114, 21);
            this.scCourse.Name = "scCourse";
            this.scCourse.ReorderTabsEnabled = true;
            this.scCourse.SelectedTabFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.scCourse.SelectedTabIndex = 0;
            this.scCourse.Size = new System.Drawing.Size(826, 294);
            this.scCourse.TabFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scCourse.TabIndex = 24;
            this.scCourse.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.tiCourseGeneral,
            this.tiCourseDetails});
            this.scCourse.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.VisualStudio2008Dock;
            // 
            // superTabControlPanel7
            // 
            this.superTabControlPanel7.Controls.Add(this.txtCoursePricing);
            this.superTabControlPanel7.Controls.Add(this.lblCoursePrice);
            this.superTabControlPanel7.Controls.Add(this.txtCourseDuration);
            this.superTabControlPanel7.Controls.Add(this.lblCourseDuration);
            this.superTabControlPanel7.Controls.Add(this.txtCourseCert);
            this.superTabControlPanel7.Controls.Add(this.lblCourseCert);
            this.superTabControlPanel7.Controls.Add(this.txtCourseName);
            this.superTabControlPanel7.Controls.Add(this.lblCourseName);
            this.superTabControlPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel7.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.superTabControlPanel7.Location = new System.Drawing.Point(0, 30);
            this.superTabControlPanel7.Name = "superTabControlPanel7";
            this.superTabControlPanel7.Size = new System.Drawing.Size(826, 264);
            this.superTabControlPanel7.TabIndex = 1;
            this.superTabControlPanel7.TabItem = this.tiCourseGeneral;
            // 
            // txtCoursePricing
            // 
            this.txtCoursePricing.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCoursePricing.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCoursePricing.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtCoursePricing.Border.Class = "TextBoxBorder";
            this.txtCoursePricing.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCoursePricing.DisabledBackColor = System.Drawing.Color.White;
            this.txtCoursePricing.Enabled = false;
            this.txtCoursePricing.ForeColor = System.Drawing.Color.Black;
            this.txtCoursePricing.Location = new System.Drawing.Point(481, 84);
            this.txtCoursePricing.Multiline = true;
            this.txtCoursePricing.Name = "txtCoursePricing";
            this.txtCoursePricing.PreventEnterBeep = true;
            this.txtCoursePricing.Size = new System.Drawing.Size(322, 157);
            this.txtCoursePricing.TabIndex = 204;
            // 
            // lblCoursePrice
            // 
            this.lblCoursePrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblCoursePrice.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCoursePrice.ForeColor = System.Drawing.Color.Black;
            this.lblCoursePrice.Location = new System.Drawing.Point(481, 55);
            this.lblCoursePrice.Name = "lblCoursePrice";
            this.lblCoursePrice.Size = new System.Drawing.Size(98, 23);
            this.lblCoursePrice.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblCoursePrice.TabIndex = 43;
            this.lblCoursePrice.Text = "Pricing:";
            // 
            // txtCourseDuration
            // 
            this.txtCourseDuration.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCourseDuration.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCourseDuration.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtCourseDuration.Border.Class = "TextBoxBorder";
            this.txtCourseDuration.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCourseDuration.DisabledBackColor = System.Drawing.Color.White;
            this.txtCourseDuration.Enabled = false;
            this.txtCourseDuration.ForeColor = System.Drawing.Color.Black;
            this.txtCourseDuration.Location = new System.Drawing.Point(24, 84);
            this.txtCourseDuration.Multiline = true;
            this.txtCourseDuration.Name = "txtCourseDuration";
            this.txtCourseDuration.PreventEnterBeep = true;
            this.txtCourseDuration.Size = new System.Drawing.Size(433, 157);
            this.txtCourseDuration.TabIndex = 203;
            // 
            // lblCourseDuration
            // 
            this.lblCourseDuration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblCourseDuration.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCourseDuration.ForeColor = System.Drawing.Color.Black;
            this.lblCourseDuration.Location = new System.Drawing.Point(24, 55);
            this.lblCourseDuration.Name = "lblCourseDuration";
            this.lblCourseDuration.Size = new System.Drawing.Size(107, 23);
            this.lblCourseDuration.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblCourseDuration.TabIndex = 41;
            this.lblCourseDuration.Text = "Duration:";
            // 
            // txtCourseCert
            // 
            this.txtCourseCert.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCourseCert.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCourseCert.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtCourseCert.Border.Class = "TextBoxBorder";
            this.txtCourseCert.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCourseCert.DisabledBackColor = System.Drawing.Color.White;
            this.txtCourseCert.Enabled = false;
            this.txtCourseCert.ForeColor = System.Drawing.Color.Black;
            this.txtCourseCert.Location = new System.Drawing.Point(585, 24);
            this.txtCourseCert.Name = "txtCourseCert";
            this.txtCourseCert.PreventEnterBeep = true;
            this.txtCourseCert.Size = new System.Drawing.Size(218, 25);
            this.txtCourseCert.TabIndex = 202;
            // 
            // lblCourseCert
            // 
            this.lblCourseCert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblCourseCert.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCourseCert.ForeColor = System.Drawing.Color.Black;
            this.lblCourseCert.Location = new System.Drawing.Point(481, 24);
            this.lblCourseCert.Name = "lblCourseCert";
            this.lblCourseCert.Size = new System.Drawing.Size(98, 23);
            this.lblCourseCert.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblCourseCert.TabIndex = 39;
            this.lblCourseCert.Text = "Certification:";
            // 
            // txtCourseName
            // 
            this.txtCourseName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCourseName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCourseName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtCourseName.Border.Class = "TextBoxBorder";
            this.txtCourseName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCourseName.DisabledBackColor = System.Drawing.Color.White;
            this.txtCourseName.Enabled = false;
            this.txtCourseName.ForeColor = System.Drawing.Color.Black;
            this.txtCourseName.Location = new System.Drawing.Point(137, 24);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.PreventEnterBeep = true;
            this.txtCourseName.Size = new System.Drawing.Size(320, 25);
            this.txtCourseName.TabIndex = 201;
            // 
            // lblCourseName
            // 
            this.lblCourseName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblCourseName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCourseName.ForeColor = System.Drawing.Color.Black;
            this.lblCourseName.Location = new System.Drawing.Point(24, 24);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(107, 23);
            this.lblCourseName.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblCourseName.TabIndex = 37;
            this.lblCourseName.Text = "Course Name:";
            // 
            // tiCourseGeneral
            // 
            this.tiCourseGeneral.AttachedControl = this.superTabControlPanel7;
            this.tiCourseGeneral.GlobalItem = false;
            this.tiCourseGeneral.Name = "tiCourseGeneral";
            this.tiCourseGeneral.Text = "  General";
            // 
            // superTabControlPanel9
            // 
            this.superTabControlPanel9.Controls.Add(this.txtCourseDetails);
            this.superTabControlPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel9.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.superTabControlPanel9.Location = new System.Drawing.Point(0, 30);
            this.superTabControlPanel9.Name = "superTabControlPanel9";
            this.superTabControlPanel9.Size = new System.Drawing.Size(826, 264);
            this.superTabControlPanel9.TabIndex = 0;
            this.superTabControlPanel9.TabItem = this.tiCourseDetails;
            // 
            // txtCourseDetails
            // 
            this.txtCourseDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCourseDetails.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCourseDetails.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCourseDetails.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtCourseDetails.Border.Class = "TextBoxBorder";
            this.txtCourseDetails.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCourseDetails.DisabledBackColor = System.Drawing.Color.White;
            this.txtCourseDetails.Enabled = false;
            this.txtCourseDetails.ForeColor = System.Drawing.Color.Black;
            this.txtCourseDetails.Location = new System.Drawing.Point(15, 15);
            this.txtCourseDetails.Multiline = true;
            this.txtCourseDetails.Name = "txtCourseDetails";
            this.txtCourseDetails.PreventEnterBeep = true;
            this.txtCourseDetails.Size = new System.Drawing.Size(796, 234);
            this.txtCourseDetails.TabIndex = 205;
            // 
            // tiCourseDetails
            // 
            this.tiCourseDetails.AttachedControl = this.superTabControlPanel9;
            this.tiCourseDetails.GlobalItem = false;
            this.tiCourseDetails.Name = "tiCourseDetails";
            this.tiCourseDetails.Text = "  Details";
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
            this.bsvTpPrint.Location = new System.Drawing.Point(97, 0);
            this.bsvTpPrint.Name = "bsvTpPrint";
            this.bsvTpPrint.Size = new System.Drawing.Size(861, 560);
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
            this.mtBookings.Checked = true;
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
            this.btnDummy.AutoExpandOnClick = true;
            this.btnDummy.CanCustomize = false;
            this.btnDummy.EnableMarkup = false;
            this.btnDummy.Image = global::Client.Properties.Resources.tools_16;
            this.btnDummy.Name = "btnDummy";
            this.btnDummy.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.biToolsGridViews,
            this.biToolsTemplate,
            this.biToolsUser,
            this.biToolsRooms});
            this.btnDummy.Text = "Tools";
            // 
            // biToolsGridViews
            // 
            this.biToolsGridViews.Name = "biToolsGridViews";
            this.biToolsGridViews.Text = "Grid view management";
            this.biToolsGridViews.Click += new System.EventHandler(this.biToolsGridViews_Click);
            // 
            // biToolsTemplate
            // 
            this.biToolsTemplate.Enabled = false;
            this.biToolsTemplate.Name = "biToolsTemplate";
            this.biToolsTemplate.Text = "Template management";
            this.biToolsTemplate.Click += new System.EventHandler(this.biToolsTemplate_Click);
            // 
            // biToolsUser
            // 
            this.biToolsUser.Name = "biToolsUser";
            this.biToolsUser.Text = "User management";
            this.biToolsUser.Click += new System.EventHandler(this.biToolsUser_Click);
            // 
            // biToolsRooms
            // 
            this.biToolsRooms.Name = "biToolsRooms";
            this.biToolsRooms.Text = "Room/zone management";
            this.biToolsRooms.Click += new System.EventHandler(this.biToolsRooms_Click);
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
            this.mTools.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
            this.mBookingsList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(960, 620);
            this.Controls.Add(this.bsv);
            this.Controls.Add(this.sb);
            this.Controls.Add(this.ms);
            this.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
            this.pCompanies.ResumeLayout(false);
            this.scCompanies.Panel1.ResumeLayout(false);
            this.scCompanies.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scCompanies)).EndInit();
            this.scCompanies.ResumeLayout(false);
            this.mCompanies.ResumeLayout(false);
            this.pCompany.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scCompany)).EndInit();
            this.scCompany.ResumeLayout(false);
            this.superTabControlPanel4.ResumeLayout(false);
            this.tpCompanyContacts.ResumeLayout(false);
            this.superTabControlPanel6.ResumeLayout(false);
            this.pContacts.ResumeLayout(false);
            this.scContacts.Panel1.ResumeLayout(false);
            this.scContacts.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scContacts)).EndInit();
            this.scContacts.ResumeLayout(false);
            this.mContacts.ResumeLayout(false);
            this.pContact.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scContact)).EndInit();
            this.scContact.ResumeLayout(false);
            this.superTabControlPanel1.ResumeLayout(false);
            this.superTabControlPanel3.ResumeLayout(false);
            this.superTabControlPanel2.ResumeLayout(false);
            this.pEnquiries.ResumeLayout(false);
            this.scEnquiries.Panel1.ResumeLayout(false);
            this.scEnquiries.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scEnquiries)).EndInit();
            this.scEnquiries.ResumeLayout(false);
            this.pEnquiriesGrid.ResumeLayout(false);
            this.pEnquiriesGridTools.ResumeLayout(false);
            this.pEnquiriesGridTools.PerformLayout();
            this.mEnquiries.ResumeLayout(false);
            this.pEnquiry.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scEnquiry)).EndInit();
            this.scEnquiry.ResumeLayout(false);
            this.superTabControlPanel8.ResumeLayout(false);
            this.superTabControlPanel10.ResumeLayout(false);
            this.superTabControlPanel5.ResumeLayout(false);
            this.pCourses.ResumeLayout(false);
            this.scCourses.Panel1.ResumeLayout(false);
            this.scCourses.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scCourses)).EndInit();
            this.scCourses.ResumeLayout(false);
            this.mCourses.ResumeLayout(false);
            this.pCourse.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scCourse)).EndInit();
            this.scCourse.ResumeLayout(false);
            this.superTabControlPanel7.ResumeLayout(false);
            this.superTabControlPanel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsv)).EndInit();
            this.bsv.ResumeLayout(false);
            this.mTools.ResumeLayout(false);
            this.mBookingsList.ResumeLayout(false);
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
        private DevComponents.DotNetBar.LabelX lblCountBookingsGrid;
        private DevComponents.DotNetBar.LabelX lblCountBookingsList;
        private DevComponents.DotNetBar.LabelX lblBookingsListCompany;
        private DevComponents.DotNetBar.LabelX lblCountBookingsCalendar;
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
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl gEnquiries;
        private DevComponents.DotNetBar.LabelX lblEnquiriesCompany;
        private DevComponents.DotNetBar.LabelX lblCountEnquiries;
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
        private DevComponents.DotNetBar.SuperTabControl scContact;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel1;
        private DevComponents.DotNetBar.SuperTabItem tiContactGeneral;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel3;
        private DevComponents.DotNetBar.SuperTabItem tiContactDocs;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtContactNotes;
        private DevComponents.DotNetBar.SuperTabItem tiContactNotes;
        private DevComponents.DotNetBar.LabelX lblContactCompany;
        private DevComponents.DotNetBar.LabelX lblContactName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtContactPhone;
        private DevComponents.DotNetBar.LabelX lblContactPhone;
        private DevComponents.DotNetBar.Controls.TextBoxX txtContactEmail;
        private DevComponents.DotNetBar.Controls.TextBoxX txtContactCompany;
        private DevComponents.DotNetBar.Controls.TextBoxX txtContactNameFirst;
        private DevComponents.DotNetBar.Controls.TextBoxX txtContactNameLast;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtContactNameTitle;
        private DevComponents.Editors.ComboItem cbxiContactTitleOfc;
        private DevComponents.Editors.ComboItem cbxiContactTitleProf;
        private DevComponents.Editors.ComboItem cbxiContactTitleDr;
        private DevComponents.Editors.ComboItem cbxiContactTitleMaster;
        private DevComponents.Editors.ComboItem cbxiContactTitleMs;
        private DevComponents.Editors.ComboItem cbxiContactTitleMiss;
        private DevComponents.Editors.ComboItem cbxiContactTitleMrs;
        private DevComponents.Editors.ComboItem cbxiContactTitleMr;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxContactNameTitle;
        private DevComponents.DotNetBar.LabelX lblContactEmail;
        private DevComponents.DotNetBar.LabelX lblContactFileAccessVal;
        private DevComponents.DotNetBar.LabelX lblContactFileAccess;
        private DevComponents.DotNetBar.LabelX lblContactFileModVal;
        private DevComponents.DotNetBar.LabelX lblContactFileMod;
        private DevComponents.DotNetBar.LabelX lblContactFileSizeVal;
        private DevComponents.DotNetBar.LabelX lblContactFileSize;
        private DevComponents.DotNetBar.LabelX lblContactFileLocVal;
        private DevComponents.DotNetBar.LabelX lblContactFileLoc;
        private DevComponents.DotNetBar.LabelX lblContactFileNameVal;
        private DevComponents.DotNetBar.LabelX lblContactFileName;
        private System.Windows.Forms.ListView lvContactDocuments;
        private System.Windows.Forms.ColumnHeader chFilename;
        private DevComponents.DotNetBar.ButtonX btnContactDocumentAdd;
        private DevComponents.DotNetBar.LabelX lblContactAddress;
        private DevComponents.DotNetBar.ButtonX btnCompanySave;
        private DevComponents.DotNetBar.ButtonX btnContactCancel;
        private DevComponents.DotNetBar.ButtonX btnContactSave;
        private DevComponents.DotNetBar.SuperTabItem tiCompanyNotes;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCompanyNotes;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel6;
        private DevComponents.DotNetBar.SuperTabItem tiCompanyGeneral;
        private DevComponents.DotNetBar.LabelX lblCompanyName;
        private DevComponents.DotNetBar.LabelX lblCompanyReg;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCompanyPhone;
        private DevComponents.DotNetBar.LabelX lblCompanyPhone;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCompanyEmail;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCompanyName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCompanyReg;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCompanyRegVat;
        private DevComponents.DotNetBar.LabelX lblCompanyTrading;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCompanyTrading;
        private DevComponents.DotNetBar.LabelX lblCompanyEmail;
        private DevComponents.DotNetBar.LabelX lblCompanyAddress;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCompanyAddress;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel4;
        private DevComponents.DotNetBar.SuperTabControl scCompany;
        private DevComponents.DotNetBar.ButtonX btnCompanyCancel;
        private DevComponents.DotNetBar.ButtonX btnCourseCancel;
        private DevComponents.DotNetBar.ButtonX btnCourseSave;
        private DevComponents.DotNetBar.SuperTabControl scCourse;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel7;
        private DevComponents.DotNetBar.SuperTabItem tiCourseGeneral;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel9;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCourseDetails;
        private DevComponents.DotNetBar.SuperTabItem tiCourseDetails;
        private DevComponents.DotNetBar.SuperTabItem tiEnquiryDocs;
        private DevComponents.DotNetBar.ButtonX btnEnquiryDocs;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView lvEnquiryDocs;
        private DevComponents.DotNetBar.LabelX lblEnquiryFileName;
        private DevComponents.DotNetBar.LabelX lblEnquiryFileNameVal;
        private DevComponents.DotNetBar.LabelX lblEnquiryFileLoc;
        private DevComponents.DotNetBar.LabelX lblEnquiryFileLocVal;
        private DevComponents.DotNetBar.LabelX lblEnquiryFileSize;
        private DevComponents.DotNetBar.LabelX lblEnquiryFileSizeVal;
        private DevComponents.DotNetBar.LabelX lblEnquiryFileMod;
        private DevComponents.DotNetBar.LabelX lblEnquiryFileModVal;
        private DevComponents.DotNetBar.LabelX lblEnquiryFileAccess;
        private DevComponents.DotNetBar.LabelX lblEnquiryFileAccessVal;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel10;
        private DevComponents.DotNetBar.SuperTabItem tiEnquiryGeneral;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel8;
        private DevComponents.DotNetBar.SuperTabControl scEnquiry;
        private DevComponents.DotNetBar.ButtonX btnEnquirySave;
        private DevComponents.DotNetBar.ButtonX btnEnquiryCancel;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCompanyContact;
        private DevComponents.DotNetBar.LabelX lblCompanyContact;
        private DevComponents.DotNetBar.LabelX lblCourseName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCourseName;
        private DevComponents.DotNetBar.LabelX lblCourseCert;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCourseCert;
        private DevComponents.DotNetBar.LabelX lblCourseDuration;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCourseDuration;
        private DevComponents.DotNetBar.LabelX lblCoursePrice;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCoursePricing;
        private DevComponents.DotNetBar.LabelX lblEnquiryName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtEnquiryName;
        private DevComponents.DotNetBar.LabelX lblEnquiryCompany;
        private DevComponents.DotNetBar.Controls.TextBoxX txtEnquiryCompany;
        private DevComponents.DotNetBar.Controls.TextBoxX txtEnquiryPhone;
        private DevComponents.DotNetBar.LabelX lblEnquiryPhone;
        private DevComponents.DotNetBar.Controls.TextBoxX txtEnquiryEmail;
        private DevComponents.DotNetBar.LabelX lblEnquiryEmail;
        private DevComponents.DotNetBar.LabelX lblEnquiryType;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxEnquiryType;
        private DevComponents.DotNetBar.SuperTabItem tiEnquiryInfo;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel5;
        private DevComponents.DotNetBar.Controls.TextBoxX txtEnquiryReferrer;
        private DevComponents.DotNetBar.LabelX lblEnquiryReferrer;
        private DevComponents.DotNetBar.Controls.TextBoxX txtEnquiryInfo;
        private DevComponents.DotNetBar.LabelX lblEnquiryInfo;
        private DevComponents.DotNetBar.LabelX lblEnquiryCourses;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView lvEnquiryCourses;
        private DevComponents.DotNetBar.Controls.TextBoxX txtEnquiryInfoWanted;
        private DevComponents.DotNetBar.LabelX lblEnquiryInfoWanted;
        private DevComponents.DotNetBar.Controls.TextBoxX txtContactAddress;
        private DevComponents.DotNetBar.SuperTabControlPanel tpCompanyContacts;
        private DevComponents.DotNetBar.SuperTabItem tiCompanyContacts;
        private DevComponents.DotNetBar.LabelX lblEnquiryNumberVal;
        private DevComponents.DotNetBar.LabelX lblEnquiryNumber;
        private DevComponents.DotNetBar.ButtonItem biToolsTemplate;
        private DevComponents.DotNetBar.ButtonItem biToolsUser;
        private DevComponents.DotNetBar.ButtonItem biToolsGridViews;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl scCompaniesContacts;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn1;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn2;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn3;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn4;
        private DevComponents.DotNetBar.ButtonItem biToolsRooms;
    }
}