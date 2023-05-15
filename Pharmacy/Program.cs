using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pharmacy pharmacy = new Pharmacy(100);
            Console.WriteLine("Hello! Please enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("\nAnd your username please: ");
            string username = Console.ReadLine();
            User user = new User(name, username);
            user.Operation(ref pharmacy);
        }
    }
}
