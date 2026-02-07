using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.

Symbol       Value
I             1
V             5
X             10
L             50
C             100
D             500
M             1000
For example, 2 is written as II in Roman numeral, just two ones added together. 12 is written as XII, which is simply X + II. The number 27 is written as XXVII, which is XX + V + II.

Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not IIII. Instead, the number four is written as IV. Because the one is before the five we subtract it making four. The same principle applies to the number nine, which is written as IX. There are six instances where subtraction is used:

I can be placed before V (5) and X (10) to make 4 and 9. 
X can be placed before L (50) and C (100) to make 40 and 90. 
C can be placed before D (500) and M (1000) to make 400 and 900.
Given a roman numeral, convert it to an integer.

 

Example 1:

Input: s = "III"
Output: 3
Explanation: III = 3.
Example 2:

Input: s = "LVIII"
Output: 58
Explanation: L = 50, V= 5, III = 3.
Example 3:

Input: s = "MCMXCIV"
Output: 1994
Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.
 */
namespace RomanToInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test Input

            string s = "VL";

            // Call method
            int result = RomanToInt(s);
            Console.WriteLine("Input: "+ s);
            Console.WriteLine("Output: " + result);

            Console.ReadLine();
        }

        public static int RomanToInt(string s)
        {
            // Step 1: Create a Roman numeral map
            Dictionary<char, int> map = new Dictionary<char, int>()
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };

            int total = 0;
            // Step 2: Loop through the string
            for (int i = 0; i < s.Length; i++)
            {
                // Get value of current symbol
                int currentValue = map[s[i]];

                //Check if the next symbol exists and is greater
                if (i + 1 < s.Length && map[s[i + 1]] > currentValue)
                {
                    total = total - currentValue;
                }
                else
                { 
                    total += currentValue;
                }
            }


            return total;
            
        }
    }
}
