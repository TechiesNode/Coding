using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of elements:-");
            int num = int.Parse(Console.ReadLine());
            int[] arr = new int[num];

            for (int i = 0; i < num; i++)
            {
                Console.Write($"Enter the elements at {i+1}:-");
                arr[i] = int.Parse(Console.ReadLine());
            }
            int max = arr[0];

            for (int i = 1; i < num; i++)
            {
                if (arr[i] > max)
                { 
                    max = arr[i];
                }
            }
            Console.WriteLine($"Biggest Element in the array is: {max}");
        }
    }
}
