using System.Data.OleDb;

namespace OnlineBooking
{
    class Database
    {
        public static OleDbConnection connection = new();
        public static OleDbCommand command = new("", connection);
        public static OleDbDataReader? dataAdapter;

        #pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public static string currentFullName;
        #pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        #pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public static string sql;
        #pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

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
