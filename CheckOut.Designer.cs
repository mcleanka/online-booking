namespace OnlineBooking
{
    partial class FormCheckOut
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
            this.TextBoxCheckOut = new System.Windows.Forms.TextBox();
            this.LabelCustomerReview = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabelServices = new System.Windows.Forms.LinkLabel();
            this.linkLabelUsers = new System.Windows.Forms.LinkLabel();
            this.linkLabelBookings = new System.Windows.Forms.LinkLabel();
            this.linkLabelCustomers = new System.Windows.Forms.LinkLabel();
            this.ButtonSubmit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxCheckOut
            // 
            this.TextBoxCheckOut.Location = new System.Drawing.Point(14, 173);
            this.TextBoxCheckOut.Multiline = true;
            this.TextBoxCheckOut.Name = "TextBoxCheckOut";
            this.TextBoxCheckOut.PlaceholderText = "Please type you booking review";
            this.TextBoxCheckOut.Size = new System.Drawing.Size(487, 141);
            this.TextBoxCheckOut.TabIndex = 0;
            // 
            // LabelCustomerReview
            // 
            this.LabelCustomerReview.AutoSize = true;
            this.LabelCustomerReview.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelCustomerReview.Location = new System.Drawing.Point(117, 26);
            this.LabelCustomerReview.Name = "LabelCustomerReview";
            this.LabelCustomerReview.Size = new System.Drawing.Size(269, 45);
            this.LabelCustomerReview.TabIndex = 32;
            this.LabelCustomerReview.Text = "Customer Review";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkLabelServices);
            this.panel1.Controls.Add(this.linkLabelUsers);
            this.panel1.Controls.Add(this.linkLabelBookings);
            this.panel1.Controls.Add(this.linkLabelCustomers);
            this.panel1.Location = new System.Drawing.Point(60, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 64);
            this.panel1.TabIndex = 33;
            // 
            // linkLabelServices
            // 
            this.linkLabelServices.AutoSize = true;
            this.linkLabelServices.Location = new System.Drawing.Point(234, 23);
            this.linkLabelServices.Name = "linkLabelServices";
            this.linkLabelServices.Size = new System.Drawing.Size(62, 20);
            this.linkLabelServices.TabIndex = 19;
            this.linkLabelServices.TabStop = true;
            this.linkLabelServices.Text = "Services";
            // 
            // linkLabelUsers
            // 
            this.linkLabelUsers.AutoSize = true;
            this.linkLabelUsers.Location = new System.Drawing.Point(31, 23);
            this.linkLabelUsers.Name = "linkLabelUsers";
            this.linkLabelUsers.Size = new System.Drawing.Size(44, 20);
            this.linkLabelUsers.TabIndex = 16;
            this.linkLabelUsers.TabStop = true;
            this.linkLabelUsers.Text = "Users";
            // 
            // linkLabelBookings
            // 
            this.linkLabelBookings.AutoSize = true;
            this.linkLabelBookings.Location = new System.Drawing.Point(316, 23);
            this.linkLabelBookings.Name = "linkLabelBookings";
            this.linkLabelBookings.Size = new System.Drawing.Size(70, 20);
            this.linkLabelBookings.TabIndex = 17;
            this.linkLabelBookings.TabStop = true;
            this.linkLabelBookings.Text = "Bookings";
            // 
            // linkLabelCustomers
            // 
            this.linkLabelCustomers.AutoSize = true;
            this.linkLabelCustomers.Location = new System.Drawing.Point(116, 23);
            this.linkLabelCustomers.Name = "linkLabelCustomers";
            this.linkLabelCustomers.Size = new System.Drawing.Size(78, 20);
            this.linkLabelCustomers.TabIndex = 18;
            this.linkLabelCustomers.TabStop = true;
            this.linkLabelCustomers.Text = "Customers";
            // 
            // ButtonSubmit
            // 
            this.ButtonSubmit.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ButtonSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonSubmit.Location = new System.Drawing.Point(376, 340);
            this.ButtonSubmit.Name = "ButtonSubmit";
            this.ButtonSubmit.Size = new System.Drawing.Size(125, 41);
            this.ButtonSubmit.TabIndex = 34;
            this.ButtonSubmit.Text = "Submit Review";
            this.ButtonSubmit.UseVisualStyleBackColor = false;
            // 
            // FormCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 393);
            this.Controls.Add(this.ButtonSubmit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LabelCustomerReview);
            this.Controls.Add(this.TextBoxCheckOut);
            this.Name = "FormCheckOut";
            this.Text = "CheckOut";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TextBoxCheckOut;
        private Label LabelCustomerReview;
        private Panel panel1;
        private LinkLabel linkLabelServices;
        private LinkLabel linkLabelUsers;
        private LinkLabel linkLabelBookings;
        private LinkLabel linkLabelCustomers;
        private Button ButtonSubmit;
    }
}