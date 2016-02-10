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

            Icon = Properties.Resources.logo;

            DataSet ds = Program.DB.SelectAll("SELECT ID,Name FROM Companies;");
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow r in ds.Tables[0].Rows)
                {
                    DevComponents.Editors.ComboItem i = new DevComponents.Editors.ComboItem();
                    i.Tag = r["ID"];
                    i.Text = r["Name"].ToString();
                    cbxCompany.Items.Add(i);
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
            if (cbxCompany.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter a name to continue.", "Name", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            if (cbxCompany.SelectedIndex > -1)
            {
                DevComponents.Editors.ComboItem i = (DevComponents.Editors.ComboItem)cbxCompany.SelectedItem;
                SharedData.iCompanyID = Convert.ToInt32(i.Tag);
            }
            else
            {
                string sDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                Program.DB.AddParameter("Name", cbxCompany.Text.Trim());
                Program.DB.AddParameter("Entered", sDate);
                Program.DB.AddParameter("Modified", sDate);

                int iID = Program.DB.Insert("INSERT INTO Companies (Name,Entered,Modified) VALUES (@Name,@Entered,@Modified)");
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

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
