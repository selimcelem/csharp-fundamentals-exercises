//Create an array of integers with at least 5 values.

//Loop through the array using a for or foreach loop.

//Add up all the numbers in the array.

//Print the total sum to the console.

//Bonus Challenges(optional):
//Add logic to calculate and display the average.

//Display only the even numbers from the array.

using System;

class SumOfArrays
{
    static void Main(string[] args)
    {
        int[] myNum = { 10, 20, 30, 40 };

        int totalSum = myNum.Sum();

        for (int i = 0; i < myNum.Length; i++)
        {
            Console.WriteLine(myNum[i]);
        }
        Console.WriteLine($"The average is: {myNum.Average()}");
        Console.WriteLine($"The total sum is: {totalSum}");

        var even = new List<int>();
        foreach (int element in myNum)
        {
            if (element % 2 == 0) 
            {
                even.Add(element);
            }
        }
        Console.WriteLine($"Even numbers in the array: {even.Count}");
        Console.WriteLine($"The even numbers are: {string.Join(", ", even)}");
    }
}