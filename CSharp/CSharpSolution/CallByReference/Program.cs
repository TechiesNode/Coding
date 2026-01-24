using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallByReference
{
    public class Employee
    {
        public string Name { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.Name = "Subhash";
            //Creating another Instance of Employee with existing Employee Instance using assignment operator.
            //Both emp1 and emp2 share the same memory locationa as = Operator uses Call By Reference Mechanism.
            Employee emp2 = emp1;
            emp2.Name = "Subhash Thakur";

            Console.WriteLine($"Employee1 Name : {emp1.Name}");     //Output:- Employee1 Name : Subhash Thakur
            Console.WriteLine($"Employee2 Name : {emp2.Name}");     //Output:- Employee1 Name : Subhash Thakur


            //====================Usiing ref keyword============

            int a = 15;
            UpdateValue(ref a);
            Console.WriteLine($"Value of a : {a}");
            Console.ReadKey();
           
        }

        static void UpdateValue(ref int b)
        {
            b = 30;
        }
    }
}
