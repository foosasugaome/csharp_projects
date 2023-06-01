using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class
            MathOperations mathOperations = new MathOperations();

            // Perform the operation on an integer
            int intResult = mathOperations.PerformOperation(5);
            Console.WriteLine("Result for integer: " + intResult);

            // Perform the operation on a decimal
            int decimalResult = mathOperations.PerformOperation(8.7m);
            Console.WriteLine("Result for decimal: " + decimalResult);

            // Perform the operation on a string
            string input = "12345";
            int stringResult = mathOperations.PerformOperation(input);
            Console.WriteLine("Result for string: " + stringResult);

            // Wait for the user to press a key before closing the console window
            Console.ReadKey();
        }
    }
}
