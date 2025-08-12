using System;
using System.Threading.Channels;

//Create an array of integers (you can hardcode it for now).

//Use a loop to find:

//The maximum number

//The minimum number

//Print both results.

class ArrayProblems
{
    static void Main()
    {
        int[] arr = [-6, 10, 24, 43, 14];
        int maxValue = arr[0];
        int minValue = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > maxValue)
            {
                maxValue = arr[i];
            }
            if (arr[i] < minValue)
            {
                minValue = arr[i];
            }
        }
        Console.WriteLine($"The highest number is {maxValue} and the lowest number is {minValue}");
    }
}