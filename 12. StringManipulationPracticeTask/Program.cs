using System;
class ReverseString
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a word or sentence to reverse: ");
        string? input1 = Console.ReadLine();
        while (string.IsNullOrEmpty(input1))
        {
            Console.WriteLine("Enter a valid sentence!");
            input1 = Console.ReadLine();
        }
            Console.WriteLine("This is indeed a sentence.");

        //Manually reversing the string
        Console.WriteLine("We will reverse the string now: ");
        string reversedString = "";
        for (int i = input1.Length - 1; i >= 0; i--)
        {
            reversedString += input1[i];
        }
        Console.WriteLine("{0} chars: {1}", reversedString.Length, reversedString);
    }
}