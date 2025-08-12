using System;

class Program
{
    static void Main()
    {
        string name;
        do
        {
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();
        } while (string.IsNullOrWhiteSpace(name));

        int age;
        while (true)
        {
            Console.WriteLine("Enter your age: ");
            string ageInput = Console.ReadLine();

            if (int.TryParse(ageInput, out age))
            {
                break;
            }
            Console.WriteLine("Invalid age. Please enter a valid number.");
        }

        bool isStudent = false;
        string inputString;

        while (true)
        {
            Console.WriteLine("Are you a student? (Y/N)");
            inputString = Console.ReadLine().ToLower();

            if (inputString == "y")
            {
                isStudent = true;
                break; 
            }
            else if (inputString == "n")
            {
                isStudent = false;
                break;
            }

            Console.WriteLine("Invalid input. Please enter Y or N.");
        }

        Console.WriteLine($"Your name is: {name}");
        Console.WriteLine("Your age is: " + age);


        if (age <= 17)
        {
            Console.WriteLine("Ýou're a minor");
        }
        else
        {
            Console.WriteLine("You're an adult");
        }

        //Cleaner version > Console.WriteLine(isStudent ? "Welcome student!" : "You are not a student!");
        
        if (isStudent)
        {
            Console.WriteLine("Welcome student!");
        }
        if (!isStudent)
        {
            Console.WriteLine("You are not a student!");
        }

    }
}