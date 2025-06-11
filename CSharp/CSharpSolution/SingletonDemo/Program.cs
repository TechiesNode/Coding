using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo // Defines a namespace called SingletonDemo
{
    // The Singleton class is sealed to prevent other classes from inheriting it
    public sealed class Singleton
    {
        // A private static variable to hold the single instance of the class
        private static Singleton _instance = null;

        // A private static readonly object used for locking to ensure thread safety
        private static readonly object _lock = new object();

        // Private constructor ensures that the class cannot be instantiated from outside
        private Singleton()
        {
            Console.WriteLine("Singleton Instance Created"); // Message to show when the instance is created
        }

        // Public static property to provide global access to the Singleton instance
        public static Singleton Instance
        {
            get
            {
                // First check to avoid locking every time (performance optimization)
                if (_instance == null)
                {
                    // Lock to make the instance creation thread-safe
                    lock (_lock)
                    {
                        // Double-check to ensure instance is still null before creating
                        if (_instance == null)
                        {
                            _instance = new Singleton(); // Instantiate the Singleton
                        }
                    }
                }
                return _instance; // Return the single instance
            }
        }

        // A public method to demonstrate some functionality
        public void ShowMessage()
        {
            Console.WriteLine("Hello from Singleton!"); // Print a message
        }
    }

    // The main Program class to run the application
    public class Program
    {
        // Entry point of the application
        static void Main(string[] args)
        {
            // Access the Singleton instance for the first time (instance will be created here)
            Singleton instance1 = Singleton.Instance;

            // Access the Singleton instance again (same instance will be returned)
            Singleton instance2 = Singleton.Instance;

            // Call the method on the Singleton instance
            instance1.ShowMessage();

            // Check if both instance1 and instance2 refer to the same object
            Console.WriteLine($"Are Instance1 and Instance2 the same? {instance1 == instance2}");
        }
    }
}

/*
1.The Singleton Design Pattern ensures that a class has only one instance and provides a global point of access to that instance
2.Usefule when:- To control access to shared resources like database connections, log files or configuration settings.
3.Thread Safety:- To ensures multiple threads access the same instance instead of creating new ones.
4.Global State Management:-When maintaining a single source of truth, such as a configuration manager or caching system.
5.Database Connection Pooling, Logging System, Configuration Manager, Caching System, Thread Pool Manager, 

 */