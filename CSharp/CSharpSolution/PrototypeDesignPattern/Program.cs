using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPattern
{
    //The Prototype Abstract Class
    //This is an abstract class which is used for the types of object that can be cloned itself.
    public abstract class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public string Type  { get; set; }
        public abstract Employee GetClone();
        public abstract void ShowDetails();
    }
    //This is a class that implements the prototype interface for cloning itself.
    public class PermanentEmployee : Employee
    {
        public int Salary { get; set; }
        public override Employee GetClone()
        {
            //MemberwiseClone Method Creates a shallow copy of the current System.Object
            //So typecast the object Appropriate Type.
            //In this case, typecast to PermanentEmployee type.
            return (PermanentEmployee)this.MemberwiseClone();
        }
        public override void ShowDetails()
        {
            Console.WriteLine("Permanent Employee");
            Console.WriteLine($"Name:{this.Name}, Department: {this.Department}, Type:{this.Type}, Salary: {this.Salary}\n");
        }
    }

    //This is a class that implements the prototype interface for cloning itself.
    public class TemporaryEmployee : Employee
    {
        public int FixedAmount { get; set; }
        //MemberwiseClone Method Creates a shallow copy of the current System.Object
        //So typecast the object Appropriate Type.
        //In this case, typecast to TemporaryEmployee type.
        public override Employee GetClone()
        {
            return (TemporaryEmployee)this.MemberwiseClone();
        }
        public override void ShowDetails()
        {
            Console.WriteLine("Temporary Employee");
            Console.WriteLine($" Name:{this.Name}, Department: {this.Department}, Type:{this.Type}, FixedAmount: {this.FixedAmount}\n");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating an Instance of Permanent Employee Class
            Employee emp1 = new PermanentEmployee()
            {
                Name = "Anurag",
                Department = "IT",
                Type = "Permanent",
                Salary = 100000
            };
            //Creating a clone of the above Permanent Employee
            Employee emp2 = emp1.GetClone();
            //Changing the Name and Department Property Value of emp2 instance,
            //will not chane the Name and Department Property Value of the emp1 instance
            emp2.Name = "Pranaya";
            emp2.Department = "HR";
            emp1.ShowDetails();
            emp2.ShowDetails();
            //Creating an Instance of Temporary Employee Class
            Employee emp3 = new TemporaryEmployee()
            {
                Name = "Priti",
                Department = "HR",
                Type = "Temprary",
                FixedAmount = 20000
            };
            //Creating a Clone of the above Temporary Employee.
            Employee emp4 = emp3.GetClone();
            //Changing the Name and Department Property Value of emp4 instance,
            //will not change the Name and Department Property Value of the emp3 instance
            emp4.Name = "Priyanka";
            emp4.Department = "Sales";
            emp3.ShowDetails();
            emp4.ShowDetails();
            Console.Read();
        }
    }
}
/*
 Prototype Design Pattern:- The Prototype Design Pattern specifies the kind of object to create using a
    prototypical instance and create new objects by copying this prototype. The Prototype Design Pattern
    creates objects by copying an existing objects, known as prototype.
    
    To simplyfy we can say that the Prototype Design Pattern gives us a way to create new or cloned objects
    from the existing object of a class. That means it clones object with its data into a new object.
    If we make any changes to the cloned object(i.e new ) it does not effect the original object.
    
    This pattern is useful when creation of object is time-consuming or complex in term of resources. 
    Instead of going through the costly process of creating a fresh object from scratch, an existing  
    instance serves as a prototype, and new objects can be created by copying this prototype

**Object Cloning:-
    When we talk about object cloning in C#, it means it is all about Call by Value.
    So If we change one object, it will not affect the other.
    C# provides one method called "MemberwiseClone", which will create a new complete copy
    of the object with a different memory.
 */