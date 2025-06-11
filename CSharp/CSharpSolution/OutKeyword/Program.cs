using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutKeyword
{
    internal class Program
    {
        static void GetValues(out int a, out int b)
        {
            a = 10;
            b = 20;
            
        }
        static void Main(string[] args)
        {
            int x, y;
            GetValues(out x, out y);
            Console.WriteLine($"X = {x}, Y = {y}");
        }
    }
}

/*
 out Keyword:- The out keyword in c# is used to pass arguments by reference, specifically to allow a method to output values back to the calller
                Out parameter let a method assign values that will be returned back to calling method - even though the method return type is void.
Key Points:- 
    * Pass by Reference
    * Initiliazation before call not required
    * Assignment inside method required before the method returns
    * Purpose is to return multiple values or output data from a method
    * Return type can be void even though values are returned via out parameters.
 */