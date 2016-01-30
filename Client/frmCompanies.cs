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
    public partial class frmCompanies : MetroAppForm
    {
        public frmCompanies()
        {
            InitializeComponent();

            DataSet ds = Program.DB.SelectAll("SELECT ID,NameFirst,NameLast FROM Companies;");
            if (ds.Tables.Count > 0)
            {
                List<ComboItem> items = new List<ComboItem>();
                foreach (DataRow r in ds.Tables[0].Rows)
                {
                    items.Add(new ComboItem() { Text = r["Name"].ToString(), Value = Convert.ToInt32(r["ID"]) });
                }
                cbxCompanies.DataSource = items;
                cbxCompanies.DisplayMember = "Text";
                cbxCompanies.ValueMember = "Value";
                cbxCompanies.SelectedIndex = -1;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cbxCompanies.SelectedIndex = -1;
            txtName.Text = "";
            ActiveControl = txtName;
            txtName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a name to continue.", "Name", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            int iID = 0;
            if (cbxCompanies.SelectedIndex < 0)
            {
                string sDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string sInsertCols = "", sInsertVals = "";

                sInsertCols += sInsertCols != "" ? ",Name" : "Name";
                sInsertVals += sInsertVals != "" ? ",@name" : "@name";
                Program.DB.AddParameter("@name", txtName.Text.Trim());

                sInsertCols += sInsertCols != "" ? ",Modified" : "Modified";
                sInsertVals += sInsertVals != "" ? ",@mod" : "@mod";
                Program.DB.AddParameter("@mod", sDate);

                sInsertCols += sInsertCols != "" ? ",Entered" : "Entered";
                sInsertVals += sInsertVals != "" ? ",@ent" : "@ent";
                Program.DB.AddParameter("@ent", sDate);

                iID = Program.DB.Insert("INSERT INTO Companies (" + sInsertCols + ") VALUES (" + sInsertVals + ")");
                if (iID < 1)
                {
                    MessageBox.Show("The addition failed. Please try again.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("The addition was successful.", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SharedData.iCompanyID = iID;
                }
            }
            else
            {
                SharedData.iCompanyID = Convert.ToInt32(cbxCompanies.SelectedValue);
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
