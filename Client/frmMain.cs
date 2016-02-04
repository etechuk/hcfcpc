using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Metro;
using DevComponents.DotNetBar.Schedule;
using DevComponents.Schedule.Model;
using DevComponents.DotNetBar.SuperGrid;

using unvell.ReoGrid;

namespace Client
{
    public partial class frmMain : MetroAppForm
    {
        #region Members

        // Calendar
        private CalendarModel cmBookings = new CalendarModel();
        // Notifications
        private Balloon b = new Balloon();
        // Data
        private DataSet ds = new DataSet();
        private DataTable dsCompanies = new DataTable();

        private int iSSItemSelected = 0;
        private string wsCurrent;
        private ReoGridRange rSelected;

        GridRow rBooking;

        #endregion

        #region Form

        public frmMain()
        {
            InitializeComponent();

            Program.bSignOut = false;
            Icon = Properties.Resources.logo;

            pBookingsCalendar.Location = new Point(0, 0);
            pBookingsCalendar.Width = pBookings.Width;
            pBookingsCalendar.Height = pBookings.Height;

            pBookingsGrid.Location = new Point(0, 0);
            pBookingsGrid.Width = pBookings.Width;
            pBookingsGrid.Height = pBookings.Height;

            pBookingsList.Location = new Point(0, 0);
            pBookingsList.Width = pBookings.Width;
            pBookingsList.Height = pBookings.Height;

            pEnquiriesGrid.Location = new Point(0, 0);
            pEnquiriesGrid.Width = pBookings.Width;
            pEnquiriesGrid.Height = pBookings.Height;

            CompanyListInit();
            Set_DefaultView();

            if (Properties.Settings.Default.StartMaximised)
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            Activate();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (rgBookings.Worksheets.Count > 0)
            {
                rgBookings.Worksheets.Clear();
            }

            if (!Program.bSignOut)
            {
                Application.Exit();
            }
        }

        #endregion

        #region Clicked

        private void biBookingsViewDay_Click(object sender, EventArgs e)
        {
            cvBookings.SelectedView = eCalendarView.Day;
            pBookingsGrid.Visible = false;
            pBookingsList.Visible = false;
            pBookingsCalendar.Visible = true;
            biBookingsViewDay.Checked = true;
            LoadBookings();
        }

        private void biBookingsViewWeek_Click(object sender, EventArgs e)
        {
            cvBookings.SelectedView = eCalendarView.Week;
            pBookingsGrid.Visible = false;
            pBookingsList.Visible = false;
            pBookingsCalendar.Visible = true;
            biBookingsViewWeek.Checked = true;
            LoadBookings();
        }

        private void biBookingsViewMonth_Click(object sender, EventArgs e)
        {
            cvBookings.SelectedView = eCalendarView.Month;
            pBookingsGrid.Visible = false;
            pBookingsList.Visible = false;
            pBookingsCalendar.Visible = true;
            biBookingsViewMonth.Checked = true;
            LoadBookings();
        }

        private void biBookingsViewYear_Click(object sender, EventArgs e)
        {
            cvBookings.SelectedView = eCalendarView.Year;
            pBookingsGrid.Visible = false;
            pBookingsList.Visible = false;
            pBookingsCalendar.Visible = true;
            biBookingsViewYear.Checked = true;
            LoadBookings();
        }

        private void biBookingsViewGrid_Click(object sender, EventArgs e)
        {
            pBookingsGrid.Visible = true;
            pBookingsList.Visible = false;
            pBookingsCalendar.Visible = false;
            biBookingsGrid.Checked = true;
            LoadBookingsGrid();
        }

        private void biBookingsViewList_Click(object sender, EventArgs e)
        {
            pBookingsGrid.Visible = false;
            pBookingsList.Visible = true;
            pBookingsCalendar.Visible = false;
            biBookingsList.Checked = true;
            LoadBookings();
        }

        private void cvBookings_ItemClick(object sender, EventArgs e)
        {
            if (cvBookings.SelectedView == eCalendarView.Year)
            {
                cvBookings.SelectedView = eCalendarView.Day;
            }

            if (cvBookings.SelectedAppointments.Count == 0)
            {
                SharedData.iBookingID = 0;
                SharedData.dtSelectedStart = Convert.ToDateTime(cvBookings.DateSelectionStart);
                SharedData.dtSelectedFinish = Convert.ToDateTime(cvBookings.DateSelectionEnd);
            }
        }

        private void cvBookings_ItemDoubleClick(object sender, MouseEventArgs e)
        {
            if (cvBookings.SelectedView == eCalendarView.Year)
            {
                cvBookings.SelectedView = eCalendarView.Day;
                return;
            }

            if (cvBookings.SelectedAppointments.Count > 0)
            {
                SharedData.iBookingID = Convert.ToInt32(cvBookings.SelectedAppointments[0].Appointment.Tag);
                Form frmBooking = new frmBooking();
                DialogResult dlg = frmBooking.ShowDialog();
                if (dlg == DialogResult.OK)
                {
                    LoadBookings();
                }
                SharedData.iBookingID = 0;
            }
        }

        private void gBookings_RowActivated(object sender, GridRowActivatedEventArgs e)
        {
            rBooking = e.NewActiveRow as GridRow;
        }

        private void rgBookings_DoubleClick(object sender, EventArgs e)
        {
            if (iSSItemSelected > 0)
            {
                SharedData.iBookingID = iSSItemSelected;

                Form frmBooking = new frmBooking();
                DialogResult dlg = frmBooking.ShowDialog();
                if (dlg == DialogResult.OK)
                {
                    wsCurrent = rgBookings.CurrentWorksheet.Name;
                    LoadBookingsGrid();
                }

                SharedData.iBookingID = 0;
            }
        }

        #endregion

        #region Mouse Events

        private void cvBookings_MouseEnter(object sender, EventArgs e)
        {
            AppointmentView av = sender as AppointmentView;
            if (av == null || av.Appointment == null || ab == null)
            {
                return;
            }

            DataSet d = Program.DB.SelectAll("SELECT BName,BCompany,BDates,BTimes,BComments FROM Jobs WHERE ID=" + av.Appointment.Tag.ToString() + ";");
            if (d.Tables.Count > 0 && d.Tables[0].Rows.Count > 0)
            {
                string sDate = "", sStart = "", sFinish = "";
                DataRow row = d.Tables[0].Rows[0];

                if (ab == null)
                {
                    ShowTooltip();
                }

                string[] sDates = new string[] { };
                if (row["BDates"] != DBNull.Value)
                {
                    sDates = row["BDates"].ToString().Split('|');
                    if (sDates.Length == 2)
                    {
                        sDates[0] = sDates[0].Replace(" 00:00:00", "");
                        sDates[1] = sDates[1].Replace(" 00:00:00", "");
                        sDate = sDates[0] + " - " + sDates[1];
                    }
                }

                if (row["BTimes"] != DBNull.Value)
                {
                    string[] sTimes = row["BTimes"].ToString().Split('|');
                    if (sTimes.Length == 2 && sDates.Length == 2)
                    {
                        sDates[0] += " " + sTimes[0] + ":00";
                        sDates[1] += " " + sTimes[1] + ":00";
                        sStart = sTimes[0];
                        sFinish = sTimes[1];

                        DateTime now = DateTime.Now;
                        int iYear = now.Year, iMonth = now.Month, iDay = now.Day;

                        string[] d1 = sDates[0].Split('/');
                        string[] t1 = sTimes[0].Split(':');
                        iYear = Convert.ToInt32(d1[2].Substring(0, d1[2].IndexOf(' ')));
                        iMonth = Convert.ToInt32(d1[1]);
                        iDay = Convert.ToInt32(d1[0]);
                        sStart = new DateTime(iYear, iMonth, iDay, Convert.ToInt32(t1[0]), Convert.ToInt32(t1[1]), 0).ToString("hh:mm");

                        string[] d2 = sDates[1].Split('/');
                        string[] t2 = sTimes[1].Split(':');
                        iYear = Convert.ToInt32(d2[2].Substring(0, d2[2].IndexOf(' ')));
                        iMonth = Convert.ToInt32(d2[1]);
                        iDay = Convert.ToInt32(d2[0]);
                        sFinish = new DateTime(iYear, iMonth, iDay, Convert.ToInt32(t2[0]), Convert.ToInt32(t2[1]), 0).ToString("hh:mm");
                    }
                }

                string sCompany = "";
                if (d.Tables[0].Rows[0]["BCompany"].ToString().Length > 0)
                {
                    DataSet ds = Program.DB.SelectAll("SELECT Name FROM Companies WHERE ID=" + d.Tables[0].Rows[0]["BCompany"].ToString() + ";");
                    if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {
                        sCompany = ds.Tables[0].Rows[0]["Name"].ToString();
                    }
                }

                b.Text = "";
                b.CaptionText = d.Tables[0].Rows[0]["BName"].ToString();
                if (sCompany.Length > 0 && !sCompany.Any(char.IsDigit))
                {
                    b.Text = sCompany;
                }
                if (sDate.Length > 0)
                {
                    b.Text += b.Text.Length > 0 ? Environment.NewLine : "";
                    b.Text += sDate;
                }
                if (sStart.Length > 0 && sFinish.Length > 0)
                {
                    b.Text += b.Text.Length > 0 ? Environment.NewLine : "";
                    b.Text += sStart + " - " + sFinish;
                }
                b.AutoResize();
                b.Show(av, false);
            }
        }

