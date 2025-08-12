#define USE_Basic             // Toggle between versions by commenting this line
// #define USE_Basic                > Simple and direct                         > Small scripts, quick tests
// #define USE_Improved             > Uses var, interpolation, better loop      > When you want modern, clean C#
// #define USE_SwitchExpression     > More structured condition handling        > For complex conditions
// #define USE_Functions            > Best for scalability and reusability      > For larger projects

using System;

#if USE_Basic
class Program
{
    static void Main()
    {
        long bigNumber = 1000000000000000000L;
        double myBankAccount = 15000.95;
        string myName = "Selim";
        bool amIRich = (myBankAccount > 10000) ? true : false;

        Console.WriteLine($"Your name is {myName}, {bigNumber} dollars is your desired goal, your bank contains {myBankAccount} dollars.");
        Console.WriteLine(amIRich ? "You are quite rich though!" : "You are not that rich!");

        double depositAmount;
        do
        {
            Console.WriteLine("How much would you like to deposit to your bank account?");
            string userInput = Console.ReadLine();

            if (double.TryParse(userInput, out depositAmount) && depositAmount >= 0)
            {
                myBankAccount += depositAmount;
                Console.WriteLine($"You have successfully deposited {depositAmount} dollars to your bank account. Your new balance is {myBankAccount} dollars.");
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        } while (true);

        Console.WriteLine($"Goodbye {myName}!");
    }
}
#endif


#if USE_Improved
// Improved Readability and Formatting
class program
{
    static void Main()
    {
        // Implicit typing (var) for readability
        const long bigNumber = 1_000_000_000_000_000_000L; // Readable numeric literals
        var myBankAccount = 15_000.95; // Use underscores for better readability
        var myName = "Selim";

        // Ternary operator with direct assignment
        var amIRich = myBankAccount > 10_000;

        // String interpolation for clean output
        Console.WriteLine($"Your name is {myName}, {bigNumber} dollars is your desired goal, your bank contains {myBankAccount:C} dollars.");
        Console.WriteLine(amIRich ? "You are quite rich though!" : "You are not that rich!");

        // Using 'while(true)' to remove redundant 'do-while'
        while (true)
        {
            Console.Write("How much would you like to deposit to your bank account? ");
            var userInput = Console.ReadLine();

            if (double.TryParse(userInput, out var depositAmount) && depositAmount >= 0)
            {
                myBankAccount += depositAmount;
                Console.WriteLine($"You have successfully deposited {depositAmount:C}. Your new balance is {myBankAccount:C}.");
                break;
            }

            Console.WriteLine("Invalid input. Please enter a valid number.");
        }

        Console.WriteLine($"Goodbye, {myName}!");
    }
}
#endif


#if USE_SwitchExpression
// Using switch expression and 'break' inside a loop
class Program
{
    static void Main()
    {
        const long bigNumber = 1_000_000_000_000_000_000L;
        decimal myBankAccount = 15_000.95M; // ✅ Using decimal for financial calculations
        string myName = "Selim";

        // Using switch expression instead of ternary operator
        string wealthStatus = myBankAccount switch
        {
            >= 10_000 => "You are quite rich though!",
            _ => "You are not that rich!"
        };

        Console.WriteLine($"Your name is {myName}, {bigNumber} dollars is your desired goal, your bank contains {myBankAccount:C} dollars.");
        Console.WriteLine(wealthStatus);

        // Loop with 'break' inside a switch for better handling
        while (true)
        {
            Console.Write("Enter deposit amount: ");
            if (decimal.TryParse(Console.ReadLine(), out var depositAmount) && depositAmount >= 0)
            {
                myBankAccount += depositAmount;
                Console.WriteLine($"Deposited {depositAmount:C}. New balance: {myBankAccount:C}.");
                break;
            }

            Console.WriteLine("Invalid amount. Try again.");
        }

        Console.WriteLine($"Goodbye, {myName}!");
    }
}
#endif


#if USE_Functions
// Using Functions for Reusability
class Program
{
    static void Main()
    {
        const long bigNumber = 1_000_000_000_000_000_000L;
        decimal myBankAccount = 15_000.95M;
        string myName = "Selim";
        string wealthStatus = GetWealthStatus(myBankAccount);
        Console.WriteLine($"Your name is {myName}, {bigNumber} dollars is your desired goal, your bank contains {myBankAccount:C} dollars.");
        Console.WriteLine(wealthStatus);
        DepositToBankAccount(ref myBankAccount);
        Console.WriteLine($"Goodbye, {myName}!");
    }
    static string GetWealthStatus(decimal bankAccount)
    {
        return bankAccount switch
        {
            >= 10_000 => "You are quite rich though!",
            _ => "You are not that rich!"
        };
    }
    static void DepositToBankAccount(ref decimal bankAccount)
    {
        while (true)
        {
            Console.Write("Enter deposit amount: ");
            if (decimal.TryParse(Console.ReadLine(), out var depositAmount) && depositAmount >= 0)
            {
                bankAccount += depositAmount;
                Console.WriteLine($"Deposited {depositAmount:C}. New balance: {bankAccount:C}.");
                break;
            }
            Console.WriteLine("Invalid amount. Try again.");
        }
    }
}
#endif