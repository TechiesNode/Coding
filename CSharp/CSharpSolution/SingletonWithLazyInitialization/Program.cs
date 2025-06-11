using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonWithLazyInitialization
{

    public sealed class Singleton
    {
        private static readonly Lazy<Singleton> _lazyinstance = new Lazy<Singleton>(() => new Singleton());
        // Private constructor to prevent instantiation from outside
        private Singleton()
        {
            Console.WriteLine("Singleton instance created.");
        }

        // Public property to access the singleton instance
        public static Singleton Instance => _lazyinstance.Value;

        public void DisplayMessage(string msg)
        {
            Console.WriteLine(msg);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton instance1 = Singleton.Instance;
            
            Singleton instance2 = Singleton.Instance;
            instance1.DisplayMessage("Hello from Singleton with Lazy Initialization!");
            Console.WriteLine($"Are instance1 and instance2 the same? {instance1 == instance2}");
            Console.WriteLine(object.ReferenceEquals(instance1, instance2));
            Console.ReadLine();
            //instance1.DisplayMessage("Exiting the application.");
            // The application will exit here, and the singleton instance will be disposed of if necessary.
        }
    }
}
