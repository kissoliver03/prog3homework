using Prog3HomeWork.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog3HomeWork.View
{
    public partial class Rendelés : Form
    {
        private List<Product> Products;
        private List<ProductsControl> controls;
        private List<Order> Orders;

        private MainForm MainForm;

        public double orderSum = 0;
        public double sellingSum = 0;
        public Rendelés(List<Product> products, List<Order> orders, MainForm mainForm)
        {
            InitializeComponent();
            this.Products = products;
            this.Orders = orders;
            this.MainForm = mainForm;
        }

        private void Rendelések_Load(object sender, EventArgs e)
        {
            controls = new List<ProductsControl>();
            foreach (var product in Products)
            {
                ProductsControl productControl = new ProductsControl(this);
                flowLayoutPanel1.Controls.Add(productControl);
                productControl.ItemLoad(product);
                controls.Add(productControl);
            }
            OrderButton.Enabled = false;
        }

        public void GetTotalSum()
        {
            orderSum = 0;
            sellingSum = 0;
       
            bool ButtonEnabled = false;
            foreach(ProductsControl productControl in controls)
            {
                if (productControl.isChecked)
                {
                    orderSum += productControl.quantity * productControl.product.SellingPrice;
                    if(productControl.quantity > 0)
                    {
                        ButtonEnabled = true;
                    }
                }
                OrderButton.Enabled = ButtonEnabled;
            }
            OrderSumLabel.Text = "$" + orderSum.ToString("F2", CultureInfo.InvariantCulture);

        }
        private void OrderButton_Click(object sender, EventArgs e)
        {
            MainForm.totalOrderNumber++;
            foreach (ProductsControl productControl in controls)
            {
                if (productControl.isChecked)
                {
                    Orders.Add(new(productControl.quantity, productControl.product));
                }
            }
            Close();
        }
    }
}
