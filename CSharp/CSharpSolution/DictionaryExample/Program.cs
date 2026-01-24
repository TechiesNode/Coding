using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating a Dictionary
            Dictionary<int, string> sub = new Dictionary<int, string>();

            //Adding Elements
            sub.Add(1, "C#");
            sub.Add(2, "JavaScript,CSS,HTML");
            sub.Add(3, "Dart");
            //Displaying Dictionary
            foreach (var item in sub)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }
        }
    }
}
