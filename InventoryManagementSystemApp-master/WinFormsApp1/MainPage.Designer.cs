namespace WinFormsApp1
{
    partial class MainPage
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
            button1 = new Button();
            users = new Label();
            orders = new Label();
            inventory = new Label();
            usersButton = new Button();
            ordersButton = new Button();
            inventoryButton = new Button();
            panel2 = new Panel();
            userLabel = new Label();
            label2 = new Label();
            logo = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(users);
            panel1.Controls.Add(orders);
            panel1.Controls.Add(inventory);
            panel1.Controls.Add(usersButton);
            panel1.Controls.Add(ordersButton);
            panel1.Controls.Add(inventoryButton);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 93);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(593, 66);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 7;
            label1.Text = "Products";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Image = Properties.Resources.Sell1;
            button1.Location = new Point(593, 12);
            button1.Name = "button1";
            button1.Size = new Size(62, 51);
            button1.TabIndex = 6;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // users
            // 
            users.AutoSize = true;
            users.Location = new Point(466, 67);
            users.Name = "users";
            users.Size = new Size(35, 15);
            users.TabIndex = 5;
            users.Text = "Users";
            // 
            // orders
            // 
            orders.AutoSize = true;
            orders.Location = new Point(306, 66);
            orders.Name = "orders";
            orders.Size = new Size(42, 15);
            orders.TabIndex = 4;
            orders.Text = "Orders";
            // 
            // inventory
            // 
            inventory.AutoSize = true;
            inventory.Location = new Point(144, 67);
            inventory.Name = "inventory";
            inventory.Size = new Size(57, 15);
            inventory.TabIndex = 3;
            inventory.Text = "Inventory";
            // 
            // usersButton
            // 
            usersButton.BackColor = Color.Transparent;
            usersButton.Image = Properties.Resources.People;
            usersButton.Location = new Point(453, 13);
            usersButton.Name = "usersButton";
            usersButton.Size = new Size(62, 51);
            usersButton.TabIndex = 2;
            usersButton.UseVisualStyleBackColor = false;
            usersButton.Click += usersButton_Click;
            // 
            // ordersButton
            // 
            ordersButton.BackColor = Color.Transparent;
            ordersButton.Image = Properties.Resources.E_commerce;
            ordersButton.Location = new Point(296, 13);
            ordersButton.Name = "ordersButton";
            ordersButton.Size = new Size(62, 50);
            ordersButton.TabIndex = 1;
            ordersButton.UseVisualStyleBackColor = false;
            ordersButton.Click += ordersButton_Click;
            // 
            // inventoryButton
            // 
            inventoryButton.BackColor = Color.Transparent;
            inventoryButton.Image = Properties.Resources.Warehouse;
            inventoryButton.Location = new Point(139, 12);
            inventoryButton.Name = "inventoryButton";
            inventoryButton.Size = new Size(62, 51);
            inventoryButton.TabIndex = 0;
            inventoryButton.UseVisualStyleBackColor = false;
            inventoryButton.Click += inventoryButton_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(userLabel);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(logo);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 93);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 357);
            panel2.TabIndex = 1;
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Location = new Point(12, 323);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(41, 15);
            userLabel.TabIndex = 2;
            userLabel.Text = "admin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 299);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 1;
            label2.Text = "Current Session:";
            // 
            // logo
            // 
            logo.AutoSize = true;
            logo.Font = new Font("Tw Cen MT Condensed Extra Bold", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logo.Location = new Point(146, 153);
            logo.Name = "logo";
            logo.Size = new Size(520, 44);
            logo.TabIndex = 0;
            logo.Text = "INVENTORY MANAGEMENT SYSTEM";
            logo.Click += logo_Click;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MainPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainPage";
            Load += MainPage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button inventoryButton;
        private Button usersButton;
        private Button ordersButton;
        private Label inventory;
        private Label users;
        private Label orders;
        private Panel panel2;
        private Label logo;
        private Label label1;
        private Button button1;
        private Label userLabel;
        private Label label2;
    }
}