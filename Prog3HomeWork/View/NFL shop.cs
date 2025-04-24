using Prog3HomeWork.Data;
using Prog3HomeWork.Models;
using Prog3HomeWork.View;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Prog3HomeWork
{
    public partial class MainForm : Form
    {
        private List<Product> products = new List<Product>();
        private List<Order> orders = new List<Order>();

        public int totalOrderNumber = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Biztosan ki szeretnél lépni?", "Kilépés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void fájlBetöltésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Text Files (*.txt)|*.txt|CSV files (*.csv)|*.csv";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    products.Clear();
                    products.AddRange(new Loader<Product>().LoadFile(fileDialog.FileName, new ProductParser()));

                    MessageBox.Show("A fájl beolvasása sikeres volt!", "Figyelem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hiba történt a fájl beolvasása közben!", "Figyelem!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void névjegyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DateTime.Now.ToString("yyyy/MM/dd") + "\nSDCBFE", "Névjegy", MessageBoxButtons.OK);
        }

        private void rendelésToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (products.Count != 0)
            {
                ShowOrdersForm();
            }
            else
            {
                MessageBox.Show("Nincs beolvasott termék!\nElöször történjen meg a beolvasás a \"Fájl betöltés...\" fülön", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ShowOrdersForm()
        {
            Rendelés OrdersForm = new Rendelés(products, orders, this);
            OrdersForm.ShowDialog();
        }

        private void könyvelésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (orders.Count != 0)
            {
                ShowAccountingForm();
            }
            else
            {
                MessageBox.Show("Nem történt még rendelés!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowAccountingForm()
        {
            Könyvelés AccoutingForm = new Könyvelés(orders, this);
            AccoutingForm.ShowDialog();
        }
       
    }
}
