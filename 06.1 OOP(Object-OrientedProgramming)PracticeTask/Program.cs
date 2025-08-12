// 1. Create a new class called BankAccount.
// 2. Add private fields:
//      string accountHolder
//      decimal balance
// 3. Use a constructor to set the account holder name and initial balance.
// 4. Add public methods:
//  Deposit(decimal amount)
//  Withdraw(decimal amount)
//  GetBalance()(or a public getter property)
// 5. In Main(), create a new account and test deposit/withdraw.

using System;
using System.Security.Principal;
using System.Xml.Linq;

public class Program
{
    public static void Main()
    {
        var account = new BankAccount("John", 5000.86m);

        string action;
        while (true)
        {
            Console.WriteLine("Would you like to deposit or withdraw?");
            action = Console.ReadLine()?.ToLower() ?? string.Empty;

            if (action == "deposit" || action == "withdraw")
            {
                break; // valid input, exit the loop
            }

            Console.WriteLine("Invalid action. Please type 'deposit' or 'withdraw'.");
        }

        Console.WriteLine("Enter amount:");
        string? amountInput = Console.ReadLine();

        if (decimal.TryParse(amountInput, out decimal amount))
        {
            try
            {
                if (action == "deposit")
                {
                    account.Deposit(amount);
                    Console.WriteLine($"After deposit: {account.GetBalance()}");
                }
                else if (action == "withdraw")
                {
                    account.Withdraw(amount);
                    Console.WriteLine($"After withdrawal: {account.GetBalance()}");
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Transaction failed: {ex.Message}");
            }
        }
        else
        {
            Console.WriteLine("Invalid amount entered.");
        }
        Console.WriteLine(account);
    }
}

public class BankAccount
{
    private string accountHolder;
    private decimal balance;

    public BankAccount(string accountHolder, decimal balance)
    {
        this.accountHolder = accountHolder;
        this.balance = balance;
    }

    public void Deposit(decimal amount)
    {
        balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
        }
        else
        {
            throw new InvalidOperationException("insufficient funds.");
        }
    }

    public decimal GetBalance()
    {
        return balance;
    }

    public override string ToString()
    {
        return $"The account holder is {accountHolder} and your balance is {balance}";
    }
}


