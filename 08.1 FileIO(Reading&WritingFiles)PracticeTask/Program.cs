//Practice Task:

//Prompt the User for Input:

//Ask the user to enter their name.

//Ask the user to enter their score.

//Write Data to a File:

//Create or open a file named score.txt.

//Write the user's name and score to the file in the format: Name: [name], Score: [score].

//Read Data from the File:

//Read the contents of score.txt.

//Display the contents to the console.

using System;
using System.Security.Cryptography.X509Certificates;

namespace PracticeTaskFileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name: ");
            string? userName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter your score: ");
            if (!int.TryParse(Console.ReadLine(), out int score))
            {
                Console.WriteLine("Invalid score. Please enter a number.");
                return;
            }

            string path = @"E:\C#\8.1 PracticeTestFiles\";
            Directory.CreateDirectory(path);

            string fileName = "8.1 FileIO.txt";
            string filePath = Path.Combine(path, fileName);

            File.WriteAllText(filePath, $"Name: {userName}\n" + $"Score: {score}\n");

            bool exists = File.Exists(filePath);
            if (exists)
            {       
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                    Console.WriteLine(line);
            }                      
        }
    }
}
