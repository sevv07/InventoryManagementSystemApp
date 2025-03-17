namespace WinFormsApp1
{
    partial class Inventory
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            dvgInventory = new DataGridView();
            Barcode = new DataGridViewTextBoxColumn();
            Product = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dvgInventory).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 297);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 60);
            panel1.TabIndex = 0;
            // 
            // dvgInventory
            // 
            dvgInventory.AllowUserToAddRows = false;
            dvgInventory.AllowUserToDeleteRows = false;
            dvgInventory.AllowUserToResizeColumns = false;
            dvgInventory.AllowUserToResizeRows = false;
            dvgInventory.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dvgInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dvgInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgInventory.Columns.AddRange(new DataGridViewColumn[] { Barcode, Product, Quantity });
            dvgInventory.Dock = DockStyle.Fill;
            dvgInventory.EnableHeadersVisualStyles = false;
            dvgInventory.Location = new Point(0, 0);
            dvgInventory.Name = "dvgInventory";
            dvgInventory.ReadOnly = true;
            dvgInventory.Size = new Size(800, 297);
            dvgInventory.TabIndex = 1;
            dvgInventory.CellContentClick += dvgInventory_CellContentClick;
            dvgInventory.DoubleClick += dvgInventory_DoubleClick;
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
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 357);
            Controls.Add(dvgInventory);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Inventory";
            Text = "Inventory";
            ((System.ComponentModel.ISupportInitialize)dvgInventory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dvgInventory;
        private DataGridViewTextBoxColumn Barcode;
        private DataGridViewTextBoxColumn Product;
        private DataGridViewTextBoxColumn Quantity;
    }
}