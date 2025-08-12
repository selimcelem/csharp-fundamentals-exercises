using System;

class LeetCodeProblem
{
    static void Main()
    {
        int[] numbers = { 2, 7, 11, 15 };
        int target = 9;

        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
               if (numbers[i] + numbers[j] == target)
                {
                    Console.WriteLine($"Match found: {numbers[i]} + {numbers[j]} = {target} (indices {i}, {j})");
                }
            }
        }
    }
}
