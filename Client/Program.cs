using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

using Common;
using unvell.ReoGrid;

namespace Client
{
    static class Program
    {
        public static Database DB = new Database();
        public static Globals Global = new Globals();

        public static bool bSignOut = false;
        public static Form frmCurrent;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (Properties.Settings.Default.PathToData == "")
            {
                string sDir = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\" + Application.CompanyName + "\\" + Application.ProductName + "\\";
                if (!Directory.Exists(sDir))
                {
                    DirectoryInfo inf = Directory.CreateDirectory(sDir);
                    if (inf.Exists)
                    {
                        Properties.Settings.Default.PathToData = sDir;
                        Properties.Settings.Default.Save();
                    }
                }
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (!Global.UserSigned)
            {
                frmCurrent = new frmSignIn();
                Application.Run(frmCurrent);
            }
        }
    }

    public static class SharedData
    {
        public static int iEnquiryID = 0;
        public static int iBookingID = 0;
        public static int iCourseID = 0;
        public static int iCompanyID = 0;
        public static int iContactID = 0;
        public static int iAddressID = 0;
        public static int iEmailID = 0;
        public static int iPhoneID = 0;
        public static int iCommentID = 0;
        public static Dictionary<string, string> dSchedule = new Dictionary<string, string>();
        public static DateTime dtSelectedStart = DateTime.Today;
        public static DateTime dtSelectedFinish = DateTime.Today;

        public static string sBookingContact = "";
        public static string sBookingCompany = "";
        public static string sBookingPhone = "";
        public static string sBookingEmail = "";
        public static string sBookingRooms = "";
    }

    public class ComboItem
    {
        public string Text { get; set; }
        public int Value { get; set; }
    }

    public static class DateExtension
    {
        public static long ToUnixTimestamp(this DateTime target)
        {
            var dt = new DateTime(1970, 1, 1, 0, 0, 0, target.Kind);
            var ts = System.Convert.ToInt64((target - dt).TotalSeconds);
            return ts;
        }

        public static DateTime ToDateTime(this DateTime target, long ts)
        {
            var dt = new DateTime(1970, 1, 1, 0, 0, 0, target.Kind);
            return dt.AddSeconds(ts);
        }
    }
}
