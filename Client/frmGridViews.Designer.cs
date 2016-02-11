namespace Client
{
    partial class frmGridViews
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
            this.g = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.m = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.gID = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gName = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gStart = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gFinish = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.txtName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblName = new DevComponents.DotNetBar.LabelX();
            this.lblFrom = new DevComponents.DotNetBar.LabelX();
            this.dtTo = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dtFrom = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.lblTo = new DevComponents.DotNetBar.LabelX();
            this.tv = new System.Windows.Forms.TreeView();
            this.lblRooms = new DevComponents.DotNetBar.LabelX();
            this.m.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFrom)).BeginInit();
            this.SuspendLayout();
            // 
            // g
            // 
            this.g.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.g.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.g.ContextMenuStrip = this.m;
            this.g.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.g.ForeColor = System.Drawing.Color.Black;
            this.g.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.g.Location = new System.Drawing.Point(12, 12);
            this.g.Name = "g";
            // 
            // 
            // 
            this.g.PrimaryGrid.AllowEdit = false;
            this.g.PrimaryGrid.Columns.Add(this.gID);
            this.g.PrimaryGrid.Columns.Add(this.gName);
            this.g.PrimaryGrid.Columns.Add(this.gStart);
            this.g.PrimaryGrid.Columns.Add(this.gFinish);
            this.g.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row;
            this.g.PrimaryGrid.ShowRowHeaders = false;
            this.g.PrimaryGrid.UseAlternateRowStyle = true;
            this.g.Size = new System.Drawing.Size(455, 457);
            this.g.TabIndex = 0;
            this.g.RowActivated += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridRowActivatedEventArgs>(this.g_RowActivated);
            this.g.RowClick += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridRowClickEventArgs>(this.g_RowClick);
            this.g.RowDoubleClick += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridRowDoubleClickEventArgs>(this.g_RowDoubleClick);
            // 
            // m
            // 
            this.m.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.m.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mAdd,
            this.mRemove});
            this.m.Name = "m";
            this.m.Size = new System.Drawing.Size(169, 48);
            // 
            // mAdd
            // 
            this.mAdd.Name = "mAdd";
            this.mAdd.Size = new System.Drawing.Size(168, 22);
            this.mAdd.Text = "Add grid view";
            this.mAdd.Click += new System.EventHandler(this.mAdd_Click);
            // 
            // mRemove
            // 
            this.mRemove.Name = "mRemove";
            this.mRemove.Size = new System.Drawing.Size(168, 22);
            this.mRemove.Text = "Remove grid view";
            this.mRemove.Click += new System.EventHandler(this.mRemove_Click);
            // 
            // gID
            // 
            this.gID.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.None;
            this.gID.MinimumWidth = 60;
            this.gID.Name = "ID";
            this.gID.Width = 60;
            // 
            // gName
            // 
            this.gName.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            this.gName.Name = "Name";
            // 
            // gStart
            // 
            this.gStart.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.None;
            this.gStart.MinimumWidth = 100;
            this.gStart.Name = "Start";
            // 
            // gFinish
            // 
            this.gFinish.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.None;
            this.gFinish.MinimumWidth = 100;
            this.gFinish.Name = "Finish";
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(482, 435);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(68, 34);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(704, 435);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(68, 34);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.txtName.Enabled = false;
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(599, 13);
            this.txtName.Name = "txtName";
            this.txtName.PreventEnterBeep = true;
            this.txtName.Size = new System.Drawing.Size(173, 25);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(482, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(111, 23);
            this.lblName.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblName.TabIndex = 413;
            this.lblName.Text = "Grid view name:";
            // 
            // lblFrom
            // 
            this.lblFrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblFrom.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblFrom.ForeColor = System.Drawing.Color.Black;
            this.lblFrom.Location = new System.Drawing.Point(482, 44);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(82, 23);
            this.lblFrom.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblFrom.TabIndex = 415;
            this.lblFrom.Text = "Start date:";
            // 
            // dtTo
            // 
            this.dtTo.AllowEmptyState = false;
            this.dtTo.AutoAdvance = true;
            this.dtTo.AutoSelectDate = true;
            this.dtTo.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.dtTo.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtTo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtTo.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtTo.ButtonDropDown.Visible = true;
            this.dtTo.CustomFormat = "dd/MM/yyyy";
            this.dtTo.DateTimeSelectorVisibility = DevComponents.Editors.DateTimeAdv.eDateTimeSelectorVisibility.DateSelector;
            this.dtTo.Enabled = false;
            this.dtTo.ForeColor = System.Drawing.Color.Black;
            this.dtTo.IsPopupCalendarOpen = false;
            this.dtTo.Location = new System.Drawing.Point(599, 75);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dtTo.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtTo.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtTo.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtTo.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtTo.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtTo.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtTo.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtTo.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtTo.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtTo.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtTo.MonthCalendar.DisplayMonth = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.dtTo.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.dtTo.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtTo.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtTo.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtTo.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtTo.MonthCalendar.TodayButtonVisible = true;
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(173, 25);
            this.dtTo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtTo.TabIndex = 3;
            this.dtTo.Enter += new System.EventHandler(this.dtTo_Enter);
            // 
            // dtFrom
            // 
            this.dtFrom.AllowEmptyState = false;
            this.dtFrom.AutoAdvance = true;
            this.dtFrom.AutoSelectDate = true;
            this.dtFrom.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.dtFrom.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtFrom.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFrom.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtFrom.ButtonDropDown.Visible = true;
            this.dtFrom.CustomFormat = "dd/MM/yyyy";
            this.dtFrom.DateTimeSelectorVisibility = DevComponents.Editors.DateTimeAdv.eDateTimeSelectorVisibility.DateSelector;
            this.dtFrom.Enabled = false;
            this.dtFrom.ForeColor = System.Drawing.Color.Black;
            this.dtFrom.IsPopupCalendarOpen = false;
            this.dtFrom.Location = new System.Drawing.Point(599, 44);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dtFrom.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFrom.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtFrom.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtFrom.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtFrom.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtFrom.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtFrom.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtFrom.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtFrom.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtFrom.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFrom.MonthCalendar.DisplayMonth = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.dtFrom.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.dtFrom.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtFrom.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtFrom.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtFrom.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFrom.MonthCalendar.TodayButtonVisible = true;
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(173, 25);
            this.dtFrom.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtFrom.TabIndex = 2;
            this.dtFrom.Enter += new System.EventHandler(this.dtFrom_Enter);
            // 
            // lblTo
            // 
            this.lblTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblTo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTo.ForeColor = System.Drawing.Color.Black;
            this.lblTo.Location = new System.Drawing.Point(482, 75);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(82, 23);
            this.lblTo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblTo.TabIndex = 420;
            this.lblTo.Text = "Finish date:";
            // 
            // tv
            // 
            this.tv.BackColor = System.Drawing.Color.White;
            this.tv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tv.CheckBoxes = true;
            this.tv.Enabled = false;
            this.tv.ForeColor = System.Drawing.Color.Black;
            this.tv.FullRowSelect = true;
            this.tv.HideSelection = false;
            this.tv.Location = new System.Drawing.Point(482, 138);
            this.tv.Name = "tv";
            this.tv.Size = new System.Drawing.Size(290, 291);
            this.tv.TabIndex = 4;
            // 
            // lblRooms
            // 
            this.lblRooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblRooms.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblRooms.ForeColor = System.Drawing.Color.Black;
            this.lblRooms.Location = new System.Drawing.Point(482, 113);
            this.lblRooms.Name = "lblRooms";
            this.lblRooms.Size = new System.Drawing.Size(111, 23);
            this.lblRooms.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblRooms.TabIndex = 422;
            this.lblRooms.Text = "Rooms to show:";
            // 
            // frmGridViews
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CaptionFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ClientSize = new System.Drawing.Size(784, 481);
            this.Controls.Add(this.lblRooms);
            this.Controls.Add(this.tv);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.dtTo);
            this.Controls.Add(this.dtFrom);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.g);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGridViews";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Grid View Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGridViews_FormClosing);
            this.m.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFrom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.SuperGrid.SuperGridControl g;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gID;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gName;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gStart;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gFinish;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.Controls.TextBoxX txtName;
        private DevComponents.DotNetBar.LabelX lblName;
        private DevComponents.DotNetBar.LabelX lblFrom;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtTo;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtFrom;
        private DevComponents.DotNetBar.LabelX lblTo;
        private System.Windows.Forms.TreeView tv;
        private DevComponents.DotNetBar.LabelX lblRooms;
        private System.Windows.Forms.ContextMenuStrip m;
        private System.Windows.Forms.ToolStripMenuItem mAdd;
        private System.Windows.Forms.ToolStripMenuItem mRemove;
    }
}