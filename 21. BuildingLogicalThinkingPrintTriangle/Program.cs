//Write a program that prints a right-angled triangle using * like this:
//*
//**
//***
//****
//*****
//Ask the user how tall they want the triangle to be (e.g. 5).

//Use an outer for loop to handle the rows (1 to height).

//Inside that, use an inner for loop to print * as many times as the current row number.

//After the inner loop, write Console.WriteLine() to move to the next row.

using System; // Gives access to basic C# functions like Console

class Program
{
    static void Main()
    {
        int height = 0; // Declare a variable to store the triangle's height

        while (true) // Infinite loop to keep asking for valid input
        {
            Console.WriteLine("How tall do you want your triangle to be?"); // Ask the user for input
            string? input = Console.ReadLine(); // Read user input as a string

            if (int.TryParse(input, out height)) // Try converting the input to an integer
            {
                break; // If conversion works, exit the loop
            }
            else
            {
                Console.WriteLine("Please enter a valid number!"); // If conversion fails, show error
            }
        }

        Console.WriteLine($"You entered {height}"); // Confirm the height entered by the user

        for (int i = 1; i <= height; i++) // Outer loop: controls the number of rows
        {
            for (int j = 1; j <= i; j++) // Inner loop: prints stars per row
            {
                Console.Write("*"); // Print a star without a line break
            }
            Console.WriteLine(); // Move to the next line after each row
        }
    }
}

