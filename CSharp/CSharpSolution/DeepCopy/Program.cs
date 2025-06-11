using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DeepCopy
{

    public class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public Address EmpAddress { get; set; }

        public Employee GetClone()
        { 
            Employee employee = (Employee)this.MemberwiseClone();
            employee.EmpAddress = EmpAddress.GetClone();
            return employee;

        }
    }

    public class Address
    {
        public string address  { get; set; }
        public Address GetClone()
        { 
            return (Address)this.MemberwiseClone();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee emp1 = new Employee
            {
                Name = "Anurag",
                Department = "IT",
                EmpAddress = new Address() { address = "BBSR"}
            };

            Employee emp2 = emp1.GetClone();
            emp2.Name = "Pranay";
            emp2.EmpAddress.address = "Mumbai";
            Console.WriteLine("Emplpyee 1: ");
            Console.WriteLine("Name: " + emp1.Name + ", Address: " + emp1.EmpAddress.address + ", Dept: " + emp1.Department);
            Console.WriteLine("Emplpyee 2: ");
            Console.WriteLine("Name: " + emp2.Name + ", Address: " + emp2.EmpAddress.address + ", Dept: " + emp2.Department);
            Console.Read();
        }
    }
}
