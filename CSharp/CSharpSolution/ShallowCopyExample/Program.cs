using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShallowCopyExample
{
    class Address
    {
        public string City;
    }
    class Person
    {
        public string Name;
        public Address Addr;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person
            {
                Name = "Amit",
                Addr = new Address { City = "Delhi" }
            };

            //Shallow Copy
            Person p2 = p1;
            p2.Name = "Rahul";
            p2.Addr.City = "Mumbai";
            Console.WriteLine("Shallow Copy:");
            Console.WriteLine("p1.Name: " + p1.Name);         // Amit (Name is independent)
            Console.WriteLine("p1.Addr.City: " + p1.Addr.City); // Mumbai (Shared address)
            Console.WriteLine($"p2.Name = {p2.Name}, p2.Addr.City = {p2.Addr.City}");

        }
    }
}
/*
 Output:-
Shallow Copy:
p1.Name: Rahul
p1.Addr.City: Mumbai
p2.Name = Rahul, p2.Addr.City = Mumbai
 */
