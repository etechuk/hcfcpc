namespace Client
{
    partial class frmCompanies
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
            this.lblName = new DevComponents.DotNetBar.LabelX();
            this.txtName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbxCompanies = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblCompanies = new DevComponents.DotNetBar.LabelX();
            this.btnAdd = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
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
            this.ms.Size = new System.Drawing.Size(542, 34);
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
            this.ms.TabIndex = 14;
            this.ms.TabStripFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(19, 84);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(116, 23);
            this.lblName.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblName.TabIndex = 18;
            this.lblName.Text = "Company Name:";
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
            this.txtName.Location = new System.Drawing.Point(151, 84);
            this.txtName.Name = "txtName";
            this.txtName.PreventEnterBeep = true;
            this.txtName.Size = new System.Drawing.Size(375, 25);
            this.txtName.TabIndex = 17;
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
            this.cbxCompanies.Location = new System.Drawing.Point(151, 52);
            this.cbxCompanies.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxCompanies.Name = "cbxCompanies";
            this.cbxCompanies.Size = new System.Drawing.Size(375, 25);
            this.cbxCompanies.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxCompanies.TabIndex = 16;
            // 
            // lblCompanies
            // 
            this.lblCompanies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblCompanies.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCompanies.ForeColor = System.Drawing.Color.Black;
            this.lblCompanies.Location = new System.Drawing.Point(19, 52);
            this.lblCompanies.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblCompanies.Name = "lblCompanies";
            this.lblCompanies.Size = new System.Drawing.Size(116, 25);
            this.lblCompanies.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblCompanies.TabIndex = 15;
            this.lblCompanies.Text = "Existing Companies:";
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAdd.Location = new System.Drawing.Point(222, 138);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 34);
            this.btnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Add Company";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Location = new System.Drawing.Point(425, 138);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 34);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Location = new System.Drawing.Point(19, 138);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 34);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save / Choose";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmCompanies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 191);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cbxCompanies);
            this.Controls.Add(this.lblCompanies);
            this.Controls.Add(this.ms);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCompanies";
            this.Text = "Companies";
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.Metro.MetroShell ms;
        private DevComponents.DotNetBar.LabelX lblCompanies;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxCompanies;
        private DevComponents.DotNetBar.Controls.TextBoxX txtName;
        private DevComponents.DotNetBar.LabelX lblName;
        private DevComponents.DotNetBar.ButtonX btnAdd;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnSave;
    }
}