using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> countries = new List<string>();
            countries.Add("India");
            countries.Add("USA");

           List<string> newCountries = new List<string>();

            newCountries.Add("Japan");
            newCountries.Add("UK");

            countries.AddRange(newCountries);

            foreach (string country in countries)
            {
                Console.WriteLine(country);
            }
        }
    }
}
