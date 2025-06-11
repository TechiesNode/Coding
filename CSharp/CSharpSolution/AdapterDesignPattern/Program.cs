using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public decimal Salary { get; set; }

        public Employee(int id, string name, string designation, decimal salary)
        {
            ID = id;
            Name = name;
            Designation = designation;
            Salary = salary;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            string[,] employeesArray = new string[5, 4]
                {
                    {"101","John","SE","10000"},
                    {"102","Smith","SE","20000"},
                    {"103","Dev","SSE","30000"},
                    {"104","Pam","SE","40000"},
                    {"105","Sara","SSE","50000"}
                };

            Console.WriteLine("HR system passes employee string array to Adapter\n");
            ITarget target = new EmployeeAdapter();
            target.ProcessCompanySalary(employeesArray);
            Console.Read();
        }
    }
}
/*
Defintion:-The Adapter Pattern is a structural design pattern that allows two incompatible interfaces to work together.
It acts as a bridge between the existing system and new components without modifying existing code.

When To Use:-
    1.When you need to integrate a third-party library with an incompatible interface.
    2.When you want to use an existing class but its interface doesn't match your needs.
    3.When working with legacy code that connot be modified directly.
Real-Life Analogy:- Think of a power adaptor for charging a laptop. A US laptop plug won't fit
                    into an Indian power socket directly, so an adapter is used to make them compatible.

 */