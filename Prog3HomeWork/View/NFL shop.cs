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

        private void rendelésToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
            FileReader fileReader = new FileReader();
            fileReader.Read(products);

        }

        private void névjegyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DateTime.Now.ToString("yyyy/MM/dd") + "\nSDCBFE", "Névjegy", MessageBoxButtons.OK);
        }

        private void rendelésToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (products.Count == 0)
            {
                MessageBox.Show("Nincs termék a listában!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ShowOrdersForm();
        }
        private void ShowOrdersForm()
        {
            Rendelés OrdersForm = new Rendelés(products, orders);
            OrdersForm.ShowDialog();
        }

        private void könyvelésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (products.Count != 0)
            {
                ShowAccountingForm();
            }
            else
            {
                MessageBox.Show("Nem történt még rendelés!");
            }
        }

        private void ShowAccountingForm()
        {
            Könyvelés AccoutingForm = new Könyvelés();
            AccoutingForm.ShowDialog();
        }
       
    }
}
