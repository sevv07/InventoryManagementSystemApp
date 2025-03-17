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
    public partial class AddOrder : Form
    {
        // Database connection
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mehme\Documents\sqlDB.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;


        private ShowInventory parent;
        private String ID;
        private Dictionary<string, int> quantities = new Dictionary<string, int> { };


        private SmartPhoneBoxFactoryApple appleBoxFactory = new SmartPhoneBoxFactoryApple();
        private SmartPhoneBoxFactorySamsung samsungBoxFactory = new SmartPhoneBoxFactorySamsung();
        private SmartPhoneSamsung samsungPhoneFactory = new SmartPhoneSamsung();
        private SmartPhoneApple applePhoneFactory = new SmartPhoneApple();
        private ChargerApple chargerAppleFactory = new ChargerApple();
        private ChargerSamsung chargerSamsungFactory = new ChargerSamsung();
        private HeadphonesApple headphonesAppleFactory = new HeadphonesApple();
        private HeadphonesSamsung headphonesSamsungFactory = new HeadphonesSamsung();

        public void getQuantities()
        {
            

            cmd = new SqlCommand("select Barcode, Quantity from Products", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                quantities.Add(dr[0].ToString(), int.Parse(dr[1].ToString()));
            }
            dr.Close();
            con.Close();


        }

        public AddOrder(ShowInventory showInventory, String ID)
        {
            InitializeComponent();
            this.parent = showInventory;
            this.ID = ID;
            getQuantities();
        }


        private void cancelOrderButton_Click(object sender, EventArgs e)
        {

            this.Close();
           

        }



        private void addOrderButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, Func<int, ProductComponent>> methodDictionary = new Dictionary<string, Func<int, ProductComponent>>
{
    {"0001", applePhoneFactory.CreateProduct},
    {"0002", chargerAppleFactory.CreateProduct},
    {"0003", headphonesAppleFactory.CreateProduct},
    {"0004", samsungPhoneFactory.CreateProduct},
    {"0005", chargerSamsungFactory.CreateProduct},
    {"0006", headphonesSamsungFactory.CreateProduct},
    {"0007", appleBoxFactory.CreateProduct},
    {"0008", samsungBoxFactory.CreateProduct}
};

            if (methodDictionary.ContainsKey(ID))
            {
                try
                {
                    int quantity = int.Parse(quantityTextBox.Text);
                    int stockQunantity = quantities[ID];

                    if (quantity > stockQunantity)
                    {
                        MessageBox.Show("Not enough stock");
                    }
                    else
                    {
                        parent._cart.Add(methodDictionary[ID](quantity));
                        parent.editLabel();
                        parent.UpdateStock(ID, quantity);
                        MessageBox.Show("Order added successfully");
                        parent.LoadData(); 
                        this.Close();
                        
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter a valid quantity");
                }
            }
            else
            {
                MessageBox.Show("Product not found");
            }
        }




        // Abstract class ProductComponent for composite pattern
        public abstract class ProductComponent
        {

            public virtual string Barcode { get; set; }
            public virtual string ProductName { get; set; }
            public virtual string Producer { get; set; }
            public virtual string Category { get; set; }
            public virtual int quantity { get; set; }
            public virtual double price { get; set; }

            public virtual void Add(ProductComponent component)
            {
                throw new NotImplementedException("Bu işlem desteklenmiyor.");
            }

            public virtual void Remove(ProductComponent component)
            {
                throw new NotImplementedException("Bu işlem desteklenmiyor.");
            }

            public virtual double GetPrice()
            {
                throw new NotImplementedException("Bu işlem desteklenmiyor.");
            }

            public virtual string GetDescription()
            {
                return "";
            }
        }


        //
        public abstract class Product : ProductComponent
        {

            public Product(string Barcode, string ProductName, string Producer, int quantity, double price)
            {
                this.quantity = quantity;
                this.Barcode = Barcode;
                this.ProductName = ProductName;
                this.Producer = Producer;
                this.Category = "Leaf Product";
                this.price = price;
            }

            public override double GetPrice()
            {
                return price;
            }
            public override string GetDescription()
            {
              
                return quantity + " x " + ProductName + " " + price + " TL\n";
            }
        }

        public abstract class ProductGroup : ProductComponent
        {
            public List<ProductComponent> _products = new List<ProductComponent>();
            
            

            public string groupName { get; set; }

            public ProductGroup(string groupName)
            {
                this.groupName = groupName;
            }

            public override void Add(ProductComponent product)
            {
                _products.Add(product);
            }
            public override void Remove(ProductComponent product)
            {
                _products.Remove(product);
            }
            public override double GetPrice()
            {
                double price = 0;
                foreach (var product in _products)
                {
                    price += product.GetPrice();
                }
                return price;
            }
            public override string GetDescription()
            {
                string description = "";
                foreach (var product in _products)
                {
                    description += product.GetDescription();
                }
                return description;
            }
        }

        // Concrete class SmartPhone for creating products

        public class SmartPhone : Product
        {
            public SmartPhone(string Barcode, string ProductName, string Producer, int quantity, double price) : base(Barcode, ProductName, Producer, quantity, price)
            {
            }
        }
        // Concrete class Charger for creating products
        public class Charger : Product
        {
            public Charger(string Barcode, string ProductName, string Producer, int quantity, double price) : base(Barcode, ProductName, Producer, quantity, price)
            {
            }
        }
        // Concrete class Headphones for creating products
        public class Headphones : Product
        {
            public Headphones(string Barcode, string ProductName, string Producer, int quantity, double price) : base(Barcode, ProductName, Producer, quantity, price)
            {
            }
        }

        // Concrete class PhoneBox for creating products
        public class PhoneBox : ProductGroup
        {
            public PhoneBox(string groupName) : base(groupName)
            {

            }
        }
        public class Mainbox : ProductGroup
        {
            public Mainbox(string groupName) : base(groupName)
            {

            }
        }




        // Abstract class ProductGroupFactory for creating factories
        public abstract class ProductGroupFactory
        {
            public abstract ProductGroup CreateProduct(int quantity);
        }
        // Abstract class ProductFactory for creating factories
        public abstract class ProductFactory
        {
            public abstract Product CreateProduct(int quantity);
        }





        // Concrete ProductGrupFactory classes for creating factories
    
        public class SmartPhoneBoxFactoryApple : ProductGroupFactory
        {
            public override ProductGroup CreateProduct(int quantity)
            {
                PhoneBox applePhoneBox = new PhoneBox("Apple Phone Box");
                applePhoneBox.Add(new SmartPhone("0001", "iPhone 16 Pro Max", "Apple", quantity, quantity * 1200.0));
                applePhoneBox.Add(new Charger("0002", "Apple Charger", "Apple", quantity, quantity * 50.0));
                applePhoneBox.Add(new Headphones("0003", "Apple Headphones", "Apple", quantity, quantity * 100.0));
                return applePhoneBox;
            }
        }

        public class SmartPhoneBoxFactorySamsung : ProductGroupFactory
        {
            public override ProductGroup CreateProduct(int quantity)
            {
                PhoneBox samsungPhoneBox = new PhoneBox("Samsung Phone Box");
                samsungPhoneBox.Add(new SmartPhone("0004", "Samsung Galaxy S21", "Samsung", quantity, quantity * 1000.0));
                samsungPhoneBox.Add(new Charger("0005", "Samsung Charger", "Samsung", quantity, quantity * 40.0));
                samsungPhoneBox.Add(new Headphones("0006", "Samsung Headphones", "Samsung", quantity, quantity * 80.0));
                return samsungPhoneBox;

            }
        }
        public class SmartPhoneSamsung : ProductFactory
        {
            public override Product CreateProduct(int quantity)
            {
                return new SmartPhone("0004", "Samsung Galaxy S21", "Samsung", quantity, quantity * 1000.0);
            }
        }
        public class SmartPhoneApple : ProductFactory
        {
            public override Product CreateProduct(int quantity)
            {
                return new SmartPhone("0001", "iPhone 16 Pro Max", "Apple", quantity, quantity * 1200.0);
            }
        }
        public class ChargerSamsung : ProductFactory
        {
            public override Product CreateProduct(int quantity)
            {
                return new Charger("0005", "Samsung Charger", "Samsung", quantity, quantity * 40.0);
            }
        }
        public class ChargerApple : ProductFactory
        {
            public override Product CreateProduct(int quantity)
            {
                return new Charger("0002", "Apple Charger", "Apple", quantity, quantity * 50.0);
            }
        }
        public class HeadphonesSamsung : ProductFactory
        {
            public override Product CreateProduct(int quantity)
            {
                return new Headphones("0006", "Samsung Headphones", "Samsung", quantity, quantity * 80.0);
            }
        }
        public class HeadphonesApple : ProductFactory
        {
            public override Product CreateProduct(int quantity)
            {
                return new Headphones("0003", "Apple Headphones", "Apple", quantity, quantity * 100.0);
            }
        }

        
    }
}
