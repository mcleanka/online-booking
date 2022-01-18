namespace OnlineBooking
{
    public partial class LogInForm : Form
    {
        private RegisterUserForm registerUserForm;

        #pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public LogInForm()
        #pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            InitializeComponent();
        }

        private void LinkLabelRegisterHere_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registerUserForm = new RegisterUserForm();

            registerUserForm.Show();

            this.Hide();
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                TextBoxPassword.PasswordChar = (char)0;
            }
            else
            {
                TextBoxPassword.PasswordChar= '*';
            }
        }

        private void ButtonCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonLogIn_Click(object sender, EventArgs e)
        {
            if(
                string.IsNullOrEmpty(this.TextBoxUserName.Text.Trim()) ||
                string.IsNullOrEmpty(this.TextBoxPassword.Text.Trim())
                )
            {
                /// Both field are empty
                MessageBox.Show(
                    "Please enter your username and password",
                    "Input Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation
                );

                if (this.TextBoxUserName.CanSelect)
                {
                    this.TextBoxUserName.Select();
                }

                return;

            }

            Database.sql = "SELECT Username, Password FROM Users WHERE Username = @us AND Password = @pa";

            Database.command.Parameters.Clear();
            Database.command.CommandType = System.Data.CommandType.Text;
            Database.command.CommandText = Database.sql;

            Database.command.Parameters.AddWithValue("@us", this.TextBoxUserName.Text.Trim().ToString());
            Database.command.Parameters.AddWithValue("@pa", this.TextBoxUserName.Text.Trim().ToString());

            Database.OpenConnection();
            Database.dataAdapter = Database.command.ExecuteReader();

            if(Database.dataAdapter.HasRows)
            {
                while (Database.dataAdapter.Read())
                {
                    Database.currentFullName = Database.dataAdapter[0].ToString() + " " + Database.dataAdapter[0].ToString();
                    MessageBox.Show(
                        "Welcome " + Database.currentFullName,
                        "Login successed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }

                this.TextBoxUserName.Text = String.Empty;
                this.TextBoxPassword.Text = String.Empty;

                this.Hide();

                FormServices formServices = new();
                formServices.ShowDialog();

                
            }
            else
            {
                MessageBox.Show(
                    "Invalid log in supplied",
                    "Input Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                if(this.TextBoxUserName.CanSelect)
                {
                    this.TextBoxUserName.Select();
                }

            }

            Database.dataAdapter.Close();
            Database.CloseConnection();
        }
    }
}