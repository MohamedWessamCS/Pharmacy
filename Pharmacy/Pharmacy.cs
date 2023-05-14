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
            for(int i = 0; i < products.Length; i++)
            {
                if (products[i].Name == product.Name)
                {
                    return true;
                }
            }
            return false;
        }
        public bool CheckExistence(string name, out Product prod, out int index)
        {
            for(int i = 0; i < products.Length; i++)
            {
                if (products[i].Name == name)
                {
                    prod = products[i];
                    index = i;
                    return true;
                }
            }
            prod = null;
            index = -1;
            return false;
        }
        public void UpdateProduct(string name, int quantity, string description, float sellPrice, float purchasePrice)
        {
            Product prod;
            int index;
            if(CheckExistence(name, out prod, out index))
            {
                products[index].Quantity = quantity;
                products[index].Description = description;
                products[index].SellPrice = sellPrice;
                products[index].PurchasePrice = purchasePrice;

            }
        }
    }
}
