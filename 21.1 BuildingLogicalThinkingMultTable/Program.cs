//Instructions:

//Ask the user for a number (like 5).

//Use a loop to print its multiplication table up to 10.

using System; // Includes basic system functionality like Console

class BuildingLogicalThinkingMultTable
{
    static void Main()
    {
        int table = 0; // Declare an integer variable to store the user's input

        while (true) // Start an infinite loop to keep asking until valid input is received
        {
            Console.WriteLine("Please enter a number: "); // Prompt the user to enter a number
            string? input = Console.ReadLine(); // Read the user's input as a string (can be null)

            if (int.TryParse(input, out table)) // Try to convert the string to an integer
            {
                break; // If successful, exit the loop
            }
            else
            {
                Console.WriteLine("Please enter a valid number!"); // If input is not a number, show error
            }
        }

        Console.WriteLine($"You have entered {table}"); // Confirm the input to the user

        for (int i = 1; i <= 10; i++) // Loop from 1 to 10 to print the multiplication table
        {
            Console.WriteLine($"{table} x {i} = {table * i}"); // Print each line of the multiplication table
        }
    }
}
