﻿namespace Client
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
            this.lblContacts = new DevComponents.DotNetBar.LabelX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.lblCompany = new DevComponents.DotNetBar.LabelX();
            this.txtCompanies = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtNameFirst = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtNameLast = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbxContact = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.SuspendLayout();
            // 
            // lblContacts
            // 
            this.lblContacts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblContacts.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblContacts.ForeColor = System.Drawing.Color.Black;
            this.lblContacts.Location = new System.Drawing.Point(12, 21);
            this.lblContacts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblContacts.Name = "lblContacts";
            this.lblContacts.Size = new System.Drawing.Size(98, 25);
            this.lblContacts.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblContacts.TabIndex = 4;
            this.lblContacts.Text = "Contacts:";
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Location = new System.Drawing.Point(12, 133);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(68, 34);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Location = new System.Drawing.Point(323, 133);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(115, 34);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save / Choose";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblCompany
            // 
            this.lblCompany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblCompany.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCompany.ForeColor = System.Drawing.Color.Black;
            this.lblCompany.Location = new System.Drawing.Point(12, 84);
            this.lblCompany.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(98, 25);
            this.lblCompany.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblCompany.TabIndex = 14;
            this.lblCompany.Text = "Company:";
            // 
            // txtCompanies
            // 
            this.txtCompanies.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCompanies.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCompanies.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCompanies.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtCompanies.Border.Class = "TextBoxBorder";
            this.txtCompanies.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCompanies.DisabledBackColor = System.Drawing.Color.White;
            this.txtCompanies.ForeColor = System.Drawing.Color.Black;
            this.txtCompanies.Location = new System.Drawing.Point(123, 85);
            this.txtCompanies.Name = "txtCompanies";
            this.txtCompanies.PreventEnterBeep = true;
            this.txtCompanies.Size = new System.Drawing.Size(315, 25);
            this.txtCompanies.TabIndex = 18;
            // 
            // txtNameFirst
            // 
            this.txtNameFirst.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNameFirst.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtNameFirst.Border.Class = "TextBoxBorder";
            this.txtNameFirst.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNameFirst.DisabledBackColor = System.Drawing.Color.White;
            this.txtNameFirst.ForeColor = System.Drawing.Color.Black;
            this.txtNameFirst.Location = new System.Drawing.Point(123, 54);
            this.txtNameFirst.Name = "txtNameFirst";
            this.txtNameFirst.PreventEnterBeep = true;
            this.txtNameFirst.Size = new System.Drawing.Size(132, 25);
            this.txtNameFirst.TabIndex = 20;
            this.txtNameFirst.TextChanged += new System.EventHandler(this.txtNameFirst_TextChanged);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(12, 52);
            this.labelX1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(98, 25);
            this.labelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.labelX1.TabIndex = 19;
            this.labelX1.Text = "First/Last Name:";
            // 
            // txtNameLast
            // 
            this.txtNameLast.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNameLast.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtNameLast.Border.Class = "TextBoxBorder";
            this.txtNameLast.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNameLast.DisabledBackColor = System.Drawing.Color.White;
            this.txtNameLast.ForeColor = System.Drawing.Color.Black;
            this.txtNameLast.Location = new System.Drawing.Point(261, 54);
            this.txtNameLast.Name = "txtNameLast";
            this.txtNameLast.PreventEnterBeep = true;
            this.txtNameLast.Size = new System.Drawing.Size(177, 25);
            this.txtNameLast.TabIndex = 21;
            this.txtNameLast.TextChanged += new System.EventHandler(this.txtNameLast_TextChanged);
            // 
            // cbxContact
            // 
            this.cbxContact.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxContact.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbxContact.DisplayMember = "Text";
            this.cbxContact.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxContact.ForeColor = System.Drawing.Color.Black;
            this.cbxContact.FormattingEnabled = true;
            this.cbxContact.ItemHeight = 19;
            this.cbxContact.Location = new System.Drawing.Point(123, 23);
            this.cbxContact.Name = "cbxContact";
            this.cbxContact.Size = new System.Drawing.Size(315, 25);
            this.cbxContact.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxContact.TabIndex = 22;
            // 
            // frmContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ClientSize = new System.Drawing.Size(450, 179);
            this.Controls.Add(this.cbxContact);
            this.Controls.Add(this.txtNameLast);
            this.Controls.Add(this.txtNameFirst);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txtCompanies);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblContacts);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmContacts";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Contacts";
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.LabelX lblContacts;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.LabelX lblCompany;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCompanies;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNameFirst;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNameLast;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxContact;
    }
}