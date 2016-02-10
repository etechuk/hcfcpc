using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DevComponents.DotNetBar.Metro;
using DevComponents.DotNetBar.SuperGrid;

namespace Client
{
    public partial class frmGridViews : MetroForm
    {
        List<int> iRooms = new List<int>();
        GridRow row;
        int iID = 0;

        bool bDataChanged = false;
        bool bDateStartChosen = false;
        bool bDateFinishChosen = false;

        public frmGridViews()
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

            ds = Program.DB.SelectAll("SELECT * FROM WorkSheets;");
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    DateTime dtS = Convert.ToDateTime(dr["Start"].ToString()), dtF = Convert.ToDateTime(dr["Finish"].ToString());

                    GridRow r = new GridRow(new object[] {
                        dr["ID"].ToString(), dr["Name"].ToString(), dtS.Date.ToShortDateString(), dtF.Date.ToShortDateString()
                    });
                    r.Tag = dr["ID"];
                    g.PrimaryGrid.Rows.Add(r);
                }
            }
        }

        private void mAdd_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            dtFrom.Text = "";
            dtTo.Text = "";
            foreach (TreeNode n in tv.Nodes)
            {
                n.Checked = false;
            }
            txtName.Enabled = true;
            dtFrom.Enabled = true;
            dtTo.Enabled = true;
            tv.Enabled = true;
            btnCancel.Enabled = true;
            btnSave.Enabled = true;
            g.Enabled = false;
        }

        private void mRemove_Click(object sender, EventArgs e)
        {
            if (row != null && row.Tag != null && Convert.ToInt32(row.Tag) > 0)
            {
                Program.DB.AddParameter("ID", Convert.ToInt32(row.Tag));
                int i = Program.DB.Delete("DELETE FROM WorkSheets WHERE ID=@ID;");
                if (i < 1)
                {
                    MessageBox.Show("The removal failed. Please try again.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("The removal was successful.", "Updated", (MessageBoxButtons.OK), (MessageBoxIcon.Information));
                }

                g.PrimaryGrid.Rows.Clear();
                DataSet ds = Program.DB.SelectAll("SELECT * FROM WorkSheets;");
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        DateTime dtS = Convert.ToDateTime(dr["Start"].ToString()), dtF = Convert.ToDateTime(dr["Finish"].ToString());

                        GridRow r = new GridRow(new object[] {
                        dr["ID"].ToString(), dr["Name"].ToString(), dtS.Date.ToShortDateString(), dtF.Date.ToShortDateString()
                    });
                        r.Tag = dr["ID"];
                        g.PrimaryGrid.Rows.Add(r);
                    }
                }

                bDataChanged = true;
            }
        }

        private void g_RowActivated(object sender, GridRowActivatedEventArgs e)
        {
            row = e.NewActiveRow as GridRow;
        }

        private void g_RowClick(object sender, GridRowClickEventArgs e)
        {
            if (e.MouseEventArgs.Button == MouseButtons.Right)
            {
                Point pos = g.PointToClient(Cursor.Position);
                m.Show(g, pos);
            }
            else if (e.MouseEventArgs.Button == MouseButtons.Left)
            {
                if (e.GridRow.RowIndex > -1 && e.MouseEventArgs.Button == MouseButtons.Left)
                {
                    iID = Convert.ToInt32(g.PrimaryGrid.Rows[e.GridRow.RowIndex].Tag);

                    Program.DB.AddParameter("ID", iID);
                    DataSet d = Program.DB.SelectAll("SELECT * FROM WorkSheets WHERE ID=@ID;");
                    if (d.Tables.Count > 0 && d.Tables[0].Rows.Count > 0)
                    {
                        DataRow r = d.Tables[0].Rows[0];

                        txtName.Text = r["Name"].ToString();
                        dtFrom.Text = Convert.ToDateTime(r["Start"].ToString()).ToShortDateString();
                        dtTo.Text = Convert.ToDateTime(r["Finish"].ToString()).ToShortDateString();

                        string[] sRooms = r["Rooms"].ToString().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                        foreach (TreeNode n in tv.Nodes)
                        {
                            if (sRooms.Contains(n.Tag.ToString()))
                            {
                                n.Checked = true;
                                if (n.Nodes.Count > 0)
                                {
                                    foreach (TreeNode nc in n.Nodes)
                                    {
                                        if (sRooms.Contains(nc.Tag.ToString()))
                                        {
                                            nc.Checked = true;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                n.Checked = false;
                                if (n.Nodes.Count > 0)
                                {
                                    foreach (TreeNode nc in n.Nodes)
                                    {
                                        nc.Checked = false;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void g_RowDoubleClick(object sender, GridRowDoubleClickEventArgs e)
        {
            txtName.Enabled = true;
            dtFrom.Enabled = true;
            dtTo.Enabled = true;
            tv.Enabled = true;
            btnCancel.Enabled = true;
            btnSave.Enabled = true;
            bDateStartChosen = false;
            bDateFinishChosen = false;
            g.Enabled = false;
            bDateFinishChosen = true;
            bDateStartChosen = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            dtFrom.Text = "";
            dtTo.Text = "";
            foreach (TreeNode n in tv.Nodes)
            {
                n.Checked = false;
            }
            txtName.Enabled = false;
            dtFrom.Enabled = false;
            dtTo.Enabled = false;
            tv.Enabled = false;
            btnCancel.Enabled = false;
            btnSave.Enabled = false;
            bDateStartChosen = false;
            bDateFinishChosen = false;
            g.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int i;

            if (txtName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter a grid view name to continue.", "Grid View Name", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            else if (!bDateStartChosen)
            {
                MessageBox.Show("Please select a start date to continue.", "Start Date", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            else if (!bDateFinishChosen)
            {
                MessageBox.Show("Please select a finish date to continue.", "Finish Date", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            string sRooms = "";
            int iRooms = 0;
            foreach (TreeNode n in tv.Nodes)
            {
                if (n.Checked && n.Nodes.Count > 0)
                {
                    sRooms += sRooms.Length > 0 ? "," + n.Tag : n.Tag;
                    iRooms++;

                    foreach (TreeNode nc in n.Nodes)
                    {
                        if (nc.Checked)
                        {
                            sRooms += sRooms.Length > 0 ? "," + nc.Tag : nc.Tag;
                            iRooms++;
                        }
                    }
                }
                else if (n.Checked)
                {
                    sRooms += sRooms.Length > 0 ? "," + n.Tag : n.Tag;
                    iRooms++;
                }
            }

            if (iRooms == 0)
            {
                MessageBox.Show("Please choose some rooms to continue.", "Rooms", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            Program.DB.AddParameter("Name", txtName.Text);
            Program.DB.AddParameter("Start", Convert.ToDateTime(dtFrom.Text));
            Program.DB.AddParameter("Finish", Convert.ToDateTime(dtTo.Text));
            Program.DB.AddParameter("Rooms", sRooms);

            if (iID > 0)
            {
                Program.DB.AddParameter("ID", iID);
                i = Program.DB.Update("UPDATE WorkSheets SET Name=@Name,Rooms=@Rooms,Start=@Start,Finish=@Finish WHERE ID=@ID;");
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
                i = Program.DB.Insert("INSERT INTO WorkSheets (Name,Rooms,Start,Finish) VALUES (@Name,@Rooms,@Start,@Finish)");
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
            txtName.Enabled = false;
            dtFrom.Enabled = false;
            dtTo.Enabled = false;
            tv.Enabled = false;
            btnCancel.Enabled = false;
            btnSave.Enabled = false;
            bDateStartChosen = false;
            bDateFinishChosen = false;
            g.Enabled = true;

            g.PrimaryGrid.Rows.Clear();
            DataSet ds = Program.DB.SelectAll("SELECT * FROM WorkSheets;");
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    DateTime dtS = Convert.ToDateTime(dr["Start"].ToString()), dtF = Convert.ToDateTime(dr["Finish"].ToString());

                    GridRow r = new GridRow(new object[] {
                        dr["ID"].ToString(), dr["Name"].ToString(), dtS.Date.ToShortDateString(), dtF.Date.ToShortDateString()
                    });
                    r.Tag = dr["ID"];
                    g.PrimaryGrid.Rows.Add(r);
                }
            }

            bDataChanged = true;
        }

        private void dtFrom_Enter(object sender, EventArgs e)
        {
            bDateStartChosen = true;
        }

        private void dtTo_Enter(object sender, EventArgs e)
        {
            bDateFinishChosen = true;
        }

        private void frmGridViews_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bDataChanged)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}
