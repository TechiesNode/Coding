using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    class Person
    {
        public string Name;
        public int Age;

        public void Display()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Name = "Subhash";
            p.Age = 34;
            p.Display();
        }
    }
}
