using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormsApp1
{

    public partial class Cart : Form
    {
        private ShowInventory parent;



        public Cart(ShowInventory showInventory)
        {
            parent = showInventory;
            InitializeComponent();

            string orderDetail = "";

            foreach (var item in parent._cart._products)
            {

                orderDetail += item.GetDescription() + "\n";
            }


            richTextBox1.Text = orderDetail;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
 /*      
public partial class Cart
    {
        private List<IObserver> observers = new List<IObserver>();
        private double totalPrice = 0;

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        private void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update();
            }
        }

        public void AddProduct(double price)
        {
            totalPrice += price;
            NotifyObservers();
        }

        public void RemoveProduct(double price)
        {
            totalPrice -= price;
            NotifyObservers();
        }

        public double GetPrice() => totalPrice;
    }

}
 */
