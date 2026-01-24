using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertElementAtASpecificPosition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> countries = new List<string>()
            {
                "India",
                "USA"
            };
            countries.Insert(1, "China");
            Console.WriteLine($"Index of China Element in the List: {countries.IndexOf("China")}");
            Console.WriteLine("\n Accessing List After Inserting China at Index 1");
            foreach (var item in countries)
            { 
                Console.WriteLine(item);
            }
        }
    }
}
