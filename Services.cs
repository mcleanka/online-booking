using System.Data;
using System.Data.OleDb;

namespace OnlineBooking
{
    public partial class FormServices : Form
    {
        public FormServices()
        {
            InitializeComponent();
        }

        private void FormServices_Load(object sender, EventArgs e)
        {
            Database.sql = "SELECT * FROM Users ORDER BY UserID";

            Database.command.CommandType = System.Data.CommandType.Text;
            Database.command.CommandText = Database.sql;

            Database.OpenConnection();
            Database.dataAdapter = Database.command.ExecuteReader();

            System.Data.DataTable dataTable = new();

            dataTable.Columns.Add("Service", typeof(string));
            dataTable.Columns.Add("Price", typeof(string));

            if (Database.dataAdapter.HasRows)
            {
                while (Database.dataAdapter.Read())
                {
                    Database.sessionUserName = Database.dataAdapter[0].ToString() + " " + Database.dataAdapter[0].ToString();

                    DataRow row = dataTable.NewRow();
                    row["Service"] = Database.dataAdapter[0].ToString();
                    row["Price"] = Database.dataAdapter[1].ToString();
                    dataTable.Rows.Add(row);
                }
            }

            dataGridViewAllServices.DataSource = dataTable;

            Database.dataAdapter.Close();
            Database.CloseConnection();
        }
    }
}
