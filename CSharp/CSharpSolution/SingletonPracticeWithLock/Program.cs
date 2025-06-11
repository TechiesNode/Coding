using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPracticeWithLock
{
    public sealed class Singleton
    {
        private static Singleton _instance = null;
        private static readonly object _objLock = new object();
        private Singleton()
        {
            Console.WriteLine();
        }

        public static Singleton Instance
        {
            get 
            {
                if (_instance == null)
                {
                    lock (_objLock)
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
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
