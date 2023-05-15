using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy
{
    public abstract class Human
    {
        public string Name { get; set; }
        public Human(string name)
        {
            Name = name;
        }
        public abstract void Introduce();
        public abstract void Operation(ref Pharmacy pharmacy);
    }
    public  class User : Human
    {
        // A property for the username of the user
        public string Username { get; set; }
        // A constructor that takes a name and a username as parameters
        public User(string name, string username) : base(name)
        {
            Name = name;
            Username = username;
        }

        // An override method for the user to introduce themselves
        public override void Introduce()
        {
            Console.WriteLine($"Hello, I am {Name} and my username is {Username}.");
        }

        public override void Operation(ref Pharmacy pharmacy)
        {
            Orders order = new Orders(this);
            bool flag = false;
            pharmacy.PrintProducts();
            do
            {
                Console.Write("Choose Product to Purchase: ");
                string productName = Console.ReadLine();
                Console.Write("\n");
                Product prod;
                int index = 0;
                pharmacy.CheckExistence(productName, out prod, out index);
                order.AddItemToOrder(ref prod);
                Console.WriteLine("Press 1 if you would like to purchase another item");
                int choice = int.Parse(Console.ReadLine());
                if(choice == 1)
                {
                    flag = true;
                }
                else
                {
                    flag = false
                }
            }
            while (flag);

        }
    }
    public class Doctor : Human
    {
        
        public string Specialty { get; set; }

        
        public Doctor(string name, string specialty) : base(name)
        {
            Name = name;
            Specialty = specialty;
        }

        
        public override void Introduce()
        {
            Console.WriteLine($"Hello, I am Dr. {Name} and I specialize in {Specialty}.");
        }
        public override void Operation(ref Pharmacy pharmacy)
        {

        }
    }
}
