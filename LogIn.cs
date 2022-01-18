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

        private void LogInForm_Load(object sender, EventArgs e)
        {
            Database.OpenConnection();
            MessageBox.Show("The connection is" + Database.connection.State.ToString());

            Database.CloseConnection();
        }
    }
}