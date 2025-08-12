// Mini-Project: Calculator
#define USE_IFELSE      // Uncomment this for the if else method
// #define USE_SWITCH   // Uncomment this to use switch method

using System;
using System.ComponentModel.Design;

class Program

{
    private static double num1;
    private static string op;
    private static double num2;

    static void Main()
    {
        Console.WriteLine("Enter the first number: ");
        while (!double.TryParse(Console.ReadLine(), out num1))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            Console.Write("Enter the first number: ");
        }

        Console.Write("Enter the operator (+, -, *, /, %): ");
        while (!new[] { "+", "-", "*", "/", "%" }.Contains(op = Console.ReadLine(), StringComparer.Ordinal))
        {
            Console.WriteLine("Invalid operator. Please enter one of: +, -, *, /, %.");
            Console.Write("Enter the operator (+, -, *, /, %): ");
        }

        Console.WriteLine("Enter the second number: ");
        while (!double.TryParse(Console.ReadLine(), out num2))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            Console.Write("Enter the second number: ");
        }
#if USE_IFELSE
        if (op == "+")
        {
            Console.WriteLine(num1 + num2);
        }
        else if (op == "-")
        {
            Console.WriteLine(num1 - num2);
        }
        else if (op == "*")
        {
            Console.WriteLine(num1 * num2);
        }
        else if (op == "/")
        {
            while (num2 == 0)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
                Console.WriteLine("Please enter a valid number: ");
                while (!double.TryParse(Console.ReadLine(), out num2) || num2 == 0)
                {
                    Console.WriteLine("Error: Cannot divide by zero.");
                    Console.WriteLine("Please enter a valid number: ");
                }
            }
            Console.WriteLine(num1 / num2);
        }
        else if (op == "%")
        {
            Console.WriteLine(num1 % num2);
        }
        else
        {
            Console.WriteLine("Invalid Operator");
        }
#endif

#if USE_SWITCH
        // Switch method (improved readability)
        switch (op)
        {
            case "+":
                Console.WriteLine($"Result: {num1 + num2}"); 
                break;
            case "-":
                Console.WriteLine($"Result: {num1 - num2}");
                break;
            case "*":
                Console.WriteLine($"Result: {num1 * num2}");
                break;
            case "/":
                Console.WriteLine($"Result: {num1 / num2}"); 
                if (num2 == 0)
                    Console.WriteLine("Error: Cannot divide by zero.");
                else
                    Console.WriteLine($"Result: {num1 / num2}");
                break;
            case "%":
                Console.WriteLine($"Result: {num1 % num2}");
                break;
            default:
                Console.WriteLine("Invalid Operator"); 
                break;
        }
#endif

    }
}