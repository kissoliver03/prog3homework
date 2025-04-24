using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prog3HomeWork.Interface;

namespace Prog3HomeWork.Data
{
    public class Loader<T>
    {
        public List<T> LoadFile(string filePath, IParser<T> parser)
        {
            List<T> list = new List<T>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string[] dataItems;
                while (!reader.EndOfStream)
                {
                    dataItems = reader.ReadLine().Split(';');
                    list.Add(
                        parser.Parse(dataItems)
                    );
                }
            }
            return list;
        }
    }
}
