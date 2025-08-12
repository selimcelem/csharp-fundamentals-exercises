using System;

namespace FirstConsoleProject
{
    class MainClass
    {
        private static string Name = "Hello World! My name is Selim";
        private static string Age = "I am 31 years old";

        public static void Main(string[] args)  // this is a method called "Main" that is called when the program starts
        {
            Console.WriteLine(Name);

            while (true)
            {
                Console.WriteLine("Press 'Enter' to see my age");

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine(Age);
                    break;
                }
                else
                {
                    Console.WriteLine("You didn't press 'Enter'");
                }
                
                Console.WriteLine("Press any key to close the console");
                Console.ReadKey();
            }
        }
    }
}

