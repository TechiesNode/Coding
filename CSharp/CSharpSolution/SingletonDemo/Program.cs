using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{

    public sealed class Singleton
    {
        private static Singleton _instance = null;
        private static readonly object _lock = new object();
        
        //Private constructor prevents instantiation from other clasess
        private Singleton() 
        {
            Console.WriteLine("Singleton Instance Created");
        }
        public static Singleton Instance
        {
            get
            { 
                if(_instance == null) 
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        { 
                            _instance = new Singleton();
                        }
                    }
                }
                return _instance;
            }
        }
        public void ShowMessage()
        {
            Console.WriteLine("Hello from Singleton!");
        }
    }
    public class Program
    {

        static void Main(string[] args)
        {
            Singleton instance1 = Singleton.Instance;
            Singleton instance2 = Singleton.Instance;
            instance1.ShowMessage();
            Console.WriteLine($"Are Instance1 and Instance2 the same? {instance1 == instance2}");
        }
    }
}
/*
1.The Singleton Design Pattern ensures that a class has only one instance and provides a global point of access to that instance
2.Usefule when:- To control access to shared esources like database connections, log files or configuration settings.
3.Thread Safety:- To ensures multiple threads access the same instance instead of creating new ones.
4.Global State Management:-When maintaining a single source of truth, such as a configuration manager or caching system.
 */