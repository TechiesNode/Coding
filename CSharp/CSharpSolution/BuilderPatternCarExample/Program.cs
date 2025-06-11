using BuilderPatternCarExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;



namespace BuilderPatternCarExample
{
    // 1. Product
    public class Car
    {
        public string Engine { get; set; }
        public string Wheels { get; set; }
        public string Body { get; set; }

        public void ShowDetails()
        {
            Console.WriteLine("Car Details:");
            Console.WriteLine($"Engine: {Engine}");
            Console.WriteLine($"Wheels: {Wheels}");
            Console.WriteLine($"Body: {Body}");
        }
    }

    // 2. Builder Interface
    public interface ICarBuilder
    {
        void BuildEngine();
        void BuildWheels();
        void BuildBody();
        Car GetCar();
    }

    // 3. Concrete Builder
    public class SportsCarBuilder : ICarBuilder
    {
        private Car _car = new Car();

        public void BuildEngine()
        {
            _car.Engine = "V8 Engine";
        }

        public void BuildWheels()
        {
            _car.Wheels = "18 inch Alloy Wheels";
        }

        public void BuildBody()
        {
            _car.Body = "Sporty Body";
        }

        public Car GetCar()
        {
            return _car;
        }
    }

    // Optional: Another Builder (SUV)
    public class SUVCarBuilder : ICarBuilder
    {
        private Car _car = new Car();

        public void BuildEngine()
        {
            _car.Engine = "V6 Diesel Engine";
        }

        public void BuildWheels()
        {
            _car.Wheels = "20 inch All-Terrain Wheels";
        }

        public void BuildBody()
        {
            _car.Body = "SUV Body";
        }

        public Car GetCar()
        {
            return _car;
        }
    }

    // 4. Director
    public class Director
    {
        private ICarBuilder _builder;

        public Director(ICarBuilder builder)
        {
            _builder = builder;
        }

        public void ConstructCar()
        {
            _builder.BuildEngine();
            _builder.BuildWheels();
            _builder.BuildBody();
        }

        public Car GetCar()
        {
            return _builder.GetCar();
        }
    }

    // 5. Client
    class Program
    {
        static void Main(string[] args)
        {
            // Create a builder
            ICarBuilder builder = new SportsCarBuilder(); // or new SUVCarBuilder();

            // Create the director with the builder
            Director director = new Director(builder);

            // Construct the product
            director.ConstructCar();

            // Get the final product
            Car car = director.GetCar();

            // Show the details
            car.ShowDetails();

            Console.ReadLine();
        }
    }
}

//Create a builder (e.g., new SportsCarBuilder()).

//Pass it to the director: new Director(builder).

//Director calls build steps: director.ConstructCar().

//Get the final car: Car car = director.GetCar().

//Display car details: car.ShowDetails().

