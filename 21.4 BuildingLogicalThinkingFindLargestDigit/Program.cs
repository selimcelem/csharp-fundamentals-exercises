//Task: Ask the user to enter a number (e.g., 5834) and find the largest digit (8 in this case).

using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

class BuildingLogicalThinkingReverseNumber
{
    static void Main()
    {
        int number = 0;

        while (true) // Start an infinite loop until we get valid input
        {
            Console.WriteLine("Please enter a number: "); // Ask the user to input a number
            string? input = Console.ReadLine(); // Read the user input (as a string)

            if (int.TryParse(input, out number)) // Try to convert input to an integer
            {
                break; // If it works, exit the loop
            }
            else
            {
                Console.WriteLine("Please enter a valid number!"); // If it doesn't work, ask again
            }
        }
        int maxDigit = FindMaxDigit(number);
        Console.WriteLine($"You have entered {number}"); // Confirm the user's number
        Console.WriteLine($"The largest digit is {maxDigit}");
    }
    static int FindMaxDigit(int number)
    {
        int maxDigit = 0;
        number = Math.Abs(number); // Handle negative numbers

        while (number > 0)
        {
            int digit = number % 10; // Extract the last digit
            if (digit > maxDigit)
            {
                maxDigit = digit; // Update maxDigit if the current digit is larger
            }
            number /= 10; // Remove the last digit
        }

        return maxDigit;
    }
}
