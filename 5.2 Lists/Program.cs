using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Step 1: Declare and initialize the list
        List<string> studentNames = new List<string>
        {
            "Alice",
            "Bob",
            "Charlie",
            "Diana",
            "Ethan"
        };

        // Step 2: Iterate through the list and print each name
        foreach (string name in studentNames)
        {
            Console.WriteLine(name);
        }
    }
}
