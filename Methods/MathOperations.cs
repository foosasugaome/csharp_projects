using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class MathOperations
    {
        // Method to double the input number
        public int DoubleNumber(int number)
        {
            return number * 2;
        }

        // Method to square the input number
        public int SquareNumber(int number)
        {
            return number * number;
        }

        // Method to calculate the factorial of the input number
        public int CalculateFactorial(int number)
        {
            int factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }

}
