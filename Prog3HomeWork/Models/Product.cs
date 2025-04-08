using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog3HomeWork.Models
{
    public class Product
    {
       public string TeamName { get; set; }
       public string PlayerName { get; set; }
       public int ShirtNumber { get; set; }
       public string ShirtSize { get; set; }
       public double PurchasePrice { get; set; }
       public double SellingPrice { get; set; }
       public string ImagePath { get; set; }
       public bool isChecked { get; set; }
       public int Quantity { get; set; }


        public Product(string teamName, string playerName, int shirtNumber, string shirtSize, double purchasePrice, double sellingPrice, string imagePath)
        {
            TeamName = teamName;
            PlayerName = playerName;
            ShirtNumber = shirtNumber;
            ShirtSize = shirtSize;
            PurchasePrice = purchasePrice;
            SellingPrice = sellingPrice;
            ImagePath = imagePath;
            isChecked = false;
            Quantity = 0;
        }

        public double GetTotalPrice()
        {
            return SellingPrice * Quantity;
        }
    }
}
