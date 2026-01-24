using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMinimumElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of element:-");
            int num = int.Parse(Console.ReadLine());

            int[] arr = new int[num];

            for (int i = 0; i < num; i++)
            {
                Console.Write($"Enter the element at {i+1}:-");
                arr[i] = int.Parse(Console.ReadLine());

            }

            int min = arr[0];
            for (int i = 1; i < num; i++)
            {
                if (arr[i] < min)
                { 
                    min = arr[i];
                }
            }

            Console.WriteLine($"The smallest number in this array is: {min}");
        }
    }
}
