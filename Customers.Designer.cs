namespace OnlineBooking
{
    partial class Customers
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
            this.labelAllCustomers = new System.Windows.Forms.Label();
            this.dataGridViewAllCustomers = new System.Windows.Forms.DataGridView();
            this.buttonEditCustomer = new System.Windows.Forms.Button();
            this.buttonDeleteCustomer = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabelUsers = new System.Windows.Forms.LinkLabel();
            this.linkLabelBookings = new System.Windows.Forms.LinkLabel();
            this.linkLabelCustomers = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllCustomers)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAllCustomers
            // 
            this.labelAllCustomers.AutoSize = true;
            this.labelAllCustomers.Location = new System.Drawing.Point(25, 170);
            this.labelAllCustomers.Name = "labelAllCustomers";
            this.labelAllCustomers.Size = new System.Drawing.Size(100, 20);
            this.labelAllCustomers.TabIndex = 0;
            this.labelAllCustomers.Text = "All Customers";
            // 
            // dataGridViewAllCustomers
            // 
            this.dataGridViewAllCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllCustomers.Location = new System.Drawing.Point(25, 206);
            this.dataGridViewAllCustomers.Name = "dataGridViewAllCustomers";
            this.dataGridViewAllCustomers.RowHeadersWidth = 51;
            this.dataGridViewAllCustomers.RowTemplate.Height = 29;
            this.dataGridViewAllCustomers.Size = new System.Drawing.Size(763, 232);
            this.dataGridViewAllCustomers.TabIndex = 1;
            // 
            // buttonEditCustomer
            // 
            this.buttonEditCustomer.ForeColor = System.Drawing.Color.Teal;
            this.buttonEditCustomer.Location = new System.Drawing.Point(548, 160);
            this.buttonEditCustomer.Name = "buttonEditCustomer";
            this.buttonEditCustomer.Size = new System.Drawing.Size(117, 40);
            this.buttonEditCustomer.TabIndex = 12;
            this.buttonEditCustomer.Text = "Edit";
            this.buttonEditCustomer.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteCustomer
            // 
            this.buttonDeleteCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonDeleteCustomer.Location = new System.Drawing.Point(671, 160);
            this.buttonDeleteCustomer.Name = "buttonDeleteCustomer";
            this.buttonDeleteCustomer.Size = new System.Drawing.Size(117, 40);
            this.buttonDeleteCustomer.TabIndex = 13;
            this.buttonDeleteCustomer.Text = "Delete";
            this.buttonDeleteCustomer.UseVisualStyleBackColor = true;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.ForeColor = System.Drawing.Color.Teal;
            this.labelTitle.Location = new System.Drawing.Point(288, 29);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(221, 35);
            this.labelTitle.TabIndex = 14;
            this.labelTitle.Text = "Service Booking";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkLabelUsers);
            this.panel1.Controls.Add(this.linkLabelBookings);
            this.panel1.Controls.Add(this.linkLabelCustomers);
            this.panel1.Location = new System.Drawing.Point(120, 79);
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
            this.linkLabelCustomers.Location = new System.Drawing.Point(230, 23);
            this.linkLabelCustomers.Name = "linkLabelCustomers";
            this.linkLabelCustomers.Size = new System.Drawing.Size(78, 20);
            this.linkLabelCustomers.TabIndex = 18;
            this.linkLabelCustomers.TabStop = true;
            this.linkLabelCustomers.Text = "Customers";
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonDeleteCustomer);
            this.Controls.Add(this.buttonEditCustomer);
            this.Controls.Add(this.dataGridViewAllCustomers);
            this.Controls.Add(this.labelAllCustomers);
            this.Name = "Customers";
            this.Text = "Customers";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllCustomers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelAllCustomers;
        private DataGridView dataGridViewAllCustomers;
        private Button buttonEditCustomer;
        private Button buttonDeleteCustomer;
        private Label labelTitle;
        private Panel panel1;
        private LinkLabel linkLabelUsers;
        private LinkLabel linkLabelBookings;
        private LinkLabel linkLabelCustomers;
    }
}