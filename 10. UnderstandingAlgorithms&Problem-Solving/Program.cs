//Break the problem down like this:

//Create a list of scores

//Loop through the list to:

//Add all scores together for average

//Keep track of highest score

//Keep track of lowest score

//Count how many are above 80

//Print the results

using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main()
    {
        Dictionary<string, int> studentData = new()
        {
            { "Selim", 92 },
            { "Alice", 88 },
            { "John", 59 }
        };

        // Then you can pass studentData.Values.ToList() to your existing methods,
        // or enhance them to work with Dictionary directly.

        Program program = new Program();
        List<int> gradesList = new List<int>(studentData.Values);

        int averageScore = 0;
        Console.WriteLine("Students who scored above 80: ");
        foreach (var entry in studentData)
        {
            if (entry.Value > 80)
                Console.WriteLine($"{entry.Key} scored {entry.Value}");
            averageScore += entry.Value;
        }

        averageScore /= studentData.Count;

        Console.WriteLine($"Average Score: {averageScore}");
        Console.WriteLine($"Highest Score: {program.FindMaxValue(gradesList)}");
        Console.WriteLine($"Lowest Score: {program.FindMinValue(gradesList)}");
        Console.WriteLine($"Above a score of 80: {program.FindAbove80(gradesList)}");
    }
    public int FindMaxValue(List<int> list)
    {
        if (list.Count == 0)
        {
            throw new InvalidOperationException("Empty list");
        }
        int maxValue = int.MinValue;
        foreach (int item in list)
        {
            if (item > maxValue)
            {
                maxValue = item;
            }
        }
        return maxValue;
    }
    public int FindMinValue(List<int> list)
    {
        if (list.Count == 0)
        {
            throw new InvalidOperationException("Empty list");
        }
        int minValue = int.MaxValue;
        foreach (int item in list)
        {
            if (item < minValue)
            {
                minValue = item;
            }
        }
        return minValue;
    }
    public int FindAbove80(List<int> list)
    {
        if (list.Count == 0)
        {
            throw new InvalidOperationException("Empty list");
        }
        int count = 0;
        foreach (int item in list)
        {
            if (item >= 80)
            {
                count++;
            }
        }
        return count;
    }
}