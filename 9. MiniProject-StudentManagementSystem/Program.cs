//Features to Implement:
//✅ A Student class with :

//Name(string)

//Age (int)

//Grade (string)

//✅ A List<Student> to store student records

//✅ A simple menu system in the console:

//Add new student

//View all students

//Save to file

//Load from file

//Exit

//✅ Save/load the list using:

//File.WriteAllText() or File.WriteAllLines()

//File.ReadAllText() or File.ReadAllLines()

using System;

class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>();
        bool running = true;

        while (running)
        {
            Console.WriteLine("1. Add new student");
            Console.WriteLine("2. View all students");
            Console.WriteLine("3. Save to file");
            Console.WriteLine("4. Load from file");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option: ");
            string? option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    AddStudent(students);
                    break;
                case "2":
                    ViewStudents(students);
                    break;
                case "3":
                    SaveToFile(students);
                    break;
                case "4":
                    LoadFromFile(students);
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again");
                    break;
            }
        }
    }
    static void AddStudent(List<Student> students)
    {
        Console.WriteLine("Enter name: ");
        string? name = Console.ReadLine();
        Console.WriteLine("Enter age: ");
        string? ageInput = Console.ReadLine();
        if (int.TryParse(ageInput, out int age))
        {
            Console.WriteLine("Enter grade: ");
            string? grade = Console.ReadLine();
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(grade))
            {
                students.Add(new Student { Name = name, Age = age, Grade = grade });
            }
            else
            {
                Console.WriteLine("Name and grade cannot be empty.");
            }

        }
        else
        {
            Console.WriteLine("Invalid age. Please enter a vlid number.");
        }
    }
    static void ViewStudents(List<Student> students)
    {
        foreach (var student in students)
        {
            Console.WriteLine($"Name: {student.Name}. Age: {student.Age}. Grade: {student.Grade}");
        }
    }
    static void SaveToFile(List<Student> students)
    {
        List<string> lines = new List<string>();
        foreach (var student in students)
        {
            lines.Add($"{student.Name}, {student.Age}, {student.Grade}");
        }
        File.WriteAllLines("students.txt", lines);
    }
    static void LoadFromFile(List<Student> students)
    {
        if (File.Exists("students.txt"))
        {
            string[] lines = File.ReadAllLines("students.txt");
            students.Clear();
            foreach (var line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length == 3 && int.TryParse(parts[1], out int age))
                {
                    students.Add(new Student { Name = parts[0].Trim(), Age = age, Grade = parts[2].Trim() });
                }

                else
                {
                    Console.WriteLine("Skipping invalid entry in file.");
                }
            }
            Console.WriteLine("Students loaded successfully.");
            }
        else
        {
            Console.WriteLine("No saved data found.");
        }
    }
}


class Student
{
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }
    public string Grade { get; set; } = string.Empty;
}
