using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DevComponents.DotNetBar.Metro;

namespace Client
{
    public partial class frmBooking : MetroAppForm
    {
        #region Members

        string sNextIDFormat = "000000";
        int iNextID = 0;

        List<string> sDocuments = new List<string>();

        #endregion

        public frmBooking()
        {
            InitializeComponent();

            for (int i = 1; i < 201; i++)
            {
                cbxDelegates.Items.Add(i.ToString());
                cbxLunchAttendees.Items.Add(i.ToString());
            }

            DataSet ds = Program.DB.SelectAll("SELECT ID,Name FROM Companies;");
            if (ds.Tables.Count > 0)
            {
                List<ComboItem> items = new List<ComboItem>() { new ComboItem() { Text = "", Value = -1 } };
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    items.Add(new ComboItem() { Text = dr["Name"].ToString().Trim(), Value = Convert.ToInt32(dr["ID"]) });
                }
                cbxCompanies.DataSource = items;
                cbxCompanies.DisplayMember = "Text";
                cbxCompanies.ValueMember = "Value";
            }

            ds = Program.DB.SelectAll("SELECT ID,Name,IsZone FROM Rooms;");
            Dictionary<int, string> zones = new Dictionary<int, string>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    if (dr["IsZone"] != DBNull.Value && dr["IsZone"].Equals("Y"))
                    {
                        zones.Add(Convert.ToInt32(dr["ID"]), dr["Name"].ToString());
                    }
                }

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    string sZone = "";
                    foreach (KeyValuePair<int, string> zone in zones)
                    {
                        if (dr["Name"] != DBNull.Value && Convert.ToInt32(dr["ID"]) == zone.Key)
                        {
                            sZone = zone.Value.Replace("|", " - ") + " - ";
                            break;
                        }
                    }

                    string sRoom = sZone + dr["Name"].ToString();
                    lvRooms.Items.Add(sRoom);
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
                        if (row["BCompany"] != DBNull.Value && row["BCompany"].ToString().All(char.IsDigit))
                        {
                            foreach (ComboItem item in cbxCompanies.Items)
                            {
                                if (item.Value == Convert.ToInt32(row["BCompany"].ToString()))
                                {
                                    cbxCompanies.SelectedItem = item;
                                    break;
                                }
                            }
                        }

                        if (cbxCompanies.SelectedIndex > -1 && row["BContact"] != DBNull.Value && row["BContact"].ToString().All(char.IsDigit))
                        {
                            DataSet d = Program.DB.SelectAll("SELECT ID,NameTitle,NameFirst,NameLast FROM Contacts WHERE Company='" + row["BCompany"].ToString() + "'");
                            if (d.Tables.Count > 0 && d.Tables[0].Rows.Count > 0)
                            {
                                cbxContacts.Items.Clear();
                                List<ComboItem> items = new List<ComboItem>();
                                foreach (DataRow r in d.Tables[0].Rows)
                                {
                                    items.Add(new ComboItem() { Text = (r["NameLast"].ToString() + ", " + r["NameFirst"].ToString()).Trim(), Value = Convert.ToInt32(r["ID"]) });
                                }
                                cbxContacts.DataSource = items;
                                cbxContacts.DisplayMember = "Text";
                                cbxContacts.ValueMember = "Value";
                            }
                            foreach (ComboItem item in cbxContacts.Items)
                            {
                                if (item.Value == Convert.ToInt32(row["BContact"].ToString()))
                                {
                                    cbxContacts.SelectedItem = item;
                                    break;
                                }
                            }
                        }

                        txtPhone.Text = row["BPhone"].ToString();
                        txtEmail.Text = row["BEmail"].ToString();

