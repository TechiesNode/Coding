using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonRealLifeExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger logger1 = Logger.Instance;
            logger1.Log("App Started");

            Logger logger2 = Logger.Instance;
            logger2.Log("Logging a user actionss");

            if (logger1 == logger2)
            {
                Console.WriteLine("Logger instances is the same across the applications");
            }

            logger1.Log("App Ended. ");
        }
    }
}
