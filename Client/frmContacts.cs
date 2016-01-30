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
    public partial class frmContacts : MetroAppForm
    {
        public frmContacts()
        {
            InitializeComponent();

            DataSet ds = Program.DB.SelectAll("SELECT ID,NameFirst,NameLast FROM Contacts;");
            if (ds.Tables.Count > 0)
            {
                List<ComboItem> items = new List<ComboItem>();
                foreach (DataRow r in ds.Tables[0].Rows)
                {
                    string sName = r["NameLast"].ToString() + (r["NameFirst"].ToString() != "" ? ", " + r["NameFirst"].ToString() : "");
                    items.Add(new ComboItem() { Text = sName, Value = Convert.ToInt32(r["ID"]) });
                }
                cbxContacts.DataSource = items;
                cbxContacts.DisplayMember = "Text";
                cbxContacts.ValueMember = "Value";
                cbxContacts.SelectedIndex = -1;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cbxContacts.SelectedIndex = -1;
            cbxCompanies.SelectedIndex = -1;
            cbxTitle.SelectedIndex = -1;
            txtTitle.Text = "";
            txtNameFirst.Text = "";
            txtNameLast.Text = "";
            ActiveControl = txtTitle;
            txtTitle.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNameFirst.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a first name to continue.", "First Name", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            if (txtNameLast.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a last name to continue.", "Last Name", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            int iID = 0;
            if (cbxContacts.SelectedIndex < 0)
            {
                string sDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string sInsertCols = "", sInsertVals = "";

                if (txtTitle.Text.Trim() != "")
                {
                    sInsertCols += sInsertCols != "" ? ",Title" : "Title";
                    sInsertVals += sInsertVals != "" ? ",@title" : "@title";
                    Program.DB.AddParameter("@title", txtTitle.Text.Trim());
                }

                sInsertCols += sInsertCols != "" ? ",NameFirst" : "NameFirst";
                sInsertVals += sInsertVals != "" ? ",@fname" : "@fname";
                Program.DB.AddParameter("@fname", txtNameFirst.Text.Trim());

                sInsertCols += sInsertCols != "" ? ",NameLast" : "NameLast";
                sInsertVals += sInsertVals != "" ? ",@lname" : "@lname";
                Program.DB.AddParameter("@lname", txtNameLast.Text.Trim());

                sInsertCols += sInsertCols != "" ? ",Company" : "Company";
                sInsertVals += sInsertVals != "" ? ",@company" : "@company";
                Program.DB.AddParameter("@company", SharedData.iCompanyID);

                sInsertCols += sInsertCols != "" ? ",Modified" : "Modified";
                sInsertVals += sInsertVals != "" ? ",@mod" : "@mod";
                Program.DB.AddParameter("@mod", sDate);

                sInsertCols += sInsertCols != "" ? ",Entered" : "Entered";
                sInsertVals += sInsertVals != "" ? ",@ent" : "@ent";
                Program.DB.AddParameter("@ent", sDate);

                iID = Program.DB.Insert("INSERT INTO Contacts (" + sInsertCols + ") VALUES (" + sInsertVals + ")");
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
            else
            {
                SharedData.iContactID = Convert.ToInt32(cbxContacts.SelectedValue);
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
