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
        public abstract void Operation();
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

        public override void Operation()
        {

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
        public override void Operation()
        {

        }
    }
}
