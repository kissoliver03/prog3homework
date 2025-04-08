using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog3HomeWork.Models
{
    public class Product
    {
       public string TeamName { get; private set; }
       public string PlayerName { get; private set; }
       public int ShirtNumber { get; private set; }
       public string ShirtSize { get; private set; }
       public double PurchasePrice { get; private set; }
       public double SellingPrice { get; private set; }
       public string ImagePath { get; private set; }


        public Product(string teamName, string playerName, int shirtNumber, string shirtSize, double purchasePrice, double sellingPrice, string imagePath)
        {
            TeamName = teamName;
            PlayerName = playerName;
            ShirtNumber = shirtNumber;
            ShirtSize = shirtSize;
            PurchasePrice = purchasePrice;
            SellingPrice = sellingPrice;
            ImagePath = imagePath;
        }
    }
}
