namespace WinFormsApp1
{
    partial class AddOrder
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
            label1 = new Label();
            quantityTextBox = new TextBox();
            addOrderButton = new Button();
            cancelOrderButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 34);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter the quantity:";
            // 
            // quantityTextBox
            // 
            quantityTextBox.Location = new Point(84, 97);
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.Size = new Size(100, 23);
            quantityTextBox.TabIndex = 1;
            // 
            // addOrderButton
            // 
            addOrderButton.Location = new Point(51, 162);
            addOrderButton.Name = "addOrderButton";
            addOrderButton.Size = new Size(75, 23);
            addOrderButton.TabIndex = 2;
            addOrderButton.Text = "Add";
            addOrderButton.UseVisualStyleBackColor = true;
            addOrderButton.Click += addOrderButton_Click;
            // 
            // cancelOrderButton
            // 
            cancelOrderButton.Location = new Point(170, 162);
            cancelOrderButton.Name = "cancelOrderButton";
            cancelOrderButton.Size = new Size(75, 23);
            cancelOrderButton.TabIndex = 3;
            cancelOrderButton.Text = "Cancel";
            cancelOrderButton.UseVisualStyleBackColor = true;
            cancelOrderButton.Click += cancelOrderButton_Click;
            // 
            // AddOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 220);
            Controls.Add(cancelOrderButton);
            Controls.Add(addOrderButton);
            Controls.Add(quantityTextBox);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddOrder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox quantityTextBox;
        private Button addOrderButton;
        private Button cancelOrderButton;
    }
}