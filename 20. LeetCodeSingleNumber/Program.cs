//Problem Summary:

//Given a non-empty array of integers, where every element appears twice except for one, find that single one.

//🧠 Example:
//Input: [4, 1, 2, 1, 2]
//Output: 4
//(Only 4 appears once, all others appear twice.)

using System;
using System.Collections.Generic; // Needed for Dictionary

class LeetCodeProblem
{
    static void Main()
    {
        // Create an array of numbers. All numbers appear twice except one.
        int[] numbers = { 4, 1, 2, 1, 2 };

        // Call the function to find the number that appears only once
        int singleNumber = FindSingleNumber(numbers);

        // Print the result
        Console.WriteLine($"Appears once: {singleNumber}.");
    }

    // Method to find the number that appears only once
    static int FindSingleNumber(int[] nums)
    {
        // Create a dictionary to store how many times each number appears
        var dict = new Dictionary<int, int>();

        // Loop through all numbers in the array
        foreach (var num in nums)
        {
            // If the number is already in the dictionary, increase its count
            if (dict.ContainsKey(num))
                dict[num]++;
            else
                // Otherwise, add the number with count 1
                dict[num] = 1;
        }

        // Loop through the dictionary to find the number that appears once
        foreach (var kvp in dict)
        {
            if (kvp.Value == 1)
                return kvp.Key; // Return the number that appears only once
        }

        // Return -1 if no single number is found (should not happen in this problem)
        return -1;
    }
}
