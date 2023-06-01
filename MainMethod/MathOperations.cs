using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    public class MathOperations
    {
        // Method that performs a math operation on an integer
        public int PerformOperation(int number)
        {
            // Example math operation: square the input number
            int result = number * number;
            return result;
        }

        // Method that performs a different math operation on a decimal
        public int PerformOperation(decimal number)
        {
            // Example math operation: calculate the square root of the input number
            int result = (int)Math.Sqrt((double)number);
            return result;
        }

        // Method that performs a different math operation on a string (if it can be converted to an integer)
        public int PerformOperation(string input)
        {
            // Example math operation: calculate the length of the input string
            int result = 0;

            // Try to convert the input string to an integer
            if (int.TryParse(input, out int number))
            {
                result = input.Length;
            }

            return result;
        }
    }
}
