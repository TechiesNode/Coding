using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of elements:- ");
            int numOfElement = int.Parse(Console.ReadLine());

            int[] arr = new int[numOfElement];
            int sum = 0;

            

            for (int i = 0; i < numOfElement; i++)
            { 
                Console.Write($"Enter the element at {i+1}:- ");
                arr[i] = int.Parse(Console.ReadLine());
                sum = sum + arr[i];
            }

            Console.WriteLine($"Sum of elements: {sum}");

        }
    }
}
