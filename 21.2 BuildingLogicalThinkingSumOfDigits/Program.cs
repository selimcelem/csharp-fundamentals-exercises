//What to do:
//Ask the user for a number (e.g. 1234), then calculate and print the sum of its digits.

using System; // Gives us access to built-in features like Console

class BuildingLogicalThinkingSumOfDigits
{
    static void Main()
    {
        int number = 0; // This will store the final valid number entered by the user
        int sum = 0;    // This will hold the total sum of the digits

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

        while (number > 0) // Keep going until the number is reduced to 0
        {
            int digit = number % 10; // Get the last digit (e.g., 1234 % 10 = 4)
            sum += digit;            // Add that digit to the total sum
            number /= 10;            // Remove the last digit (e.g., 1234 / 10 = 123)
        }

        Console.WriteLine("The sum of the digits is " + sum); // Display the final result
    }
}
