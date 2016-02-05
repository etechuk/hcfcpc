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
    public partial class frmCompanies : MetroForm
    {
        public frmCompanies()
        {
            InitializeComponent();

            DataSet ds = Program.DB.SelectAll("SELECT ID,Name FROM Companies;");
            if (ds.Tables.Count > 0)
            {
                AutoCompleteStringCollection asCompanies = new AutoCompleteStringCollection();
                foreach (DataRow r in ds.Tables[0].Rows)
                {
                    asCompanies.Add(r["Name"].ToString());
                }
                txtCompany.AutoCompleteCustomSource = asCompanies;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtCompany.Text = "";
            txtCompany.Text = "";
            ActiveControl = txtCompany;
            txtCompany.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCompany.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a name to continue.", "Name", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            int iID = 0;
            if (txtCompany.Text.Trim().Length == 0)
            {
                string sDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string sInsertCols = "", sInsertVals = "";

                sInsertCols += sInsertCols != "" ? ",Name" : "Name";
                sInsertVals += sInsertVals != "" ? ",@name" : "@name";
                Program.DB.AddParameter("@name", txtCompany.Text.Trim());

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
                Program.DB.AddParameter("Name", txtCompany.Text.Trim());
                DataSet ds = Program.DB.SelectAll("SELECT ID,NameFirst,NameLast FROM Companies WHERE Name=@Name;");
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    SharedData.iCompanyID = Convert.ToInt32(ds.Tables[0].Rows[0]["ID"]);
                }
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
