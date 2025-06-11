using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepCopyExample
{
    class Address
    {
        public string City;
    }

    class Person
    {
        public string Name;
        public Address Addr;

        // Deep copy method
        public Person DeepCopy()
        {
            return new Person
            {
                Name = this.Name,
                Addr = new Address { City = this.Addr.City }
            };
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person
            {
                Name = "Amit",
                Addr = new Address { City = "Delhi" }
            };

            // Deep copy
            Person p2 = p1.DeepCopy();

            p2.Name = "Rahul";
            p2.Addr.City = "Mumbai";

            Console.WriteLine("\nDeep Copy:");
            Console.WriteLine("p1.Name: " + p1.Name);         // Amit
            Console.WriteLine("p1.Addr.City: " + p1.Addr.City); // Delhi (not affected)
        }
    }
}
