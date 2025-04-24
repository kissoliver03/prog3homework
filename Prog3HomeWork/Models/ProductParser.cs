using Prog3HomeWork.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace Prog3HomeWork.Models
{
    public class ProductParser : IParser<Product>
    {
        public Product Parse(string[] input)
        {
            return new Product(input[0], input[1], int.Parse(input[2]), input[3], double.Parse(input[4]), double.Parse(input[5]), input[6]);
        }
    }
}
