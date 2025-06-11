using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPatternRealLifeExample
{
    public interface ICreditCard
    { 
        string GetCardType();
        int GetCreditLimit();
        int GetAnnualCharge();
    }

    public class MoneyBack : ICreditCard
    {
        public string GetCardType() => "MoneyBack";
        public int GetAnnualCharge() => 15000;
        public int GetCreditLimit() => 1500000;
    } 
    public class Titanium : ICreditCard
    {
        public string GetCardType() => "Titanium";
        public int GetAnnualCharge() => 20000;
        public int GetCreditLimit() => 2000000;
    }
    public class Platinum : ICreditCard
    {
        public string GetCardType() => "Platinum";
        public int GetAnnualCharge() => 25000;
        public int GetCreditLimit() => 2500000;
    }

    // Factory Class 

    public static class CredtiCardFactory
    {
        public static ICreditCard GetCreditCard(string cardType)
        {
            switch (cardType)
            {
                case "MoneyBack":
                    return new MoneyBack();
                case "Titanium":
                    return new Titanium();
                case "Platinum":
                    return new Platinum();
                default:
                    return null;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Card type (MoneyBack/Titanium/Platinum: )");
            ICreditCard cardDetails = CredtiCardFactory.GetCreditCard("Platinum");

            if (cardDetails != null)
            {
                Console.WriteLine($"\nCardType: {cardDetails.GetCardType()}");
                Console.WriteLine($"\nCreditLimit: {cardDetails.GetCreditLimit()}");
                Console.WriteLine($"\nGetAnnualCharge: {cardDetails.GetAnnualCharge()}");
            }

            else
            {
                Console.WriteLine("\nInvalid Card Type");
            }
            
        }
    }
}
