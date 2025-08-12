using System;

class Program
{
    static void Main()
    {
     
        string[] studentNames = { "John", "Alice", "Michael", "Hasan", "Marie" };

        Console.WriteLine("Student List:");

        foreach (var name in studentNames)
        {
            Console.WriteLine(name);
        }
     
    }
}