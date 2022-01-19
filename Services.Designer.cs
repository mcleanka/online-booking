namespace OnlineBooking
{
    partial class FormServices
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
            this.ButtonBookService = new System.Windows.Forms.Button();
            this.ButtonAmendService = new System.Windows.Forms.Button();
            this.ButtonDeleteService = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabelServices = new System.Windows.Forms.LinkLabel();
            this.linkLabelUsers = new System.Windows.Forms.LinkLabel();
            this.linkLabelBookings = new System.Windows.Forms.LinkLabel();
            this.linkLabelCustomers = new System.Windows.Forms.LinkLabel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelservicesTable = new System.Windows.Forms.Label();
            this.dataGridViewAllServices = new System.Windows.Forms.DataGridView();
            this.ButtonAddService = new System.Windows.Forms.Button();
            this.LabelServiceName = new System.Windows.Forms.Label();
            this.LabelServicePrice = new System.Windows.Forms.Label();
            this.TextBoxServiceName = new System.Windows.Forms.TextBox();
            this.TextBoxServicePrice = new System.Windows.Forms.TextBox();
            this.LabelServiceID = new System.Windows.Forms.Label();
            this.TextBoxServiceID = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllServices)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonBookService
            // 
            this.ButtonBookService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ButtonBookService.Location = new System.Drawing.Point(422, 226);
            this.ButtonBookService.Name = "ButtonBookService";
            this.ButtonBookService.Size = new System.Drawing.Size(117, 40);
            this.ButtonBookService.TabIndex = 27;
            this.ButtonBookService.Text = "Book";
            this.ButtonBookService.UseVisualStyleBackColor = true;
            this.ButtonBookService.Click += new System.EventHandler(this.ButtonBookService_Click);
            // 
            // ButtonAmendService
            // 
            this.ButtonAmendService.ForeColor = System.Drawing.Color.Teal;
            this.ButtonAmendService.Location = new System.Drawing.Point(545, 226);
            this.ButtonAmendService.Name = "ButtonAmendService";
            this.ButtonAmendService.Size = new System.Drawing.Size(117, 40);
            this.ButtonAmendService.TabIndex = 29;
            this.ButtonAmendService.Text = "Amend";
            this.ButtonAmendService.UseVisualStyleBackColor = true;
            this.ButtonAmendService.Click += new System.EventHandler(this.ButtonAmendService_Click);
            // 
            // ButtonDeleteService
            // 
            this.ButtonDeleteService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ButtonDeleteService.Location = new System.Drawing.Point(668, 226);
            this.ButtonDeleteService.Name = "ButtonDeleteService";
            this.ButtonDeleteService.Size = new System.Drawing.Size(117, 40);
            this.ButtonDeleteService.TabIndex = 28;
            this.ButtonDeleteService.Text = "Delete";
            this.ButtonDeleteService.UseVisualStyleBackColor = true;
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
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(271, 25);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(275, 45);
            this.labelTitle.TabIndex = 31;
            this.labelTitle.Text = "Available Services";
            // 
            // labelservicesTable
            // 
            this.labelservicesTable.AutoSize = true;
            this.labelservicesTable.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelservicesTable.Location = new System.Drawing.Point(12, 236);
            this.labelservicesTable.Name = "labelservicesTable";
            this.labelservicesTable.Size = new System.Drawing.Size(132, 25);
            this.labelservicesTable.TabIndex = 32;
            this.labelservicesTable.Text = "Services Table";
            // 
            // dataGridViewAllServices
            // 
            this.dataGridViewAllServices.AllowUserToAddRows = false;
            this.dataGridViewAllServices.AllowUserToOrderColumns = true;
            this.dataGridViewAllServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAllServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllServices.Location = new System.Drawing.Point(12, 268);
            this.dataGridViewAllServices.Name = "dataGridViewAllServices";
            this.dataGridViewAllServices.RowHeadersWidth = 51;
            this.dataGridViewAllServices.RowTemplate.Height = 29;
            this.dataGridViewAllServices.Size = new System.Drawing.Size(773, 258);
            this.dataGridViewAllServices.TabIndex = 33;
            // 
            // ButtonAddService
            // 
            this.ButtonAddService.Location = new System.Drawing.Point(668, 180);
            this.ButtonAddService.Name = "ButtonAddService";
            this.ButtonAddService.Size = new System.Drawing.Size(117, 40);
            this.ButtonAddService.TabIndex = 34;
            this.ButtonAddService.Text = "Add";
            this.ButtonAddService.UseVisualStyleBackColor = true;
            this.ButtonAddService.Click += new System.EventHandler(this.ButtonAddService_Click);
            // 
            // LabelServiceName
            // 
            this.LabelServiceName.AutoSize = true;
            this.LabelServiceName.Location = new System.Drawing.Point(232, 190);
            this.LabelServiceName.Name = "LabelServiceName";
            this.LabelServiceName.Size = new System.Drawing.Size(49, 20);
            this.LabelServiceName.TabIndex = 35;
            this.LabelServiceName.Text = "Name";
            // 
            // LabelServicePrice
            // 
            this.LabelServicePrice.AutoSize = true;
            this.LabelServicePrice.Location = new System.Drawing.Point(465, 190);
            this.LabelServicePrice.Name = "LabelServicePrice";
            this.LabelServicePrice.Size = new System.Drawing.Size(41, 20);
            this.LabelServicePrice.TabIndex = 36;
            this.LabelServicePrice.Text = "Price";
            // 
            // TextBoxServiceName
            // 
            this.TextBoxServiceName.Location = new System.Drawing.Point(302, 187);
            this.TextBoxServiceName.Name = "TextBoxServiceName";
            this.TextBoxServiceName.PlaceholderText = "Service Name";
            this.TextBoxServiceName.Size = new System.Drawing.Size(131, 27);
            this.TextBoxServiceName.TabIndex = 37;
            // 
            // TextBoxServicePrice
            // 
            this.TextBoxServicePrice.Location = new System.Drawing.Point(537, 187);
            this.TextBoxServicePrice.Name = "TextBoxServicePrice";
            this.TextBoxServicePrice.PlaceholderText = "Service Price";
            this.TextBoxServicePrice.Size = new System.Drawing.Size(108, 27);
            this.TextBoxServicePrice.TabIndex = 38;
            // 
            // LabelServiceID
            // 
            this.LabelServiceID.AutoSize = true;
            this.LabelServiceID.Location = new System.Drawing.Point(73, 190);
            this.LabelServiceID.Name = "LabelServiceID";
            this.LabelServiceID.Size = new System.Drawing.Size(24, 20);
            this.LabelServiceID.TabIndex = 39;
            this.LabelServiceID.Text = "ID";
            // 
            // TextBoxServiceID
            // 
            this.TextBoxServiceID.Location = new System.Drawing.Point(126, 187);
            this.TextBoxServiceID.Name = "TextBoxServiceID";
            this.TextBoxServiceID.PlaceholderText = "Service ID";
            this.TextBoxServiceID.Size = new System.Drawing.Size(86, 27);
            this.TextBoxServiceID.TabIndex = 40;
            // 
            // FormServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 538);
            this.Controls.Add(this.TextBoxServiceID);
            this.Controls.Add(this.LabelServiceID);
            this.Controls.Add(this.TextBoxServicePrice);
            this.Controls.Add(this.TextBoxServiceName);
            this.Controls.Add(this.LabelServicePrice);
            this.Controls.Add(this.LabelServiceName);
            this.Controls.Add(this.ButtonAddService);
            this.Controls.Add(this.dataGridViewAllServices);
            this.Controls.Add(this.labelservicesTable);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButtonAmendService);
            this.Controls.Add(this.ButtonDeleteService);
            this.Controls.Add(this.ButtonBookService);
            this.Name = "FormServices";
            this.Text = "Services";
            this.Load += new System.EventHandler(this.FormServices_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllServices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ButtonBookService;
        private Button ButtonAmendService;
        private Button ButtonDeleteService;
        private Panel panel1;
        private LinkLabel linkLabelServices;
        private LinkLabel linkLabelUsers;
        private LinkLabel linkLabelBookings;
        private LinkLabel linkLabelCustomers;
        private Label labelTitle;
        private Label labelservicesTable;
        private DataGridView dataGridViewAllServices;
        private Button ButtonAddService;
        private Label LabelServiceName;
        private Label LabelServicePrice;
        private TextBox TextBoxServiceName;
        private TextBox TextBoxServicePrice;
        private Label LabelServiceID;
        private TextBox TextBoxServiceID;
    }
}