        private void cvBookings_MouseLeave(object sender, EventArgs e)
        {
            if (b != null && b.Visible)
            {
                b.Hide();
            }
        }

        private void sheet_CellMouseDown(object sender, unvell.ReoGrid.Events.CellMouseEventArgs e)
        {
            if (e.Cell != null && e.Cell.Tag != null)
            {
                iSSItemSelected = Convert.ToInt32(e.Cell.Tag);
            }
        }

        private void sheet_CellMouseEnter(object sender, unvell.ReoGrid.Events.CellMouseEventArgs e)
        {
            Worksheet sheet = e.Worksheet;
            ReoGridPos p = sheet.HoverPos;
            if (sheet.Cells[p].Tag != null && sheet.Cells[p].Tag.ToString().Length > 0)
            {
                DataSet d = Program.DB.SelectAll("SELECT BName,BCompany,BDates,BTimes,BComments FROM Jobs WHERE ID=" + sheet.Cells[p].Tag.ToString() + ";");
                if (d.Tables.Count > 0 && d.Tables[0].Rows.Count > 0)
                {
                    string sDate = "", sStart = "", sFinish = "";
                    DataRow row = d.Tables[0].Rows[0];

                    if (ab == null)
                    {
                        ShowTooltip();
                    }

                    string[] sDates = new string[] { };
                    if (row["BDates"] != DBNull.Value)
                    {
                        sDates = row["BDates"].ToString().Split('|');
                        if (sDates.Length == 2)
                        {
                            sDates[0] = sDates[0].Replace(" 00:00:00", "");
                            sDates[1] = sDates[1].Replace(" 00:00:00", "");
                            sDate = sDates[0] + " - " + sDates[1];
                        }
                    }

                    if (row["BTimes"] != DBNull.Value)
                    {
                        string[] sTimes = row["BTimes"].ToString().Split('|');
                        if (sTimes.Length == 2 && sDates.Length == 2)
                        {
                            sDates[0] += " " + sTimes[0] + ":00";
                            sDates[1] += " " + sTimes[1] + ":00";
                            sStart = sTimes[0];
                            sFinish = sTimes[1];

                            DateTime now = DateTime.Now;
                            int iYear = now.Year, iMonth = now.Month, iDay = now.Day;

                            string[] d1 = sDates[0].Split('/');
                            string[] t1 = sTimes[0].Split(':');
                            iYear = Convert.ToInt32(d1[2].Substring(0, d1[2].IndexOf(' ')));
                            iMonth = Convert.ToInt32(d1[1]);
                            iDay = Convert.ToInt32(d1[0]);
                            sStart = new DateTime(iYear, iMonth, iDay, Convert.ToInt32(t1[0]), Convert.ToInt32(t1[1]), 0).ToString("hh:mm");

                            string[] d2 = sDates[1].Split('/');
                            string[] t2 = sTimes[1].Split(':');
                            iYear = Convert.ToInt32(d2[2].Substring(0, d2[2].IndexOf(' ')));
                            iMonth = Convert.ToInt32(d2[1]);
                            iDay = Convert.ToInt32(d2[0]);
                            sFinish = new DateTime(iYear, iMonth, iDay, Convert.ToInt32(t2[0]), Convert.ToInt32(t2[1]), 0).ToString("hh:mm");
                        }
                    }

                    string sCompany = "";
                    if (d.Tables[0].Rows[0]["BCompany"].ToString().Length > 0)
                    {
                        DataSet ds = Program.DB.SelectAll("SELECT Name FROM Companies WHERE ID=" + d.Tables[0].Rows[0]["BCompany"].ToString() + ";");
                        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                        {
                            sCompany = ds.Tables[0].Rows[0]["Name"].ToString();
                        }
                    }

                    b.Text = "";
                    b.CaptionText = d.Tables[0].Rows[0]["BName"].ToString();
                    if (sCompany.Length > 0 && !sCompany.Any(char.IsDigit))
                    {
                        b.Text = sCompany;
                    }
                    if (sDate.Length > 0)
                    {
                        b.Text += b.Text.Length > 0 ? Environment.NewLine : "";
                        b.Text += sDate;
                    }
                    if (sStart.Length > 0 && sFinish.Length > 0)
                    {
                        b.Text += b.Text.Length > 0 ? Environment.NewLine : "";
                        b.Text += sStart + " - " + sFinish;
                    }
                    b.AutoResize();
                    b.Show(rgBookings, false);
                }
            }
        }

        private void sheet_CellMouseLeave(object sender, unvell.ReoGrid.Events.CellMouseEventArgs e)
        {
            Worksheet sheet = e.Worksheet;
            ReoGridPos p = sheet.HoverPos;
            if (sheet.Cells[p].Tag != null)
            {
                return;
            }

            if (b != null && b.Visible)
            {
                b.Hide();
            }
        }

        private void sheet_CurrentWorksheetChanged()
        {
            txtGridCompany.Text = "";
            txtListCompany.Text = "";

            if (rgBookings.Worksheets.Count > 0)
            {
                //rgBookings.CurrentWorksheet.FreezeToCell(2, 1, FreezePosition.LeftTop);
            }
        }

        private void sheet_SelectionRangeChanged(object sender, unvell.ReoGrid.Events.RangeEventArgs e)
        {
            Worksheet sheet = rgBookings.CurrentWorksheet;
            ReoGridRange r = sheet.SelectionRange;
            SharedData.dtSelectedStart = Convert.ToDateTime(sheet[1, r.StartPos.Col].ToString());
            SharedData.dtSelectedFinish = Convert.ToDateTime(sheet[1, r.EndPos.Col].ToString());
            string sRooms = "";
            for (int i = r.StartPos.Row; i <= r.EndPos.Row; i++)
            {
                sRooms += (sRooms.Length > 0 ? "|" : "") + sheet.Cells[i, 0].Tag.ToString();
            }
            SharedData.sBookingRooms = sRooms;
        }

        #endregion

        #region Methods

