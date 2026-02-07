using System;
using System.Collections.Generic;
/*
 * https://leetcode.com/problems/two-sum/description/
 Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

You can return the answer in any order.

 

Example 1:

Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
Example 2:

Input: nums = [3,2,4], target = 6
Output: [1,2]
Example 3:

Input: nums = [3,3], target = 6
Output: [0,1]
 */
class Program
{
    static void Main(string[] args)
    {
        // Input
        int[] nums = { 9, 15, 2, 7 };
        int target = 9;

        // Call TwoSum method
        int[] result = TwoSum(nums, target);

        // Output
        if (result.Length > 0)
        {
            Console.WriteLine($"Output: [{result[0]}, {result[1]}]");
        }
        else
        {
            Console.WriteLine("No two sum solution found.");
        }

        Console.ReadLine(); // Keep console window open
    }

    public static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int diff = target - nums[i];  // diff == 9-2=>7

            if (map.ContainsKey(diff))
            {
                return new int[] { map[diff], i };
            }

            map[nums[i]] = i;
        }

        return new int[0];
    }
}
