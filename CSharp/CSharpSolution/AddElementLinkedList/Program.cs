using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddElementLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> linkedList = new LinkedList<string>();
            linkedList.AddLast("India");
            linkedList.AddLast("USA");
            linkedList.AddLast("SriLanka");
            linkedList.AddLast("UK");
            linkedList.AddLast("Japan");
            Console.WriteLine("LinkedList Elements:-");
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            linkedList.Clear();
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }

        }
    }
}
