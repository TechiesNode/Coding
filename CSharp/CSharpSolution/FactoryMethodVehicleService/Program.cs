using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodVehicleService
{
    public interface IVehicleService
    {
        void Service();
    }

    public class BikeService : IVehicleService
    {
        public void Service()
        {
            Console.WriteLine("Servicing a Bike:");
        }
    }
    public class CarService : IVehicleService
    {
        public void Service()
        {
            Console.WriteLine("Servicing a Car:");
        }
    }
    public class TruckService : IVehicleService
    {
        public void Service()
        {
            Console.WriteLine("Servicing a Truck:");
        }
    }
    public class VehicleServiceFactory
    {
        public static IVehicleService GetVehicleService(string vehicleType)
        {
            switch (vehicleType.ToLower())
            {
                case "bike":
                    return new BikeService();
                case "car":
                    return new CarService();
                case "truck":
                    return new TruckService();
                default:
                    throw new ArgumentException("Invalid Vehicle Type: ");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the vehcle type among (Bike/Car/Truck) :-");
            string vehicleType = Console.ReadLine();

            try
            {
                IVehicleService service = VehicleServiceFactory.GetVehicleService(vehicleType);
                service.Service();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error {ex.Message}");
            }
        }
    }
}
