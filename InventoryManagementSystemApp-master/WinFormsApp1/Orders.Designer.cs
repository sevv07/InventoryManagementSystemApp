namespace WinFormsApp1
{
    partial class Orders
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
            panel1 = new Panel();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            Order_ID = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Detail = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Created_by = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 260);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 58);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(697, 23);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Add Order";
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Order_ID, Date, Detail, Price, Created_by });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(784, 260);
            dataGridView1.TabIndex = 1;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // Order_ID
            // 
            Order_ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Order_ID.HeaderText = "Order_ID";
            Order_ID.Name = "Order_ID";
            Order_ID.ReadOnly = true;
            Order_ID.Width = 78;
            // 
            // Date
            // 
            Date.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Date.HeaderText = "Date";
            Date.Name = "Date";
            Date.ReadOnly = true;
            Date.Width = 56;
            // 
            // Detail
            // 
            Detail.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Detail.HeaderText = "Detail";
            Detail.Name = "Detail";
            Detail.ReadOnly = true;
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // Created_by
            // 
            Created_by.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Created_by.HeaderText = "Created_by";
            Created_by.Name = "Created_by";
            Created_by.ReadOnly = true;
            // 
            // Orders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 318);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Orders";
            Text = "Orders";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Button button1;
        private DataGridViewTextBoxColumn Order_ID;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Detail;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Created_by;
    }
}