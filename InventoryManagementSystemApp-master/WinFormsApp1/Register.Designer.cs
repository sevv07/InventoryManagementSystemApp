namespace WinFormsApp1
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            nameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            phoneTextBox = new TextBox();
            emailTextBox = new TextBox();
            surnameTextBox = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(330, 118);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(138, 23);
            nameTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(330, 211);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(138, 23);
            passwordTextBox.TabIndex = 2;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(330, 303);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(138, 23);
            phoneTextBox.TabIndex = 4;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(330, 252);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(138, 23);
            emailTextBox.TabIndex = 3;
            // 
            // surnameTextBox
            // 
            surnameTextBox.Location = new Point(330, 162);
            surnameTextBox.Name = "surnameTextBox";
            surnameTextBox.Size = new Size(138, 23);
            surnameTextBox.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(330, 358);
            button1.Name = "button1";
            button1.Size = new Size(83, 29);
            button1.TabIndex = 5;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(263, 121);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 6;
            label1.Text = "Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(242, 165);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 7;
            label2.Text = "Surname :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(238, 210);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 8;
            label3.Text = "Password :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(259, 252);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 9;
            label4.Text = "E-Mail :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(258, 303);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 10;
            label5.Text = "Phone :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.ForeColor = Color.RoyalBlue;
            label6.Location = new Point(49, 9);
            label6.Name = "label6";
            label6.Size = new Size(742, 37);
            label6.TabIndex = 11;
            label6.Text = "INVENTORY MANAGEMENT SYSTEM REGİSTER";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(surnameTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(phoneTextBox);
            Controls.Add(passwordTextBox);
            Controls.Add(nameTextBox);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameTextBox;
        private TextBox passwordTextBox;
        private TextBox phoneTextBox;
        private TextBox emailTextBox;
        private TextBox surnameTextBox;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}