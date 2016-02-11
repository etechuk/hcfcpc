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
    public partial class frmRooms : MetroForm
    {
        TreeNode nSelected;

        public frmRooms()
        {
            InitializeComponent();

            Icon = Properties.Resources.logo;

            DataSet ds = Program.DB.SelectAll("SELECT ID,Name,IsZone FROM Rooms;");
            Dictionary<int, string> zones = new Dictionary<int, string>();
            if (ds.Tables.Count > 0)
            {
                TreeNode tnRoot = new TreeNode();

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    if (dr["IsZone"] != DBNull.Value && dr["IsZone"].Equals("Y"))
                    {
                        zones.Add(Convert.ToInt32(dr["ID"]), dr["Name"].ToString());
                    }
                }

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    if (dr["IsZone"] != DBNull.Value && dr["IsZone"].Equals("Y"))
                    {
                        tv.Nodes.Add(dr["Name"].ToString().Replace("|", " - "));
                        tnRoot = tv.Nodes[tv.Nodes.Count - 1];
                        tnRoot.Tag = dr["ID"];
                    }
                    else if (dr["IsZone"] != DBNull.Value && dr["IsZone"].Equals("B"))
                    {
                        tv.Nodes.Add(dr["Name"].ToString().Replace("|", " - "));
                        tv.Nodes[tv.Nodes.Count - 1].Tag = dr["ID"];
                    }
                    else
                    {
                        tnRoot.Nodes.Add(dr["Name"].ToString());
                        tnRoot.Nodes[tnRoot.Nodes.Count - 1].Tag = dr["ID"];
                    }
                }
            }

            tv.ExpandAll();
        }

        private void tv_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            nSelected = e.Node;

            if (e.Node.Tag != null && e.Node.Tag.ToString() != "")
            {
                DataSet d = Program.DB.SelectAll("SELECT Name,IsZone FROM Rooms WHERE ID=" + e.Node.Tag.ToString() + ";");
                if (d.Tables.Count > 0 && d.Tables[0].Rows.Count > 0)
                {
                    txtName.Text = d.Tables[0].Rows[0]["Name"].ToString();
                }
            }
        }

        private void tv_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            txtName.Enabled = true;
            btnCancel.Enabled = true;
            btnSave.Enabled = true;
            btnClose.Enabled = false;
            btnSaveAll.Enabled = false;
            tv.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtName.Enabled = false;
            btnCancel.Enabled = false;
            btnSave.Enabled = false;
            btnClose.Enabled = true;
            btnSaveAll.Enabled = true;
            tv.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            nSelected.Text = txtName.Text;
            txtName.Text = "";
            txtName.Enabled = false;
            btnCancel.Enabled = false;
            btnSave.Enabled = false;
            btnClose.Enabled = true;
            btnSaveAll.Enabled = true;
            tv.Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            if (tv.Nodes.Count > 0)
            {
                foreach (TreeNode n in tv.Nodes)
                {
                    Program.DB.AddParameter("ID", n.Tag);
                    Program.DB.AddParameter("Name", n.Text);
                    int i = Program.DB.Update("UPDATE Rooms SET Name=@Name WHERE ID=@ID;");

                    if (n.Nodes.Count > 0)
                    {
                        foreach (TreeNode nc in n.Nodes)
                        {
                            Program.DB.AddParameter("ID", nc.Tag);
                            Program.DB.AddParameter("Name", nc.Text);
                            int ic = Program.DB.Update("UPDATE Rooms SET Name=@Name WHERE ID=@ID;");
                        }
                    }
                }
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
