namespace OnlineBooking
{
    partial class Services
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
            this.buttonBookService = new System.Windows.Forms.Button();
            this.buttonEditUser = new System.Windows.Forms.Button();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabelServices = new System.Windows.Forms.LinkLabel();
            this.linkLabelUsers = new System.Windows.Forms.LinkLabel();
            this.linkLabelBookings = new System.Windows.Forms.LinkLabel();
            this.linkLabelCustomers = new System.Windows.Forms.LinkLabel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelservicesTable = new System.Windows.Forms.Label();
            this.dataGridViewAllServices = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllServices)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBookService
            // 
            this.buttonBookService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonBookService.Location = new System.Drawing.Point(393, 161);
            this.buttonBookService.Name = "buttonBookService";
            this.buttonBookService.Size = new System.Drawing.Size(117, 40);
            this.buttonBookService.TabIndex = 27;
            this.buttonBookService.Text = "Book";
            this.buttonBookService.UseVisualStyleBackColor = true;
            // 
            // buttonEditUser
            // 
            this.buttonEditUser.ForeColor = System.Drawing.Color.Teal;
            this.buttonEditUser.Location = new System.Drawing.Point(516, 161);
            this.buttonEditUser.Name = "buttonEditUser";
            this.buttonEditUser.Size = new System.Drawing.Size(117, 40);
            this.buttonEditUser.TabIndex = 29;
            this.buttonEditUser.Text = "Amend";
            this.buttonEditUser.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonDeleteUser.Location = new System.Drawing.Point(639, 161);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(117, 40);
            this.buttonDeleteUser.TabIndex = 28;
            this.buttonDeleteUser.Text = "Delete";
            this.buttonDeleteUser.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkLabelServices);
            this.panel1.Controls.Add(this.linkLabelUsers);
            this.panel1.Controls.Add(this.linkLabelBookings);
            this.panel1.Controls.Add(this.linkLabelCustomers);
            this.panel1.Location = new System.Drawing.Point(136, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 64);
            this.panel1.TabIndex = 30;
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
            this.labelTitle.Location = new System.Drawing.Point(271, 25);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(221, 35);
            this.labelTitle.TabIndex = 31;
            this.labelTitle.Text = "Service Booking";
            // 
            // labelservicesTable
            // 
            this.labelservicesTable.AutoSize = true;
            this.labelservicesTable.Location = new System.Drawing.Point(12, 226);
            this.labelservicesTable.Name = "labelservicesTable";
            this.labelservicesTable.Size = new System.Drawing.Size(101, 20);
            this.labelservicesTable.TabIndex = 32;
            this.labelservicesTable.Text = "Services Table";
            // 
            // dataGridViewAllServices
            // 
            this.dataGridViewAllServices.AllowUserToAddRows = false;
            this.dataGridViewAllServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAllServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllServices.Location = new System.Drawing.Point(12, 268);
            this.dataGridViewAllServices.Name = "dataGridViewAllServices";
            this.dataGridViewAllServices.RowHeadersWidth = 51;
            this.dataGridViewAllServices.RowTemplate.Height = 29;
            this.dataGridViewAllServices.Size = new System.Drawing.Size(773, 258);
            this.dataGridViewAllServices.TabIndex = 33;
            // 
            // Services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 538);
            this.Controls.Add(this.dataGridViewAllServices);
            this.Controls.Add(this.labelservicesTable);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonEditUser);
            this.Controls.Add(this.buttonDeleteUser);
            this.Controls.Add(this.buttonBookService);
            this.Name = "Services";
            this.Text = "Services";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllServices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonBookService;
        private Button buttonEditUser;
        private Button buttonDeleteUser;
        private Panel panel1;
        private LinkLabel linkLabelServices;
        private LinkLabel linkLabelUsers;
        private LinkLabel linkLabelBookings;
        private LinkLabel linkLabelCustomers;
        private Label labelTitle;
        private Label labelservicesTable;
        private DataGridView dataGridViewAllServices;
    }
}