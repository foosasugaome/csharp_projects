using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsOptionalParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class
            MathOperations mathOperations = new MathOperations();

            // Ask the user to input two numbers
            Console.Write("Enter the first number: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number (optional, press Enter to skip): ");
            string input2 = Console.ReadLine();

            int number2 = 0;
            if (!string.IsNullOrEmpty(input2))
            {
                number2 = int.Parse(input2);
            }

            // Call the method in the class, passing in the one or two numbers entered
            int result = mathOperations.PerformOperation(number1, number2);

            // Display the result to the screen
            Console.WriteLine("Result: " + result);

            // Wait for the user to press a key before closing the console window
            Console.ReadKey();
        }
    }
}
