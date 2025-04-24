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
        public Product product { get; private set; }
        private Rendelés order;
        public bool isChecked { get; private set; } = false;
        public int quantity { get; private set; } = 0;
        public ProductsControl(Rendelés rendeles)
        {
            InitializeComponent();
            this.order = rendeles;
        }

        public void ItemLoad(Product products)
        {
            this.product = products;

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
            isChecked = checkBox1.Checked;
            order.GetTotalSum();
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
                if (quantityTextBox.Text.Length > 0)
                {
                    int tempQuantity = 0;
                    if (!int.TryParse(quantityTextBox.Text, out tempQuantity))
                    {
                        MessageBox.Show("Nem megfelelő a bevitt érték!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        quantityTextBox.Text = "";
                        quantity = 0;
                    }
                    else
                    {
                        quantity = tempQuantity;
                    }
                }
                else
                {
                    quantity = 0;
                }
                order.GetTotalSum();
        }
    }
}
