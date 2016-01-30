namespace Client
{
    partial class frmContacts
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
            this.ms = new DevComponents.DotNetBar.Metro.MetroShell();
            this.cbxContacts = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblContacts = new DevComponents.DotNetBar.LabelX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.lblTitle = new DevComponents.DotNetBar.LabelX();
            this.txtTitle = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblName = new DevComponents.DotNetBar.LabelX();
            this.txtNameFirst = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtNameLast = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbxTitle = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbxiMr = new DevComponents.Editors.ComboItem();
            this.cbxiMiss = new DevComponents.Editors.ComboItem();
            this.cbxiMrs = new DevComponents.Editors.ComboItem();
            this.cbxiMs = new DevComponents.Editors.ComboItem();
            this.cbxiMaster = new DevComponents.Editors.ComboItem();
            this.cbxiDr = new DevComponents.Editors.ComboItem();
            this.cbxiProf = new DevComponents.Editors.ComboItem();
            this.cbxCompanies = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblCompany = new DevComponents.DotNetBar.LabelX();
            this.btnAdd = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // ms
            // 
            this.ms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.ms.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ms.CanCustomize = false;
            this.ms.CaptionFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ms.CaptionVisible = true;
            this.ms.Dock = System.Windows.Forms.DockStyle.Top;
            this.ms.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ms.ForeColor = System.Drawing.Color.Black;
            this.ms.HelpButtonText = null;
            this.ms.HelpButtonVisible = false;
            this.ms.KeyTipsFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ms.Location = new System.Drawing.Point(1, 1);
            this.ms.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ms.Name = "ms";
            this.ms.SettingsButtonVisible = false;
            this.ms.ShowIcon = false;
            this.ms.Size = new System.Drawing.Size(558, 34);
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
            this.ms.TabIndex = 1;
            this.ms.TabStripFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // cbxContacts
            // 
            this.cbxContacts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxContacts.DisplayMember = "Text";
            this.cbxContacts.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxContacts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxContacts.ForeColor = System.Drawing.Color.Black;
            this.cbxContacts.FormattingEnabled = true;
            this.cbxContacts.ItemHeight = 19;
            this.cbxContacts.Location = new System.Drawing.Point(141, 52);
            this.cbxContacts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxContacts.Name = "cbxContacts";
            this.cbxContacts.Size = new System.Drawing.Size(400, 25);
            this.cbxContacts.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxContacts.TabIndex = 5;
            // 
            // lblContacts
            // 
            this.lblContacts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblContacts.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblContacts.ForeColor = System.Drawing.Color.Black;
            this.lblContacts.Location = new System.Drawing.Point(19, 52);
            this.lblContacts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblContacts.Name = "lblContacts";
            this.lblContacts.Size = new System.Drawing.Size(116, 25);
            this.lblContacts.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblContacts.TabIndex = 4;
            this.lblContacts.Text = "Existing Contacts:";
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Location = new System.Drawing.Point(440, 206);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 34);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Location = new System.Drawing.Point(19, 206);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 34);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save / Choose";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblTitle.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(19, 84);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(116, 23);
            this.lblTitle.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Name (Title):";
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtTitle.Border.Class = "TextBoxBorder";
            this.txtTitle.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTitle.DisabledBackColor = System.Drawing.Color.White;
            this.txtTitle.ForeColor = System.Drawing.Color.Black;
            this.txtTitle.Location = new System.Drawing.Point(141, 84);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.PreventEnterBeep = true;
            this.txtTitle.Size = new System.Drawing.Size(166, 25);
            this.txtTitle.TabIndex = 8;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(19, 116);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(116, 23);
            this.lblName.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Name (First/Last):";
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
            this.txtNameFirst.ForeColor = System.Drawing.Color.Black;
            this.txtNameFirst.Location = new System.Drawing.Point(141, 116);
            this.txtNameFirst.Name = "txtNameFirst";
            this.txtNameFirst.PreventEnterBeep = true;
            this.txtNameFirst.Size = new System.Drawing.Size(166, 25);
            this.txtNameFirst.TabIndex = 10;
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
            this.txtNameLast.ForeColor = System.Drawing.Color.Black;
            this.txtNameLast.Location = new System.Drawing.Point(313, 116);
            this.txtNameLast.Name = "txtNameLast";
            this.txtNameLast.PreventEnterBeep = true;
            this.txtNameLast.Size = new System.Drawing.Size(228, 25);
            this.txtNameLast.TabIndex = 12;
            // 
            // cbxTitle
            // 
            this.cbxTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxTitle.DisplayMember = "Text";
            this.cbxTitle.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTitle.ForeColor = System.Drawing.Color.Black;
            this.cbxTitle.FormattingEnabled = true;
            this.cbxTitle.ItemHeight = 19;
            this.cbxTitle.Items.AddRange(new object[] {
            this.cbxiMr,
            this.cbxiMiss,
            this.cbxiMrs,
            this.cbxiMs,
            this.cbxiMaster,
            this.cbxiDr,
            this.cbxiProf});
            this.cbxTitle.Location = new System.Drawing.Point(313, 85);
            this.cbxTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxTitle.Name = "cbxTitle";
            this.cbxTitle.Size = new System.Drawing.Size(228, 25);
            this.cbxTitle.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxTitle.TabIndex = 13;
            // 
            // cbxiMr
            // 
            this.cbxiMr.Text = "Mr";
            // 
            // cbxiMiss
            // 
            this.cbxiMiss.Text = "Miss";
            // 
            // cbxiMrs
            // 
            this.cbxiMrs.Text = "Mrs";
            // 
            // cbxiMs
            // 
            this.cbxiMs.Text = "Ms";
            // 
            // cbxiMaster
            // 
            this.cbxiMaster.Text = "Master";
            // 
            // cbxiDr
            // 
            this.cbxiDr.Text = "Dr";
            // 
            // cbxiProf
            // 
            this.cbxiProf.Text = "Prof";
            // 
            // cbxCompanies
            // 
            this.cbxCompanies.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxCompanies.DisplayMember = "Text";
            this.cbxCompanies.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxCompanies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCompanies.ForeColor = System.Drawing.Color.Black;
            this.cbxCompanies.FormattingEnabled = true;
            this.cbxCompanies.ItemHeight = 19;
            this.cbxCompanies.Location = new System.Drawing.Point(141, 148);
            this.cbxCompanies.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxCompanies.Name = "cbxCompanies";
            this.cbxCompanies.Size = new System.Drawing.Size(400, 25);
            this.cbxCompanies.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxCompanies.TabIndex = 15;
            // 
            // lblCompany
            // 
            this.lblCompany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblCompany.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCompany.ForeColor = System.Drawing.Color.Black;
            this.lblCompany.Location = new System.Drawing.Point(19, 148);
            this.lblCompany.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(116, 25);
            this.lblCompany.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblCompany.TabIndex = 14;
            this.lblCompany.Text = "Company:";
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAdd.Location = new System.Drawing.Point(230, 206);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 34);
            this.btnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add Contact";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 260);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbxCompanies);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.cbxTitle);
            this.Controls.Add(this.txtNameLast);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtNameFirst);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbxContacts);
            this.Controls.Add(this.lblContacts);
            this.Controls.Add(this.ms);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(560, 260);
            this.Name = "frmContacts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Contacts";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Metro.MetroShell ms;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxContacts;
        private DevComponents.DotNetBar.LabelX lblContacts;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.LabelX lblTitle;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTitle;
        private DevComponents.DotNetBar.LabelX lblName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNameFirst;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNameLast;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxTitle;
        private DevComponents.Editors.ComboItem cbxiMr;
        private DevComponents.Editors.ComboItem cbxiMiss;
        private DevComponents.Editors.ComboItem cbxiMrs;
        private DevComponents.Editors.ComboItem cbxiMs;
        private DevComponents.Editors.ComboItem cbxiMaster;
        private DevComponents.Editors.ComboItem cbxiDr;
        private DevComponents.Editors.ComboItem cbxiProf;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxCompanies;
        private DevComponents.DotNetBar.LabelX lblCompany;
        private DevComponents.DotNetBar.ButtonX btnAdd;
    }
}