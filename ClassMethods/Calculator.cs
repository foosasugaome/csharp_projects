using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethods
{
    class Calculator
    {
        // Create a void method named "DivideByTwo" that takes an integer as input and outputs an integer
        // The method divides the input number by 2 and outputs the result
        public void DivideByTwo(int number)
        {
            int result = number / 2;
            Console.WriteLine($"Result: {result}");
        }

        // Create a method with output parameters that calculates the sum and difference of two numbers
        public void Calculate(int a, int b, out int sum, out int difference)
        {
            sum = a + b;
            difference = a - b;
        }

        // Overload the "Calculate" method with different parameter types
        public void Calculate(double a, double b, out double sum, out double difference)
        {
            sum = a + b;
            difference = a - b;
        }
    }
}
