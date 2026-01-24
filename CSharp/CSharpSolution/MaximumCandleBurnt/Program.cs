using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumCandleBurnt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N (initial candles) and K (leftovers needed to make 1 new candle):");
            var input = Console.ReadLine().Split();
            int initialCandles = int.Parse(input[0]);   // N
            int exchangeRate = int.Parse(input[1]);     // K
            
            int totalBurned = 0;        // total candles burned
            int leftoverPieces = 0;     // burnt pieces collected

            int currentCandles = initialCandles;

            while (currentCandles > 0)
            {
                // burn all current candles
                totalBurned = totalBurned + currentCandles;
                leftoverPieces = leftoverPieces + currentCandles;

                // exchange leftover pieces for new candles
                currentCandles = leftoverPieces / exchangeRate;
                leftoverPieces = leftoverPieces % exchangeRate;
            }

            Console.WriteLine("Maximum candles burned = " + totalBurned);
        }
    }
}

/*
 Problem Description
You are given N unburnt candles.
Every time you burn a candle, it becomes a burnt candle (wax).
For every K burnt candles, you can use the wax to make 1 new unburnt candle.

Your task is to find the maximum number of candles you can burn, including the ones created from recycling burnt candles.
N is the initial number of unburnt candles.

K is the number of burnt candles needed to create 1 new unburnt candle.
Print a single integer — the maximum total number of candles you can burn.
1 ≤ N ≤ 10^6

2 ≤ K ≤ 1000

Sample Input

7 3

Sample Output
10
 */