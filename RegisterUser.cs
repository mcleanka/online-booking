using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineBooking
{
    public partial class RegisterUserForm : Form
    {
        private LogInForm logInForm;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public RegisterUserForm()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            InitializeComponent();
        }

        private void RegisterUserForm_Load(object sender, EventArgs e)
        {

        }

        private void LinkLabelLogIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            logInForm = new LogInForm();
            this.Hide();
            logInForm.Show();
        }
    }
}