        private void Set_DefaultView()
        {
            switch (Properties.Settings.Default.DefaultView)
            {
                case 0: // Bookings tab, day view
                    LoadBookings();
                    cvBookings.SelectedView = eCalendarView.Day;
                    pBookingsGrid.Visible = false;
                    pBookingsList.Visible = false;
                    pBookingsCalendar.Visible = true;
                    biBookingsViewDay.Checked = true;
                    ms.SelectedTab = mtBookings;
                    break;
                case 1: // Bookings tab, week view
                    LoadBookings();
                    cvBookings.SelectedView = eCalendarView.Week;
                    pBookingsGrid.Visible = false;
                    pBookingsList.Visible = false;
                    pBookingsCalendar.Visible = true;
                    biBookingsViewWeek.Checked = true;
                    ms.SelectedTab = mtBookings;
                    break;
                case 3: // Bookings tab, year view
                    LoadBookings();
                    cvBookings.SelectedView = eCalendarView.Year;
                    pBookingsGrid.Visible = false;
                    pBookingsList.Visible = false;
                    pBookingsCalendar.Visible = true;
                    biBookingsViewYear.Checked = true;
                    ms.SelectedTab = mtBookings;
                    break;
                case 4: // Bookings tab, grid view
                    LoadBookingsGrid();
                    pBookingsGrid.Visible = true;
                    pBookingsList.Visible = false;
                    pBookingsCalendar.Visible = false;
                    biBookingsGrid.Checked = true;
                    ms.SelectedTab = mtBookings;
                    break;
                case 5: // Bookings tab, list view
                    LoadBookings();
                    pBookingsGrid.Visible = false;
                    pBookingsList.Visible = true;
                    pBookingsCalendar.Visible = false;
                    biBookingsList.Checked = true;
                    ms.SelectedTab = mtBookings;
                    break;
                case 6: // Enquiries tab
                    LoadEnquiries();
                    ms.SelectedTab = mtEnquiries;
                    break;
                case 7: // Courses tab
                    LoadCourses();
                    ms.SelectedTab = mtCourses;
                    break;
                case 8: // Companies tab
                    LoadCompanies();
                    ms.SelectedTab = mtCompanies;
                    break;
                case 9: // Contacts tab
                    LoadContacts();
                    ms.SelectedTab = mtContacts;
                    break;
                default: // Bookings tab, month view
                    LoadBookings();
                    cvBookings.SelectedView = eCalendarView.Month;
                    pBookingsGrid.Visible = false;
                    pBookingsList.Visible = false;
                    pBookingsCalendar.Visible = true;
                    biBookingsViewMonth.Checked = true;
                    ms.SelectedTab = mtBookings;
                    break;
            }
        }

        private void LoadBookings()
        {
            if (cmBookings.Appointments.Count > 0)
            {
                cmBookings.Appointments.Clear();
            }
            gBookings.PrimaryGrid.Rows.Clear();

            DataSet d, ds = Program.DB.SelectAll("SELECT ID,Job,BName,BCompany,BRoom,BRoomLayout,BDates,BTimes,BPhone,BEmail FROM Jobs WHERE BName IS NOT NULL AND BUser IS NOT NULL ORDER BY Job DESC");

            d = Program.DB.SelectAll("SELECT ID,Name,IsZone FROM Rooms;");
            Dictionary<int, string> zones = new Dictionary<int, string>();
            Dictionary<int, string> rooms = new Dictionary<int, string>();
            if (d.Tables.Count > 0)
            {
                foreach (DataRow r in d.Tables[0].Rows)
                {
                    if (r["IsZone"] != DBNull.Value && r["IsZone"].Equals("Y"))
                    {
                        zones.Add(Convert.ToInt32(r["ID"]), r["Name"].ToString());
                        continue;
                    }

                    string sZone = "";
                    foreach (KeyValuePair<int, string> zone in zones)
                    {
                        if (r["Name"] != DBNull.Value && Convert.ToInt32(r["ID"]) == zone.Key)
                        {
                            sZone = zone.Value.Replace("|", " - ") + " - ";
                            break;
                        }
                    }

                    rooms.Add(Convert.ToInt32(r["ID"]), sZone + r["Name"].ToString());
                }
            }

            d = Program.DB.SelectAll("SELECT ID,Name FROM Companies;");
            Dictionary<int, string> companies = new Dictionary<int, string>();
            List<ComboItem> companiesCombo = new List<ComboItem>();
            companiesCombo.Add(new ComboItem() { });
            if (d.Tables.Count > 0)
            {
                foreach (DataRow r in d.Tables[0].Rows)
                {
                    companies.Add(Convert.ToInt32(r["ID"]), r["Name"].ToString());
                    companiesCombo.Add(new ComboItem() { Value = Convert.ToInt32(r["ID"]), Text = r["Name"].ToString() });
                }
            }

            d = Program.DB.SelectAll("SELECT ID,NameFirst,NameLast FROM Contacts;");
            Dictionary<int, string> contacts = new Dictionary<int, string>();
            if (d.Tables.Count > 0)
            {
                foreach (DataRow r in d.Tables[0].Rows)
                {
                    string contact = (r["NameFirst"] != DBNull.Value ? r["NameFirst"].ToString() : "") + r["NameLast"].ToString();
                    contacts.Add(Convert.ToInt32(r["ID"]), contact);
                }
            }

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    Appointment appointment = new Appointment();

                    string sDate = "";
                    string[] sDates = new string[] { };
                    if (row["BDates"] != DBNull.Value)
                    {
                        sDates = row["BDates"].ToString().Split('|');
                        if (sDates.Length == 2)
                        {
                            sDates[0] = sDates[0].Replace(" 00:00:00", "");
                            sDates[1] = sDates[1].Replace(" 00:00:00", "");
                            sDate = sDates[0] + " - " + sDates[1];
                        }
                    }

                    string sStart = "", sFinish = "";
                    if (row["BTimes"] != DBNull.Value)
                    {
                        string[] sTimes = row["BTimes"].ToString().Split('|');
                        if (sTimes.Length == 2 && sDates.Length == 2)
                        {
                            sDates[0] += " " + sTimes[0] + ":00";
                            sDates[1] += " " + sTimes[1] + ":00";
                            sStart = sTimes[0];
                            sFinish = sTimes[1];

                            DateTime now = DateTime.Now;
                            int iYear = now.Year, iMonth = now.Month, iDay = now.Day;

                            string[] d1 = sDates[0].Split('/');
                            string[] t1 = sTimes[0].Split(':');
                            iYear = Convert.ToInt32(d1[2].Substring(0, d1[2].IndexOf(' ')));
                            iMonth = Convert.ToInt32(d1[1]);
                            iDay = Convert.ToInt32(d1[0]);
                            appointment.StartTime = new DateTime(iYear, iMonth, iDay, Convert.ToInt32(t1[0]), Convert.ToInt32(t1[1]), 0);

                            string[] d2 = sDates[1].Split('/');
                            string[] t2 = sTimes[1].Split(':');
                            iYear = Convert.ToInt32(d2[2].Substring(0, d2[2].IndexOf(' ')));
                            iMonth = Convert.ToInt32(d2[1]);
                            iDay = Convert.ToInt32(d2[0]);
                            appointment.EndTime = new DateTime(iYear, iMonth, iDay, Convert.ToInt32(t2[0]), Convert.ToInt32(t2[1]), 0);
                        }
                    }

                    string sCompany = "";
                    if (companies.Count > 0)
                    {
                        foreach (KeyValuePair<int, string> company in companies)
                        {
                            if (company.Key > -1 && row["BCompany"] != DBNull.Value && company.Key == Convert.ToInt32(row["BCompany"]))
                            {
                                sCompany = company.Value;
                                break;
                            }
                        }
                    }

                    string sRoom = "";
                    if (rooms.Count > 0 && row["BRoom"] != DBNull.Value)
                    {
                        string[] sRooms = row["BRoom"].ToString().Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

                        foreach (KeyValuePair<int, string> room in rooms)
                        {
                            if (room.Key > -1 && sRooms.Contains(room.Key.ToString()))
                            {
                                sRoom = room.Value;
                                break;
                            }
                        }
                    }

                    appointment.Subject = row["BName"].ToString();
                    appointment.CategoryColor = Appointment.CategoryGreen;
                    appointment.TimeMarkedAs = Appointment.TimerMarkerBusy;
                    appointment.Tag = row["ID"].ToString();
                    appointment.Locked = true;
                    cmBookings.Appointments.Add(appointment);

                    GridRow r = new GridRow(new object[] {
                        false, row["Job"].ToString(), sDate, sStart, sFinish, row["BName"].ToString(), sRoom, sCompany, row["BPhone"].ToString(),
                        row["BEmail"].ToString(), row["BRoomLayout"].ToString()
                    });
                    r.Tag = row["ID"];
                    gBookings.PrimaryGrid.Rows.Add(r);
                }
            }

