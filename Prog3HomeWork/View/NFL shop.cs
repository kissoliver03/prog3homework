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
            products = fileReader.Read(products);
          /*  if (ReadFile())
            {
                MessageBox.Show("A file olvasása sikeres volt!");
            }
          */
        }

       /* private bool ReadFile()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Text Files (*.txt)|*.txt|CSV files (*.csv)|*.csv";
            bool readSuccess = false;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                readSuccess = true;
                StreamReader reader = null;
                try
                {
                    reader = new StreamReader(fileDialog.FileName);
                    string[] items;
                    while (!reader.EndOfStream)
                    {
                        items = reader.ReadLine().Split(';');

                        products.Add(new Product(items[0], items[1], int.Parse(items[2]), items[3], int.Parse(items[4]), int.Parse(items[5]), items[6]));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        String.Format("Hiba történt a fájl olvasása közben! {0}", ex.Message),
                        "Figyelem!"
                    );
                }
                finally
                {
                    if (reader != null)
                    {
                        reader.Close();
                    }
                }
            }
            return readSuccess;
        }
       */

        private void névjegyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DateTime.Now.ToString("yyyy/MM/dd") + "\nSDCBFE", "Névjegy", MessageBoxButtons.OK);
        }

        private void rendelésToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if(products.Count == 0)
            {
                MessageBox.Show("Nincs termék a listában!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ShowOrdersForm();
        }
        private void ShowOrdersForm()
        {
            Rendelés OrdersForm = new Rendelés(products);
            OrdersForm.ShowDialog();
        }
    }
}
