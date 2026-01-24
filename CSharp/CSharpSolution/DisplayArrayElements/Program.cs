using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayArrayElements
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
                Console.Write($"Enter the element {i+1}:-");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("---------Elements in array are---------------");
            for (int i = 0; i < num; i++)
            {
                Console.Write(arr[i]+" ");
            }
        }
    }
}
