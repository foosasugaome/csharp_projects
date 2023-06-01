using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class
            MathOperations mathOperations = new MathOperations();

            // Call the method in the class, passing in two numbers
            int result =  mathOperations.PerformOperation(5, 10);
            Console.WriteLine("Result : {0}", result);

            // Call the method in the class, specifying the parameters by name
            result =  mathOperations.PerformOperation(number1: 8, number2: 20);
            Console.WriteLine("Result : {0}", result);

            // Wait for the user to press a key before closing the console window
            Console.ReadLine();
        }
    }
}
