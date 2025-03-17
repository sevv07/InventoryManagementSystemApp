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

namespace WinFormsApp1
{
    public partial class OrderDetail : Form
    {

        // Database connection
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mehme\Documents\sqlDB.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;


        Orders parent;
        string ID;
        public OrderDetail(Orders orders, string ID)
        {
            parent = orders;
            this.ID = ID;
            InitializeComponent();
            loadDetail();

        }

        public void loadDetail()
        {
            string orderDetail = "";

            cmd.Parameters.Clear();
            cmd = new SqlCommand("SELECT Detail FROM Orders WHERE Order_ID = @ID", con);
            cmd.Parameters.AddWithValue("@ID", ID);

            try
            {
                con.Open();
                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    orderDetail = result.ToString();
                }
                else
                {
                    orderDetail = "No details found.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

            richTextBox1.Text = orderDetail;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("DELETE FROM Orders WHERE Order_ID = @ID", con);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ID", ID);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Order completed!");
                this.Close();
                parent.LoadData();
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong.");
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
