﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallByValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 15;
            int b = a;
            Console.WriteLine($"Value of a : {b}");
            b = 30;
            Console.WriteLine($"Value of a : {a}");
            Console.WriteLine($"Value of a : {b}");
            
            Console.ReadKey();
        }
    }
}
/*
 ** Call by Value:- A copy of the actual value is passed to the method. Changes made iinside the method do not affect the original variable
 ** Call by Reference:-  A reference to the actual variable is passed. Changes made in the method affect the original variable
 */