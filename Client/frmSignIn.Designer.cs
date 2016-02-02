namespace Client
{
    partial class frmSignIn
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
            this.pSign = new System.Windows.Forms.Panel();
            this.cbxRemember = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cpMain = new DevComponents.DotNetBar.Controls.CircularProgress();
            this.btnExit = new DevComponents.DotNetBar.ButtonX();
            this.btnSettings = new DevComponents.DotNetBar.ButtonX();
            this.btnSign = new DevComponents.DotNetBar.ButtonX();
            this.txtPass = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblPass = new DevComponents.DotNetBar.LabelX();
            this.txtUser = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblUser = new DevComponents.DotNetBar.LabelX();
            this.lblSign = new DevComponents.DotNetBar.LabelX();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.pSettings = new DevComponents.DotNetBar.PanelEx();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.txtDataName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblDataName = new DevComponents.DotNetBar.LabelX();
            this.txtDataPass = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblDataPass = new DevComponents.DotNetBar.LabelX();
            this.txtDataUser = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblDataUser = new DevComponents.DotNetBar.LabelX();
            this.txtDataPort = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblDataPort = new DevComponents.DotNetBar.LabelX();
            this.txtDataHost = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblDataHost = new DevComponents.DotNetBar.LabelX();
            this.lblInstructions = new DevComponents.DotNetBar.LabelX();
            this.lblSettings = new DevComponents.DotNetBar.LabelX();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.pSign.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.pSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // sm
            // 
            this.sm.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2016;
            this.sm.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // pSign
            // 
            this.pSign.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pSign.BackColor = System.Drawing.Color.Transparent;
            this.pSign.Controls.Add(this.cbxRemember);
            this.pSign.Controls.Add(this.cpMain);
            this.pSign.Controls.Add(this.btnExit);
            this.pSign.Controls.Add(this.btnSettings);
            this.pSign.Controls.Add(this.btnSign);
            this.pSign.Controls.Add(this.txtPass);
            this.pSign.Controls.Add(this.lblPass);
            this.pSign.Controls.Add(this.txtUser);
            this.pSign.Controls.Add(this.lblUser);
            this.pSign.Controls.Add(this.lblSign);
            this.pSign.Controls.Add(this.pbxLogo);
            this.pSign.ForeColor = System.Drawing.Color.Black;
            this.pSign.Location = new System.Drawing.Point(12, 12);
            this.pSign.Name = "pSign";
            this.pSign.Size = new System.Drawing.Size(310, 419);
            this.pSign.TabIndex = 5;
            // 
            // cbxRemember
            // 
            this.cbxRemember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.cbxRemember.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbxRemember.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxRemember.ForeColor = System.Drawing.Color.Black;
            this.cbxRemember.Location = new System.Drawing.Point(118, 270);
            this.cbxRemember.Name = "cbxRemember";
            this.cbxRemember.Size = new System.Drawing.Size(156, 23);
            this.cbxRemember.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.cbxRemember.TabIndex = 3;
            this.cbxRemember.Text = " Remember username";
            // 
            // cpMain
            // 
            this.cpMain.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cpMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.cpMain.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cpMain.Location = new System.Drawing.Point(118, 366);
            this.cpMain.Name = "cpMain";
            this.cpMain.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(159)))));
            this.cpMain.Size = new System.Drawing.Size(75, 49);
            this.cpMain.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.cpMain.TabIndex = 5;
            this.cpMain.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(232, 385);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 31);
            this.btnExit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnExit.TabIndex = 34;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSettings.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.Location = new System.Drawing.Point(3, 385);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(75, 31);
            this.btnSettings.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSettings.TabIndex = 33;
            this.btnSettings.TabStop = false;
            this.btnSettings.Text = "Settings";
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnSign
            // 
            this.btnSign.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSign.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSign.Location = new System.Drawing.Point(118, 310);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(75, 31);
            this.btnSign.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSign.TabIndex = 5;
            this.btnSign.TabStop = false;
            this.btnSign.Text = "Sign In";
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // txtPass
            // 
            this.txtPass.AutoSelectAll = true;
            this.txtPass.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPass.Border.Class = "TextBoxBorder";
            this.txtPass.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPass.DisabledBackColor = System.Drawing.Color.White;
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.Black;
            this.txtPass.Location = new System.Drawing.Point(118, 237);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.PreventEnterBeep = true;
            this.txtPass.Size = new System.Drawing.Size(156, 25);
            this.txtPass.TabIndex = 2;
            this.txtPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPass_KeyDown);
            // 
            // lblPass
            // 
            this.lblPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblPass.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblPass.ForeColor = System.Drawing.Color.Black;
            this.lblPass.Location = new System.Drawing.Point(38, 239);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(74, 23);
            this.lblPass.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.lblPass.TabIndex = 31;
            this.lblPass.Text = "Password:";
            // 
            // txtUser
            // 
            this.txtUser.AutoSelectAll = true;
            this.txtUser.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtUser.Border.Class = "TextBoxBorder";
            this.txtUser.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtUser.DisabledBackColor = System.Drawing.Color.White;
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.Black;
            this.txtUser.Location = new System.Drawing.Point(118, 206);
            this.txtUser.Name = "txtUser";
            this.txtUser.PreventEnterBeep = true;
            this.txtUser.Size = new System.Drawing.Size(156, 25);
            this.txtUser.TabIndex = 1;
            this.txtUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUser_KeyDown);
            // 
            // lblUser
            // 
            this.lblUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblUser.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblUser.ForeColor = System.Drawing.Color.Black;
            this.lblUser.Location = new System.Drawing.Point(38, 208);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(74, 23);
            this.lblUser.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.lblUser.TabIndex = 29;
            this.lblUser.Text = "Username:";
            // 
            // lblSign
            // 
            this.lblSign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblSign.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblSign.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSign.ForeColor = System.Drawing.Color.Black;
            this.lblSign.Location = new System.Drawing.Point(3, 162);
            this.lblSign.Name = "lblSign";
            this.lblSign.Size = new System.Drawing.Size(304, 23);
            this.lblSign.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblSign.TabIndex = 28;
            this.lblSign.Text = "Sign into an account";
            this.lblSign.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // pbxLogo
            // 
            this.pbxLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxLogo.ForeColor = System.Drawing.Color.Black;
            this.pbxLogo.Image = global::Client.Properties.Resources.logo_signin;
            this.pbxLogo.ImageLocation = "";
            this.pbxLogo.Location = new System.Drawing.Point(3, 3);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(304, 138);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxLogo.TabIndex = 27;
            this.pbxLogo.TabStop = false;
            // 
            // pSettings
            // 
            this.pSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pSettings.CanvasColor = System.Drawing.Color.Transparent;
            this.pSettings.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pSettings.Controls.Add(this.btnSave);
            this.pSettings.Controls.Add(this.btnCancel);
            this.pSettings.Controls.Add(this.txtDataName);
            this.pSettings.Controls.Add(this.lblDataName);
            this.pSettings.Controls.Add(this.txtDataPass);
            this.pSettings.Controls.Add(this.lblDataPass);
            this.pSettings.Controls.Add(this.txtDataUser);
            this.pSettings.Controls.Add(this.lblDataUser);
            this.pSettings.Controls.Add(this.txtDataPort);
            this.pSettings.Controls.Add(this.lblDataPort);
            this.pSettings.Controls.Add(this.txtDataHost);
            this.pSettings.Controls.Add(this.lblDataHost);
            this.pSettings.Controls.Add(this.lblInstructions);
            this.pSettings.Controls.Add(this.lblSettings);
            this.pSettings.DisabledBackColor = System.Drawing.Color.Empty;
            this.pSettings.Location = new System.Drawing.Point(12, 12);
            this.pSettings.Name = "pSettings";
            this.pSettings.Size = new System.Drawing.Size(310, 419);
            this.pSettings.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pSettings.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pSettings.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pSettings.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pSettings.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pSettings.Style.GradientAngle = 90;
            this.pSettings.TabIndex = 9;
            this.pSettings.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(222, 319);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 31);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 41;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Location = new System.Drawing.Point(13, 319);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 31);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 40;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtDataName
            // 
            this.txtDataName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtDataName.Border.Class = "TextBoxBorder";
            this.txtDataName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDataName.DisabledBackColor = System.Drawing.Color.White;
            this.txtDataName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataName.ForeColor = System.Drawing.Color.Black;
            this.txtDataName.Location = new System.Drawing.Point(104, 268);
            this.txtDataName.Name = "txtDataName";
            this.txtDataName.PreventEnterBeep = true;
            this.txtDataName.Size = new System.Drawing.Size(193, 25);
            this.txtDataName.TabIndex = 8;
            // 
            // lblDataName
            // 
            // 
            // 
            // 
            this.lblDataName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDataName.ForeColor = System.Drawing.Color.Black;
            this.lblDataName.Location = new System.Drawing.Point(13, 268);
            this.lblDataName.Name = "lblDataName";
            this.lblDataName.Size = new System.Drawing.Size(85, 23);
            this.lblDataName.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblDataName.TabIndex = 39;
            this.lblDataName.Text = "Database:";
            // 
            // txtDataPass
            // 
            this.txtDataPass.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtDataPass.Border.Class = "TextBoxBorder";
            this.txtDataPass.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDataPass.DisabledBackColor = System.Drawing.Color.White;
            this.txtDataPass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataPass.ForeColor = System.Drawing.Color.Black;
            this.txtDataPass.Location = new System.Drawing.Point(104, 237);
            this.txtDataPass.Name = "txtDataPass";
            this.txtDataPass.PreventEnterBeep = true;
            this.txtDataPass.Size = new System.Drawing.Size(193, 25);
            this.txtDataPass.TabIndex = 7;
            // 
            // lblDataPass
            // 
            // 
            // 
            // 
            this.lblDataPass.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDataPass.ForeColor = System.Drawing.Color.Black;
            this.lblDataPass.Location = new System.Drawing.Point(13, 237);
            this.lblDataPass.Name = "lblDataPass";
            this.lblDataPass.Size = new System.Drawing.Size(85, 23);
            this.lblDataPass.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblDataPass.TabIndex = 37;
            this.lblDataPass.Text = "Password:";
            // 
            // txtDataUser
            // 
            this.txtDataUser.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtDataUser.Border.Class = "TextBoxBorder";
            this.txtDataUser.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDataUser.DisabledBackColor = System.Drawing.Color.White;
            this.txtDataUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataUser.ForeColor = System.Drawing.Color.Black;
            this.txtDataUser.Location = new System.Drawing.Point(104, 206);
            this.txtDataUser.Name = "txtDataUser";
            this.txtDataUser.PreventEnterBeep = true;
            this.txtDataUser.Size = new System.Drawing.Size(193, 25);
            this.txtDataUser.TabIndex = 6;
            // 
            // lblDataUser
            // 
            // 
            // 
            // 
            this.lblDataUser.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDataUser.ForeColor = System.Drawing.Color.Black;
            this.lblDataUser.Location = new System.Drawing.Point(13, 207);
            this.lblDataUser.Name = "lblDataUser";
            this.lblDataUser.Size = new System.Drawing.Size(85, 23);
            this.lblDataUser.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblDataUser.TabIndex = 35;
            this.lblDataUser.Text = "Username:";
            // 
            // txtDataPort
            // 
            this.txtDataPort.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtDataPort.Border.Class = "TextBoxBorder";
            this.txtDataPort.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDataPort.DisabledBackColor = System.Drawing.Color.White;
            this.txtDataPort.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataPort.ForeColor = System.Drawing.Color.Black;
            this.txtDataPort.Location = new System.Drawing.Point(104, 175);
            this.txtDataPort.Name = "txtDataPort";
            this.txtDataPort.PreventEnterBeep = true;
            this.txtDataPort.Size = new System.Drawing.Size(193, 25);
            this.txtDataPort.TabIndex = 5;
            // 
            // lblDataPort
            // 
            // 
            // 
            // 
            this.lblDataPort.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDataPort.ForeColor = System.Drawing.Color.Black;
            this.lblDataPort.Location = new System.Drawing.Point(13, 175);
            this.lblDataPort.Name = "lblDataPort";
            this.lblDataPort.Size = new System.Drawing.Size(85, 23);
            this.lblDataPort.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblDataPort.TabIndex = 33;
            this.lblDataPort.Text = "Host port:";
            // 
            // txtDataHost
            // 
            this.txtDataHost.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtDataHost.Border.Class = "TextBoxBorder";
            this.txtDataHost.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDataHost.DisabledBackColor = System.Drawing.Color.White;
            this.txtDataHost.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataHost.ForeColor = System.Drawing.Color.Black;
            this.txtDataHost.Location = new System.Drawing.Point(104, 144);
            this.txtDataHost.Name = "txtDataHost";
            this.txtDataHost.PreventEnterBeep = true;
            this.txtDataHost.Size = new System.Drawing.Size(193, 25);
            this.txtDataHost.TabIndex = 4;
            // 
            // lblDataHost
            // 
            // 
            // 
            // 
            this.lblDataHost.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDataHost.ForeColor = System.Drawing.Color.Black;
            this.lblDataHost.Location = new System.Drawing.Point(13, 144);
            this.lblDataHost.Name = "lblDataHost";
            this.lblDataHost.Size = new System.Drawing.Size(85, 23);
            this.lblDataHost.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblDataHost.TabIndex = 31;
            this.lblDataHost.Text = "Host address:";
            // 
            // lblInstructions
            // 
            // 
            // 
            // 
            this.lblInstructions.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblInstructions.ForeColor = System.Drawing.Color.Black;
            this.lblInstructions.Location = new System.Drawing.Point(3, 55);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(304, 72);
            this.lblInstructions.TabIndex = 1;
            this.lblInstructions.Text = "Enter the connection details for the\r\ndatabase below. To check they work,\r\nclick " +
    "the Save button.";
            this.lblInstructions.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblSettings
            // 
            // 
            // 
            // 
            this.lblSettings.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblSettings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettings.ForeColor = System.Drawing.Color.Black;
            this.lblSettings.Location = new System.Drawing.Point(3, 12);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(304, 23);
            this.lblSettings.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblSettings.TabIndex = 0;
            this.lblSettings.Text = "Database Connection Details";
            this.lblSettings.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2016;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // frmSignIn
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CaptionFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientSize = new System.Drawing.Size(334, 443);
            this.Controls.Add(this.pSign);
            this.Controls.Add(this.pSettings);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(350, 480);
            this.Name = "frmSignIn";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HCF Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSignIn_FormClosing);
            this.Shown += new System.EventHandler(this.frmSignIn_Shown);
            this.pSign.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.pSettings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.StyleManager sm;
        private System.Windows.Forms.Panel pSign;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbxRemember;
        private DevComponents.DotNetBar.Controls.CircularProgress cpMain;
        private DevComponents.DotNetBar.ButtonX btnExit;
        private DevComponents.DotNetBar.ButtonX btnSettings;
        private DevComponents.DotNetBar.ButtonX btnSign;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPass;
        private DevComponents.DotNetBar.LabelX lblPass;
        private DevComponents.DotNetBar.Controls.TextBoxX txtUser;
        private DevComponents.DotNetBar.LabelX lblUser;
        private DevComponents.DotNetBar.LabelX lblSign;
        private System.Windows.Forms.PictureBox pbxLogo;
        private DevComponents.DotNetBar.PanelEx pSettings;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDataName;
        private DevComponents.DotNetBar.LabelX lblDataName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDataPass;
        private DevComponents.DotNetBar.LabelX lblDataPass;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDataUser;
        private DevComponents.DotNetBar.LabelX lblDataUser;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDataPort;
        private DevComponents.DotNetBar.LabelX lblDataPort;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDataHost;
        private DevComponents.DotNetBar.LabelX lblDataHost;
        private DevComponents.DotNetBar.LabelX lblInstructions;
        private DevComponents.DotNetBar.LabelX lblSettings;
        private DevComponents.DotNetBar.StyleManager styleManager1;
    }
}