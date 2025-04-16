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

        private MainForm MainForm;
        public Könyvelés(List<Order> orders, MainForm mainForm)
        {
            InitializeComponent();
            this.Orders = orders;
            this.MainForm = mainForm;
        }

        private void Könyvelés_Load(object sender, EventArgs e)
        {
            double PurchaseTotal = 0;
            double SellingTotal = 0;

            foreach (Order order in Orders)
            {
                PurchaseTotal += order.Product.PurchasePrice * order.Quantity;
                SellingTotal += order.Product.SellingPrice * order.Quantity;

            }
            QuantityLabel.Text = MainForm.totalOrderNumber + "db";
            PurchaseLabel.Text = "$" + PurchaseTotal.ToString("F2", System.Globalization.CultureInfo.InvariantCulture);
            SellingLabel.Text = "$" + SellingTotal.ToString("F2", System.Globalization.CultureInfo.InvariantCulture);
            ProfitLabel.Text = "$" + (SellingTotal - PurchaseTotal).ToString("F2", System.Globalization.CultureInfo.InvariantCulture);
        }
    }
}
