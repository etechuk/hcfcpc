﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DevComponents.DotNetBar.Metro;
using DevComponents.DotNetBar.SuperGrid;

namespace Client
{
    public partial class frmBooking : MetroForm
    {
        #region Members

        string sNextIDFormat = "000000";
        int iNextID = 0;

        List<string> sDocuments = new List<string>();
        List<int> iRooms = new List<int>();

        GridRow rComment;

        #endregion

        #region Form

        public frmBooking()
        {
            InitializeComponent();

            Icon = Properties.Resources.logo;

            for (int i = 1; i < 201; i++)
            {
                cbxDelegates.Items.Add(i.ToString());
                cbxLunchAttendees.Items.Add(i.ToString());
            }

            DataSet ds = Program.DB.SelectAll("SELECT ID,Name FROM Companies;");
            if (ds.Tables.Count > 0)
            {
                AutoCompleteStringCollection asCompanies = new AutoCompleteStringCollection();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    asCompanies.Add(dr["Name"].ToString().Trim());
                }
                txtCompany.AutoCompleteCustomSource = asCompanies;
            }

            ds = Program.DB.SelectAll("SELECT ID,Name,IsZone FROM Rooms;");
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
                        tvRooms.Nodes.Add(dr["Name"].ToString().Replace("|", " - "));
                        tnRoot = tvRooms.Nodes[tvRooms.Nodes.Count - 1];
                        tnRoot.Tag = dr["ID"];
                    }
                    else if (dr["IsZone"] != DBNull.Value && dr["IsZone"].Equals("B"))
                    {
                        tvRooms.Nodes.Add(dr["Name"].ToString().Replace("|", " - "));
                        tvRooms.Nodes[tvRooms.Nodes.Count - 1].Tag = dr["ID"];
                    }
                    else
                    {
                        tnRoot.Nodes.Add(dr["Name"].ToString());
                        tnRoot.Nodes[tnRoot.Nodes.Count - 1].Tag = dr["ID"];
                    }
                }
            }

            if (SharedData.iBookingID > 0)
            {
                Text = "Edit Booking";

                //iNextID = SharedData.iBookingID;
                ds = Program.DB.SelectAll("SELECT ID,Job,BUser,BUserMod,BName,BCompany,BContact,BPhone,BEmail,BRoom,BRoomLayout,BDates,BTimes,BTimesAccess,BDelegates,BEquipment,BRefreshments,BRefreshmentsTimes,BLunch,BLunchMenu,BLunchNumber,BLunchTime,BLunchDiet,BComments,BInvoiceAddress,BInvoicePayment,BInvoiceOrder,Confirmed FROM Jobs WHERE ID=" + SharedData.iBookingID);
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    DataRow row = ds.Tables[0].Rows[0];
                    if (row.ItemArray.Length > 0)
                    {
                        iNextID = Convert.ToInt32(row["Job"]);

                        DataSet d;
                        if (row["BCompany"] != DBNull.Value && row["BCompany"].ToString().All(char.IsDigit))
                        {
                            d = Program.DB.SelectAll("SELECT Name FROM Companies WHERE ID=" + row["BCompany"].ToString() + ";");
                            if (d.Tables.Count > 0 && d.Tables[0].Rows.Count > 0)
                            {
                                txtCompany.Text = d.Tables[0].Rows[0]["Name"].ToString();
                            }
                        }

                        if (txtCompany.Text.Trim() != "" && row["BContact"] != DBNull.Value && row["BContact"].ToString().All(char.IsDigit))
                        {
                            AutoCompleteStringCollection asContacts = new AutoCompleteStringCollection();
                            Program.DB.AddParameter("Company", row["BCompany"].ToString());
                            d = Program.DB.SelectAll("SELECT ID,NameTitle,NameFirst,NameLast FROM Contacts WHERE Company=@Company;");
                            if (d.Tables.Count > 0 && d.Tables[0].Rows.Count > 0)
                            {
                                string sSelected = "";
                                foreach (DataRow r in d.Tables[0].Rows)
                                {
                                    asContacts.Add(r["NameFirst"].ToString() + " " + r["NameLast"].ToString());
                                    if (r["ID"] == row["BContact"])
                                    {
                                        sSelected = r["NameFirst"].ToString() + " " + r["NameLast"].ToString();
                                    }
                                }
                                txtContact.AutoCompleteCustomSource = asContacts;
                                txtContact.Text = sSelected;
                            }
                        }

                        txtPhone.Text = row["BPhone"].ToString();
                        txtEmail.Text = row["BEmail"].ToString();

                        if (row["BRoom"] != DBNull.Value && row["BRoom"].ToString() != "")
                        {
                            string[] sRooms = row["BRoom"].ToString().Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                            foreach (TreeNode n in tvRooms.Nodes)
                            {
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
                                if (sRooms.Contains(n.Tag.ToString()))
                                {
                                    n.Checked = true;
                                }
                            }
                            tvRooms.ExpandAll();
                            tvRooms.TopNode = tvRooms.Nodes[0];
                        }

                        txtLayout.Text = row["BRoomLayout"].ToString();
                        txtName.Text = row["BName"].ToString();

                        DateTime now = DateTime.Now;
                        int iYear = now.Year, iMonth = now.Month, iDay = now.Day;

                        string[] dates;
                        if (row["BDates"].ToString() != "")
                        {
                            dates = row["BDates"].ToString().Split('|');
                            if (dates.Length == 2)
                            {
                                string[] d1 = dates[0].Split('/');
                                iYear = Convert.ToInt32(d1[2].Substring(0, d1[2].IndexOf(' ')));
                                iMonth = Convert.ToInt32(d1[1]);
                                iDay = Convert.ToInt32(d1[0]);
                                dtDateFrom.Value = new DateTime(iYear, iMonth, iDay);

                                string[] d2 = dates[1].Split('/');
                                iYear = Convert.ToInt32(d2[2].Substring(0, d2[2].IndexOf(' ')));
                                iMonth = Convert.ToInt32(d2[1]);
                                iDay = Convert.ToInt32(d2[0]);
                                dtDateTo.Value = new DateTime(iYear, iMonth, iDay);
                            }
                        }

                        string[] sTimes = row["BTimes"].ToString().Split('|');
                        if (sTimes.Length == 2)
                        {
                            dtTimeFrom.Text = sTimes[0];
                            dtTimeTo.Text = sTimes[1];
                        }
                        else
                        {
                            dtTimeFrom.Text = "";
                            dtTimeTo.Text = "";
                        }

                        sTimes = row["BTimesAccess"].ToString().Split('|');
                        if (sTimes.Length == 2)
                        {
                            dtTimeAccessFrom.Text = sTimes[0];
                            dtTimeAccessTo.Text = sTimes[1];
                        }
                        else
                        {
                            dtTimeAccessFrom.Text = "";
                            dtTimeAccessTo.Text = "";
                        }

                        cbxDelegates.SelectedIndex = cbxDelegates.FindStringExact(row["BDelegates"].ToString());
                        txtEquipment.Text = row["BEquipment"].ToString();

                        if (row["BRefreshments"] != DBNull.Value && row["BRefreshments"].ToString() == "Y")
                        {
                            swRefreshments.Value = true;
                        }
                        else
                        {
                            swRefreshments.Value = false;
                        }
                        txtRefreshmentTimes.Text = row["BRefreshmentsTimes"].ToString();

                        if (row["BLunch"] != DBNull.Value && row["BLunch"].ToString() == "Y")
                        {
                            swLunch.Value = true;
                        }
                        else
                        {
                            swLunch.Value = false;
                        }
                        txtLunchMenu.Text = row["BLunchMenu"].ToString();

                        cbxLunchAttendees.SelectedIndex = cbxLunchAttendees.FindStringExact(row["BLunchNumber"].ToString());
                        dtLunchTime.Text = row["BLunchTime"].ToString().Length > 0 ? row["BLunchTime"].ToString() : "";
                        txtLunchDiet.Text = row["BLunchDiet"].ToString();

                        d = Program.DB.SelectAll("SELECT ID,Entered,UserID,Comment FROM Comments WHERE Job=" + iNextID + ";");
                        if (d.Tables.Count > 0 && d.Tables[0].Rows.Count > 0)
                        {
                            foreach (DataRow r in d.Tables[0].Rows)
                            {
                                string sUser = "";
                                if (r["UserID"] != DBNull.Value && r["UserID"].ToString() != "")
                                {
                                    DataSet du = Program.DB.SelectAll("SELECT NameFirst,NameLast FROM Users WHERE ID=" + r["UserID"].ToString() + ";");
                                    if (du.Tables.Count > 0 && du.Tables[0].Rows.Count > 0)
                                    {
                                        sUser = du.Tables[0].Rows[0]["NameFirst"].ToString() + " " + du.Tables[0].Rows[0]["NameFirst"].ToString();
                                    }
                                }

                                GridRow gr = new GridRow(new object[] { r["Entered"].ToString(), sUser, r["Comment"].ToString() });
                                gr.Tag = r["ID"];
                                gComments.PrimaryGrid.Rows.Add(gr);
                            }
                        }

                        txtInvoiceAddress.Text = row["BInvoiceAddress"].ToString();
                        foreach (DevComponents.Editors.ComboItem ci in cbxPaymentMethod.Items)
                        {
                            if (ci.Text == row["BInvoicePayment"].ToString())
                            {
                                cbxPaymentMethod.SelectedItem = ci;
                                break;
                            }
                        }
                        txtPurchaseOrder.Text = row["BInvoiceOrder"].ToString();

                        if (row["BUser"] != DBNull.Value && row["BUser"].ToString().All(char.IsDigit))
                        {
                            d = Program.DB.SelectAll("SELECT NameFirst,NameLast FROM Users WHERE ID=" + row["BUser"].ToString() + ";");
                            if (d.Tables.Count > 0 && d.Tables[0].Rows.Count == 1)
                            {
                                lblUsers.Text = "Added by: " + d.Tables[0].Rows[0]["NameFirst"].ToString() + " " + d.Tables[0].Rows[0]["NameLast"].ToString();
                                lblUsers.Visible = true;
                            }
                        }

                        if (row["BUserMod"] != DBNull.Value && row["BUserMod"].ToString().All(char.IsDigit))
                        {
                            d = Program.DB.SelectAll("SELECT NameFirst,NameLast FROM Users WHERE ID=" + row["BUserMod"].ToString() + ";");
                            if (d.Tables.Count > 0 && d.Tables[0].Rows.Count == 1)
                            {
                                lblUsers.Text += Environment.NewLine + "Last modified by: " + d.Tables[0].Rows[0]["NameFirst"].ToString() + " " + d.Tables[0].Rows[0]["NameLast"].ToString();
                                lblUsers.Visible = true;
                            }
                        }

                        Text = "Edit Booking: " + Convert.ToInt32(row["Job"]).ToString(sNextIDFormat);

                        Program.DB.AddParameter("Job", row["Job"]);
                        DataSet c = Program.DB.SelectAll("SELECT * FROM Comments WHERE Job=@Job;");
                        if (c.Tables.Count > 0 && c.Tables[0].Rows.Count > 0)
                        {
                            foreach (DataRow r in c.Tables[0].Rows)
                            {
                                string sUser = r["UserID"].ToString();
                                Program.DB.AddParameter("ID", r["UserID"]);
                                DataSet cu = Program.DB.SelectAll("SELECT NameFirst,NameLast FROM Users WHERE ID=@ID;");
                                if (cu.Tables.Count > 0 && cu.Tables[0].Rows.Count > 0)
                                {
                                    sUser = cu.Tables[0].Rows[0]["NameFirst"] + " " + cu.Tables[0].Rows[0]["NameFirst"];
                                }

                                GridRow cr = new GridRow(new object[] {
                                    r["Entered"].ToString(), sUser, r["Comment"].ToString()
                                });
                                cr.Tag = r["ID"];
                            }
                        }
                    }
                }

                string sPath = Properties.Settings.Default.PathToData + @"\Bookings\" + SharedData.iBookingID.ToString(sNextIDFormat);
                if (Directory.Exists(sPath))
                {
                    string[] sFiles = Directory.GetFiles(sPath);
                    foreach (string sFile in sFiles)
                    {
                        if (File.Exists(sFile))
                        {
                            FileInfo inf = new FileInfo(sFile);
                            ListViewItem i = new ListViewItem();
                            i.Tag = sFile;
                            i.Text = inf.Name;
                            lvDocuments.Items.Add(i);
                        }
                    }
                }
            }
            else
            {
                dtDateFrom.Value = SharedData.dtSelectedStart != DateTime.Today ? SharedData.dtSelectedStart : DateTime.Today;
                dtDateTo.Value = SharedData.dtSelectedFinish != DateTime.Today ? SharedData.dtSelectedFinish : DateTime.Today;

                if (SharedData.sBookingCompany != "")
                {
                    txtCompany.Text = SharedData.sBookingCompany;
                }
                if (SharedData.sBookingContact != "")
                {
                    txtContact.Text = SharedData.sBookingContact;
                }
                if (SharedData.sBookingEmail != "")
                {
                    txtEmail.Text = SharedData.sBookingEmail;
                }
                if (SharedData.sBookingPhone != "")
                {
                    txtPhone.Text = SharedData.sBookingEmail;
                }
                if (SharedData.sBookingRooms != "")
                {
                    string[] sRooms = SharedData.sBookingRooms.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (TreeNode n in tvRooms.Nodes)
                    {
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
                        if (sRooms.Contains(n.Tag.ToString()))
                        {
                            n.Checked = true;
                        }
                    }
                    tvRooms.ExpandAll();
                    tvRooms.TopNode = tvRooms.Nodes[0];
                }

                dtTimeFrom.Text = "08:30";
                dtTimeTo.Text = "16:30";
                dtTimeAccessFrom.Text = "08:00";
                dtTimeAccessTo.Text = "17:00";

                ds = Program.DB.SelectAll("SELECT MAX(Job) AS NextID FROM Jobs;");
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0]["NextID"] != DBNull.Value)
                {
                    iNextID = Convert.ToInt32(ds.Tables[0].Rows[0]["NextID"].ToString()) + 1;
                }
                else
                {
                    iNextID = 1;
                }

                foreach (TreeNode item in tvRooms.Nodes)
                {
                    item.Checked = false;
                }

                Text = "Add Booking: " + iNextID.ToString(sNextIDFormat);
            }
        }

        #endregion

        #region Changed

        private void txtCompany_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab) && txtCompany.Text.ToString().Length > 0)
            {
                Program.DB.AddParameter("Name", txtCompany.Text);
                DataSet ds = Program.DB.SelectAll("SELECT ID,NameFirst,NameLast FROM Contacts WHERE Company=@Name;");
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    AutoCompleteStringCollection asContacts = new AutoCompleteStringCollection();
                    foreach (DataRow r in ds.Tables[0].Rows)
                    {
                        asContacts.Add(r["NameFirst"].ToString() + " " + r["NameLast"].ToString());
                    }
                    txtContact.AutoCompleteCustomSource = asContacts;
                }
            }
        }

        private void dtDateFrom_ValueChanged(object sender, EventArgs e)
        {
            dtDateTo.Value = dtDateFrom.Value;
        }

        private void cbxContacts_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string sContact = txtContact.Text.Trim() != "" ? txtContact.Text.Trim() : "";
            if (sContact != "")
            {
                DataSet d, ds = Program.DB.SelectAll("SELECT Phones,Emails FROM Contacts WHERE ID=" + sContact + ";");
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    string[] sPhones = ds.Tables[0].Rows[0]["Phones"].ToString().Split(',');
                    string[] sEmails = ds.Tables[0].Rows[0]["Emails"].ToString().Split(',');
                    if (sPhones.Length > 0)
                    {
                        d = Program.DB.SelectAll("SELECT Number FROM Phones WHERE ID=" + sPhones[0] + ";");
                        if (d.Tables.Count > 0 && d.Tables[0].Rows.Count > 0)
                        {
                            txtPhone.Text = d.Tables[0].Rows[0]["Number"].ToString();
                        }
                    }
                    if (sEmails.Length > 0)
                    {
                        d = Program.DB.SelectAll("SELECT Address FROM Emails WHERE ID=" + sEmails[0] + ";");
                        if (d.Tables.Count > 0 && d.Tables[0].Rows.Count > 0)
                        {
                            txtEmail.Text = d.Tables[0].Rows[0]["Address"].ToString();
                        }
                    }
                }
            }
        }

        private void tvRooms_AfterCheck(object sender, TreeViewEventArgs e)
        {
            int iID = e.Node.Tag != null ? Convert.ToInt32(e.Node.Tag) : -1;
            if (e.Node.Checked && iID > -1)
            {
                iRooms.Add(iID);
            }
            else
            {
                if (iRooms.Contains(iID))
                {
                    iRooms.Remove(iID);
                }
            }
        }

        #endregion

        #region Clicked

        private void btnCompanies_Click(object sender, EventArgs e)
        {
            Form frmCompanies = new frmCompanies();
            DialogResult dlg = frmCompanies.ShowDialog();
            if (dlg == DialogResult.OK)
            {
                DataSet ds = Program.DB.SelectAll("SELECT ID,Name FROM Companies;");
                if (ds.Tables.Count > 0)
                {
                    AutoCompleteStringCollection asCompanies = new AutoCompleteStringCollection();
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        asCompanies.Add(dr["Name"].ToString().Trim());
                        if (Convert.ToInt32(dr["ID"]) == SharedData.iCompanyID)
                        {
                            txtCompany.Text = dr["Name"].ToString();
                        }
                    }
                    txtCompany.AutoCompleteCustomSource = asCompanies;
                }

                SharedData.iCompanyID = 0;
            }
        }

        private void btnContacts_Click(object sender, EventArgs e)
        {
            Form frmContacts = new frmContacts();
            DialogResult dlg = frmContacts.ShowDialog();
            if (dlg == DialogResult.OK && txtCompany.Text.Trim() != "")
            {
                Program.DB.AddParameter("Company", txtCompany.Text.Trim());
                DataSet ds = Program.DB.SelectAll("SELECT ID,NameFirst,NameLast FROM Contacts WHERE Company=@Company;");
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    AutoCompleteStringCollection asContacts = new AutoCompleteStringCollection();
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        asContacts.Add(dr["NameFirst"].ToString() + " " + dr["NameLast"].ToString());
                        if (Convert.ToInt32(dr["ID"]) == SharedData.iContactID)
                        {
                            txtContact.Text = dr["NameFirst"].ToString() + " " + dr["NameLast"].ToString();
                        }
                    }
                    txtContact.AutoCompleteCustomSource = asContacts;
                }

                SharedData.iContactID = 0;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int iNid = 1;
            DataSet ds = Program.DB.SelectAll("SELECT MAX(Job) AS NextID FROM Jobs;");
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0]["NextID"] != DBNull.Value)
            {
                iNid = Convert.ToInt32(ds.Tables[0].Rows[0]["NextID"]) + 1;
            }

            if (SharedData.iBookingID < 1 && iNextID != iNid)
            {
                DialogResult dlg = MessageBox.Show("The booking number has changed. The\nbooking number will now be " + iNextID.ToString(sNextIDFormat) + ".\n\nIs this okay?", "Booking number changed", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg != DialogResult.Yes)
                {
                    dlg = MessageBox.Show("You chose not to accept the new booking number.\n\nDo you want to continue the addition?", "Booking number changed", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dlg != DialogResult.Yes)
                    {
                        Close();
                    }
                    else
                    {
                        iNextID = iNid;
                        Text = "Booking: " + iNextID.ToString(sNextIDFormat);
                    }
                }
            }

            string sDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string sInsertCols = "", sInsertVals = "", sUpdateVals = "";

            int iCompany = 0, iContact = 0;

            sUpdateVals += "BName=@name";
            sInsertCols += "BName";
            sInsertVals += "@name";

            if (txtCompany.Text.Trim() != "")
            {
                sUpdateVals += ",BCompany=@company";
                sInsertCols += ",BCompany";
                sInsertVals += ",@company";
                Program.DB.AddParameter("Name", txtCompany.Text.Trim());
                DataSet d = Program.DB.SelectAll("SELECT ID FROM Companies WHERE Name=@Name;");
                if (d.Tables.Count > 0 && d.Tables[0].Rows.Count > 0)
                {
                    iCompany = Convert.ToInt32(d.Tables[0].Rows[0]["ID"]);
                }
            }

            if (txtContact.Text.Trim() != "")
            {
                sUpdateVals += ",BContact=@contact";
                sInsertCols += ",BContact";
                sInsertVals += ",@contact";
                string[] sName = txtContact.Text.Trim().Split(' ');
                Program.DB.AddParameter("NameFirst", sName[0]);
                Program.DB.AddParameter("NameLast", sName[1]);
                DataSet d = Program.DB.SelectAll("SELECT ID FROM Contacts WHERE NameFirst=@NameFirst AND NameLast=@NameLast;");
                if (d.Tables.Count > 0 && d.Tables[0].Rows.Count > 0)
                {
                    iContact = Convert.ToInt32(d.Tables[0].Rows[0]["ID"]);
                }
            }

            Program.DB.AddParameter("@name", txtName.Text.Trim());

            if (txtCompany.Text.Trim() != "")
            {
                Program.DB.AddParameter("@company", iCompany);
            }

            if (txtContact.Text.Trim() != "")
            {
                Program.DB.AddParameter("@contact", iContact);
            }

            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter an event name to continue.", "Contact name", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            if (iRooms.Count < 1)
            {
                MessageBox.Show("Please choose at least one room to continue.", "Rooms", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            if (txtPhone.Text.Trim() != "")
            {
                sUpdateVals += ",BPhone=@phone";
                sInsertCols += ",BPhone";
                sInsertVals += ",@phone";
                Program.DB.AddParameter("@phone", txtPhone.Text.Trim());
            }

            if (txtEmail.Text.Trim() != "")
            {
                sUpdateVals += ",BEmail=@email";
                sInsertCols += ",BEmail";
                sInsertVals += ",@email";
                Program.DB.AddParameter("@email", txtEmail.Text.Trim());
            }

            if (iRooms.Count > 0)
            {
                string sRooms = "";
                foreach (int iRoom in iRooms)
                {
                    sRooms += sRooms.Length > 0 ? "|" + iRoom.ToString() : iRoom.ToString();
                }
                sUpdateVals += ",BRoom=@room";
                sInsertCols += ",BRoom";
                sInsertVals += ",@room";
                Program.DB.AddParameter("@room", sRooms);
            }

            if (dtDateFrom.Value.ToString() != "" && dtDateTo.Value.ToString() != "")
            {
                sUpdateVals += ",BDates=@dates";
                sInsertCols += ",BDates";
                sInsertVals += ",@dates";
                Program.DB.AddParameter("@dates", dtDateFrom.Value + "|" + dtDateTo.Value);
            }

            if (dtTimeFrom.Value.ToString() != "" && dtTimeTo.Value.ToString() != "")
            {
                sUpdateVals += ",BTimes=@times";
                sInsertCols += ",BTimes";
                sInsertVals += ",@times";
                Program.DB.AddParameter("@times", dtTimeFrom.Value.ToString("HH:mm") + "|" + dtTimeTo.Value.ToString("HH:mm"));
            }

            if (dtTimeAccessFrom.Value.ToString() != "" && dtTimeAccessTo.Value.ToString() != "")
            {
                sUpdateVals += ",BTimesAccess=@access";
                sInsertCols += ",BTimesAccess";
                sInsertVals += ",@access";
                Program.DB.AddParameter("@access", dtTimeAccessFrom.Value.ToString("HH:mm") + "|" + dtTimeAccessTo.Value.ToString("HH:mm"));
            }

            if (cbxDelegates.SelectedItem != null)
            {
                sUpdateVals += ",BDelegates=@delegates";
                sInsertCols += ",BDelegates";
                sInsertVals += ",@delegates";
                Program.DB.AddParameter("@delegates", Convert.ToInt32(cbxDelegates.SelectedItem.ToString()));
            }

            if (txtEquipment.Text.Trim() != "")
            {
                sUpdateVals += ",BEquipment=@equipment";
                sInsertCols += ",BEquipment";
                sInsertVals += ",@equipment";
                Program.DB.AddParameter("@equipment", txtEquipment.Text.Trim());
            }

            sUpdateVals += ",BRefreshments=@ref";
            sInsertCols += ",BRefreshments";
            sInsertVals += ",@ref";
            Program.DB.AddParameter("@ref", swRefreshments.Value == true ? "Y" : "N");

            if (txtRefreshmentTimes.Text.Trim() != "")
            {
                sUpdateVals += ",BRefreshmentsTimes=@reftimes";
                sInsertCols += ",BRefreshmentsTimes";
                sInsertVals += ",@reftimes";
                Program.DB.AddParameter("@reftimes", txtRefreshmentTimes.Text.Trim());
            }

            sUpdateVals += ",BLunch=@lunch";
            sInsertCols += ",BLunch";
            sInsertVals += ",@lunch";
            Program.DB.AddParameter("@lunch", swLunch.Value == true ? "Y" : "N");

            if (txtLunchMenu.Text.Trim() != "")
            {
                sUpdateVals += ",BLunchMenu=@lunchmenu";
                sInsertCols += ",BLunchMenu";
                sInsertVals += ",@lunchmenu";
                Program.DB.AddParameter("@lunchmenu", txtLunchMenu.Text.Trim());
            }

            if (cbxLunchAttendees.SelectedItem != null)
            {
                sUpdateVals += ",BLunchNumber=@lunchnum";
                sInsertCols += ",BLunchNumber";
                sInsertVals += ",@lunchnum";
                Program.DB.AddParameter("@lunchnum", Convert.ToInt32(cbxLunchAttendees.SelectedItem.ToString()));
            }

            if (dtLunchTime.Value.ToString() != "")
            {
                sUpdateVals += ",BLunchTime=@lunchtime";
                sInsertCols += ",BLunchTime";
                sInsertVals += ",@lunchtime";
                Program.DB.AddParameter("@lunchtime", dtLunchTime.Value.ToString());
            }

            if (txtLunchDiet.Text.Trim() != "")
            {
                sUpdateVals += ",BLunchDiet=@lunchdiet";
                sInsertCols += ",BLunchDiet";
                sInsertVals += ",@lunchdiet";
                Program.DB.AddParameter("@lunchdiet", txtLunchDiet.Text.Trim());
            }

            if (txtInvoiceAddress.Text.Trim() != "")
            {
                sUpdateVals += ",BInvoiceAddress=@invoiceaddress";
                sInsertCols += ",BInvoiceAddress";
                sInsertVals += ",@invoiceaddress";
                Program.DB.AddParameter("@invoiceaddress", txtInvoiceAddress.Text.Trim());
            }

            string sPayment = cbxPaymentMethod.SelectedItem != null ? cbxPaymentMethod.SelectedItem.ToString() : "";
            if (sPayment != "")
            {
                sUpdateVals += ",BInvoicePayment=@payment";
                sInsertCols += ",BInvoicePayment";
                sInsertVals += ",@payment";
                Program.DB.AddParameter("@payment", sPayment);
            }

            if (txtPurchaseOrder.Text.Trim() != "")
            {
                sUpdateVals += ",BInvoiceOrder=@invoicepo";
                sInsertCols += ",BInvoiceOrder";
                sInsertVals += ",@invoicepo";
                Program.DB.AddParameter("@invoicepo", txtPurchaseOrder.Text.Trim());
            }

            sUpdateVals += ",Confirmed=@confirmed";
            sInsertCols += ",Confirmed";
            sInsertVals += ",@confirmed";
            Program.DB.AddParameter("@confirmed", "Y");

            sUpdateVals += ",BModified=@mod";
            sInsertCols += ",BModified";
            sInsertVals += ",@mod";
            Program.DB.AddParameter("@mod", sDate);

            bool bFilesExist = false;

            if (SharedData.iBookingID < 1)
            {
                sInsertCols += ",Job";
                sInsertVals += ",@job";
                Program.DB.AddParameter("@job", iNextID);

                sInsertCols += ",BUser";
                sInsertVals += ",@user";
                Program.DB.AddParameter("@user", Program.Global.UserID);

                sInsertCols += ",BEntered";
                sInsertVals += ",@ent";
                Program.DB.AddParameter("@ent", sDate);

                int iID = Program.DB.Insert("INSERT INTO Jobs (" + sInsertCols + ") VALUES (" + sInsertVals + ")");
                if (iID < 1)
                {
                    MessageBox.Show("The addition failed. Please try again.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SharedData.iBookingID = iID;

                if (sDocuments.Count > 0)
                {
                    string sPath = Properties.Settings.Default.PathToData + @"\Bookings\" + iID.ToString(sNextIDFormat);
                    if (!Directory.Exists(sPath))
                    {
                        Directory.CreateDirectory(sPath);
                        if (!Directory.Exists(sPath))
                        {
                            MessageBox.Show("The default location for linked documents\ncould't be created. Please make sure the folder\nis writable, or change the location in the\nsettings, and try again.", "Permissions", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        foreach (string sFile in sDocuments)
                        {
                            bFilesExist = false;
                            FileInfo inf = new FileInfo(sFile);
                            if (File.Exists(sPath + @"\" + inf.Name))
                            {
                                DialogResult msg = MessageBox.Show("'" + inf.Name + "' already exists.\n\nWould you like to overwrite?", "File exists", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (msg == DialogResult.Yes)
                                {
                                    bFilesExist = true;
                                }
                            }
                            if (bFilesExist)
                            {
                                File.Copy(sFile, sPath + @"\" + inf.Name, true);
                            }
                            else
                            {
                                File.Copy(sFile, sPath + @"\" + inf.Name, false);
                            }
                        }
                    }
                }

                MessageBox.Show("The addition was successful.", "Added", (MessageBoxButtons.OK), (MessageBoxIcon.Information));
            }
            else
            {
                int iID = Program.DB.Update("UPDATE Jobs SET " + sUpdateVals + " WHERE ID=" + SharedData.iBookingID);
                if (iID < 1)
                {
                    MessageBox.Show("The update failed. Please try again.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (sDocuments.Count > 0)
                {
                    string sPath = Properties.Settings.Default.PathToData + @"\Bookings\" + iID.ToString(sNextIDFormat);
                    if (!Directory.Exists(sPath))
                    {
                        Directory.CreateDirectory(sPath);
                        if (!Directory.Exists(sPath))
                        {
                            MessageBox.Show("The default location for linked documents\ncould't be created. Please make sure the folder\nis writable, or change the location in the\nsettings, and try again.", "Permissions", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        foreach (string sFile in sDocuments)
                        {
                            bFilesExist = false;
                            FileInfo inf = new FileInfo(sFile);
                            if (File.Exists(sPath + @"\" + inf.Name))
                            {
                                DialogResult msg = MessageBox.Show("'" + inf.Name + "' already exists.\n\nWould you like to overwrite?", "File exists", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (msg == DialogResult.Yes)
                                {
                                    bFilesExist = true;
                                }
                            }
                            if (bFilesExist)
                            {
                                File.Copy(sFile, sPath + @"\" + inf.Name, true);
                            }
                            else
                            {
                                File.Copy(sFile, sPath + @"\" + inf.Name, false);
                            }
                        }
                    }
                }

                MessageBox.Show("The update was successful.", "Updated", (MessageBoxButtons.OK), (MessageBoxIcon.Information));
            }

            if (gComments.PrimaryGrid.Rows.Count > 0)
            {
                foreach (GridRow r in gComments.PrimaryGrid.Rows)
                {
                    if (r.Tag != null && r.Tag.ToString() != "")
                    {
                        DataSet d = Program.DB.SelectAll("SELECT ID FROM Comments WHERE ID=" + r.Tag.ToString() + ";");
                        if (d.Tables.Count > 0 && d.Tables[0].Rows.Count > 0)
                        {
                            Program.DB.AddParameter("Comment", r.Cells[2].Value.ToString());
                            Program.DB.AddParameter("Modified", DateTime.Now);
                            int iCID = Program.DB.Update("UPDATE Comments SET Comment=@Comment,Modified=@Modified WHERE ID=" + r.Tag.ToString() + ";");
                        }
                    }
                    else
                    {
                        Program.DB.AddParameter("Job", iNextID);
                        Program.DB.AddParameter("UserID", Program.Global.UserID);
                        Program.DB.AddParameter("Comment", r.Cells[2].Value.ToString());
                        Program.DB.AddParameter("Entered", DateTime.Now);
                        Program.DB.AddParameter("Modified", DateTime.Now);
                        int iCID = Program.DB.Update("INSERT INTO Comments (Job,UserID,Comment,Entered,Modified) VALUES (@Job,@UserID,@Comment,@Entered,@Modified)");
                    }
                }
            }

            SharedData.dSchedule.Clear();
            SharedData.dSchedule.Add("name", txtName.Text.Trim());
            SharedData.dSchedule.Add("dates", dtDateFrom.Value.ToString() != "" && dtDateTo.Value.ToString() != "" ? dtDateFrom.Value + "|" + dtDateTo.Value : "");
            SharedData.dSchedule.Add("times", dtTimeFrom.Value.ToString() != null && dtTimeTo.Value.ToString() != null ? dtTimeFrom.Value.ToString() + "|" + dtTimeTo.Value.ToString() : "");

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnDocumentAdd_Click(object sender, EventArgs e)
        {
            DialogResult dlg = ofd.ShowDialog();
            if (dlg == DialogResult.OK)
            {
                FileInfo inf = new FileInfo(ofd.FileName);
                bool bHasItem = false;
                foreach (ListViewItem doc in lvDocuments.Items)
                {
                    if (inf.Name == doc.Text)
                    {
                        bHasItem = true;
                        break;
                    }
                }
                if (bHasItem)
                {
                    MessageBox.Show("The file already exists in the list.", "Exists", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                lvDocuments.Items.Add(inf.Name);
                sDocuments.Add(ofd.FileName);
            }
        }

        #endregion

        private void lvDocuments_ItemActivate(object sender, EventArgs e)
        {
            string sRegdApp, sFile = lvDocuments.SelectedItems[0].Tag.ToString();
            if (sFile.Length > 0)
            {
                FileInfo inf = new FileInfo(sFile);
                bool bAppExists = Program.Utils.TryRegisteredApplication(inf.Extension, out sRegdApp);
                if (bAppExists)
                {
                    System.Diagnostics.Process.Start(sFile);
                }
            }
        }

        private void gComments_RowActivated(object sender, GridRowActivatedEventArgs e)
        {
            rComment = e.NewActiveRow as GridRow;
        }

        private void gComments_RowClick(object sender, GridRowClickEventArgs e)
        {
            if (e.MouseEventArgs.Button == MouseButtons.Right)
            {
                Point pos = gComments.PointToClient(Cursor.Position);
                mComments.Show(gComments, pos);
            }
            else if (e.MouseEventArgs.Button == MouseButtons.Left)
            {
                if (rComment != null && e.MouseEventArgs.Button == MouseButtons.Left)
                {
                    txtComment.Text = rComment.Cells[2].Value.ToString();
                }
            }
        }

        private void gComments_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Point pos = gComments.PointToClient(Cursor.Position);
                mComments.Show(gComments, pos);
            }
        }

        private void mCommentsAdd_Click(object sender, EventArgs e)
        {
            rComment = null;
            txtComment.Text = "";
            txtComment.Enabled = true;
            gComments.Enabled = false;
            btnCommentSave.Enabled = true;
            btnCommentCancel.Enabled = true;
        }

        private void btnCommentSave_Click(object sender, EventArgs e)
        {
            if (txtComment.Text.Trim().Length > 0)
            {
                if (rComment != null && rComment.Tag.ToString() != "")
                {
                    rComment.Cells[2].Value = txtComment.Text.Trim();
                    gComments.PrimaryGrid.Rows[rComment.Index] = rComment;
                }
                else
                {
                    GridRow r = new GridRow(new object[] {
                        DateTime.Now.ToString(), Program.Global.UserFirstName + " " + Program.Global.UserLastName, txtComment.Text.Trim()
                    });
                    gComments.PrimaryGrid.Rows.Add(r);
                }
            }

            rComment = null;
            txtComment.Text = "";
            txtComment.Enabled = false;
            btnCommentSave.Enabled = false;
            btnCommentCancel.Enabled = false;
            gComments.Enabled = true;
        }

        private void btnCommentCancel_Click(object sender, EventArgs e)
        {
            rComment = null;
            txtComment.Text = "";
            txtComment.Enabled = false;
            btnCommentSave.Enabled = false;
            btnCommentCancel.Enabled = false;
            gComments.Enabled = true;
        }
    }
}
