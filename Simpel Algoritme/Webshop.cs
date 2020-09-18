using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simpel_Algoritme
{
    public partial class Webshop : Form
    {
        Order order;
        public Webshop()
        {
            InitializeComponent();
            order = new Order();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            double price = Convert.ToDouble(tbPrice.Text);

            Product product = new Product(name, price);
            order.AddProduct(product);

            tbName.Text = null;
            tbPrice.Text = null;
            tbName.Focus();

            lbAllProducts.Items.Clear();
            foreach (Product item in order.products)
            {
                lbAllProducts.Items.Add(item);
            }
        }

        private void btnMaxPrice_Click(object sender, EventArgs e)
        {
            double price = order.GiveMaximumPrice();

            btnMaxPrice.Text = "Maximum price is: " + price.ToString();
        }

        private void btnAvgPrice_Click(object sender, EventArgs e)
        {
            double price = order.GiveAveragePrice();

            btnAvgPrice.Text = "Average price is: " + price.ToString();
        }

        private void btnAllProducts_Click(object sender, EventArgs e)
        {
            double minPrice = Convert.ToDouble(tbMinPrice.Text);

            List<Product> products = order.GetAllProducts(minPrice);

            lbProductsMinPrice.Items.Clear();
            foreach (Product product in products)
            {
                lbProductsMinPrice.Items.Add(product);
            }
        }

        private void btnSortProducts_Click(object sender, EventArgs e)
        {
            List<Product> products = order.SortProductsByPrice();

            lbAllProducts.Items.Clear();
            foreach (Product product in products)
            {
                lbAllProducts.Items.Add(product);
            }
        }
    }
}
