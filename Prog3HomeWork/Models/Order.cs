using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog3HomeWork.Models
{
    public class Order
    {
        public int Quantity {  get; private set; }
        public Product Product { get; private set; }


        public Order(int quantity, Product product)
        {
            Quantity = quantity;
            Product = product;
        }
    }
}
