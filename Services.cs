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
            Database.sql = "SELECT ServiceID, ServiceName, Price FROM Services ORDER BY ServiceID";

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
                    System.Data.DataRow row = dataTable.NewRow();
                    row["Service"] = Database.dataAdapter[0].ToString();
                    row["Price"] = Database.dataAdapter[1].ToString();
                    dataTable.Rows.Add(row);
                }
            }

            dataGridViewAllServices.DataSource = dataTable;

            Database.dataAdapter.Close();
            Database.CloseConnection();
        }

        private void ButtonAddService_Click(object sender, EventArgs e)
        {
            if (
                string.IsNullOrEmpty(this.TextBoxServiceName.Text.Trim()) ||
                string.IsNullOrEmpty(this.TextBoxServicePrice.Text.Trim())
                )
            {
                /// fill all field
                MessageBox.Show(
                    "All fields are required",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation
                );

                if (this.TextBoxServiceName.CanSelect)
                {
                    this.TextBoxServiceName.Select();
                }

                return;

            }

            Database.sql = "INSERT INTO Services ([ServiceName], [Price]) VALUES(@name, @price)";

            // preparing connection
            Database.command.Parameters.Clear();
            Database.command.CommandType = System.Data.CommandType.Text;
            Database.command.CommandText = Database.sql;

            // params for user creditations
            Database.command.Parameters.AddWithValue("@name", this.TextBoxServiceName.Text.Trim().ToString());
            Database.command.Parameters.AddWithValue("@price", this.TextBoxServicePrice.Text.Trim().ToString());

            // starting connection
            Database.OpenConnection();

            MessageBox.Show(
                        "Service added successfully!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );


            // close db connection
            Database.command.ExecuteNonQuery();
            Database.CloseConnection();

            // reload the datasetview
            ReloadDataSetView();
        }

        private void ReloadDataSetView()
        {
            System.Data.DataTable dataTable = new();

            Database.OpenConnection();

            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT ServiceID, ServiceName, Price FROM Services ORDER BY ServiceID", Database.connection);
            adapter.Fill(dataTable);

            dataGridViewAllServices.DataSource = dataTable;

            Database.CloseConnection();

            // clear inputs
            this.TextBoxServiceID.Text = String.Empty;
            this.TextBoxServiceName.Text = String.Empty;
            this.TextBoxServicePrice.Text = String.Empty;
        }

        private void ButtonAmendService_Click(object sender, EventArgs e)
        {
            if (
                string.IsNullOrEmpty(this.TextBoxServiceID.Text.Trim()) ||
                string.IsNullOrEmpty(this.TextBoxServiceName.Text.Trim()) ||
                string.IsNullOrEmpty(this.TextBoxServicePrice.Text.Trim())
                )
            {
                /// fill all field
                MessageBox.Show(
                    "All fields are required",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation
                );

                if (this.TextBoxServiceID.CanSelect)
                {
                    this.TextBoxServiceID.Select();
                }

                return;


            }
            Database.OpenConnection();

            Database.sql = "UPDATE Services SET [ServiceName] = @name, [Price] = @price WHERE [ServiceID] = @id";

            Database.command.Parameters.Clear();
            Database.command.CommandType = System.Data.CommandType.Text;
            Database.command.CommandText = Database.sql;

            // params for user creditations
            Database.command.Parameters.AddWithValue("@id", Int32.Parse(this.TextBoxServiceID.Text.Trim().ToString()));
            Database.command.Parameters.AddWithValue("@name", this.TextBoxServiceName.Text.Trim().ToString());
            Database.command.Parameters.AddWithValue("@price", Int32.Parse(this.TextBoxServicePrice.Text.Trim().ToString()));

            Database.command.ExecuteNonQuery();
            Database.CloseConnection();

            MessageBox.Show("Record Update successfully!");

            ReloadDataSetView();
        }

        private void ButtonBookService_Click(object sender, EventArgs e)
        {
            Database.sql = "INSERT INTO Bookings ([CustomerID], [ServiceID], [Amount], [BookingDate]) VALUES(@customer, @service, @amount, @dated)";

            // preparing connection
            Database.command.Parameters.Clear();
            Database.command.CommandType = System.Data.CommandType.Text;
            Database.command.CommandText = Database.sql;

            // params
            Database.command.Parameters.AddWithValue("@customer", Database.sessionUserID);
            Database.command.Parameters.AddWithValue("@service", this.TextBoxServiceID.Text.Trim().ToString());
            Database.command.Parameters.AddWithValue("@amount", CalculateBookingAmount());
            Database.command.Parameters.AddWithValue("@dated", DateTime.Now.ToString("yyyy’-‘MM’-‘dd’T’HH’:’mm’:’ss"));

            // starting connection
            Database.OpenConnection();

            MessageBox.Show(
                        "Booking successful!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

            // close booking and opening checkout window
            this.Hide();
            FormCheckOut formCheckOut = new();
            formCheckOut.ShowDialog();

            // close db connection
            Database.command.ExecuteNonQuery();
            Database.CloseConnection();
        }

        private int CalculateBookingAmount()
        {
            return 3;
        }
    }
}
