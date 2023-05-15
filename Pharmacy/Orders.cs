using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy
{
    internal class Orders
    {
        // User, ID, Products and Price, Total Price

        // User name:
        // Receipt ID:
        // Product1 90 pounds
        // Product2 100 pounds
        // .
        // .
        // .
        // Total Price: 190 pounds
        User user;
        static int lastId;
        int id;
        Product[] products = new Product[100];
        public int Id { get { return id; } }

        public Orders(User user)
        {
            this.user = user;
            id = ++lastId;
        }
        public void AddItemToOrder(ref Product product)
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i] == null)
                {
                    products[i] = product;
                    break;
                }
            }
        }
        public void PrintReceipt()
        {
            Console.WriteLine("User name: {0}", user.Name);
            Console.WriteLine("Receipt ID: {0}", id);
            float totalPrice = 0;
            for (int i = 0; products[i] != null; i++)
            {
                totalPrice += products[i].SellPrice;
                Console.WriteLine("Product name: {0}    Price: {1}", products[i].Name, products[i].SellPrice);
            }
            Console.WriteLine(totalPrice);
        }
    }
}
