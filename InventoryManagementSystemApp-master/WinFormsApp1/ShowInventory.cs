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
    public partial class ShowInventory : Form,IStockObserver
    {
        public void OnStockLow(string productName, int quantity)
        {
            MessageBox.Show($"Stock for {productName} is low! Remaining: {quantity}", "Low Stock Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private StockNotifier stockNotifier = new StockNotifier();

        public ShowInventory(Orders parent)
        {
            InitializeComponent();
            this.parent = parent;

            // Gözlemci olarak ekle
            stockNotifier.AddObserver(this);

            // Verileri yükle
            LoadData();
        }



        // Geçici stok bilgilerini tutmak için bir Dictionary
        private Dictionary<string, int> tempStocks = new Dictionary<string, int>();

        private Orders parent;

        public AddOrder.ProductGroup _cart = new AddOrder.Mainbox("Main Box");


        // Database connection
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mehme\Documents\sqlDB.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;


        public void LoadData()
        {
            dataGridView1.Rows.Clear();
            cmd = new SqlCommand("select Barcode, [Product Name], Quantity , Price from Products", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr[0], dr[1], dr[2], dr[3]);
            }
            dr.Close();
            con.Close();
        }


        public void UpdateStock(string barcode, int quantity)
        {
            // Stok miktarını al
            cmd = new SqlCommand("SELECT [Product Name], Quantity FROM Products WHERE Barcode = @Barcode", con);
            cmd.Parameters.AddWithValue("@Barcode", barcode);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            string productName = reader["Product Name"].ToString();
            int currentStock = Convert.ToInt32(reader["Quantity"]);
            con.Close();

            // Yeni stok miktarını hesapla
            int newStock = currentStock - quantity;

            // Veritabanında güncelle
            cmd = new SqlCommand("UPDATE Products SET Quantity = @Quantity WHERE Barcode = @Barcode", con);
            cmd.Parameters.AddWithValue("@Quantity", newStock);
            cmd.Parameters.AddWithValue("@Barcode", barcode);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            // Stok seviyesini kontrol et
            stockNotifier.CheckStock(productName, newStock);

            tempStocks.Add(barcode, currentStock); // Geçici stok bilgilerine ekle
        }




        public void editLabel()
        {
            label1.Text = "Total Price: " + _cart.GetPrice() + " $";
        }


        public ShowInventory()
        {
            InitializeComponent();
            LoadData();
        }


        // Createing an order by double clicking on a product
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dataGridView1.Rows[e.RowIndex];

                // Check if the product is out of stock

                if (!(selectedRow.Cells["Quantity"].Value.ToString().Equals("0")))
                {

                    AddOrder addOrder = new AddOrder(this, selectedRow.Cells["Barcode"].Value.ToString());
                    addOrder.Show();
                }
                else
                {
                    MessageBox.Show("This product is out of stock!");
                }
            }

             if (e.RowIndex >= 0)
    {
        var selectedRow = dataGridView1.Rows[e.RowIndex];
        string barcode = selectedRow.Cells["Barcode"].Value.ToString();

    }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Geçici stok miktarını kullanarak stokları eski haline döndür
            foreach (var item in tempStocks)
            {
                cmd = new SqlCommand("UPDATE Products SET Quantity = @Quantity WHERE Barcode = @Barcode", con);
                cmd.Parameters.AddWithValue("@Quantity", item.Value); // Eski stok miktarı
                cmd.Parameters.AddWithValue("@Barcode", item.Key);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

            // Geçici stok bilgilerini temizle
            tempStocks.Clear();

            MessageBox.Show("Order canceled stocks are retrieved.");

            // Ana formu göster ve bu formu kapat
            parent.Show();
            this.Close();
        }


        private void CompleteOrder_Click(object sender, EventArgs e)
        {
            // Calculate the total price of the order
            double totalPrice = _cart.GetPrice();


            MessageBox.Show("Order Detail: \n" + _cart.GetDescription() + "Total Price: " + totalPrice + " TL");

            cmd = new SqlCommand("insert into Orders (Date, Detail, Price , Created_by) values (@CurrentDate, @OrderDetail, @TotalPrice , @user)", con);

            cmd.Parameters.AddWithValue("@CurrentDate", DateTime.Now);
            cmd.Parameters.AddWithValue("@OrderDetail", _cart.GetDescription());
            cmd.Parameters.AddWithValue("@TotalPrice", totalPrice);
            cmd.Parameters.AddWithValue("@user", this.parent.parent.loggedInUser);

            con.Open();
            int effected_row = cmd.ExecuteNonQuery();
            con.Close();

            if (effected_row > 0)
            {
                MessageBox.Show("Order is completed.");
                tempStocks.Clear(); // Geçici stok bilgilerini temizle
                parent.LoadData();
                this.Close();
            }
            else
            {
                MessageBox.Show("Something went wrong.");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart(this);
            cart.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
