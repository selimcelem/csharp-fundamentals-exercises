using System; // Gives access to built-in C# features like Console.

class RecursionBasics // Defines a class named RecursionBasics.
{
    static void Main() // Entry point of the program.
    {
        int number; // Declares a variable to store the user's number input.

        while (true) // Infinite loop that will break only when we get valid input.
        {
            Console.WriteLine("Enter a number to calculate its factorial:"); // Asks the user for a number.
            string? input = Console.ReadLine(); // Reads the user's input from the console.

            if (int.TryParse(input, out number) && number >= 1) // Tries to convert the input to an integer and checks if it's 1 or greater.
            {
                int result = Factorial(number); // Calls the Factorial method and stores the result.
                Console.WriteLine($"Factorial of {number} is: {result}"); // Prints the result using string interpolation.
                break; // Exits the while loop because the task is complete.
            }
            else // If the input wasn't valid (not a number or less than 1)
            {
                Console.WriteLine("Please enter a valid number (1 or greater)."); // Asks the user to try again.
            }
        }

        static int Factorial(int number) // Defines a recursive method to calculate factorial.
        {
            if (number == 1) // Base case: if number is 1, we stop and return 1.
            {
                return 1; // Returns 1 when the number hits 1.
            }
            return number * Factorial(number - 1); // Recursive step: multiply number by factorial of one less than itself.
        }
    }
}
