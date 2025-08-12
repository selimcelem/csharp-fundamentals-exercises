using System;

//class DebuggingChallenge
//{
//    static void Main(string[] args)
//    {
//        int[] numbers = { 5, 3, 8, 0, 2 };
//        int sum = 0;

//        for (int i = 1; i <= numbers.Length; i++)
//        {
//            sum += numbers[i];
//        }

//        Console.WriteLine("The total sum is: " + sum);
//        Console.WriteLine("The average is: " + sum / numbers.Length);
//    }
//}

class DebuggingChallenge
{
    static void Main(string[] args)
    {
        int[] numbers = { 5, 3, 8, 0, 2 };
        int count = 0;
        int sum = 0;

        for (int i = 0; i < numbers.Length; i+= 2)
        {
            sum += numbers[i];
            count++;
        }

        Console.WriteLine("The total sum is: " + sum);
        Console.WriteLine("The average is: " + (double)sum / count);
    }
}
