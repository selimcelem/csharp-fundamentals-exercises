//using System.Runtime.Intrinsics.X86;

//Prompt user input:

//Ask: "Please enter a number:"

//Read and parse the input:

//Use int.TryParse() to safely convert input to an integer.

//Check if even or odd:

//Use the modulo operator %

//if (number % 2 == 0) → even

//else → odd

//Print the result:

//Use Console.WriteLine() to print whether the number is even or odd.

//(Optional) Put the check logic into a method like IsEven(int number).

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter a number: ");
        string? input = Console.ReadLine();
        while (true)
        {
            if (int.TryParse(input, out int number))
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine($"The number {number} is even!");
                }
                else
                {
                    Console.WriteLine($"The number {number} is odd");
                }
                break;
            }
            else
            {
                Console.WriteLine("Please enter a valid number");
                input = Console.ReadLine();
            }
        }
    }
}