using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Program
    {
        static void Main(string[] args)
        {
            //SingletonTest singleton = new SingletonTest();
            //singleton.PrintDetails("Print Details");
            SingletonTest.SingletonDerivedClass obj = new SingletonTest.SingletonDerivedClass();
            obj.PrintDetails("True");
            Console.ReadLine();
        }
    }
}
