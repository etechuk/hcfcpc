﻿using Microsoft.Win32;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Common
{
    public class Globals
    {
        static bool _UserSigned = false;
        public bool UserSigned { get { return _UserSigned; } set { _UserSigned = value; } }

        static bool _UserIsAdmin = false;
        public bool UserIsAdmin { get { return _UserIsAdmin; } set { _UserIsAdmin = value; } }

        static int _UserID = 0;
        public int UserID { get { return _UserID; } set { _UserID = value; } }

        static string _UserFirstName = "";
        public string UserFirstName { get { return _UserFirstName; } set { _UserFirstName = value; } }

        static string _UserLastName = "";
        public string UserLastName { get { return _UserLastName; } set { _UserLastName = value; } }
    }

    public static class Extension
    {
        public static Form CentreForm(this Form child, Form parent)
        {
            child.StartPosition = FormStartPosition.Manual;
            child.Location = new Point(parent.Location.X + (parent.Width - child.Width) / 2, parent.Location.Y + (parent.Height - child.Height) / 2);
            return child;
        }

        public static bool DirectoryIsWritable(string path, bool throwIfFailed = false)
        {
            try
            {
                using (FileStream fs = File.Create(Path.Combine(path, Path.GetRandomFileName()), 1, FileOptions.DeleteOnClose)) { }
                return true;
            }
            catch
            {
                if (throwIfFailed)
                {
                    throw;
                }
                else
                {
                    return false;
                }
            }
        }
    }

    public class Utils
    {
        public bool TryRegisteredApplication(string extension, out string registeredApp)
        {
            string extensionId = GetClassesRootKeyDefaultValue(extension);
            if (extensionId == null)
            {
                registeredApp = null;
                return false;
            }

            string openCommand = GetClassesRootKeyDefaultValue(Path.Combine(new[] { extensionId, "shell", "open", "command" }));

            if (openCommand == null)
            {
                registeredApp = null;
                return false;
            }

            registeredApp = openCommand.Replace("%1", string.Empty).Replace("\"", string.Empty).Trim();
            return true;
        }

        private static string GetClassesRootKeyDefaultValue(string keyPath)
        {
            using (var key = Registry.ClassesRoot.OpenSubKey(keyPath))
            {
                if (key == null)
                {
                    return null;
                }

                var defaultValue = key.GetValue(null);
                if (defaultValue == null)
                {
                    return null;
                }

                return defaultValue.ToString();
            }
        }
    }
}
