using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace WinFormsApp1
{
    public partial class Register : Form
    {
        LoginPage parent;
        public Register(LoginPage parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Kullanıcıdan alınan veriler
            string name = nameTextBox.Text;
            string surname = surnameTextBox.Text;
            string password = passwordTextBox.Text;
            string email = emailTextBox.Text;
            string phone = phoneTextBox.Text;

            // Database connection
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mehme\Documents\sqlDB.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;


            try
            {

                cmd = new SqlCommand("INSERT INTO Users (Name, Surname, Password, Email, Phone) VALUES (@Name, @Surname, @Password, @Email, @Phone)", con);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Surname", surname);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Phone", phone);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Registration is successful..");

                this.Close();
                parent.Show();

               
            }
            catch (Exception ex)
            {

                MessageBox.Show("E-mail has taken..");
            }
        }
    }

}