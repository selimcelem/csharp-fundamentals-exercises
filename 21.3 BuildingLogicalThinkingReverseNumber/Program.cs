//Challenge: Reverse a Number
//Ask the user for a number (e.g., 1234) and print the number reversed (4321).

using System;

class BuildingLogicalThinkingReverseNumber
{
    static void Main()
    {
        int number = 0; // This will store the number entered by the user
        int reversednum = 0;    // Will hold the reversed number

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
        Console.WriteLine($"You have entered {number}"); // Confirm the user's number

        while(number > 0) // Keep going until the number is reduced to 0
        {
            int digit = number % 10; // Get the last digit (e.g., 1234 % 10 = 4)
            Console.WriteLine($"Extracted digit: {digit}");

            reversednum = reversednum * 10 + digit; // Build reversed number
            Console.WriteLine($"Reversed so far: {reversednum}");

            number /= 10;   // Remove the last digit (e.g., 1234 / 10 = 123)
        }
        Console.WriteLine($"Reversed number: {reversednum}");
    }
}