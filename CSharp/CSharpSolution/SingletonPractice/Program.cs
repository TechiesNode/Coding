using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPractice
{
    //Sealed keyword is used to prevent inheritance
    public sealed class Singleton
    {
        //Private static variable to hold the Single Instance
        private static readonly Lazy<Singleton> instance = new Lazy<Singleton>(() => new Singleton());

        //Private Constructor to prevent external Instantiation
        private Singleton()
        {
            Console.WriteLine("Singleton Instance Created");
        }
        //Public static property to provide access to the instance
        public static Singleton Instance
        {
            get { 
                return instance.Value;
            }
        }

        public void ShowMessage(string msg)
        {
            Console.WriteLine($"Message from Singleton : {msg}");
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.Instance;
            Singleton s2 = Singleton.Instance;
            s1.ShowMessage("Hello from s1");
            s2.ShowMessage("Hello from s2");
            Console.WriteLine(Object.ReferenceEquals(s1, s2));
           
        }
    }
}
