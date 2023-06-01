using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of MathOperations class
            MathOperations mathOperations = new MathOperations();

            // Ask the user for a number
            Console.Write("Enter a number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            
            // Call each method and display the returned value
            int doubledNumber = MathOperations.DoubleNumber(userInput);
            Console.WriteLine("Double of the number: " + doubledNumber);

            int squaredNumber = MathOperations.SquareNumber(userInput);
            Console.WriteLine("Square of the number: " + squaredNumber);

            int factorial = MathOperations.CalculateFactorial(userInput);
            Console.WriteLine("Factorial of the number: " + factorial);

           
            Console.ReadLine();
        }

    }
}
