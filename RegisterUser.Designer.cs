namespace OnlineBooking
{
    partial class RegisterUserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelRegister = new System.Windows.Forms.Label();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.TextBoxUserName = new System.Windows.Forms.TextBox();
            this.LabelUsername = new System.Windows.Forms.Label();
            this.ButtonRegister = new System.Windows.Forms.Button();
            this.LabelHaveAnAccount = new System.Windows.Forms.Label();
            this.LinkLabelLogIn = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // LabelRegister
            // 
            this.LabelRegister.AutoSize = true;
            this.LabelRegister.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelRegister.Location = new System.Drawing.Point(189, 27);
            this.LabelRegister.Name = "LabelRegister";
            this.LabelRegister.Size = new System.Drawing.Size(423, 37);
            this.LabelRegister.TabIndex = 0;
            this.LabelRegister.Text = "Register To Service Booking";
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Location = new System.Drawing.Point(162, 197);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(70, 20);
            this.LabelPassword.TabIndex = 4;
            this.LabelPassword.Text = "Password";
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Location = new System.Drawing.Point(304, 190);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PlaceholderText = "Enter password";
            this.TextBoxPassword.Size = new System.Drawing.Size(329, 27);
            this.TextBoxPassword.TabIndex = 2;
            // 
            // TextBoxUserName
            // 
            this.TextBoxUserName.Location = new System.Drawing.Point(304, 116);
            this.TextBoxUserName.Name = "TextBoxUserName";
            this.TextBoxUserName.PlaceholderText = "Enter username";
            this.TextBoxUserName.Size = new System.Drawing.Size(329, 27);
            this.TextBoxUserName.TabIndex = 1;
            // 
            // LabelUsername
            // 
            this.LabelUsername.AutoSize = true;
            this.LabelUsername.Location = new System.Drawing.Point(157, 119);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(75, 20);
            this.LabelUsername.TabIndex = 10;
            this.LabelUsername.Text = "Username";
            // 
            // ButtonRegister
            // 
            this.ButtonRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ButtonRegister.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonRegister.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonRegister.Location = new System.Drawing.Point(510, 275);
            this.ButtonRegister.Name = "ButtonRegister";
            this.ButtonRegister.Size = new System.Drawing.Size(112, 38);
            this.ButtonRegister.TabIndex = 11;
            this.ButtonRegister.Text = "Register";
            this.ButtonRegister.UseVisualStyleBackColor = false;
            this.ButtonRegister.Click += new System.EventHandler(this.ButtonRegister_Click);
            // 
            // LabelHaveAnAccount
            // 
            this.LabelHaveAnAccount.AutoSize = true;
            this.LabelHaveAnAccount.Location = new System.Drawing.Point(162, 285);
            this.LabelHaveAnAccount.Name = "LabelHaveAnAccount";
            this.LabelHaveAnAccount.Size = new System.Drawing.Size(169, 20);
            this.LabelHaveAnAccount.TabIndex = 15;
            this.LabelHaveAnAccount.Text = "I ready have an account!";
            // 
            // LinkLabelLogIn
            // 
            this.LinkLabelLogIn.AutoSize = true;
            this.LinkLabelLogIn.Location = new System.Drawing.Point(337, 285);
            this.LinkLabelLogIn.Name = "LinkLabelLogIn";
            this.LinkLabelLogIn.Size = new System.Drawing.Size(50, 20);
            this.LinkLabelLogIn.TabIndex = 16;
            this.LinkLabelLogIn.TabStop = true;
            this.LinkLabelLogIn.Text = "Log In";
            this.LinkLabelLogIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelLogIn_LinkClicked);
            // 
            // RegisterUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 396);
            this.Controls.Add(this.LinkLabelLogIn);
            this.Controls.Add(this.LabelHaveAnAccount);
            this.Controls.Add(this.ButtonRegister);
            this.Controls.Add(this.LabelUsername);
            this.Controls.Add(this.TextBoxUserName);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.LabelRegister);
            this.Name = "RegisterUserForm";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LabelRegister;
        private Label LabelPassword;
        private TextBox TextBoxPassword;
        private TextBox TextBoxUserName;
        private Label LabelUsername;
        private Button ButtonRegister;
        private Label LabelHaveAnAccount;
        private LinkLabel LinkLabelLogIn;
    }
}