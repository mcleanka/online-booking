namespace OnlineBooking
{
    partial class LogInForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelUsername = new System.Windows.Forms.Label();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.LabelOnlineBooking = new System.Windows.Forms.Label();
            this.TextBoxUserName = new System.Windows.Forms.TextBox();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.ButtonLogIn = new System.Windows.Forms.Button();
            this.LinkLabelRegisterHere = new System.Windows.Forms.LinkLabel();
            this.LabelDontHaveAccount = new System.Windows.Forms.Label();
            this.CheckBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.ButtonCloseApp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelUsername
            // 
            this.LabelUsername.AutoSize = true;
            this.LabelUsername.Location = new System.Drawing.Point(176, 166);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(75, 20);
            this.LabelUsername.TabIndex = 0;
            this.LabelUsername.Text = "Username";
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Location = new System.Drawing.Point(176, 215);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(70, 20);
            this.LabelPassword.TabIndex = 1;
            this.LabelPassword.Text = "Password";
            // 
            // LabelOnlineBooking
            // 
            this.LabelOnlineBooking.AutoSize = true;
            this.LabelOnlineBooking.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelOnlineBooking.Location = new System.Drawing.Point(282, 46);
            this.LabelOnlineBooking.Name = "LabelOnlineBooking";
            this.LabelOnlineBooking.Size = new System.Drawing.Size(350, 41);
            this.LabelOnlineBooking.TabIndex = 2;
            this.LabelOnlineBooking.Text = "Login To Service Booking";
            // 
            // TextBoxUserName
            // 
            this.TextBoxUserName.Location = new System.Drawing.Point(320, 159);
            this.TextBoxUserName.Name = "TextBoxUserName";
            this.TextBoxUserName.PlaceholderText = "Enter username";
            this.TextBoxUserName.Size = new System.Drawing.Size(327, 27);
            this.TextBoxUserName.TabIndex = 3;
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Location = new System.Drawing.Point(320, 215);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '*';
            this.TextBoxPassword.PlaceholderText = "Enter valid passowrd";
            this.TextBoxPassword.Size = new System.Drawing.Size(327, 27);
            this.TextBoxPassword.TabIndex = 4;
            // 
            // ButtonLogIn
            // 
            this.ButtonLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ButtonLogIn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonLogIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonLogIn.Location = new System.Drawing.Point(514, 291);
            this.ButtonLogIn.Name = "ButtonLogIn";
            this.ButtonLogIn.Size = new System.Drawing.Size(133, 40);
            this.ButtonLogIn.TabIndex = 12;
            this.ButtonLogIn.Text = "Log In";
            this.ButtonLogIn.UseVisualStyleBackColor = false;
            this.ButtonLogIn.Click += new System.EventHandler(this.ButtonLogIn_Click);
            // 
            // LinkLabelRegisterHere
            // 
            this.LinkLabelRegisterHere.AutoSize = true;
            this.LinkLabelRegisterHere.Location = new System.Drawing.Point(494, 395);
            this.LinkLabelRegisterHere.Name = "LinkLabelRegisterHere";
            this.LinkLabelRegisterHere.Size = new System.Drawing.Size(99, 20);
            this.LinkLabelRegisterHere.TabIndex = 13;
            this.LinkLabelRegisterHere.TabStop = true;
            this.LinkLabelRegisterHere.Text = "Register Here";
            this.LinkLabelRegisterHere.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelRegisterHere_LinkClicked);
            // 
            // LabelDontHaveAccount
            // 
            this.LabelDontHaveAccount.AutoSize = true;
            this.LabelDontHaveAccount.Location = new System.Drawing.Point(319, 395);
            this.LabelDontHaveAccount.Name = "LabelDontHaveAccount";
            this.LabelDontHaveAccount.Size = new System.Drawing.Size(163, 20);
            this.LabelDontHaveAccount.TabIndex = 14;
            this.LabelDontHaveAccount.Text = "Don\'t have an account?";
            // 
            // CheckBoxShowPassword
            // 
            this.CheckBoxShowPassword.AutoSize = true;
            this.CheckBoxShowPassword.Location = new System.Drawing.Point(320, 248);
            this.CheckBoxShowPassword.Name = "CheckBoxShowPassword";
            this.CheckBoxShowPassword.Size = new System.Drawing.Size(134, 24);
            this.CheckBoxShowPassword.TabIndex = 15;
            this.CheckBoxShowPassword.Text = "Show password";
            this.CheckBoxShowPassword.UseVisualStyleBackColor = true;
            this.CheckBoxShowPassword.CheckedChanged += new System.EventHandler(this.CheckBoxShowPassword_CheckedChanged);
            // 
            // ButtonCloseApp
            // 
            this.ButtonCloseApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ButtonCloseApp.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonCloseApp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonCloseApp.Location = new System.Drawing.Point(319, 291);
            this.ButtonCloseApp.Name = "ButtonCloseApp";
            this.ButtonCloseApp.Size = new System.Drawing.Size(133, 40);
            this.ButtonCloseApp.TabIndex = 16;
            this.ButtonCloseApp.Text = "Cancel";
            this.ButtonCloseApp.UseVisualStyleBackColor = false;
            this.ButtonCloseApp.Click += new System.EventHandler(this.ButtonCloseApp_Click);
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 471);
            this.Controls.Add(this.ButtonCloseApp);
            this.Controls.Add(this.CheckBoxShowPassword);
            this.Controls.Add(this.LabelDontHaveAccount);
            this.Controls.Add(this.LinkLabelRegisterHere);
            this.Controls.Add(this.ButtonLogIn);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.TextBoxUserName);
            this.Controls.Add(this.LabelOnlineBooking);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.LabelUsername);
            this.Name = "LogInForm";
            this.Text = "LogIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LabelUsername;
        private Label LabelPassword;
        private Label LabelOnlineBooking;
        private TextBox TextBoxUserName;
        private TextBox TextBoxPassword;
        private Button ButtonLogIn;
        private LinkLabel LinkLabelRegisterHere;
        private Label LabelDontHaveAccount;
        private CheckBox CheckBoxShowPassword;
        private Button ButtonCloseApp;
    }
}