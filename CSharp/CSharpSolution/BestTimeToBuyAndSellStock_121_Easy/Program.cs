using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestTimeToBuyAndSellStock_121_Easy
{
    /*
     Problem: Best Time to Buy and Sell Stock (LeetCode #121 - Easy)
        You are given an array prices where prices[i] is the price of a given stock on the i-th day.
        You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to 
        sell that stock.
        Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.
    Example:-
    Input: prices = [7,1,5,3,6,4]
    Output: 5
    Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6 - 1 = 5.

     */

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] prices = { 7, 1, 5, 3, 6, 4 };
            int profit = MaxProfit(prices);
            Console.WriteLine($"Maximum Pofit: {profit}");

        }

        public static int MaxProfit(int[] prices)
        {
            int minPrice = prices[0];
            int maxProfit = 0;
            foreach (int price in prices)
            { 
                minPrice = Math.Min(minPrice, price);
                maxProfit = Math.Max(maxProfit, price-minPrice);

            }
            return maxProfit;
        }
    }
}
