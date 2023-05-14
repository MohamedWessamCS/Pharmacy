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
                foreach (Product product in products)
                {
                    if (product.Name == value.Name)
                    {
                        if (index >= count)
                        {
                            products[index].Quantity++;
                        }
                        else
                        {
                            Console.WriteLine("Failed!"); ;
                        }
                    }
                    else
                    {
                        products[index] = value;
                        count++;
                    }
                }
            }
            get
            {
                if (index < count)
                {
                    return products[index];
                }
                else
                {
                    return null;
                }
            }
        }
        public bool CheckExistence(Product product)
        {
            bool flag = false;
            for(int i = 0; i < products.Length; i++) { }
        }
        pub
    }
}
