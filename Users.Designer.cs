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
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEditUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAllUsers
            // 
            this.dataGridViewAllUsers.AllowUserToAddRows = false;
            this.dataGridViewAllUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAllUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllUsers.Location = new System.Drawing.Point(22, 83);
            this.dataGridViewAllUsers.Name = "dataGridViewAllUsers";
            this.dataGridViewAllUsers.RowHeadersWidth = 51;
            this.dataGridViewAllUsers.RowTemplate.Height = 29;
            this.dataGridViewAllUsers.Size = new System.Drawing.Size(951, 467);
            this.dataGridViewAllUsers.TabIndex = 9;
            // 
            // labelUsersTable
            // 
            this.labelUsersTable.AutoSize = true;
            this.labelUsersTable.Location = new System.Drawing.Point(22, 45);
            this.labelUsersTable.Name = "labelUsersTable";
            this.labelUsersTable.Size = new System.Drawing.Size(102, 25);
            this.labelUsersTable.TabIndex = 10;
            this.labelUsersTable.Text = "Users Table";
            // 
            // buttonDelete
            // 
            this.buttonDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonDelete.Location = new System.Drawing.Point(856, 37);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(117, 40);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonEditUser
            // 
            this.buttonEditUser.ForeColor = System.Drawing.Color.Teal;
            this.buttonEditUser.Location = new System.Drawing.Point(724, 37);
            this.buttonEditUser.Name = "buttonEditUser";
            this.buttonEditUser.Size = new System.Drawing.Size(117, 40);
            this.buttonEditUser.TabIndex = 11;
            this.buttonEditUser.Text = "Edit";
            this.buttonEditUser.UseVisualStyleBackColor = true;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.buttonEditUser);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labelUsersTable);
            this.Controls.Add(this.dataGridViewAllUsers);
            this.Font = new System.Drawing.Font("Segoe UI Historic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Users";
            this.Text = "All Users";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewAllUsers;
        private Label labelUsersTable;
        private Button buttonDelete;
        private Button buttonEditUser;
    }
}