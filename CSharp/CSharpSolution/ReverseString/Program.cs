using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Enter a string:-");
            string strInput = Console.ReadLine();
            string reversedString = "";

            for (int i = strInput.Length - 1; i >= 0; i--)
            {
                reversedString = reversedString + strInput[i];
            }

            Console.WriteLine($"Reversed String :- {reversedString}");
        }
    }
}
