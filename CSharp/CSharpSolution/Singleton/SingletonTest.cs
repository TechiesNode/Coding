using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public  class SingletonTest
    {
        private SingletonTest()
        {
            
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }

        public class SingletonDerivedClass : SingletonTest
        { 
            
        }
    }
}