                        if (row["BRoom"] != DBNull.Value && row["BRoom"].ToString() != "")
                        {
                            string[] sRooms = row["BRoom"].ToString().Split('|');
                            foreach (ListViewItem item in lvRooms.Items)
                            {
                                foreach (string sRoom in sRooms)
                                {
                                    if (item.Name == sRoom)
                                    {
                                        item.Checked = true;
                                    }
                                }
                            }
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

                        sTimes = row["BTimesAccess"].ToString().Split('|');
                        if (sTimes.Length == 2)
                        {
                            dtTimeAccessFrom.Text = sTimes[0];
                            dtTimeAccessTo.Text = sTimes[1];
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
                        dtLunchTime.Text = row["BLunchTime"].ToString();
                        txtLunchDiet.Text = row["BLunchDiet"].ToString();
                        txtComments.Text = row["BComments"].ToString();

                        txtInvoiceAddress.Text = row["BInvoiceAddress"].ToString();
                        cbxPaymentMethod.SelectedItem = cbxPaymentMethod.FindStringExact(row["BInvoicePayment"].ToString());
                        txtPurchaseOrder.Text = row["BInvoiceOrder"].ToString();

                        if (row["BUser"] != DBNull.Value && row["BUser"].ToString().All(char.IsDigit))
                        {
                            DataSet d = Program.DB.SelectAll("SELECT NameFirst,NameLast FROM Users WHERE ID=" + row["BUser"].ToString() + ";");
                            if (d.Tables.Count > 0 && d.Tables[0].Rows.Count == 1)
                            {
                                lblUsers.Text = "Added by: " + d.Tables[0].Rows[0]["NameFirst"].ToString() + " " + d.Tables[0].Rows[0]["NameLast"].ToString();
                                lblUsers.Visible = true;
                            }
                        }

                        if (row["BUserMod"] != DBNull.Value && row["BUserMod"].ToString().All(char.IsDigit))
                        {
                            DataSet d = Program.DB.SelectAll("SELECT NameFirst,NameLast FROM Users WHERE ID=" + row["BUserMod"].ToString() + ";");
                            if (d.Tables.Count > 0 && d.Tables[0].Rows.Count == 1)
                            {
                                lblUsers.Text += Environment.NewLine + "Last modified by: " + d.Tables[0].Rows[0]["NameFirst"].ToString() + " " + d.Tables[0].Rows[0]["NameLast"].ToString();
                                lblUsers.Visible = true;
                            }
                        }

                        Text = "Edit Booking: " + Convert.ToInt32(row["Job"]).ToString(sNextIDFormat);
                    }
                }
            }
            else
            {
                dtDateFrom.Value = DateTime.Today;
                dtDateTo.Value = DateTime.Today;

                ds = Program.DB.SelectAll("SELECT MAX(Job) AS NextID FROM Jobs");
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0]["NextID"] != DBNull.Value)
                {
                    iNextID = Convert.ToInt32(ds.Tables[0].Rows[0]["NextID"].ToString()) + 1;
                }
                else
                {
                    iNextID = 1;
                }

                foreach (ListViewItem item in lvRooms.Items)
                {
                    item.Checked = false;
                }

                Text = "Add Booking: " + iNextID.ToString(sNextIDFormat);
            }
        }

        private void dtDateFrom_ValueChanged(object sender, EventArgs e)
        {
            dtDateTo.Value = dtDateFrom.Value;
        }

        private void cbxContacts_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string sContact = cbxContacts.SelectedValue != null ? cbxContacts.SelectedValue.ToString() : "";
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

        private void btnCompanies_Click(object sender, EventArgs e)
        {
            Form frmCompanies = new frmCompanies();
            DialogResult dlg = frmCompanies.ShowDialog();
            if (dlg == DialogResult.OK)
            {
                DataSet ds = Program.DB.SelectAll("SELECT ID,Name FROM Companies;");
                if (ds.Tables.Count > 0)
                {
                    List<ComboItem> items = new List<ComboItem>();
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        items.Add(new ComboItem() { Text = dr["Name"].ToString().Trim(), Value = Convert.ToInt32(dr["ID"]) });
                    }
                    cbxCompanies.DataSource = items;
                    cbxCompanies.DisplayMember = "Text";
                    cbxCompanies.ValueMember = "Value";
                }
            }
        }

        private void btnContacts_Click(object sender, EventArgs e)
        {
            Form frmContacts = new frmContacts();
            DialogResult dlg = frmContacts.ShowDialog();
            if (dlg == DialogResult.OK && cbxCompanies.SelectedItem != null)
            {
                DataSet ds = Program.DB.SelectAll("SELECT ID FROM Companies WHERE Name='" + cbxCompanies.SelectedItem.ToString() + "';");
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    ds = Program.DB.SelectAll("SELECT ID,NameTitle,NameFirst,NameLast FROM Contacts WHERE Company='" + ds.Tables[0].Rows[0]["ID"].ToString() + "'");
                    if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {
                        List<ComboItem> items = new List<ComboItem>();
                        foreach (DataRow dr in ds.Tables[0].Rows)
                        {
                            items.Add(new ComboItem() { Text = (dr["NameLast"].ToString() + ", " + dr["NameFirst"].ToString()).Trim(), Value = Convert.ToInt32(dr["ID"]) });
                        }
                        cbxContacts.DataSource = items;
                        cbxContacts.DisplayMember = "Text";
                        cbxContacts.ValueMember = "Value";
                    }
                }
            }
        }

        private void cbxCompanies_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbxContacts.Items.Clear();
            if (cbxCompanies.SelectedValue != null && cbxCompanies.SelectedValue.ToString() != "")
            {
                DataSet ds = Program.DB.SelectAll("SELECT ID,NameTitle,NameFirst,NameLast FROM Contacts WHERE Company='" + cbxCompanies.SelectedValue.ToString() + "'");
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    List<ComboItem> items = new List<ComboItem>();
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        items.Add(new ComboItem() { Text = (dr["NameLast"].ToString() + ", " + dr["NameFirst"].ToString()).Trim(), Value = Convert.ToInt32(dr["ID"]) });
                    }
                    cbxContacts.DataSource = items;
                    cbxContacts.DisplayMember = "Text";
                    cbxContacts.ValueMember = "Value";
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int iNid = 1;
            DataSet ds = Program.DB.SelectAll("SELECT MAX(Job) AS NextID FROM Jobs;");
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0]["NextID"] != DBNull.Value)
            {
                iNid = Convert.ToInt32(ds.Tables[0].Rows[0]["NextID"]);
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

            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter an event name to continue.", "Contact name", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            sUpdateVals += "BName=@name";
            sInsertCols += "BName";
            sInsertVals += "@name";
            Program.DB.AddParameter("@name", txtName.Text.Trim());

            string sCompany = cbxCompanies.SelectedValue != null ? cbxCompanies.SelectedValue.ToString() : "";
            if (sCompany != "")
            {
                sUpdateVals += ",BCompany=@company";
                sInsertCols += ",BCompany";
                sInsertVals += ",@company";
                Program.DB.AddParameter("@company", Convert.ToInt32(sCompany));
            }

            string sContact = cbxContacts.SelectedValue != null ? cbxContacts.SelectedValue.ToString() : "";
            if (sContact != "")
            {
                sUpdateVals += ",BContact=@contact";
                sInsertCols += ",BContact";
                sInsertVals += ",@contact";
                Program.DB.AddParameter("@contact", Convert.ToInt32(sContact));
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

            string sRooms = "";
            foreach (ListViewItem item in lvRooms.Items)
            {
                if (item.Checked == true)
                {
                    sRooms += sRooms.Length > 0 ? "|" + item.Name : item.Name;
                }
            }
            if (sRooms != "")
            {
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

            if (txtComments.Text.Trim() != "")
            {
                sUpdateVals += ",BComments=@comments";
                sInsertCols += ",BComments";
                sInsertVals += ",@comments";
                Program.DB.AddParameter("@comments", txtComments.Text.Trim());
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
                bool bFilesExist = false;

                if (sDocuments.Count > 0)
                {
                    string sPath = Properties.Settings.Default.PathToData + "Bookings\\" + iNextID.ToString(sNextIDFormat);
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
                            if (File.Exists(sPath + inf.Name))
                            {
                                DialogResult msg = MessageBox.Show("'" + inf.Name + "' already exists.\n\nWould you like to overwrite?", "File exists", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (msg == DialogResult.Yes)
                                {
                                    bFilesExist = true;
                                }
                            }
                            if (bFilesExist)
                            {
                                File.Copy(sFile, sPath + "\\" + inf.Name, true);
                            }
                            else
                            {
                                File.Copy(sFile, sPath + "\\" + inf.Name, false);
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
                else
                {
                    if (sDocuments.Count > 0)
                    {
                        bool bFilesExist = false;

                        string sPath = Properties.Settings.Default.PathToData + "Bookings\\" + iNextID.ToString(sNextIDFormat);
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
                                if (!File.Exists(sPath + "\\" + inf.Name))
                                {
                                    File.Copy(sFile, sPath + "\\" + inf.Name);
                                }
                                else
                                {
                                    bFilesExist = true;
                                }
                            }

                            if (bFilesExist)
                            {
                                MessageBox.Show("Some files already exists in the data folder.\n\nTo replace the files, find the related\ndata folder and overwrite them manually.", "File exists", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            }
                        }
                    }

                    MessageBox.Show("The update was successful.", "Updated", (MessageBoxButtons.OK), (MessageBoxIcon.Information));
                }
            }

            SharedData.dSchedule.Clear();
            SharedData.dSchedule.Add("name", txtName.Text.Trim());
            SharedData.dSchedule.Add("dates", dtDateFrom.Value.ToString() != "" && dtDateTo.Value.ToString() != "" ? dtDateFrom.Value + "|" + dtDateTo.Value : "");
            SharedData.dSchedule.Add("times", dtTimeFrom.Value.ToString() != null && dtTimeTo.Value.ToString() != null ? dtTimeFrom.Value.ToString() + "|" + dtTimeTo.Value.ToString() : "");
            SharedData.dSchedule.Add("comments", txtComments.Text.Trim());

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
                sDocuments.Add(inf.FullName);
            }
        }
    }
}
