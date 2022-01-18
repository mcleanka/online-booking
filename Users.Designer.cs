namespace OnlineBooking
{
    partial class Users
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
            this.dataGridViewAllUsers = new System.Windows.Forms.DataGridView();
            this.labelUsersTable = new System.Windows.Forms.Label();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.buttonEditUser = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.linkLabelUsers = new System.Windows.Forms.LinkLabel();
            this.linkLabelBookings = new System.Windows.Forms.LinkLabel();
            this.linkLabelCustomers = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllUsers)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewAllUsers
            // 
            this.dataGridViewAllUsers.AllowUserToAddRows = false;
            this.dataGridViewAllUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAllUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllUsers.Location = new System.Drawing.Point(22, 229);
            this.dataGridViewAllUsers.Name = "dataGridViewAllUsers";
            this.dataGridViewAllUsers.RowHeadersWidth = 51;
            this.dataGridViewAllUsers.RowTemplate.Height = 29;
            this.dataGridViewAllUsers.Size = new System.Drawing.Size(951, 321);
            this.dataGridViewAllUsers.TabIndex = 9;
            // 
            // labelUsersTable
            // 
            this.labelUsersTable.AutoSize = true;
            this.labelUsersTable.Location = new System.Drawing.Point(22, 188);
            this.labelUsersTable.Name = "labelUsersTable";
            this.labelUsersTable.Size = new System.Drawing.Size(102, 25);
            this.labelUsersTable.TabIndex = 10;
            this.labelUsersTable.Text = "Users Table";
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonDeleteUser.Location = new System.Drawing.Point(856, 180);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(117, 40);
            this.buttonDeleteUser.TabIndex = 1;
            this.buttonDeleteUser.Text = "Delete";
            this.buttonDeleteUser.UseVisualStyleBackColor = true;
            // 
            // buttonEditUser
            // 
            this.buttonEditUser.ForeColor = System.Drawing.Color.Teal;
            this.buttonEditUser.Location = new System.Drawing.Point(727, 183);
            this.buttonEditUser.Name = "buttonEditUser";
            this.buttonEditUser.Size = new System.Drawing.Size(117, 40);
            this.buttonEditUser.TabIndex = 11;
            this.buttonEditUser.Text = "Edit";
            this.buttonEditUser.UseVisualStyleBackColor = true;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.ForeColor = System.Drawing.Color.Teal;
            this.labelTitle.Location = new System.Drawing.Point(422, 26);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(221, 35);
            this.labelTitle.TabIndex = 15;
            this.labelTitle.Text = "Service Booking";
            // 
            // linkLabelUsers
            // 
            this.linkLabelUsers.AutoSize = true;
            this.linkLabelUsers.Location = new System.Drawing.Point(32, 23);
            this.linkLabelUsers.Name = "linkLabelUsers";
            this.linkLabelUsers.Size = new System.Drawing.Size(55, 25);
            this.linkLabelUsers.TabIndex = 16;
            this.linkLabelUsers.TabStop = true;
            this.linkLabelUsers.Text = "Users";
            // 
            // linkLabelBookings
            // 
            this.linkLabelBookings.AutoSize = true;
            this.linkLabelBookings.Location = new System.Drawing.Point(439, 23);
            this.linkLabelBookings.Name = "linkLabelBookings";
            this.linkLabelBookings.Size = new System.Drawing.Size(86, 25);
            this.linkLabelBookings.TabIndex = 17;
            this.linkLabelBookings.TabStop = true;
            this.linkLabelBookings.Text = "Bookings";
            // 
            // linkLabelCustomers
            // 
            this.linkLabelCustomers.AutoSize = true;
            this.linkLabelCustomers.Location = new System.Drawing.Point(223, 23);
            this.linkLabelCustomers.Name = "linkLabelCustomers";
            this.linkLabelCustomers.Size = new System.Drawing.Size(97, 25);
            this.linkLabelCustomers.TabIndex = 18;
            this.linkLabelCustomers.TabStop = true;
            this.linkLabelCustomers.Text = "Customers";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkLabelUsers);
            this.panel1.Controls.Add(this.linkLabelBookings);
            this.panel1.Controls.Add(this.linkLabelCustomers);
            this.panel1.Location = new System.Drawing.Point(242, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 64);
            this.panel1.TabIndex = 19;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonEditUser);
            this.Controls.Add(this.buttonDeleteUser);
            this.Controls.Add(this.labelUsersTable);
            this.Controls.Add(this.dataGridViewAllUsers);
            this.Font = new System.Drawing.Font("Segoe UI Historic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Users";
            this.Text = "All Users";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllUsers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewAllUsers;
        private Label labelUsersTable;
        private Button buttonDeleteUser;
        private Button buttonEditUser;
        private Label labelTitle;
        private LinkLabel linkLabelUsers;
        private LinkLabel linkLabelBookings;
        private LinkLabel linkLabelCustomers;
        private Panel panel1;
    }
}