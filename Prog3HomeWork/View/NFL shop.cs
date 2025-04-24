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

        private void kil�p�sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Biztosan ki szeretn�l l�pni?", "Kil�p�s", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void f�jlBet�lt�sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Text Files (*.txt)|*.txt|CSV files (*.csv)|*.csv";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    products.Clear();
                    products.AddRange(new Loader<Product>().LoadFile(fileDialog.FileName, new ProductParser()));

                    MessageBox.Show("A f�jl beolvas�sa sikeres volt!", "Figyelem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hiba t�rt�nt a f�jl beolvas�sa k�zben!", "Figyelem!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void n�vjegyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DateTime.Now.ToString("yyyy/MM/dd") + "\nSDCBFE", "N�vjegy", MessageBoxButtons.OK);
        }

        private void rendel�sToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (products.Count != 0)
            {
                ShowOrdersForm();
            }
            else
            {
                MessageBox.Show("Nincs beolvasott term�k!\nEl�sz�r t�rt�njen meg a beolvas�s a \"F�jl bet�lt�s...\" f�l�n", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ShowOrdersForm()
        {
            Rendel�s OrdersForm = new Rendel�s(products, orders, this);
            OrdersForm.ShowDialog();
        }

        private void k�nyvel�sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (orders.Count != 0)
            {
                ShowAccountingForm();
            }
            else
            {
                MessageBox.Show("Nem t�rt�nt m�g rendel�s!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowAccountingForm()
        {
            K�nyvel�s AccoutingForm = new K�nyvel�s(orders, this);
            AccoutingForm.ShowDialog();
        }
       
    }
}
