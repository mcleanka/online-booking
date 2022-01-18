using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.Odbc;
using System.Data.OleDb;

using System.Windows.Forms;

namespace OnlineBooking
{
    class Database
    {
        public static OleDbConnection connection = new();
        public static OleDbCommand command = new();
        ///public static OleDbDataAdapter dataAdapter;

        ///public static string currentFullName;
        ///public static string sql;

        public static string GetConnectionString()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + 
            Application.StartupPath + "\\DB\\Order Bookings DB.accdb";

            return connectionString;
        }

        public static void OpenConnection()
        {
            try
            {
                connection.ConnectionString = GetConnectionString();
                connection.Open();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "DB Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void CloseConnection()
        {
            try
            {
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "DB Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
