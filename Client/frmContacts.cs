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
                AutoCompleteStringCollection asContacts = new AutoCompleteStringCollection();
                foreach (DataRow r in ds.Tables[0].Rows)
                {
                    string sName = r["NameLast"].ToString() + (r["NameFirst"].ToString() != "" ? ", " + r["NameFirst"].ToString() : "");
                    asContacts.Add(sName);
                }
                txtContacts.AutoCompleteCustomSource = asContacts;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtContacts.Text = "";
            txtCompanies.Text = "";
            txtNameFirst.Text = "";
            txtNameLast.Text = "";
            ActiveControl = txtNameFirst;
            txtNameFirst.Focus();
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

            if (txtCompanies.Text.Trim().Length > 0)
            {
                Program.DB.AddParameter("Name", txtCompanies.Text.Trim());
                DataSet ds = Program.DB.SelectAll("SELECT ID FROM Companies WHERE Name=@Name;");
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    SharedData.iCompanyID = Convert.ToInt32(ds.Tables[0].Rows[0]["ID"]);
                }
            }

            int iID = 0;
            if (txtContacts.Text.Trim().Length == 0)
            {
                string sDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string sInsertCols = "", sInsertVals = "";

                sInsertCols += sInsertCols != "" ? ",NameFirst" : "NameFirst";
                sInsertVals += sInsertVals != "" ? ",@fname" : "@fname";
                Program.DB.AddParameter("@fname", txtNameFirst.Text.Trim());

                sInsertCols += sInsertCols != "" ? ",NameLast" : "NameLast";
                sInsertVals += sInsertVals != "" ? ",@lname" : "@lname";
                Program.DB.AddParameter("@lname", txtNameLast.Text.Trim());

                if (SharedData.iCompanyID > 0)
                {
                    sInsertCols += sInsertCols != "" ? ",Company" : "Company";
                    sInsertVals += sInsertVals != "" ? ",@company" : "@company";
                    Program.DB.AddParameter("@company", SharedData.iCompanyID);
                }

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
                Program.DB.AddParameter("NameFirst", txtNameFirst.Text.Trim());
                Program.DB.AddParameter("NameLast", txtNameLast.Text.Trim());
                DataSet d = Program.DB.SelectAll("SELECT ID FROM Contacts WHERE NameFirst=@NameFirst AND NameLast=@NameLast;");
                if (d.Tables.Count > 0 && d.Tables[0].Rows.Count > 0)
                {
                    SharedData.iContactID = Convert.ToInt32(d.Tables[0].Rows[0]["ID"]);
                }
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void txtNameFirst_TextChanged(object sender, EventArgs e)
        {
            txtContacts.Text = "";
        }

        private void txtNameLast_TextChanged(object sender, EventArgs e)
        {
            txtContacts.Text = "";
        }
    }
}
