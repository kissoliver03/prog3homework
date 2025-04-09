using Prog3HomeWork.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog3HomeWork.View
{
    public partial class Könyvelés : Form
    {
        private List<Order> Orders;
        public Könyvelés(List<Order> orders)
        {
            InitializeComponent();
            this.Orders = orders;
        }

        private void Könyvelés_Load(object sender, EventArgs e)
        {
            int QuantityTotal = 0;
            double PurchaseTotal = 0;
            double SellingTotal = 0;

            foreach (Order order in Orders)
            {
                QuantityTotal += order.Quantity;
                PurchaseTotal += order.Product.PurchasePrice * order.Quantity;
                SellingTotal += order.Product.SellingPrice * order.Quantity;

            }
            QuantityLabel.Text = QuantityTotal.ToString() + "db";
            PurchaseLabel.Text = "$" + PurchaseTotal.ToString("F2", System.Globalization.CultureInfo.InvariantCulture);
            SellingLabel.Text = "$" + SellingTotal.ToString("F2", System.Globalization.CultureInfo.InvariantCulture);
            ProfitLabel.Text = "$" + (SellingTotal - PurchaseTotal).ToString("F2", System.Globalization.CultureInfo.InvariantCulture);
        }
    }
}
