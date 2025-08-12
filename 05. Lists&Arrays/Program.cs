// Uncomment the version you want to run:
#define USE_VERSION_1
// #define USE_VERSION_2
// #define USE_VERSION_3

using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main()
    {
#if USE_VERSION_1
        // VERSION 1: Your original version
        double[] studentGrades = { 75.5, 88, 92, 60.5, 79 };
        double average = 0;
        int i = 1;

        Console.WriteLine("Grades in array: ");

        foreach (double grade in studentGrades)
        {
            average += grade / studentGrades.Length;
            Console.WriteLine(grade);
        }

        Console.WriteLine("Average: " + average);
        Console.WriteLine("\nGrades in list: ");

        foreach (double grade in studentGrades)
        {
            Console.WriteLine($"Grade {i}: {grade}");
            i++;
        }

        Console.WriteLine($"\nNew Average: {average}");

#elif USE_VERSION_2
        // VERSION 2: Cleaned version — total then divide
        double[] studentGrades = { 75.5, 88, 92, 60.5, 79 };
        double sum = 0;
        int i = 0;

        Console.WriteLine("Grades in array:");

        foreach (double grade in studentGrades)
        {
            Console.WriteLine(grade);
            sum += grade;
        }

        double average = sum / studentGrades.Length;
        Console.WriteLine($"Average: {average:F2}");

        Console.WriteLine("\nGrades in list:");

        List<double> gradeList = new List<double>(studentGrades);

        sum = 0;
        foreach (double grade in gradeList)
        {
            Console.WriteLine($"Grade {i}: {grade}");
            sum += grade;
            i++;
        }

        double newAverage = sum / gradeList.Count;
        Console.WriteLine($"\nNew Average: {newAverage:F2}");

#elif USE_VERSION_3
        // VERSION 3: Advanced - User input with validation
        List<double> grades = new List<double>();
        string input;
        double grade;

        Console.WriteLine("Enter grades (type 'done' to finish):");

        while (true)
        {
            Console.Write("Grade: ");
            input = Console.ReadLine();

            if (input.ToLower() == "done")
                break;

            if (double.TryParse(input, out grade))
            {
                grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid number. Try again.");
            }
        }

        if (grades.Count == 0)
        {
            Console.WriteLine("No grades entered.");
            return;
        }

        Console.WriteLine("\nGrades entered:");
        double sum = 0;
        for (int i = 0; i < grades.Count; i++)
        {
            Console.WriteLine($"Grade {i}: {grades[i]}");
            sum += grades[i];
        }

        double average = sum / grades.Count;
        Console.WriteLine($"\nAverage: {average:F2}");

#endif
    }
}
