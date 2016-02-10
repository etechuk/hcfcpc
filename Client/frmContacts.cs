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
    public partial class frmContacts : MetroForm
    {
        public frmContacts()
        {
            InitializeComponent();

            Icon = Properties.Resources.logo;

            DataSet ds = Program.DB.SelectAll("SELECT ID,Name FROM Companies;");
            if (ds.Tables.Count > 0)
            {
                AutoCompleteStringCollection asCompanies = new AutoCompleteStringCollection();
                foreach (DataRow r in ds.Tables[0].Rows)
                {
                    string sName = r["Name"].ToString();
                    asCompanies.Add(sName);
                }
                txtCompanies.AutoCompleteCustomSource = asCompanies;
            }

            ds = Program.DB.SelectAll("SELECT ID,NameFirst,NameLast FROM Contacts;");
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow r in ds.Tables[0].Rows)
                {
                    DevComponents.Editors.ComboItem i = new DevComponents.Editors.ComboItem();
                    i.Tag = r["ID"];
                    i.Text = r["NameFirst"].ToString() + " " + r["NameLast"].ToString();
                    cbxContact.Items.Add(i);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbxContact.SelectedIndex == -1 && txtNameFirst.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a first name to continue.", "First Name", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            if (cbxContact.SelectedIndex == -1 && txtNameLast.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a last name to continue.", "Last Name", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            if (cbxContact.SelectedIndex > -1)
            {
                DevComponents.Editors.ComboItem i = (DevComponents.Editors.ComboItem)cbxContact.SelectedItem;
                SharedData.iContactID = Convert.ToInt32(i.Tag);
            }
            else
            {
                string sDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string sInsertCols = "NameFirst,NameLast", sInsertVals = "@NameFirst,@NameLast";
                Program.DB.AddParameter("NameFirst", txtNameFirst.Text.Trim());
                Program.DB.AddParameter("NameLast", txtNameLast.Text.Trim());
                Program.DB.AddParameter("Entered", sDate);
                Program.DB.AddParameter("Modified", sDate);

                if (txtCompanies.Text.Trim().Length > 0)
                {
                    sInsertCols += ",Company";
                    sInsertVals += ",@Company";
                    Program.DB.AddParameter("Company", txtCompanies.Text.Trim());
                }

                int iID = Program.DB.Insert("INSERT INTO Contacts (" + sInsertCols + ") VALUES (" + sInsertVals + ")");
                if (iID < 1)
                {
                    MessageBox.Show("The addition failed. Please try again.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("The addition was successful.", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SharedData.iContactID = iID;
                }
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void txtNameFirst_TextChanged(object sender, EventArgs e)
        {
            cbxContact.SelectedIndex = -1;
        }

        private void txtNameLast_TextChanged(object sender, EventArgs e)
        {
            cbxContact.SelectedIndex = -1;
        }
    }
}
