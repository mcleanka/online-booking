namespace OnlineBooking
{
    partial class Bookings
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabelUsers = new System.Windows.Forms.LinkLabel();
            this.linkLabelBookings = new System.Windows.Forms.LinkLabel();
            this.linkLabelCustomers = new System.Windows.Forms.LinkLabel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.dataGridViewAllBookings = new System.Windows.Forms.DataGridView();
            this.labelBookingsTable = new System.Windows.Forms.Label();
            this.buttonEditUser = new System.Windows.Forms.Button();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.linkLabelServices = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllBookings)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkLabelServices);
            this.panel1.Controls.Add(this.linkLabelUsers);
            this.panel1.Controls.Add(this.linkLabelBookings);
            this.panel1.Controls.Add(this.linkLabelCustomers);
            this.panel1.Location = new System.Drawing.Point(171, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 64);
            this.panel1.TabIndex = 20;
            // 
            // linkLabelUsers
            // 
            this.linkLabelUsers.AutoSize = true;
            this.linkLabelUsers.Location = new System.Drawing.Point(32, 23);
            this.linkLabelUsers.Name = "linkLabelUsers";
            this.linkLabelUsers.Size = new System.Drawing.Size(44, 20);
            this.linkLabelUsers.TabIndex = 16;
            this.linkLabelUsers.TabStop = true;
            this.linkLabelUsers.Text = "Users";
            // 
            // linkLabelBookings
            // 
            this.linkLabelBookings.AutoSize = true;
            this.linkLabelBookings.Location = new System.Drawing.Point(439, 23);
            this.linkLabelBookings.Name = "linkLabelBookings";
            this.linkLabelBookings.Size = new System.Drawing.Size(70, 20);
            this.linkLabelBookings.TabIndex = 17;
            this.linkLabelBookings.TabStop = true;
            this.linkLabelBookings.Text = "Bookings";
            // 
            // linkLabelCustomers
            // 
            this.linkLabelCustomers.AutoSize = true;
            this.linkLabelCustomers.Location = new System.Drawing.Point(147, 23);
            this.linkLabelCustomers.Name = "linkLabelCustomers";
            this.linkLabelCustomers.Size = new System.Drawing.Size(78, 20);
            this.linkLabelCustomers.TabIndex = 18;
            this.linkLabelCustomers.TabStop = true;
            this.linkLabelCustomers.Text = "Customers";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.ForeColor = System.Drawing.Color.Teal;
            this.labelTitle.Location = new System.Drawing.Point(337, 22);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(221, 35);
            this.labelTitle.TabIndex = 21;
            this.labelTitle.Text = "Service Booking";
            // 
            // dataGridViewAllBookings
            // 
            this.dataGridViewAllBookings.AllowUserToAddRows = false;
            this.dataGridViewAllBookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAllBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllBookings.Location = new System.Drawing.Point(12, 213);
            this.dataGridViewAllBookings.Name = "dataGridViewAllBookings";
            this.dataGridViewAllBookings.RowHeadersWidth = 51;
            this.dataGridViewAllBookings.RowTemplate.Height = 29;
            this.dataGridViewAllBookings.Size = new System.Drawing.Size(866, 307);
            this.dataGridViewAllBookings.TabIndex = 22;
            // 
            // labelBookingsTable
            // 
            this.labelBookingsTable.AutoSize = true;
            this.labelBookingsTable.Location = new System.Drawing.Point(12, 181);
            this.labelBookingsTable.Name = "labelBookingsTable";
            this.labelBookingsTable.Size = new System.Drawing.Size(103, 20);
            this.labelBookingsTable.TabIndex = 23;
            this.labelBookingsTable.Text = "Booking Table";
            // 
            // buttonEditUser
            // 
            this.buttonEditUser.ForeColor = System.Drawing.Color.Teal;
            this.buttonEditUser.Location = new System.Drawing.Point(626, 167);
            this.buttonEditUser.Name = "buttonEditUser";
            this.buttonEditUser.Size = new System.Drawing.Size(117, 40);
            this.buttonEditUser.TabIndex = 25;
            this.buttonEditUser.Text = "Amend";
            this.buttonEditUser.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonDeleteUser.Location = new System.Drawing.Point(755, 164);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(117, 40);
            this.buttonDeleteUser.TabIndex = 24;
            this.buttonDeleteUser.Text = "Delete";
            this.buttonDeleteUser.UseVisualStyleBackColor = true;
            // 
            // linkLabelServices
            // 
            this.linkLabelServices.AutoSize = true;
            this.linkLabelServices.Location = new System.Drawing.Point(294, 23);
            this.linkLabelServices.Name = "linkLabelServices";
            this.linkLabelServices.Size = new System.Drawing.Size(62, 20);
            this.linkLabelServices.TabIndex = 19;
            this.linkLabelServices.TabStop = true;
            this.linkLabelServices.Text = "Services";
            // 
            // Bookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 532);
            this.Controls.Add(this.buttonEditUser);
            this.Controls.Add(this.buttonDeleteUser);
            this.Controls.Add(this.labelBookingsTable);
            this.Controls.Add(this.dataGridViewAllBookings);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.panel1);
            this.Name = "Bookings";
            this.Text = "Bookings";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllBookings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private LinkLabel linkLabelUsers;
        private LinkLabel linkLabelBookings;
        private LinkLabel linkLabelCustomers;
        private Label labelTitle;
        private DataGridView dataGridViewAllBookings;
        private Label labelBookingsTable;
        private Button buttonEditUser;
        private Button buttonDeleteUser;
        private LinkLabel linkLabelServices;
    }
}