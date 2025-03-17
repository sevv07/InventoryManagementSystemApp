namespace WinFormsApp1
{
    partial class Users
    {
        // Other code...

        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            columnName = new DataGridViewTextBoxColumn();
            columnSurname = new DataGridViewTextBoxColumn();
            columnPassword = new DataGridViewTextBoxColumn();
            columnEmail = new DataGridViewTextBoxColumn();
            columnPhoneNumber = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, columnName, columnSurname, columnPassword, columnEmail, columnPhoneNumber });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(784, 318);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // columnName
            // 
            columnName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnName.HeaderText = "Name";
            columnName.Name = "columnName";
            columnName.ReadOnly = true;
            // 
            // columnSurname
            // 
            columnSurname.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnSurname.HeaderText = "Surname";
            columnSurname.Name = "columnSurname";
            columnSurname.ReadOnly = true;
            // 
            // columnPassword
            // 
            columnPassword.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnPassword.HeaderText = "Password";
            columnPassword.Name = "columnPassword";
            columnPassword.ReadOnly = true;
            // 
            // columnEmail
            // 
            columnEmail.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnEmail.HeaderText = "Email";
            columnEmail.Name = "columnEmail";
            columnEmail.ReadOnly = true;
            // 
            // columnPhoneNumber
            // 
            columnPhoneNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnPhoneNumber.HeaderText = "PhoneNumber";
            columnPhoneNumber.Name = "columnPhoneNumber";
            columnPhoneNumber.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 274);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 44);
            panel1.TabIndex = 1;
            // 
            // Users
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 318);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Users";
            Text = "Users";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        // Other code...

        private DataGridView dataGridView1;
        private Panel panel1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn columnName;
        private DataGridViewTextBoxColumn columnSurname;
        private DataGridViewTextBoxColumn columnPassword;
        private DataGridViewTextBoxColumn columnEmail;
        private DataGridViewTextBoxColumn columnPhoneNumber;
    }
}