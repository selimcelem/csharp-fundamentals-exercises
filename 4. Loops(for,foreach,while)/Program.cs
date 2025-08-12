using System;

class program
{
    static void Main()
    {
        while(true) // Keep showing the menu untill the user chooses to exit
        {
            Console.WriteLine("\n Choose a program to run:");
            Console.WriteLine("1. Multiplication Table (for loop)");
            Console.WriteLine("2. Sum of Numbers (while loop)");
            Console.WriteLine("3. Iterate Over an Array (foreach loop)");
            Console.WriteLine("4. Number Guessing Game (while loop)");
            Console.WriteLine("5. Exit");

            Console.WriteLine("\n Enter your choice (1-5): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    MultiplicationTable();
                    break;
                case "2":
                    SumOfNumbers();
                    break;
                case "3":
                    IterateOverArray();
                    break;
                case "4":
                    NumberGuessingGame();
                    break;
                case "5":
                    Environment.Exit(0);
                    return; // Exit the program
                default:
                    Console.WriteLine("Invalid choice! Please enter a number between 1 and 5.");
                    break;
            }
        }
    }


    // 1. Multiplication Table (for loop)
    static void MultiplicationTable()
    {
        Console.Write("Enter a number: ");
        if (!int.TryParse(Console.ReadLine(), out int num))
        {
            Console.WriteLine("Please enter a valid number.");
            return;
        }

        Console.WriteLine("Enter range: ");
        if (!int.TryParse(Console.ReadLine(), out int range))
        {
            Console.WriteLine("Please enter a valid number.");
            return;
        }

        for (int i = 1; i <= range; i++)
        {
            Console.WriteLine($"{num} x {i} = {num * i}");
        }
    }

    // 2. Sum of Numbers (while loop)
    static void SumOfNumbers()
    {
        int sum = 0, num;

        Console.Write("Enter a number (0 to stop): ");

        while (true)
        {
            if (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Please enter a valid number.");
                continue;
            }

            if (num == 0) break;

            sum += num;
        }
        Console.WriteLine($"Total Sum: {sum}");
    }

    // 3. Iterate Over an Array (foreach loop)
    static void IterateOverArray()
    {
        string[] names = { "Alice", "Bob", "Charlie", "Dave" };

        foreach (string name in names)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }

    // 4. Number Guessing Game (while loop)
    static void NumberGuessingGame()
    {
        Random random = new Random();
        int secretNumber = random.Next(1, 101); // Generate a random number between 1 and 100
        int guess = 0;
        int attempts = 0;

        Console.WriteLine("Welcome to the Number Guessing Game!");
        Console.WriteLine("Guess the number between 1 and 100");   

        while (guess != secretNumber) // Loop until the correct number is guessed
        {
            Console.Write("Enter your guess: ");

            // Validate user input to ensure it is a number
            bool isValid = int.TryParse(Console.ReadLine(), out guess);
            
            if (!isValid)
            {
                Console.WriteLine("Please enter a valid number.");
                continue; // Skip this iteration and ask again
            }

            attempts++; // Increment the number of attempts

            if (guess < secretNumber)
            {
                Console.WriteLine("Too low! Try again.");
            }
            else if (guess > secretNumber)
            {
                Console.WriteLine("Too high! Try again.");
            }
            else
            {
                Console.WriteLine($"Congratulations! You guessed the number in {attempts} attempts.");
            }
        }
    }
}
