using Prog3HomeWork.Data;
using Prog3HomeWork.Models;
using Prog3HomeWork.View;
using System.Data;
using System.Windows.Forms;

namespace Prog3HomeWork
{
    public partial class MainForm : Form
    {
        private List<Product> products = new List<Product>();
        private List<Order> orders = new List<Order>();

        public int TotalOrderNumber = 0;


        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void rendel�sToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
            FileReader fileReader = new FileReader();
            fileReader.Read(products);

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
                MessageBox.Show("Nincs beolvasott term�k!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
