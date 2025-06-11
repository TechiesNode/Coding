using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public interface IVehicle
    {
        void Drive();
    }
    public class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving a Car!");
        }
    }public class Bike : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving a Bike!");
        }
    }

    public class VehicleFactory
    {
        public static IVehicle GetVehicle(string vehicleType)
        {
            if (vehicleType.Equals("Car", StringComparison.OrdinalIgnoreCase))
                return new Car();
            else if (vehicleType.Equals("Bike", StringComparison.OrdinalIgnoreCase))
                return new Bike();
            else
                throw new ArgumentException("Invalid Vehicle Type");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            // Getting a Car object from the Factory
            IVehicle myVehicle = VehicleFactory.GetVehicle("Car");
            myVehicle.Drive();

            // Getting a Bike object from the Factory
            IVehicle mySecondVehicle = VehicleFactory.GetVehicle("Bike");
            mySecondVehicle.Drive();
        }
    }
}

/*
 The Factory Design Pattern is a creational design pattern that provides an interface for 
creating objects in a superclass but allows subclass to alter the type of objects that will be created. This pattern helps 
encapsulate object creation logic, making the code more maintainable and sclable.

** A factory has a method which is used to create other objects. In technical terms, A factory
    is a class with a method. That method creates and returns different objects based on the
    received input parameter.

** If we have a superclass and n number of subclasses, and based on the data provided, if we 
have to create and return the object of one of the subclasses, then we need to use the 
factory design pattern.
 
** In the Factory Design Pattern, we create an object without exposing the object 
creation and initializing logic to the client, and the client will refer to the newly 
created object using a common interface.

Implementation Guideline:-
Step1:- Define a common Interface or Abstract Class(Product).
Step2:- Create Concrete Implementations(Concrete Products)
Step3:- Implement the Factory (Creator)
Step4:- Use the Factory in Client Code.

Benefits:- 
    *Open Close Principle Satisfied:-You can add new VehicleType without modifying Main()
    *Loose coupling :- Main only Talks to the Factory and Interface
    *Single Responsibility:- Creation Logic is moved out of Main()
    *Readability:- Code is cleaner and easier to Maintain
 */
