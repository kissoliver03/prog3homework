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
        private List<Product> products;
        public double orderSum = 0;
        public double sellingSum = 0;
        public Rendelés(List<Product> products)
        {
            InitializeComponent();
            this.products = products;
        }

        private void Rendelések_Load(object sender, EventArgs e)
        {
            foreach (var product in products)
            {
                ProductsControl productControl = new ProductsControl(orderSum, sellingSum);
                flowLayoutPanel1.Controls.Add(productControl);
                productControl.ItemLoad(product);
            }
        }
        private void OrderButton_Click(object sender, EventArgs e)
        {
          /*  double totalPrice = 0;
            foreach (var product in products)
            {
                if (product.isChecked)
                {
                    totalPrice += product.SellingPrice;
                }
            }
            OrderSumLabel.Text = "$" + totalPrice.ToString("F2", CultureInfo.InvariantCulture);
          */
            
        }
    }
}