            cvBookings.CalendarModel = cmBookings;
        }

        private void LoadBookingsGrid()
        {
            Worksheet sheet;

            if (rgBookings.Worksheets.Count > 0 && rgBookings.Worksheets[0].Name != "Sheet1")
            {
                for (int i = 0; i < rgBookings.Worksheets.Count; i++)
                {
                    //rgBookings.Worksheets[i].Unfreeze();
                }

                rgBookings.Reset();

                if (rgBookings.Worksheets.Count == 0)
                {
                    sheet = rgBookings.CreateWorksheet("Sheet1");
                    rgBookings.AddWorksheet(sheet);
                }
                else
                {
                    sheet = rgBookings.Worksheets[0];
                }

                rgBookings.CurrentWorksheet = sheet;
            }

            rgBookings.SheetTabWidth = (Width / 3) * 2;
            rgBookings.CurrentWorksheetChanged += (s, e) => sheet_CurrentWorksheetChanged();

            // Set up worksheets
            int iSheetCount = 0;
            DataSet sheets = Program.DB.SelectAll("SELECT * FROM WorkSheets;");
            foreach (DataRow r in sheets.Tables[0].Rows)
            {
                if (iSheetCount == 0)
                {
                    sheet = rgBookings.Worksheets[0];
                    sheet.Name = r["Name"].ToString();
                    iSheetCount++;
                }
                else
                {
                    sheet = rgBookings.CreateWorksheet(r["Name"].ToString());
                    rgBookings.AddWorksheet(sheet);
                    rgBookings.CurrentWorksheet = sheet;
                }

                SS_LoadSheet(sheet, r);
            }

            if (wsCurrent != "" && rgBookings.Worksheets[wsCurrent] != null)
            {
                //rgBookings.CurrentWorksheetChanged += (s, e) => sheet_CurrentWorksheetChanged();
                rgBookings.CurrentWorksheet = rgBookings.Worksheets[wsCurrent];
            }
        }

        private void LoadEnquiries()
        {
            gEnquiries.PrimaryGrid.Rows.Clear();

            DataSet d, ds = Program.DB.SelectAll("SELECT ID,Job,EName,ECompany,EPhone,EEmail,EType,EReferer,EUser,EEntered FROM Jobs WHERE EName IS NOT NULL AND EUser IS NOT NULL ORDER BY Job DESC");

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    GridRow r = new GridRow(new object[] {
                        false, row["Job"].ToString(), row["EEntered"].ToString(), row["EType"].ToString(), row["EName"].ToString(), row["ECompany"].ToString(),
                        row["EPhone"].ToString(), row["EEmail"].ToString(), row["EReferer"].ToString()
                    });
                    gEnquiries.PrimaryGrid.Rows.Add(r);
                    gEnquiries.PrimaryGrid.Rows[gEnquiries.PrimaryGrid.Rows.Count - 1].Tag = row["ID"];
                }
            }
        }

        private void LoadCourses()
        {
            gCourses.PrimaryGrid.Rows.Clear();

            DataSet ds = Program.DB.SelectAll("SELECT * FROM Courses;");
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                DataSet d;

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    GridRow r = new GridRow(new object[] {
                        false, row["ID"].ToString(), row["Name"].ToString(), row["Certification"].ToString(),
                        row["Duration"].ToString().Replace(Environment.NewLine, "; "), row["Pricing"].ToString().Replace(Environment.NewLine, "; ")
                    });
                    r.Tag = row["ID"];
                    gCourses.PrimaryGrid.Rows.Add(r);
                }
            }
        }

        private void LoadCompanies()
        {
            gCompanies.PrimaryGrid.Rows.Clear();

            DataSet ds = Program.DB.SelectAll("SELECT * FROM Companies;");
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                DataSet d;

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    string sContacts = "";
                    if (row["Contacts"].ToString().Length > 0)
                    {
                        d = Program.DB.SelectAll("SELECT NameFirst,NameLast FROM Contacts WHERE ID IN (" + row["Contacts"].ToString() + ");");
                        if (d.Tables.Count > 0 && d.Tables[0].Rows.Count > 0)
                        {
                            foreach (DataRow pr in d.Tables[0].Rows)
                            {
                                string sName = pr["NameFirst"].ToString() + " " + pr["NameFirst"].ToString();
                                sContacts = sContacts.Length > 0 ? ", " + sName: sName;
                            }
                        }
                    }

                    string sPhones = "";
                    if (row["Phones"].ToString().Length > 0)
                    {
                        d = Program.DB.SelectAll("SELECT Number FROM Phones WHERE ID IN (" + row["Phones"].ToString() + ");");
                        if (d.Tables.Count > 0 && d.Tables[0].Rows.Count > 0)
                        {
                            foreach (DataRow pr in d.Tables[0].Rows)
                            {
                                sPhones = sPhones.Length > 0 ? ", " + pr["Number"].ToString() : pr["Number"].ToString();
                            }
                        }
                    }

                    string sEmails = "";
                    if (row["Emails"].ToString().Length > 0)
                    {
                        d = Program.DB.SelectAll("SELECT Address FROM Emails WHERE ID IN (" + row["Emails"].ToString() + ");");
                        if (d.Tables.Count > 0 && d.Tables[0].Rows.Count > 0)
                        {
                            foreach (DataRow pr in d.Tables[0].Rows)
                            {
                                sEmails = sEmails.Length > 0 ? ", " + pr["Address"].ToString() : pr["Address"].ToString();
                            }
                        }
                    }

                    string sAddresses = "";
                    if (row["Emails"].ToString().Length > 0)
                    {
                        d = Program.DB.SelectAll("SELECT * FROM Addresses WHERE ID IN (" + row["Addresses"].ToString() + ");");
                        if (d.Tables.Count > 0 && d.Tables[0].Rows.Count > 0)
                        {
                            foreach (DataRow pr in d.Tables[0].Rows)
                            {
                                string sAddress = pr["Line1"].ToString() + ", " + pr["Postcode"].ToString();
                                sAddresses = sAddresses.Length > 0 ? "; " + sAddress : sAddress;
                            }
                        }
                    }

                    GridRow r = new GridRow(new object[] {
                        false, row["ID"].ToString(), row["Name"].ToString(), sContacts, sPhones, sEmails, sAddresses, row["RegNumber"].ToString(), row["RegNumberVat"].ToString()
                    });
                    r.Tag = row["ID"];
                    gCompanies.PrimaryGrid.Rows.Add(r);
                }

            }
        }

        private void LoadContacts()
        {
            gContacts.PrimaryGrid.Rows.Clear();

            DataSet ds = Program.DB.SelectAll("SELECT * FROM Contacts;");
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                DataSet d;

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    string sCompany = row["Company"].ToString();

                    Program.DB.AddParameter("ID", row["Company"]);
                    d = Program.DB.SelectAll("SELECT Name FROM Companies WHERE ID=@ID;");
                    if (d.Tables.Count > 0 && d.Tables[0].Rows.Count > 0)
                    {
                        sCompany = d.Tables[0].Rows[0]["Name"].ToString();
                    }

                    string sPhones = "";
                    if (row["Phones"].ToString().Length > 0)
                    {
                        d = Program.DB.SelectAll("SELECT Number FROM Phones WHERE ID IN (" + row["Phones"].ToString() + ");");
                        if (d.Tables.Count > 0 && d.Tables[0].Rows.Count > 0)
                        {
                            foreach (DataRow pr in d.Tables[0].Rows)
                            {
                                sPhones = sPhones.Length > 0 ? ", " + pr["Number"].ToString() : pr["Number"].ToString();
                            }
                        }
                    }

                    string sEmails = "";
                    if (row["Emails"].ToString().Length > 0)
                    {
                        d = Program.DB.SelectAll("SELECT Address FROM Emails WHERE ID IN (" + row["Emails"].ToString() + ");");
                        if (d.Tables.Count > 0 && d.Tables[0].Rows.Count > 0)
                        {
                            foreach (DataRow pr in d.Tables[0].Rows)
                            {
                                sEmails = sEmails.Length > 0 ? ", " + pr["Address"].ToString() : pr["Address"].ToString();
                            }
                        }
                    }

                    string sAddresses = "";
                    if (row["Emails"].ToString().Length > 0)
                    {
                        d = Program.DB.SelectAll("SELECT * FROM Addresses WHERE ID IN (" + row["Addresses"].ToString() + ");");
                        if (d.Tables.Count > 0 && d.Tables[0].Rows.Count > 0)
                        {
                            foreach (DataRow pr in d.Tables[0].Rows)
                            {
                                string sAddress = pr["Line1"].ToString() + ", " + pr["Postcode"].ToString();
                                sAddresses = sAddresses.Length > 0 ? "; " + sAddress : sAddress;
                            }
                        }
                    }

                    GridRow r = new GridRow(new object[] {
                        false, row["ID"].ToString(), row["NameTitle"].ToString(), row["NameFirst"].ToString(), row["NameLast"].ToString(), sCompany, sPhones, sEmails, sAddresses
                    });
                    r.Tag = row["ID"];
                    gContacts.PrimaryGrid.Rows.Add(r);
                }
            }
        }

        private void CompanyListInit()
        {
            DataSet dsCompanies = Program.DB.SelectAll("SELECT Name FROM Companies;");
            if (dsCompanies.Tables.Count > 0 && dsCompanies.Tables[0].Rows.Count > 0)
            {
                AutoCompleteStringCollection asCompanies = new AutoCompleteStringCollection();
                foreach (DataRow row in dsCompanies.Tables[0].Rows)
                {
                    asCompanies.Add(row["Name"].ToString());
                }
                txtGridCompany.AutoCompleteCustomSource = asCompanies;
                txtListCompany.AutoCompleteCustomSource = asCompanies;
                txtContactCompany.AutoCompleteCustomSource = asCompanies;
                txtEnquiriesListCompany.AutoCompleteCustomSource = asCompanies;
            }
        }

        private void SS_LoadSheet(Worksheet sheet, DataRow r, int iFilterCompany = 0)
        {
            // Disable cell editing
            sheet.BeforeCellEdit += (s, e) => e.IsCancelled = true;
            // Set up cell selection
            sheet.CellMouseDown += sheet_CellMouseDown;
            sheet.CellMouseEnter += sheet_CellMouseEnter;
            sheet.CellMouseLeave += sheet_CellMouseLeave;
            sheet.SelectionRangeChanged += sheet_SelectionRangeChanged;

            // Set column headers
            int count = 0;
            DateTime date_from = DateTime.Parse(r["Start"].ToString());
            DateTime date_to = DateTime.Parse(r["Finish"].ToString());
            List<DateTime> dates = new List<DateTime>();

            for (DateTime dt = date_from; dt <= date_to; dt = dt.AddDays(1))
            {
                dates.Add(dt);
                count++;
            }

            sheet.SetCols(count + 1);
            sheet.SetColumnsWidth(1, count, 92);
            sheet.SetColumnsWidth(0, 1, 225);

            count = 1;
            foreach (DateTime date in dates)
            {
                if (!IsWeekend(date))
                {
                    sheet[0, count] = date.ToString("ddd");
                    sheet[1, count] = Convert.ToString(date.ToShortDateString());
                }
                else
                {
                    sheet[0, count] = "S";
                    sheet[1, count] = Convert.ToString(date.Day);
                    sheet.SetColumnsWidth(count, 1, 30);
                }
                sheet.Cells[0, count].Style.HAlign = ReoGridHorAlign.Center;
                sheet.Cells[0, count].Style.VAlign = ReoGridVerAlign.Middle;
                sheet.Cells[0, count].Style.FontName = "Arial";
                sheet.Cells[0, count].Style.FontSize = 10;
                sheet.Cells[0, count].Style.Bold = true;
                sheet.Cells[1, count].Style.HAlign = ReoGridHorAlign.Center;
                sheet.Cells[1, count].Style.VAlign = ReoGridVerAlign.Middle;
                sheet.Cells[1, count].Style.FontName = "Arial";
                sheet.Cells[1, count].Style.FontSize = 10;
                sheet.Cells[1, count].Style.Bold = true;
                count++;
            }

            int iColumnCount = count + 1;

            sheet.RowHeaders[0].Height = 30;
            sheet[0, 0] = "RAW Zone Planner";
            sheet.Cells[0, 0].Style.VAlign = ReoGridVerAlign.Middle;
            sheet.Cells[0, 0].Style.FontName = "Arial";
            sheet.Cells[0, 0].Style.FontSize = 10;
            sheet.Cells[0, 0].Style.Bold = true;

            sheet.RowHeaders[1].Height = 30;
            sheet[1, 0] = r["Name"].ToString();
            sheet.Cells[1, 0].Style.VAlign = ReoGridVerAlign.Middle;
            sheet.Cells[1, 0].Style.FontName = "Arial";
            sheet.Cells[1, 0].Style.FontSize = 10;
            sheet.Cells[1, 0].Style.Bold = true;

            // Set row headers
            DataSet rooms = Program.DB.SelectAll("SELECT ID,Name,IsZone FROM Rooms WHERE ID IN (" + r["Rooms"].ToString() + ");");
            Dictionary<string, string> rows = new Dictionary<string, string>();
            int iZ = 0, iR = 0;
            foreach (DataRow row in rooms.Tables[0].Rows)
            {
                if (row["IsZone"] != DBNull.Value && row["IsZone"].Equals("Y"))
                {
                    rows.Add("z" + row["ID"].ToString(), row["Name"].ToString().Replace("|", " - "));
                    iZ++;
                    continue;
                }

                rows.Add("r" + row["ID"].ToString(), row["Name"].ToString());
                iR++;
            }

            sheet.SetRows(rows.Count + iZ + 2);

            count = 2;
            foreach (KeyValuePair<string, string> entry in rows)
            {
                if (entry.Key.Contains("z"))
                {
                    sheet.SetRowsHeight(count, 1, 15);
                    count++;

                    ReoGridRange rgr = new ReoGridRange(count, 0, 1, iColumnCount);
                    sheet.SetRangeStyles(rgr, new WorksheetRangeStyle
                    {
                        Flag = PlainStyleFlag.BackColor | PlainStyleFlag.FontStyleBold,
                        BackColor = Color.LightSteelBlue,
                        Bold = true
                    });
                }
                else
                {
                    sheet.Cells[count, 0].Style.Italic = true;
                }

                sheet[count, 0] = entry.Value;
                sheet.SetRowsHeight(count, 1, 23);
                sheet.Cells[count, 0].Tag = entry.Key.Replace("z", "").Replace("r", "");
                sheet.Cells[count, 0].Style.VAlign = ReoGridVerAlign.Middle;
                sheet.Cells[count, 0].Style.HAlign = ReoGridHorAlign.Left;
                sheet.Cells[count, 0].Style.FontName = "Arial";
                sheet.Cells[count, 0].Style.FontSize = 10;

                string sDates = "";
                foreach (DateTime date in dates)
                {
                    if (!IsWeekend(date))
                    {
                        sDates += sDates.Length > 0 ? " OR " : "";
                        sDates += "BDates LIKE '" + date.ToString("dd/MM/yyyy") + "%'";
                    }
                }

                if (sDates.Length > 0)
                {
                    DataSet d = Program.DB.SelectAll("SELECT ID,BName,BDates,BTimes,BRoom,BComments,Confirmed,Completed FROM Jobs WHERE " + sDates + (iFilterCompany > 0 ? " AND BCompany=" + iFilterCompany : "") + ";");
                    if (d.Tables.Count > 0 && d.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow dr in d.Tables[0].Rows)
                        {
                            int iColumn = 1;
                            string[] sRooms = new string[] { };
                            if (dr["BRoom"] != DBNull.Value && dr["BRoom"].ToString().Length > 0)
                            {
                                sRooms = dr["BRoom"].ToString().Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                            }

                            if (dr["BRoom"] != DBNull.Value && sRooms.Contains(entry.Key.Replace("r", "").Replace("z", "")))
                            {
                                foreach (DateTime date in dates)
                                {
                                    string[] sD = dr["BDates"].ToString().Split('|');
                                    for (int i = 0; i < sD.Length; i++)
                                    {
                                        sD[i] = sD[i].Replace(" 00:00:00", "");
                                    }
                                    if (sD[0] == date.ToString("dd/MM/yyyy"))
                                    {
                                        ReoGridRange rgr = new ReoGridRange(count, iColumn, 1, 1);
                                        DateTime dtF = Convert.ToDateTime(sD[1]);

                                        double iDays = (dtF - date).TotalDays;
                                        if (iDays > 0)
                                        {
                                            rgr.Cols = Convert.ToInt32(iDays) + 1;
                                        }
                                        if (sRooms.Length > 1)
                                        {
                                            rgr.Rows = sRooms.Length;
                                        }

                                        bool rs = sheet.HasIntersectedMergingRange(rgr);
                                        if (!rs && (rgr.Rows > 1 || rgr.Cols > 1))
                                        {
                                            sheet.MergeRange(rgr);
                                        }

                                        sheet[count, iColumn] = dr["BName"].ToString();
                                        sheet.Cells[count, iColumn].Tag = Convert.ToInt32(dr["ID"]);
                                        sheet.Cells[count, iColumn].Style.HAlign = ReoGridHorAlign.Center;
                                        sheet.Cells[count, iColumn].Style.VAlign = ReoGridVerAlign.Middle;

                                        if (dr["Completed"] != DBNull.Value && dr["Completed"].ToString() == "Y")
                                        {
                                            sheet.Cells[count, iColumn].Style.BackColor = Color.MediumVioletRed;
                                            //sheet.SetRangeBorders(rgr, BorderPositions.Outside, new RangeBorderStyle { Color = Color.IndianRed, Style = BorderLineStyle.Solid });
                                        }
                                        else
                                        {
                                            sheet.Cells[count, iColumn].Style.BackColor = Color.PaleVioletRed;
                                            //sheet.SetRangeBorders(rgr, BorderPositions.Outside, new RangeBorderStyle { Color = Color.MediumVioletRed, Style = BorderLineStyle.Solid });
                                        }

                                        if (dr["BComments"].ToString().Length > 0)
                                        {
                                            sheet.Cells[count, iColumn].Style.Bold = true;
                                        }

                                        break;
                                    }

                                    iColumn++;
                                }
                            }
                        }
                    }
                }

                count++;
            }
        }

        #endregion

        #region Functions

        public static bool IsWeekend(DateTime Validate)
        {
            if (Validate.DayOfWeek == DayOfWeek.Sunday || Validate.DayOfWeek == DayOfWeek.Saturday)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private DateTime StartOfWeek(DateTime dt, bool useSunday)
        {
            if (dt == null)
            {
                dt = DateTime.Now;
            }
            int dayOfWeek = (int)dt.DayOfWeek;
            if (!useSunday)
            {
                dayOfWeek--;
            }
            if (dayOfWeek < 0) // Day of week is Sunday and we want to use Monday as start of week. Sunday is now seventh day
            {
                dayOfWeek = 6;
            }
            return dt.AddDays(-1 * (double)dayOfWeek);
        }

        private void ShowTooltip()
        {
            b = new Balloon();
            b.AutoCloseTimeOut = 10;
            b.Owner = this;
        }

        #endregion

        #region Button Clicked

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            ab.ClosePopup();
            Form frmOptions = new frmOptions();
            frmOptions.ShowDialog();
        }

        private void btnContactCancel_Click(object sender, EventArgs e)
        {
            mContactsAdd.PerformClick();
        }

        private void btnContactSave_Click(object sender, EventArgs e)
        {

        }

        private void btnCompanyCancel_Click(object sender, EventArgs e)
        {
            mCompaniesAdd.PerformClick();
        }

        private void btnCompanySave_Click(object sender, EventArgs e)
        {

        }

        private void btnCourseCancel_Click(object sender, EventArgs e)
        {
            mCoursesAdd.PerformClick();
        }

        private void btnCourseSave_Click(object sender, EventArgs e)
        {

        }

        private void btnEnquiryCancel_Click(object sender, EventArgs e)
        {
            mEnquiriesAdd.PerformClick();
        }

        private void btnEnquirySave_Click(object sender, EventArgs e)
        {

        }

        private void btnGridCompanyReset_Click(object sender, EventArgs e)
        {
            txtGridCompany.Text = "";
            LoadBookingsGrid();
        }

        private void btnListCompanyReset_Click(object sender, EventArgs e)
        {
            txtListCompany.Text = "";
            // Unset filter
        }

        #endregion

        #region Menu Clicked

        private void mBookingsAdd_Click(object sender, EventArgs e)
        {
            Form frmBooking = new frmBooking();
            DialogResult dlg = frmBooking.ShowDialog();
            if (dlg == DialogResult.OK && SharedData.iBookingID > 0 && SharedData.dSchedule.Count > 0)
            {
                Appointment appointment = new Appointment();

                string[] sDates = SharedData.dSchedule["dates"].Split('|');
                string[] sTimes = new string[] { };
                if (SharedData.dSchedule["times"].Length > 0)
                {
                    sTimes = SharedData.dSchedule["times"].Split('|');
                }
                DateTime now = DateTime.Now;
                int iYear = now.Year, iMonth = now.Month, iDay = now.Day;

                string[] d1 = sDates[0].Split('/');
                string[] t1 = new string[] { };
                if (sTimes.Length == 2)
                {
                    t1 = sTimes[0].Split(':');
                }
                iYear = Convert.ToInt32(d1[2].Substring(0, d1[2].IndexOf(' ')));
                iMonth = Convert.ToInt32(d1[1]);
                iDay = Convert.ToInt32(d1[0]);
                appointment.StartTime = new DateTime(iYear, iMonth, iDay, (t1.Length == 2 ? Convert.ToInt32(t1[0]) : 0), (t1.Length == 2 ? Convert.ToInt32(t1[0]) : 0), 0);

                string[] d2 = sDates[1].Split('/');
                string[] t2 = new string[] { };
                if (sTimes.Length == 2)
                {
                    t2 = sTimes[1].Split(':');
                }
                iYear = Convert.ToInt32(d2[2].Substring(0, d2[2].IndexOf(' ')));
                iMonth = Convert.ToInt32(d2[1]);
                iDay = Convert.ToInt32(d2[0]);
                appointment.EndTime = new DateTime(iYear, iMonth, iDay, (t2.Length == 2 ? Convert.ToInt32(t2[0]) : 0), (t1.Length == 2 ? Convert.ToInt32(t2[0]) : 0), 0);

                appointment.Subject = SharedData.dSchedule["name"];

                appointment.CategoryColor = Appointment.CategoryGreen;
                appointment.TimeMarkedAs = Appointment.TimerMarkerBusy;
                appointment.Locked = true;
                appointment.Tag = SharedData.iBookingID;
                cmBookings.Appointments.Add(appointment);

                cvBookings.CalendarModel = cmBookings;
            }

            SharedData.iBookingID = 0;
            LoadBookings();
        }

        private void mBookingsRemove_Click(object sender, EventArgs e)
        {
            ReadOnlyCollection<AppointmentView> appointments = cvBookings.SelectedAppointments;
            if (appointments.Count == 0)
            {
                MessageBox.Show("To remove the appointment, please\nselect it and try again.", "Nothing selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (AppointmentView ap in appointments)
            {
                Program.DB.AddParameter("@id", ap.Appointment.Tag);
                Program.DB.AddParameter("@dates", DBNull.Value);
                Program.DB.AddParameter("@times", DBNull.Value);
                int i = Program.DB.Update("UPDATE Jobs SET BDates=@dates,BTimes=@times WHERE ID=@id;");
                if (i > 0)
                {
                    cvBookings.CalendarModel.Appointments.Remove(ap.Appointment);
                    return;
                }

                MessageBox.Show("The selected booking couldn't be removed.\nPlease try again.", "Failed to remove", MessageBoxButtons.OK, MessageBoxIcon.Error);
                break;
            }
        }

        private void mBookingsComplete_Click(object sender, EventArgs e)
        {

        }

        private void mBookingsGridAdd_Click(object sender, EventArgs e)
        {
            mBookingsAdd.PerformClick();
        }

        private void mBookingsGridRemove_Click(object sender, EventArgs e)
        {
            if (iSSItemSelected > 0)
            {
                Program.DB.AddParameter("@id", iSSItemSelected);
                Program.DB.AddParameter("@dates", DBNull.Value);
                Program.DB.AddParameter("@times", DBNull.Value);
                int i = Program.DB.Update("UPDATE Jobs SET BDates=@dates,BTimes=@times WHERE ID=@id;");
                if (i > 0)
                {
                    wsCurrent = rgBookings.CurrentWorksheet.Name;
                    LoadBookingsGrid();
                    LoadBookings();
                    return;
                }

                MessageBox.Show("The selected booking couldn't be removed.\nPlease try again.", "Failed to remove", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mBookingsGridComplete_Click(object sender, EventArgs e)
        {

        }

        private void mBookingsListAdd_Click(object sender, EventArgs e)
        {
            mBookingsAdd.PerformClick();
        }

        private void mBookingsListRemove_Click(object sender, EventArgs e)
        {
            /*
            int iKey = 0;
            if (Convert.ToInt32(gBookings.SelectedRows[0].Value) > 0)
            {
                iKey = Convert.ToInt32(gBookings.SelectedRows[0].Cells[0].Value);
            }

            if (iKey > 0)
            {
                int iID = Program.DB.Delete("DELETE FROM Jobs WHERE Job=" + iKey + ";");
                if (iID < 1)
                {
                    MessageBox.Show("The removal failed. Please try again.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("The removal was successful.", "Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadBookings();
            }
            */
        }

        private void mBookingsListComplete_Click(object sender, EventArgs e)
        {

        }

        private void mEnquiriesAdd_Click(object sender, EventArgs e)
        {
            txtEnquiryCompany.Text = "";
            txtEnquiryEmail.Text = "";
            txtEnquiryInfo.Text = "";
            txtEnquiryInfoWanted.Text = "";
            txtEnquiryName.Text = "";
            txtEnquiryPhone.Text = "";
            txtEnquiryReferrer.Text = "";
            cbxEnquiryType.SelectedIndex = -1;
        }

        private void mEnquiriesRemove_Click(object sender, EventArgs e)
        {

        }

        private void mEnquiriesBooking_Click(object sender, EventArgs e)
        {
            SharedData.sBookingCompany = txtEnquiryCompany.Text;
            SharedData.sBookingContact = txtEnquiryName.Text;
            SharedData.sBookingEmail = txtEnquiryEmail.Text;
            SharedData.sBookingPhone = txtEnquiryPhone.Text;

            Form frmBooking = new frmBooking();
            DialogResult dlg = frmBooking.ShowDialog();
            if (dlg == DialogResult.OK)
            {
                ms.SelectedTab = mtBookings;
            }
        }

        private void mCoursesAdd_Click(object sender, EventArgs e)
        {
            txtCourseCert.Text = "";
            txtCourseDetails.Text = "";
            txtCourseDuration.Text = "";
            txtCourseName.Text = "";
            txtCoursePricing.Text = "";
        }

        private void mCoursesRemove_Click(object sender, EventArgs e)
        {

        }

        private void mCompaniesAdd_Click(object sender, EventArgs e)
        {
            txtCompanyAddress.Text = "";
            txtCompanyContact.Text = "";
            txtCompanyEmail.Text = "";
            txtCompanyName.Text = "";
            txtCompanyNotes.Text = "";
            txtCompanyPhone.Text = "";
            txtCompanyReg.Text = "";
            txtCompanyRegVat.Text = "";
            txtCompanyTrading.Text = "";
        }

        private void mCompaniesRemove_Click(object sender, EventArgs e)
        {

        }

        private void mContactsAdd_Click(object sender, EventArgs e)
        {
            txtContactAddress.Text = "";
            txtContactCompany.Text = "";
            txtContactEmail.Text = "";
            txtContactNameFirst.Text = "";
            txtContactNameLast.Text = "";
            txtContactNameTitle.Text = "";
            txtContactNotes.Text = "";
            txtContactPhone.Text = "";
            lvContactDocuments.Clear();
            lblContactFileAccessed.Text = "";
            lblContactFileAccessedVal.Text = "";
            lblContactFileLocation.Text = "";
            lblContactFileLocationVal.Text = "";
            lblContactFileModified.Text = "";
            lblContactFileModifiedVal.Text = "";
            lblContactFileName.Text = "";
            lblContactFileNameVal.Text = "";
            lblContactFileSize.Text = "";
            lblContactFileSizeVal.Text = "";
        }

        private void mContactsRemove_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region List Clicked

        private void gContacts_RowClick(object sender, GridRowClickEventArgs e)
        {
            if (e.MouseEventArgs.Button == MouseButtons.Right)
            {
                Point pos = gContacts.PointToClient(Cursor.Position);
                mContacts.Show(gContacts, pos);
            }
            else if (e.MouseEventArgs.Button == MouseButtons.Left)
            {
                if (e.GridRow.RowIndex > -1 && e.MouseEventArgs.Button == MouseButtons.Left)
                {
                    GridElement row = gContacts.PrimaryGrid.Rows[e.GridRow.RowIndex];

                    Program.DB.AddParameter("ID", row.Tag);
                    DataSet c = Program.DB.SelectAll("SELECT * FROM Contacts WHERE ID=@ID;");
                    if (c.Tables.Count > 0 && c.Tables[0].Rows.Count > 0)
                    {
                        SharedData.iCommentID = Convert.ToInt32(c.Tables[0].Rows[0]["ID"]);

                        txtContactNameTitle.Text = c.Tables[0].Rows[0]["NameTitle"].ToString();
                        txtContactNameFirst.Text = c.Tables[0].Rows[0]["NameFirst"].ToString();
                        txtContactNameLast.Text = c.Tables[0].Rows[0]["NameLast"].ToString();
                        txtContactPhone.Text = c.Tables[0].Rows[0]["Phones"].ToString();
                        txtContactEmail.Text = c.Tables[0].Rows[0]["Emails"].ToString();
                    }
                }
            }
        }

        private void gCompanies_RowClick(object sender, GridRowClickEventArgs e)
        {
            if (e.MouseEventArgs.Button == MouseButtons.Right)
            {
                Point pos = gCompanies.PointToClient(Cursor.Position);
                mCompanies.Show(gCompanies, pos);
            }
            else if (e.MouseEventArgs.Button == MouseButtons.Left)
            {
                if (e.GridRow.RowIndex > -1 && e.MouseEventArgs.Button == MouseButtons.Left)
                {
                    GridElement row = gCompanies.PrimaryGrid.Rows[e.GridRow.RowIndex];

                    Program.DB.AddParameter("ID", row.Tag);
                    DataSet c = Program.DB.SelectAll("SELECT * FROM Companies WHERE ID=@ID;");
                    if (c.Tables.Count > 0 && c.Tables[0].Rows.Count > 0)
                    {
                        SharedData.iCommentID = Convert.ToInt32(c.Tables[0].Rows[0]["ID"]);

                        txtCompanyName.Text = c.Tables[0].Rows[0]["Name"].ToString();
                        txtCompanyTrading.Text = c.Tables[0].Rows[0]["TradingAs"].ToString();
                        txtCompanyReg.Text = c.Tables[0].Rows[0]["RegNumber"].ToString();
                        txtCompanyRegVat.Text = c.Tables[0].Rows[0]["RegNumberVat"].ToString();
                        txtCompanyPhone.Text = c.Tables[0].Rows[0]["Phones"].ToString();
                        txtCompanyEmail.Text = c.Tables[0].Rows[0]["Emails"].ToString();
                        txtCompanyAddress.Text = c.Tables[0].Rows[0]["Addresses"].ToString();
                        txtCompanyContact.Text = c.Tables[0].Rows[0]["Contacts"].ToString();
                        txtCompanyNotes.Text = c.Tables[0].Rows[0]["Notes"].ToString();
                    }
                }
            }
        }

        private void gCourses_RowClick(object sender, GridRowClickEventArgs e)
        {
            if (e.MouseEventArgs.Button == MouseButtons.Right)
            {
                Point pos = gCourses.PointToClient(Cursor.Position);
                mCourses.Show(gCourses, pos);
            }
            else if (e.MouseEventArgs.Button == MouseButtons.Left)
            {
                if (e.GridRow.RowIndex > -1 && e.MouseEventArgs.Button == MouseButtons.Left)
                {
                    GridElement row = gCourses.PrimaryGrid.Rows[e.GridRow.RowIndex];

                    Program.DB.AddParameter("ID", row.Tag);
                    DataSet c = Program.DB.SelectAll("SELECT * FROM Courses WHERE ID=@ID;");
                    if (c.Tables.Count > 0 && c.Tables[0].Rows.Count > 0)
                    {
                        SharedData.iCommentID = Convert.ToInt32(c.Tables[0].Rows[0]["ID"]);

                        txtCourseName.Text = c.Tables[0].Rows[0]["Name"].ToString();
                        txtCourseCert.Text = c.Tables[0].Rows[0]["Certification"].ToString();
                        txtCourseDuration.Text = c.Tables[0].Rows[0]["Duration"].ToString();
                        txtCoursePricing.Text = c.Tables[0].Rows[0]["Pricing"].ToString();
                        txtCourseDetails.Text = c.Tables[0].Rows[0]["Details"].ToString();
                    }
                }
            }
        }

        private void gEnquiries_RowClick(object sender, GridRowClickEventArgs e)
        {
            if (e.MouseEventArgs.Button == MouseButtons.Right)
            {
                Point pos = gEnquiries.PointToClient(Cursor.Position);
                mEnquiries.Show(gEnquiries, pos);
            }
            else if (e.MouseEventArgs.Button == MouseButtons.Left)
            {
                if (e.GridRow.RowIndex > -1 && e.MouseEventArgs.Button == MouseButtons.Left)
                {
                    GridElement row = gEnquiries.PrimaryGrid.Rows[e.GridRow.RowIndex];

                    Program.DB.AddParameter("ID", row.Tag);
                    DataSet c = Program.DB.SelectAll("SELECT * FROM Jobs WHERE ID=@ID;");
                    if (c.Tables.Count > 0 && c.Tables[0].Rows.Count > 0)
                    {
                        SharedData.iCommentID = Convert.ToInt32(c.Tables[0].Rows[0]["ID"]);

                        txtEnquiryName.Text = c.Tables[0].Rows[0]["EName"].ToString();
                        txtEnquiryCompany.Text = c.Tables[0].Rows[0]["ECompany"].ToString();
                        txtEnquiryPhone.Text = c.Tables[0].Rows[0]["EPhone"].ToString();
                        txtEnquiryEmail.Text = c.Tables[0].Rows[0]["EEmail"].ToString();
                        txtEnquiryInfo.Text = c.Tables[0].Rows[0]["EInfo"].ToString();
                        txtEnquiryReferrer.Text = c.Tables[0].Rows[0]["EReferer"].ToString();
                        txtEnquiryInfoWanted.Text = c.Tables[0].Rows[0]["EInfoWanted"].ToString();
                    }
                }
            }
        }

        private void gBookings_RowClick(object sender, GridRowClickEventArgs e)
        {
            if (e.MouseEventArgs.Button == MouseButtons.Right)
            {
                Point pos = gBookings.PointToClient(Cursor.Position);
                mBookingsList.Show(gBookings, pos);
            }
            else if (e.MouseEventArgs.Button == MouseButtons.Left)
            {
                if (e.GridRow.RowIndex > -1 && e.MouseEventArgs.Button == MouseButtons.Left)
                {
                    SharedData.iBookingID = Convert.ToInt32(gBookings.PrimaryGrid.Rows[e.GridRow.RowIndex].Tag);
                }
            }
        }

        private void gBookings_RowDoubleClick(object sender, GridRowDoubleClickEventArgs e)
        {
            if (e.GridRow.RowIndex > -1 && e.MouseEventArgs.Button == MouseButtons.Left && gBookings.PrimaryGrid.Rows[e.GridRow.RowIndex].Tag != null)
            {
                SharedData.iBookingID = Convert.ToInt32(gBookings.PrimaryGrid.Rows[e.GridRow.RowIndex].Tag);

                Form frmBooking = new frmBooking();
                DialogResult dlg = frmBooking.ShowDialog();
                if (dlg == DialogResult.OK && SharedData.iBookingID > 0 && SharedData.dSchedule.Count > 0)
                {
                    LoadBookings();
                }

                SharedData.iBookingID = 0;
            }
        }

        #endregion

        private void ms_SelectedTabChanged(object sender, EventArgs e)
        {
            switch (ms.SelectedTab.Text)
            {
                case "Bookings":
                    LoadBookings();
                    LoadBookingsGrid();
                    break;
                case "Enquiries":
                    LoadEnquiries();
                    break;
                case "Courses":
                    LoadCourses();
                    break;
                case "Companies":
                    LoadCompanies();
                    break;
                case "Contacts":
                    LoadContacts();
                    break;
            }
        }

        private void cbxContactNameTitle_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtContactNameTitle.Text = cbxContactNameTitle.SelectedText;
        }
    }
}
