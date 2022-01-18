namespace OnlineBooking
{
    public partial class RegisterUserForm : Form
    {
        public RegisterUserForm()
        {
            InitializeComponent();
        }

        private void LinkLabelLogIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LogInForm logInForm = new();
            this.Hide();
            logInForm.Show();
        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            if (
                string.IsNullOrEmpty(this.TextBoxUserName.Text.Trim()) ||
                string.IsNullOrEmpty(this.TextBoxPassword.Text.Trim())
                )
            {
                /// fill all field
                MessageBox.Show(
                    "All fields are required",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation
                );

                if (this.TextBoxUserName.CanSelect)
                {
                    this.TextBoxUserName.Select();
                }

                return;

            }

            Database.sql = "INSERT INTO Users ([Username], [Password]) VALUES(@user, @passcode)";

            // preparing connection
            Database.command.Parameters.Clear();
            Database.command.CommandType = System.Data.CommandType.Text;
            Database.command.CommandText = Database.sql;

            // params for user creditations
            Database.command.Parameters.AddWithValue("@user", this.TextBoxUserName.Text.Trim().ToString());
            Database.command.Parameters.AddWithValue("@passcode", this.TextBoxPassword.Text.Trim().ToString());

            // starting connection
            Database.OpenConnection();

            MessageBox.Show(
                        "Registration successful!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

            // close reg form and open services form
            this.Hide();
            FormServices formServices = new();
            formServices.ShowDialog();

            // close db connection
            Database.command.ExecuteNonQuery();
            Database.CloseConnection();
        }
    }
}
