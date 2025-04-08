using Prog3HomeWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Prog3HomeWork.Data
{

    public class FileReader
    {
        public void Read(List<Product> products)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Text Files (*.txt)|*.txt|CSV files (*.csv)|*.csv";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = null;
                try
                {
                    reader = new StreamReader(fileDialog.FileName);
                    string[] items;
                    while (!reader.EndOfStream)
                    {   
                        items = reader.ReadLine().Split(';');

                        products.Add(new Product(items[0], items[1], int.Parse(items[2]), items[3], double.Parse(items[4]), double.Parse(items[5]), items[6]));
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
        }
    }
}
