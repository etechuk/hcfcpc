using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DevComponents.DotNetBar.Metro;

namespace Client
{
    public partial class frmUsers : MetroForm
    {
        int iID = 0;

        public frmUsers()
        {
            InitializeComponent();

            Icon = Properties.Resources.logo;

            DataSet ds = Program.DB.SelectAll("SELECT * FROM Users;");
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow r in ds.Tables[0].Rows)
                {
                    TreeNode n = new TreeNode();
                    n.Text = r["NameFirst"].ToString() + " " + r["NameLast"].ToString();
                    n.Tag = r["ID"].ToString();
                    tv.Nodes.Add(n);
                }
            }

            txtPass.UseSystemPasswordChar = true;
        }

        private void cbxNameTitle_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DevComponents.Editors.ComboItem i = (DevComponents.Editors.ComboItem)cbxNameTitle.SelectedItem;
            txtNameTitle.Text = i.Value.ToString();
        }

        private void tv_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode n = e.Node;

            if (n.Tag != null && n.Tag.ToString().Length > 0)
            {
                iID = Convert.ToInt32(n.Tag);

                Program.DB.AddParameter("ID", iID);
                DataSet d = Program.DB.SelectAll("SELECT * FROM Users WHERE ID=@ID;");
                if (d.Tables.Count > 0 && d.Tables[0].Rows.Count > 0)
                {
                    DataRow r = d.Tables[0].Rows[0];

                    txtUser.Text = r["Username"].ToString();
                    txtPass.Text = r["Password"].ToString();
                    txtNameTitle.Text = r["NameTitle"].ToString();
                    txtNameFirst.Text = r["NameFirst"].ToString();
                    txtNameLast.Text = r["NameLast"].ToString();
                    txtEmail.Text = r["Emails"].ToString();
                    txtPhone.Text = r["Phones"].ToString();
                    txtAddress.Text = r["Addresses"].ToString();
                    txtNotes.Text = r["Notes"].ToString();

                    if (r["NameTitle"].ToString().Length > 0)
                    {
                        foreach (DevComponents.Editors.ComboItem i in cbxNameTitle.Items)
                        {
                            if (i.Value.ToString() == r["NameTitle"].ToString())
                            {
                                cbxNameTitle.SelectedItem = i;
                                break;
                            }
                        }
                    }

                    if (r["UserGroup"].ToString().Length > 0)
                    {
                        foreach (DevComponents.Editors.ComboItem i in cbxGroup.Items)
                        {
                            if (Convert.ToInt32(i.Value) == Convert.ToInt32(r["UserGroup"]))
                            {
                                cbxGroup.SelectedItem = i;
                                break;
                            }
                        }
                    }

                    if (r["Status"].ToString().Length > 0)
                    {
                        foreach (DevComponents.Editors.ComboItem i in cbxStatus.Items)
                        {
                            if (Convert.ToInt32(i.Value) == Convert.ToInt32(r["Status"]))
                            {
                                cbxStatus.SelectedItem = i;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void tv_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            txtUser.Enabled = true;
            txtPass.Enabled = true;
            txtAddress.Enabled = true;
            txtEmail.Enabled = true;
            txtNameFirst.Enabled = true;
            txtNameLast.Enabled = true;
            txtNameTitle.Enabled = true;
            txtNotes.Enabled = true;
            txtPhone.Enabled = true;
            cbxNameTitle.Enabled = true;
            cbxGroup.Enabled = true;
            cbxStatus.Enabled = true;
            btnPass.Enabled = true;
            btnCancel.Enabled = true;
            btnSave.Enabled = true;
            tv.Enabled = false;
        }

        private void mUserAdd_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtPass.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtNameFirst.Text = "";
            txtNameLast.Text = "";
            txtNameTitle.Text = "";
            txtNotes.Text = "";
            txtPhone.Text = "";
            cbxNameTitle.SelectedIndex = -1;
            cbxGroup.SelectedIndex = 0;
            cbxStatus.SelectedIndex = 0;
            txtUser.Enabled = true;
            txtPass.Enabled = true;
            txtAddress.Enabled = true;
            txtEmail.Enabled = true;
            txtNameFirst.Enabled = true;
            txtNameLast.Enabled = true;
            txtNameTitle.Enabled = true;
            txtNotes.Enabled = true;
            txtPhone.Enabled = true;
            cbxNameTitle.Enabled = true;
            cbxGroup.Enabled = true;
            cbxStatus.Enabled = true;
            btnPass.Enabled = true;
            btnCancel.Enabled = true;
            btnSave.Enabled = true;
            ActiveControl = txtUser;
            txtUser.Focus();
        }

        private void mUserRemove_Click(object sender, EventArgs e)
        {
            if (iID > 0)
            {
                if (iID == Program.Global.UserID)
                {
                    MessageBox.Show("You can't remove your own account!\nRemoval cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DialogResult dlg = MessageBox.Show("Are you sure you want to remove this user?", "Remove?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg == DialogResult.No)
                {
                    return;
                }

                Program.DB.AddParameter("ID", iID);
                int i = Program.DB.Delete("DELETE FROM Users WHERE ID=@ID;");
                if (i < 1)
                {
                    MessageBox.Show("An error has occurred and the user\nwas not removed. Please try again.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("The user was removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tv.Nodes.Clear();
                DataSet ds = Program.DB.SelectAll("SELECT * FROM Users;");
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow r in ds.Tables[0].Rows)
                    {
                        TreeNode n = new TreeNode();
                        n.Text = r["NameFirst"].ToString() + " " + r["NameLast"].ToString();
                        n.Tag = r["ID"].ToString();
                        tv.Nodes.Add(n);
                    }
                }
            }
        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            if (txtPass.UseSystemPasswordChar == true)
            {
                txtPass.UseSystemPasswordChar = false;
                txtPass.PasswordChar = Char.Parse("\0");
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
                txtPass.PasswordChar = Char.Parse("*");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtPass.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtNameFirst.Text = "";
            txtNameLast.Text = "";
            txtNameTitle.Text = "";
            txtNotes.Text = "";
            txtPhone.Text = "";
            cbxNameTitle.SelectedIndex = -1;
            cbxGroup.SelectedIndex = -1;
            cbxStatus.SelectedIndex = -1;
            txtUser.Enabled = false;
            txtPass.Enabled = false;
            txtAddress.Enabled = false;
            txtEmail.Enabled = false;
            txtNameFirst.Enabled = false;
            txtNameLast.Enabled = false;
            txtNameTitle.Enabled = false;
            txtNotes.Enabled = false;
            txtPhone.Enabled = false;
            cbxNameTitle.Enabled = false;
            cbxGroup.Enabled = false;
            cbxStatus.Enabled = false;
            btnPass.Enabled = false;
            btnCancel.Enabled = false;
            btnSave.Enabled = false;
            tv.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool go = false;

            if (txtUser.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter a username to continue.", "Username", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (txtPass.Text.Trim().Length < 4)
            {
                MessageBox.Show("Please enter a valid username. It needs to\nbe at least four characters in length.", "Password", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (txtPass.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter a password to continue.", "Password", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (txtPass.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter a valid password. It needs to\nbe at least four characters in length.", "Password", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (txtNameFirst.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter a first name to continue.", "First Name", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (txtNameLast.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter a last name to continue.", "Last Name", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (cbxGroup.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a user group to continue.", "User Group", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (cbxStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a status to continue.", "Status", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                go = true;

                Program.DB.AddParameter("User", txtUser.Text);
                DataSet d = Program.DB.SelectAll("SELECT ID FROM Users WHERE Username=@User;");
                if (d.Tables.Count > 0 && d.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("The username entered is already taken.\nPlease enter another and try again.", "Username", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

                Program.DB.AddParameter("First", txtUser.Text);
                Program.DB.AddParameter("Last", txtUser.Text);
                d = Program.DB.SelectAll("SELECT ID FROM Users WHERE NameFirst=@First AND NameLast=@Last;");
                if (d.Tables.Count > 0 && d.Tables[0].Rows.Count > 0)
                {
                    DialogResult dlg = MessageBox.Show("A user with the name entered already exists. Do you still want to create this user?", "Name Exists", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dlg == DialogResult.No)
                    {
                        return;
                    }
                }
            }

            if (!go)
            {
                return;
            }

            string sInsertCols = "", sInsertVals = "", sUpdate = "";

            sInsertCols = "Username,Password,NameFirst,NameLast,Status,UserGroup";
            sInsertVals = "@Username,@Password,@NameFirst,@NameLast,@Status,@UserGroup";
            sUpdate = "Username=@Username,Password=@Password,NameFirst=@NameFirst,NameLast=@NameLast,Status=@Status,UserGroup=@UserGroup";
            Program.DB.AddParameter("Username", txtUser.Text);
            Program.DB.AddParameter("Password", txtPass.Text);
            Program.DB.AddParameter("NameFirst", txtNameFirst.Text);
            Program.DB.AddParameter("NameLast", txtNameLast.Text);
            DevComponents.Editors.ComboItem ci = (DevComponents.Editors.ComboItem)cbxGroup.SelectedItem;
            Program.DB.AddParameter("UserGroup", ci.Value);
            ci = (DevComponents.Editors.ComboItem)cbxGroup.SelectedItem;
            Program.DB.AddParameter("Status", ci.Value);

            if (txtNameTitle.Text.Trim().Length > 0)
            {
                sInsertCols += sInsertCols.Length > 0 ? ",NameTitle" : "NameTitle";
                sInsertVals += sInsertVals.Length > 0 ? ",@NameTitle" : "@NameTitle";
                sUpdate += (sUpdate.Length > 0 ? "," : "") + "NameTitle=@NameTitle";
                Program.DB.AddParameter("NameTitle", txtNameTitle.Text);
            }

            if (txtPhone.Text.Trim().Length > 0)
            {
                sInsertCols += sInsertCols.Length > 0 ? ",Phones" : "Phones";
                sInsertVals += sInsertVals.Length > 0 ? ",@Phone" : "@Phone";
                sUpdate += (sUpdate.Length > 0 ? "," : "") + "Phones=@Phone";
                Program.DB.AddParameter("Phone", txtPhone.Text);
            }

            if (txtEmail.Text.Trim().Length > 0)
            {
                sInsertCols += sInsertCols.Length > 0 ? ",Emails" : "Emails";
                sInsertVals += sInsertVals.Length > 0 ? ",@Email" : "@Email";
                sUpdate += (sUpdate.Length > 0 ? "," : "") + "Emails=@Email";
                Program.DB.AddParameter("Email", txtEmail.Text);
            }

            if (txtAddress.Text.Trim().Length > 0)
            {
                sInsertCols += sInsertCols.Length > 0 ? ",Addresses" : "Addresses";
                sInsertVals += sInsertVals.Length > 0 ? ",@Address" : "@Address";
                sUpdate += (sUpdate.Length > 0 ? "," : "") + "Addresses=@Address";
                Program.DB.AddParameter("Address", txtAddress.Text);
            }

            int i = 0;

            if (iID > 0)
            {
                Program.DB.AddParameter("ID", iID);
                i = Program.DB.Update("UPDATE Users SET " + sUpdate + " WHERE ID=@ID;");
                if (i < 1)
                {
                    MessageBox.Show("The update failed. Please try again.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("The update was successful.", "Updated", (MessageBoxButtons.OK), (MessageBoxIcon.Information));
                }
            }
            else
            {
                i = Program.DB.Insert("INSERT INTO Users (" + sInsertCols + ") VALUES (" + sInsertVals + ")");
                if (i < 1)
                {
                    MessageBox.Show("The addition failed. Please try again.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("The addition was successful.", "Updated", (MessageBoxButtons.OK), (MessageBoxIcon.Information));
                }
            }

            iID = 0;

            btnCancel.PerformClick();

            tv.Nodes.Clear();
            DataSet ds = Program.DB.SelectAll("SELECT * FROM Users;");
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow r in ds.Tables[0].Rows)
                {
                    TreeNode n = new TreeNode();
                    n.Text = r["NameFirst"].ToString() + " " + r["NameLast"].ToString();
                    n.Tag = r["ID"].ToString();
                    tv.Nodes.Add(n);
                }
            }
        }
    }
}
