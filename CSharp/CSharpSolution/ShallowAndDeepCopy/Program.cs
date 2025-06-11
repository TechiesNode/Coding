using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ShallowCopy
{
    public class Employee
    {
        //Value type Property
        public string Name { get; set; }
        //Value type Property
        public string Department { get; set; }
        //Reference type Property
        public Address EmpAddress { get; set; }

        //Creating a Cloned Object of the Current Object
        public Employee GetClone()
        { 
            //Both Cloned and Existing Object Point to the Same Memory Location of the Address Object
            return (Employee)this.MemberwiseClone();
        }
    }

    public class Address
    {
        public string address { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee()
            {
                Name = "Anurag",
                Department = "IT",
                EmpAddress = new Address() 
                {
                    address = "BBSR"
                }
            };

            //Creaing a Clone Object from the Existing Object

            Employee emp2 = emp1.GetClone();
            //Changing Name Property of Clone Object will not reflect the changes of the existing object
            emp2.Name = "Pranaya";

            //Changing Address Property of Clone Object will reflect the changes of the Existing Object
            //This is because address is a reference type property and in the case of Shallow Copy 
            //Both Clone and Existing Object will point to the Same Memory Address

            emp2.EmpAddress.address = "Mumbai";

            Console.WriteLine("Emplpyee 1: ");
            Console.WriteLine("Name: " + emp1.Name + ", Address: " + emp1.EmpAddress.address + ", Dept: " + emp1.Department);
            Console.WriteLine("Emplpyee 2: ");
            Console.WriteLine("Name: " + emp2.Name + ", Address: " + emp2.EmpAddress.address + ", Dept: " + emp2.Department);
            Console.Read();




        }
    }
}
