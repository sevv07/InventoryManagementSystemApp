namespace WinFormsApp1
{
    partial class ShowInventory
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
            label1 = new Label();
            CompleteOrder = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            Barcode = new DataGridViewTextBoxColumn();
            Product = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(CompleteOrder);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 258);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 60);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 24);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 3;
            label1.Text = "Total price: 0 $";
            // 
            // CompleteOrder
            // 
            CompleteOrder.Location = new Point(576, 16);
            CompleteOrder.Name = "CompleteOrder";
            CompleteOrder.Size = new Size(115, 23);
            CompleteOrder.TabIndex = 2;
            CompleteOrder.Text = "Complete Order";
            CompleteOrder.UseVisualStyleBackColor = true;
            CompleteOrder.Click += CompleteOrder_Click;
            // 
            // button2
            // 
            button2.Image = Properties.Resources.Shopping_Cart;
            button2.Location = new Point(21, 7);
            button2.Name = "button2";
            button2.Size = new Size(56, 41);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(697, 16);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Barcode, Product, Quantity, Price });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(784, 258);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // Barcode
            // 
            Barcode.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Barcode.HeaderText = "Barcode";
            Barcode.Name = "Barcode";
            Barcode.ReadOnly = true;
            // 
            // Product
            // 
            Product.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Product.HeaderText = "Product";
            Product.Name = "Product";
            Product.ReadOnly = true;
            // 
            // Quantity
            // 
            Quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Quantity.HeaderText = "Quantity";
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            // 
            // Price
            // 
            Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Price.HeaderText = "Price";
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // ShowInventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 318);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ShowInventory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ShowInventory";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Barcode;
        private DataGridViewTextBoxColumn Product;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Price;
        private Button button1;
        private Button button2;
        private Button CompleteOrder;
        private Label label1;
    }
}