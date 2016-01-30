using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class frmSignIn : Form
    {
        #region Form

        public frmSignIn()
        {
            InitializeComponent();

            Icon = Properties.Resources.logo;

            if (Properties.Settings.Default.DataHost.Length > 0)
            {
                txtDataHost.Text = Properties.Settings.Default.DataHost;
                txtDataPort.Text = Properties.Settings.Default.DataPort > 0 ? Properties.Settings.Default.DataPort.ToString() : "";
                txtDataUser.Text = Properties.Settings.Default.DataUser;
                txtDataPass.Text = Properties.Settings.Default.DataPass;
                txtDataName.Text = Properties.Settings.Default.DataName;

                Program.DB.CreateSession(Properties.Settings.Default.DataHost, Properties.Settings.Default.DataPort, Properties.Settings.Default.DataUser, Properties.Settings.Default.DataPass, Properties.Settings.Default.DataName, Common.SqlProviders.SqlServer);
            }
        }

        private void frmSignIn_Shown(object sender, EventArgs e)
        {
            Activate();

            DialogResult dlg = DialogResult.Ignore;

            if (txtDataHost.Text.Trim().Length == 0)
            {
                dlg = MessageBox.Show("The database host needs to be specified.\nClick OK to enter it now.", "Database host", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (!pSettings.Visible)
                {
                    pSign.Visible = false;
                    pSettings.Visible = true;
                }
                ActiveControl = txtDataHost;
                txtDataHost.Focus();
            }
            else if (txtDataName.Text.Trim().Length == 0)
            {
                dlg = MessageBox.Show("The database name needs to be specified.\nClick OK to enter it now.", "Database name", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (!pSettings.Visible)
                {
                    pSign.Visible = false;
                    pSettings.Visible = true;
                }
                ActiveControl = txtDataName;
                txtDataName.Focus();
            }

            if (Properties.Settings.Default.UserRemember)
            {
                if (Properties.Settings.Default.UserName.Length > 0)
                {
                    txtUser.Text = Properties.Settings.Default.UserName;
                    ActiveControl = txtPass;
                    txtPass.Focus();
                }
                cbxRemember.Checked = true;
            }
            else
            {
                ActiveControl = txtUser;
                txtUser.Focus();
            }
        }

        private void frmSignIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown)
            {
                return;
            }
            else if (txtDataHost.Text.Trim().Length == 0 || txtDataName.Text.Trim().Length == 0)
            {
                DialogResult dlg = MessageBox.Show("You haven't set required database details.\nAre you sure you want to exit?", "Database", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg == DialogResult.No)
                {
                    e.Cancel = true;
                    pSign.Visible = false;
                    pSettings.Visible = true;
                }
            }
        }

        #endregion

        #region Clicked

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtDataHost.Text = Properties.Settings.Default.DataHost;
            txtDataPort.Text = Properties.Settings.Default.DataPort > 0 ? Properties.Settings.Default.DataPort.ToString() : "";
            txtDataUser.Text = Properties.Settings.Default.DataUser;
            txtDataPass.Text = Properties.Settings.Default.DataPass;
            txtDataName.Text = Properties.Settings.Default.DataName;
            pSettings.Visible = false;
            pSign.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.DataHost = txtDataHost.Text;
            Properties.Settings.Default.DataPort = txtDataPort.Text != "" ? Convert.ToInt32(txtDataPort.Text) : 0;
            Properties.Settings.Default.DataUser = txtDataUser.Text;
            Properties.Settings.Default.DataPass = txtDataPass.Text;
            Properties.Settings.Default.DataName = txtDataName.Text;
            Properties.Settings.Default.Save();

            Program.DB.CreateSession(txtDataHost.Text, Properties.Settings.Default.DataPort, Properties.Settings.Default.DataUser, Properties.Settings.Default.DataPass, Properties.Settings.Default.DataName, Common.SqlProviders.SqlServer);
            if (!Program.DB.IsAvailable())
            {
                MessageBox.Show("Invalid details or server unavailable.\nPlease try again.", "Database", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            pSettings.Visible = false;
            pSign.Visible = true;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            pSign.Visible = false;
            pSettings.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            if (pSettings.Visible)
            {
                pSettings.Visible = false;
            }

            txtUser.Enabled = false;
            txtPass.Enabled = false;
            btnSign.Enabled = false;
            cpMain.Visible = true;
            bool go = true;

            DataSet ds = Program.DB.SelectAll("SELECT ID FROM users WHERE Username='" + txtUser.Text.Trim() + "';");
            if (ds.Tables.Count < 1)
            {
                MessageBox.Show("The username provided wasn't found.\nPlease check and try again.", "Username", MessageBoxButtons.OK, MessageBoxIcon.Information);
                go = false;
            }

            if (go)
            {
                ds = Program.DB.SelectAll("SELECT ID,UserGroup,Status FROM users WHERE Username='" + txtUser.Text.Trim() + "' AND Password='" + txtPass.Text.Trim() + "';");
                if (ds.Tables.Count < 1)
                {
                    MessageBox.Show("You've entered an incorrect password.\nPlease check and try again.", "Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    go = false;
                }
            }

            int status = 0;

            if (go && ds.Tables[0].Rows.Count < 1)
            {
                MessageBox.Show("The details you entered were not found.\nPlease check and try again.", "Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                go = false;
            }
            else
            {
                if (ds.Tables.Count > 0)
                {
                    status = Convert.ToInt32(ds.Tables[0].Rows[0]["Status"].ToString());
                    switch (status)
                    {
                        case 2:
                            MessageBox.Show("The user you entered is currently disabled.\nPlease contact an administrator.", "Disabled", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            go = false;
                            break;
                        case 3:
                            MessageBox.Show("The user you entered is currently banned.\nPlease contact an administrator.", "Banned", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            go = false;
                            break;
                        case 4:
                            MessageBox.Show("The user you entered has been deleted.\nPlease contact an administrator.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            go = false;
                            break;
                    }
                }
                else
                {
                    go = false;
                }
            }

            if (!go)
            {
                txtUser.Enabled = true;
                txtPass.Enabled = true;
                txtPass.Text = "";
                btnSign.Enabled = true;
                cpMain.Visible = false;
                txtPass.Focus();
                return;
            }

            if (txtUser.Text.Length > 0 && cbxRemember.Checked)
            {
                Properties.Settings.Default.UserName = txtUser.Text.Trim();
                Properties.Settings.Default.UserRemember = cbxRemember.Checked;
            }
            else
            {
                Properties.Settings.Default.UserName = "";
                Properties.Settings.Default.UserRemember = false;
            }
            Properties.Settings.Default.Save();

            int iUserGroup = Convert.ToInt32(ds.Tables[0].Rows[0]["UserGroup"].ToString());
            Program.Global.UserIsAdmin = iUserGroup == 3 || iUserGroup == 4 ? true : false;
            Program.Global.UserID = Convert.ToInt32(ds.Tables[0].Rows[0]["ID"].ToString());
            Program.Global.UserSigned = true;

            cpMain.Visible = false;
            txtUser.Enabled = true;
            txtPass.Enabled = true;
            txtPass.Text = "";
            btnSign.Enabled = true;

            Hide();
            Form frmMain = new frmMain();
            frmMain.Show();
        }

        #endregion

        #region Methods

        private void CheckConnection()
        {
            if (txtDataHost.Text.Trim() != "" && txtDataUser.Text.Trim() != "" && txtDataPass.Text.Trim() != "" && txtDataName.Text.Trim() != "")
            {
                btnSave.PerformClick();
            }
        }

        #endregion

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                if (txtUser.Text.Trim().Length > 0 && txtPass.Text.Trim().Length > 0)
                {
                    btnSign.PerformClick();
                }
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                if (txtUser.Text.Trim().Length > 0 && txtPass.Text.Trim().Length > 0)
                {
                    btnSign.PerformClick();
                }
            }
        }
    }
}
