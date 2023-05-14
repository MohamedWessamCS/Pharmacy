using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy
{
    internal class Orders
    {
        // User, Doctor, ID, Products and Price, Total Price

        // User name:
        // Doctor name:
        // Receipt ID:
        // Product1 90 pounds
        // Product2 100 pounds
        // .
        // .
        // .
        // Total Price: 190 pounds
        User user;
        Doctor doctor;
        static int lastId;
        int id;
        Product[] products;

        public Orders(User user, Doctor doctor, Product[] products)
        {
            this.user = user;
            this.doctor = doctor;
            this.products = products;
        }
        public void PrintReceipt()
        {
            Console.WriteLine("User name: {0}", user.Name);
            Console.WriteLine("Doctor name: {0}", doctor.Name);
            Console.WriteLine("Receipt ID: {0}", id);
            int totalPrice = 0;
            for (int i = 0; i < products.Length; i++)
            {
                totalPrice += products[i].SellPrice;
                Console.WriteLine("Product name: {0}    Price: {1}", products[i].Name, products[i].SellPrice);
            }
            Console.WriteLine(totalPrice);
        }
    }
}
