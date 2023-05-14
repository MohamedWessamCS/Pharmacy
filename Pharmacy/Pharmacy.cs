using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy
{
    internal class Pharmacy
    {
        Product[] products;
        static int count = 0;
        public Pharmacy(int size)
        {
            products = new Product[size];
        }
        public Product this[int index]
        {
            set
            {
                foreach(Product product in products)
                {
                    if (product.Name)
                        Console.WriteLine();
                }
            }
        }
    }
}
