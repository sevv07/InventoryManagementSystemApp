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
    public partial class Inventory : Form
    {
        // Database connection
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mehme\Documents\sqlDB.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        public void LoadData()
        {
            dvgInventory.Rows.Clear();
            cmd = new SqlCommand("select Barcode, [Product Name], Quantity from Products", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dvgInventory.Rows.Add(dr[0], dr[1], dr[2]);
            }
            dr.Close();
            con.Close();
        }

        public Inventory()
        {
            InitializeComponent();
            LoadData();
        }

        private void dvgInventory_DoubleClick(object sender, EventArgs e)
        {
            string cellValue = "";
            // Seçili satırı al
            if (dvgInventory.CurrentRow != null) // Eğer bir satır seçildiyse
            {
                // Örnek: İlgili hücrenin 1. sütunundaki veriyi al
                cellValue = dvgInventory.CurrentRow.Cells[0].Value.ToString();

            }
            else
            {
                MessageBox.Show("Please select a row");
            }
            InventoryAdd inventoryAdd = new InventoryAdd(this, cellValue);
            inventoryAdd.Show();

        }

        private void dvgInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
