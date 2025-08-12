//Practice Task:
//Ask the user for two numbers (numerator and denominator)

//Attempt to divide the first by the second

//Use a try-catch block to:

//Catch DivideByZeroException

//Catch any other general exceptions

//Output messages like:

//“❌ You can’t divide by zero!”

//Or: “⚠️ Something went wrong: { error}”

using System;

namespace ExceptionHandlingPracticeTask
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter numerator: ");
                int numerator = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter denominator: ");
                int denominator = Convert.ToInt32(Console.ReadLine());

                int result = numerator / denominator;
                Console.WriteLine($"numerator divided by denominator: {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("❌ You can't divide by zero!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"⚠️ Something went wrong: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Division attempt completed.");
            }
        }
    }
}