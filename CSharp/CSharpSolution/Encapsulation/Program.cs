using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class BankAccount
    {
        private double balance;

        public double Balance { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            account.Balance = 100;
            Console.WriteLine("Balance : "+account.Balance);
        }
    }
}
