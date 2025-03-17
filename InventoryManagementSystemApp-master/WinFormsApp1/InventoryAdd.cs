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
    public partial class InventoryAdd : Form
    {

        // Database connection
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mehme\Documents\sqlDB.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        Inventory parent;
        String ID;
        public InventoryAdd(Inventory parent, String ID)
        {
            this.parent = parent;
            this.ID = ID;
            InitializeComponent();

            string firstQuantity = "";
            cmd = new SqlCommand("select Quantity from Products where Barcode = @ID", con);
            cmd.Parameters.AddWithValue("@ID", ID);
            con.Open();
            firstQuantity = cmd.ExecuteScalar().ToString();
            cmd.ExecuteNonQuery();
            con.Close();
            textBox1.Text = firstQuantity;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("update Products set Quantity = @newQuantity where Barcode = @ID", con);
            cmd.Parameters.AddWithValue("@newQuantity", textBox1.Text);
            cmd.Parameters.AddWithValue("@ID", ID);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            parent.LoadData();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
