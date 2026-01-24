using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of operations: ");
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter operation (Insert x / Delete x / Print): ");
                string input = Console.ReadLine();
                string[] parts = input.Split();
                if (parts[0] == "Insert")
                {
                    
                    int x = int.Parse(parts[1]);
                    list.Add(x);

                }
                else if (parts[0] == "Delete")
                {
                    int x = int.Parse(parts[1]);
                    list.Remove(x);
                }

                else if (parts[0] == "Print")
                {
                    Console.WriteLine(string.Join(" ", list));
                }
            }
        }
    }
}
