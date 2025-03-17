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
    public partial class Orders : Form
    {


        public MainPage parent;

        // Database connection
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mehme\Documents\sqlDB.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;


        public void LoadData()
        {
            dataGridView1.Rows.Clear();
            cmd = new SqlCommand("select * from Orders", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr[0], dr[1], dr[2], dr[3] , dr[4]);
            }
            dr.Close();
            con.Close();
        }
        public Orders(MainPage main)
        {

            InitializeComponent();
            parent = main;
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ShowInventory showInventory = new ShowInventory(this);
            this.Hide();
            showInventory.Show();


        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            string cellValue = "";
            if (dataGridView1.CurrentRow != null) 
            {
                 cellValue = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
           
            OrderDetail orderDetail = new OrderDetail(this, cellValue);
            orderDetail.Show();
        }
    }
}
