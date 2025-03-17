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
    public partial class MainPage : Form
    {
        public string loggedInUser;

        public MainPage(string name)
        {
            InitializeComponent();
            loggedInUser = name;

            userLabel.Text = name;
        }

        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel2.Controls.Add(childForm);
            panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }

        private void inventoryButton_Click(object sender, EventArgs e)
        {
            openChildForm(new Inventory());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new Products());
        }

        private void ordersButton_Click(object sender, EventArgs e)
        {
            openChildForm(new Orders(this));
        }

        private void usersButton_Click(object sender, EventArgs e)
        {
            openChildForm(new Users());
        }

        private void logo_Click(object sender, EventArgs e)
        {

        }
    }
}
