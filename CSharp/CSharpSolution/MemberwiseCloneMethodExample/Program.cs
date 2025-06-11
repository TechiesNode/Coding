using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberwiseCloneMethodExample
{
    public class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }

        public Employee GetClone()
        { 
           //MemberwiseClone Method Creates a Shallow copy of the current System.Object
           //So typecast the object Appropriate Type
           //In this case, typescast to Employee type
           return (Employee)this.MemberwiseClone();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating and Instance of Employee Class
            Employee emp1 = new Employee();
            emp1.Name = "Anurag";
            emp1.Department = "It";

            //Instead of using Assignment Operator, now use the clone method to create
            //a Cloned Object.
            //Both emp1 and emp2 having different Memory Address.
            Employee emp2 = emp1.GetClone();

            //Changing the Name Property Value of emp2 instance,
            //will not change the Name Property Value of emp1 instance
            emp2.Name = "Pranaya";
            Console.WriteLine("Employee 1: ");
            Console.WriteLine($"Name: {emp1.Name}, Department: {emp1.Department}");
            Console.WriteLine("Employee 2: ");
            Console.WriteLine($"Name: {emp2.Name}, Department: {emp2.Department}");
        }
    }
}
/*
 The MemberwiseClone method is a part of the System.Object class and creates a shallow copy of the given object.
 MemeberwiseClone method only copies the non-static fields of the new object.
 3.In copying , if a field is a value type, a bit-by-bit copy of the field is performed. If a field is a reference type, 
 the reference is copied, but the reference object is not.
 */