using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;

namespace Common
{
    #region Enums

    public enum SqlProviders
    {
        SqlServer
    }

    #endregion

    public class Database
    {
        #region Members

        private DbCommand dbCommand;
        private DbConnection dbConnection;
        private DbProviderFactory dbFactory;
        private string sConnection;

        public string ResponseText = "";

        #endregion

        #region Properties

        public string ConnectionString
        {
            get
            {
                return sConnection;
            }
            set
            {
                if (value != "")
                {
                    sConnection = value;
                }
            }
        }

        public DbConnection Connection
        {
            get
            {
                return dbConnection;
            }
        }

        public DbCommand Command
        {
            get
            {
                return dbCommand;
            }
        }

        #endregion

        #region Parameters

        public int AddParameter(string name, object value, string type = "", int length = -1)
        {
            DbParameter p = dbFactory.CreateParameter();
            if (type == "image")
            {
                //p = new SqlParameter(name, SqlDbType.VarBinary, length);
                p.DbType = DbType.Binary;
            }
            else
            {
                //p.ParameterName = name;
            }
            p.ParameterName = name;
            p.Value = value;
            return Command.Parameters.Add(p);
        }

        public int AddParameter(DbParameter p)
        {
            return Command.Parameters.Add(p);
        }

        #endregion

        #region Connection Methods

        public void CreateSession(string sHost, int iPort, string sUser, string sPass, string sData, SqlProviders pType)
        {
            switch (pType)
            {
                case SqlProviders.SqlServer:
                    dbFactory = SqlClientFactory.Instance;
                    break;
            }

            dbConnection = dbFactory.CreateConnection();
            dbCommand = dbFactory.CreateCommand();

            dbConnection.ConnectionString = @SetConnectionString(sHost, iPort, sUser, sPass, sData, pType);
            dbCommand.Connection = dbConnection;
        }

        public string SetConnectionString(string sHost, int iPort, string sUser, string sPass, string sData, SqlProviders pType)
        {
            string cs = "";

            switch (pType)
            {
                case SqlProviders.SqlServer:
                    cs = "Data Source=" + sHost;
                    cs += iPort > 0 ? "," + iPort.ToString() : "";
                    if (sUser != "")
                    {
                        cs += ";User Id=" + sUser + ";";
                        if (sPass != "")
                        {
                            cs += ";Password=" + sPass + ";";
                        }
                    }
                    else
                    {
                        cs += ";Integrated Security=True;";
                    }
                    cs += "Trusted_Connection=True;Initial Catalog=" + sData;
                    break;
            }

            if (cs != "")
            {
                sConnection = cs;
            }

            return sConnection;
        }

        public bool IsAvailable()
        {
            return true;
        }

        #endregion

        #region Data Methods

        public DataSet SelectAll(string query)
        {
            DbDataAdapter adapter = dbFactory.CreateDataAdapter();
            Command.CommandType = CommandType.Text;
            Command.CommandText = query;
            adapter.SelectCommand = Command;
            DataSet ds = new DataSet();

            try
            {
                adapter.Fill(ds);
            }
            catch (SqlException se)
            {
                switch (se.Number)
                {
                    case 4060:
                        System.Windows.Forms.MessageBox.Show("Couldn't connect to the specified database.\nPlease check the details and try again." + "\n\n" + se.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                        break;
                    default:
                        System.Windows.Forms.MessageBox.Show(se.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                        break;
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                Command.Parameters.Clear();

                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                    //Connection.Dispose();
                    Command.Dispose();
                }
            }

            return ds;
        }

        private static DataTable DictionariesToDataTable<T>(IEnumerable<IDictionary<string, T>> source)
        {
            if (source == null)
            {
                return null;
            }

            var result = new DataTable();
            using (var e = source.GetEnumerator())
            {
                if (!e.MoveNext())
                {
                    return result;
                }

                if (e.Current.Keys.Count == 0)
                {
                    throw new InvalidOperationException();
                }

                var length = e.Current.Keys.Count;

                result.Columns.AddRange(e.Current.Keys.Select(k => new DataColumn(k, typeof(T))).ToArray());

                do
                {
                    if (e.Current.Values.Count != length)
                    {
                        throw new InvalidOperationException();
                    }

                    result.Rows.Add(e.Current.Values);
                }
                while (e.MoveNext());

                return result;
            }
        }

        public int Delete(string query)
        {
            int iAffected = 0;
            DbDataAdapter adapter = dbFactory.CreateDataAdapter();
            Command.CommandType = CommandType.Text;
            Command.CommandText = query;
            adapter.DeleteCommand = Command;

            try
            {
                Connection.Open();
                iAffected = (int)adapter.DeleteCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Command.Parameters.Clear();

                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                    //Connection.Dispose();
                    Command.Dispose();
                }
            }

            return iAffected;
        }

        public int Insert(string query, bool returnID = true)
        {
            int iInsertID = 0;
            DbDataAdapter adapter = dbFactory.CreateDataAdapter();
            Command.CommandType = CommandType.Text;
            Command.CommandText = query + ";" + (returnID == true ? " SELECT CAST(scope_identity() AS int);" : "");
            adapter.InsertCommand = Command;

            try
            {
                Connection.Open();
                iInsertID = (int)adapter.InsertCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Command.Parameters.Clear();

                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                    //Connection.Dispose();
                    Command.Dispose();
                }
            }

            return iInsertID;
        }

        public int Update(string query)
        {
            int iAffected = 0;
            DbDataAdapter adapter = dbFactory.CreateDataAdapter();
            Command.CommandType = CommandType.Text;
            Command.CommandText = query;
            adapter.UpdateCommand = Command;

            try
            {
                Connection.Open();
                iAffected = (int)adapter.UpdateCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Command.Parameters.Clear();

                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                    //Connection.Dispose();
                    Command.Dispose();
                }
            }

            return iAffected;
        }

        #endregion
    }
}
