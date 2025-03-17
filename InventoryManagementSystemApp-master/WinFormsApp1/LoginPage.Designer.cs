namespace WinFormsApp1
{
    partial class LoginPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            usernameTextbox = new TextBox();
            passwordTextbox = new TextBox();
            usernameLabel = new Label();
            passwordLabel = new Label();
            loginButton = new Button();
            registerButton = new Button();
            SuspendLayout();
            // 
            // usernameTextbox
            // 
            usernameTextbox.Location = new Point(363, 178);
            usernameTextbox.Name = "usernameTextbox";
            usernameTextbox.Size = new Size(139, 23);
            usernameTextbox.TabIndex = 1;
            // 
            // passwordTextbox
            // 
            passwordTextbox.Location = new Point(363, 212);
            passwordTextbox.Name = "passwordTextbox";
            passwordTextbox.Size = new Size(139, 23);
            passwordTextbox.TabIndex = 2;
            passwordTextbox.UseSystemPasswordChar = true;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.BackColor = Color.Transparent;
            usernameLabel.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            usernameLabel.ForeColor = Color.Navy;
            usernameLabel.ImageAlign = ContentAlignment.TopCenter;
            usernameLabel.Location = new Point(219, 177);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(84, 30);
            usernameLabel.TabIndex = 3;
            usernameLabel.Text = "E-mail";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.BackColor = Color.Transparent;
            passwordLabel.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            passwordLabel.ForeColor = Color.Navy;
            passwordLabel.ImageAlign = ContentAlignment.TopCenter;
            passwordLabel.Location = new Point(219, 212);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(125, 30);
            passwordLabel.TabIndex = 4;
            passwordLabel.Text = "Password";
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.Transparent;
            loginButton.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            loginButton.ForeColor = Color.Navy;
            loginButton.Location = new Point(554, 190);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(75, 33);
            loginButton.TabIndex = 5;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // registerButton
            // 
            registerButton.BackColor = Color.Transparent;
            registerButton.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            registerButton.ForeColor = Color.Navy;
            registerButton.Location = new Point(652, 190);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(101, 33);
            registerButton.TabIndex = 6;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(826, 727);
            Controls.Add(registerButton);
            Controls.Add(loginButton);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Controls.Add(passwordTextbox);
            Controls.Add(usernameTextbox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox usernameTextbox;
        private TextBox passwordTextbox;
        private Label usernameLabel;
        private Label passwordLabel;
        private Button loginButton;
        private Button registerButton;
    }
}
