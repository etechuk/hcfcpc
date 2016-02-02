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
            this.lblContacts = new DevComponents.DotNetBar.LabelX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.lblCompany = new DevComponents.DotNetBar.LabelX();
            this.txtContacts = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtCompanies = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtNameFirst = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtNameLast = new DevComponents.DotNetBar.Controls.TextBoxX();
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
            this.btnCancel.Location = new System.Drawing.Point(12, 132);
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
            this.btnSave.Location = new System.Drawing.Point(323, 132);
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
            // txtContacts
            // 
            this.txtContacts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContacts.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtContacts.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtContacts.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtContacts.Border.Class = "TextBoxBorder";
            this.txtContacts.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtContacts.DisabledBackColor = System.Drawing.Color.White;
            this.txtContacts.ForeColor = System.Drawing.Color.Black;
            this.txtContacts.Location = new System.Drawing.Point(123, 23);
            this.txtContacts.Name = "txtContacts";
            this.txtContacts.PreventEnterBeep = true;
            this.txtContacts.Size = new System.Drawing.Size(315, 25);
            this.txtContacts.TabIndex = 17;
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
            this.txtNameFirst.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtNameFirst.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
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
            this.txtNameLast.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtNameLast.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
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
            // frmContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientSize = new System.Drawing.Size(450, 178);
            this.ControlBox = false;
            this.Controls.Add(this.txtNameLast);
            this.Controls.Add(this.txtNameFirst);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txtCompanies);
            this.Controls.Add(this.txtContacts);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblContacts);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(450, 215);
            this.Name = "frmContacts";
            this.ShowIcon = false;
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
        private DevComponents.DotNetBar.Controls.TextBoxX txtContacts;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCompanies;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNameFirst;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNameLast;
    }
}