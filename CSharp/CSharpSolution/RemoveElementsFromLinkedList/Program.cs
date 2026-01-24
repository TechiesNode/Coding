using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveElementsFromLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> linkedList = new LinkedList<string>();
            linkedList.AddLast("India");
            LinkedListNode<string> UsaNode = linkedList.AddLast("USA");
            linkedList.AddLast("SriLanka");
            LinkedListNode<string> UKNode = linkedList.AddLast("UK");
            linkedList.AddLast("Japan");

            Console.WriteLine("Initial LinkedList Elements:- ");
            foreach (string item in linkedList)
            { 
                Console.WriteLine(item);
            }
        }
    }
}
