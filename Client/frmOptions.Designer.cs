namespace Client
{
    partial class frmOptions
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
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.txtPathData = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblPathData = new DevComponents.DotNetBar.LabelX();
            this.btnPathDataFind = new DevComponents.DotNetBar.ButtonX();
            this.cbxDefaultView = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbxiDefaultViewBDay = new DevComponents.Editors.ComboItem();
            this.cbxiDefaultViewBWeek = new DevComponents.Editors.ComboItem();
            this.cbxiDefaultViewBMonth = new DevComponents.Editors.ComboItem();
            this.cbxiDefaultViewBYear = new DevComponents.Editors.ComboItem();
            this.cbxiDefaultViewBGrid = new DevComponents.Editors.ComboItem();
            this.cbxiDefaultViewBList = new DevComponents.Editors.ComboItem();
            this.cbxiDefaultViewEnquiries = new DevComponents.Editors.ComboItem();
            this.cbxiDefaultViewCourses = new DevComponents.Editors.ComboItem();
            this.cbxiDefaultViewCompanies = new DevComponents.Editors.ComboItem();
            this.cbxiDefaultViewContacts = new DevComponents.Editors.ComboItem();
            this.lblDefaultView = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.chkMaximised = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Location = new System.Drawing.Point(12, 126);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(68, 34);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Location = new System.Drawing.Point(448, 126);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(68, 34);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Apply";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPathData
            // 
            this.txtPathData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPathData.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPathData.Border.Class = "TextBoxBorder";
            this.txtPathData.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPathData.DisabledBackColor = System.Drawing.Color.White;
            this.txtPathData.ForeColor = System.Drawing.Color.Black;
            this.txtPathData.Location = new System.Drawing.Point(147, 23);
            this.txtPathData.Name = "txtPathData";
            this.txtPathData.PreventEnterBeep = true;
            this.txtPathData.Size = new System.Drawing.Size(338, 25);
            this.txtPathData.TabIndex = 22;
            // 
            // lblPathData
            // 
            this.lblPathData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblPathData.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblPathData.ForeColor = System.Drawing.Color.Black;
            this.lblPathData.Location = new System.Drawing.Point(12, 22);
            this.lblPathData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblPathData.Name = "lblPathData";
            this.lblPathData.Size = new System.Drawing.Size(129, 25);
            this.lblPathData.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblPathData.TabIndex = 21;
            this.lblPathData.Text = "Path to Data:";
            // 
            // btnPathDataFind
            // 
            this.btnPathDataFind.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPathDataFind.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPathDataFind.Location = new System.Drawing.Point(491, 23);
            this.btnPathDataFind.Name = "btnPathDataFind";
            this.btnPathDataFind.Size = new System.Drawing.Size(25, 25);
            this.btnPathDataFind.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPathDataFind.TabIndex = 23;
            this.btnPathDataFind.Click += new System.EventHandler(this.btnPathDataFind_Click);
            // 
            // cbxDefaultView
            // 
            this.cbxDefaultView.DisplayMember = "Text";
            this.cbxDefaultView.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxDefaultView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDefaultView.ForeColor = System.Drawing.Color.Black;
            this.cbxDefaultView.FormattingEnabled = true;
            this.cbxDefaultView.ItemHeight = 19;
            this.cbxDefaultView.Items.AddRange(new object[] {
            this.cbxiDefaultViewBDay,
            this.cbxiDefaultViewBWeek,
            this.cbxiDefaultViewBMonth,
            this.cbxiDefaultViewBYear,
            this.cbxiDefaultViewBGrid,
            this.cbxiDefaultViewBList,
            this.cbxiDefaultViewEnquiries,
            this.cbxiDefaultViewCourses,
            this.cbxiDefaultViewCompanies,
            this.cbxiDefaultViewContacts});
            this.cbxDefaultView.Location = new System.Drawing.Point(147, 54);
            this.cbxDefaultView.Name = "cbxDefaultView";
            this.cbxDefaultView.Size = new System.Drawing.Size(369, 25);
            this.cbxDefaultView.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxDefaultView.TabIndex = 24;
            // 
            // cbxiDefaultViewBDay
            // 
            this.cbxiDefaultViewBDay.Text = "Booking Calendar (Day)";
            // 
            // cbxiDefaultViewBWeek
            // 
            this.cbxiDefaultViewBWeek.Text = "Booking Calendar (Week)";
            // 
            // cbxiDefaultViewBMonth
            // 
            this.cbxiDefaultViewBMonth.Text = "Booking Calendar (Month)";
            // 
            // cbxiDefaultViewBYear
            // 
            this.cbxiDefaultViewBYear.Text = "Booking Calendar (Year)";
            // 
            // cbxiDefaultViewBGrid
            // 
            this.cbxiDefaultViewBGrid.Text = "Booking Grid";
            // 
            // cbxiDefaultViewBList
            // 
            this.cbxiDefaultViewBList.Text = "Booking List";
            // 
            // cbxiDefaultViewEnquiries
            // 
            this.cbxiDefaultViewEnquiries.Text = "Enquiries";
            // 
            // cbxiDefaultViewCourses
            // 
            this.cbxiDefaultViewCourses.Text = "Courses";
            // 
            // cbxiDefaultViewCompanies
            // 
            this.cbxiDefaultViewCompanies.Text = "Companies";
            // 
            // cbxiDefaultViewContacts
            // 
            this.cbxiDefaultViewContacts.Text = "Contacts";
            // 
            // lblDefaultView
            // 
            this.lblDefaultView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblDefaultView.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDefaultView.ForeColor = System.Drawing.Color.Black;
            this.lblDefaultView.Location = new System.Drawing.Point(12, 53);
            this.lblDefaultView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblDefaultView.Name = "lblDefaultView";
            this.lblDefaultView.Size = new System.Drawing.Size(129, 25);
            this.lblDefaultView.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblDefaultView.TabIndex = 25;
            this.lblDefaultView.Text = "Default Home View:";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(12, 86);
            this.labelX1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(129, 25);
            this.labelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.labelX1.TabIndex = 26;
            this.labelX1.Text = "Start maximised?";
            // 
            // chkMaximised
            // 
            this.chkMaximised.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.chkMaximised.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkMaximised.ForeColor = System.Drawing.Color.Black;
            this.chkMaximised.Location = new System.Drawing.Point(147, 88);
            this.chkMaximised.Name = "chkMaximised";
            this.chkMaximised.Size = new System.Drawing.Size(19, 23);
            this.chkMaximised.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkMaximised.TabIndex = 27;
            // 
            // frmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CaptionFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientSize = new System.Drawing.Size(528, 172);
            this.Controls.Add(this.chkMaximised);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.lblDefaultView);
            this.Controls.Add(this.cbxDefaultView);
            this.Controls.Add(this.btnPathDataFind);
            this.Controls.Add(this.txtPathData);
            this.Controls.Add(this.lblPathData);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOptions";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options and Settings";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog fbd;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPathData;
        private DevComponents.DotNetBar.LabelX lblPathData;
        private DevComponents.DotNetBar.ButtonX btnPathDataFind;
        private DevComponents.DotNetBar.LabelX lblDefaultView;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxDefaultView;
        private DevComponents.Editors.ComboItem cbxiDefaultViewBDay;
        private DevComponents.Editors.ComboItem cbxiDefaultViewBWeek;
        private DevComponents.Editors.ComboItem cbxiDefaultViewBMonth;
        private DevComponents.Editors.ComboItem cbxiDefaultViewBYear;
        private DevComponents.Editors.ComboItem cbxiDefaultViewBGrid;
        private DevComponents.Editors.ComboItem cbxiDefaultViewBList;
        private DevComponents.Editors.ComboItem cbxiDefaultViewEnquiries;
        private DevComponents.Editors.ComboItem cbxiDefaultViewCourses;
        private DevComponents.Editors.ComboItem cbxiDefaultViewCompanies;
        private DevComponents.Editors.ComboItem cbxiDefaultViewContacts;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkMaximised;
    }
}