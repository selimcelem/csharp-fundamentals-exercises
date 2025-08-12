using System;

//class FactorialBug
//{
//    static void Main()
//    {
//        Console.Write("Enter a number to calculate factorial: ");
//        int num = Convert.ToInt32(Console.ReadLine());

//        int result = 1;

//        for (int i = 0; i <= num; i++)
//        {
//            result = result * i;
//        }

//        Console.WriteLine($"The factorial of {num} is {result}");
//    }
//}

class FactorialBug
{
    static void Main()
    {
        Console.Write("Enter a number to calculate factorial: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int result = 1;

        for (int i = 1; i <= num; i++)
        {
            result *= i;
        }

        Console.WriteLine($"The factorial of {num} is {result}");
    }
}
