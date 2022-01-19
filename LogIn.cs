namespace OnlineBooking
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void LinkLabelRegisterHere_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterUserForm registerUserForm = new();

            registerUserForm.Show();

            this.Hide();
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

            Database.sql = "SELECT Username, Password, UserID FROM Users WHERE Username = @user AND Password = @pass";

            Database.command.Parameters.Clear();
            Database.command.CommandType = System.Data.CommandType.Text;
            Database.command.CommandText = Database.sql;

            Database.command.Parameters.AddWithValue("@user", this.TextBoxUserName.Text.Trim().ToString());
            Database.command.Parameters.AddWithValue("@pass", this.TextBoxPassword.Text.Trim().ToString());

            Database.OpenConnection();
            Database.dataAdapter = Database.command.ExecuteReader();

            if(Database.dataAdapter.HasRows)
            {
                while (Database.dataAdapter.Read())
                {
                    Database.sessionUserName = Database.dataAdapter[0].ToString();
                    Database.sessionUserID = Database.dataAdapter[2].ToString();

                    MessageBox.Show(
                        "Welcome " + Database.sessionUserName,
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

        private void CheckBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxShowPassword.Checked)
            {
                TextBoxPassword.PasswordChar = (char)0;
            }
            else
            {
                TextBoxPassword.PasswordChar = '*';
            }
        }
    }
}