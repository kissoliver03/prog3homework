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
    public partial class ProductsControl : UserControl
    {
        private Product products;
        public ProductsControl(double orderSum, double sellingSum)
        {
            InitializeComponent();
        }

        public void ItemLoad(Product products)
        {
            this.products = products;

            ShirtPictureBox.Image = Image.FromFile("..\\..\\..\\Images\\" + products.ImagePath);
            ShirtPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            TeamLabel.Text = products.TeamName;
            NameLabel.Text = products.PlayerName;
            ShirtNumberLabel.Text = "#" + products.ShirtNumber.ToString();
            ShirtSizeLabel.Text = products.ShirtSize;
            PriceLabel.Text = "$" + products.SellingPrice.ToString("F2", CultureInfo.InvariantCulture);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                products.isChecked = true;
                orderSum = products.SellingPrice * products.Quantity;
            }
            else
            {
                products.isChecked = false;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            products.Quantity = int.Parse(quantityTextBox.Text);
        }
    }
}
