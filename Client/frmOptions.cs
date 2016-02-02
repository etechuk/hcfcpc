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
    public partial class frmOptions : MetroForm
    {
        public frmOptions()
        {
            InitializeComponent();

            cbxDefaultView.SelectedIndex = 2;

            if (Properties.Settings.Default.PathToData != "")
            {
                txtPathData.Text = Properties.Settings.Default.PathToData;
            }
            if (Properties.Settings.Default.DefaultView > -1)
            {
                cbxDefaultView.SelectedIndex = Properties.Settings.Default.DefaultView;
            }
            if (Properties.Settings.Default.StartMaximised == true)
            {
                chkMaximised.Checked = true;
            }
        }

        private void btnPathDataFind_Click(object sender, EventArgs e)
        {
            DialogResult dlg = fbd.ShowDialog();
            if (dlg == DialogResult.OK && fbd.SelectedPath.Trim().Length > 0)
            {
                txtPathData.Text = fbd.SelectedPath.Trim();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.PathToData = txtPathData.Text;
            Properties.Settings.Default.DefaultView = cbxDefaultView.SelectedIndex;
            Properties.Settings.Default.StartMaximised = chkMaximised.Checked;
            Properties.Settings.Default.Save();
            Close();
        }
    }
}
