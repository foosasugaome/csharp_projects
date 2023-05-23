using System;

namespace MathAndComparisonOperators
{
    internal class Program
    {
        static void Main()
        {
            // Take input from the user and convert it to a decimal
            Console.WriteLine("Enter a number:");
            decimal input = Convert.ToDecimal(Console.ReadLine());

            // Multiply the input by 50 and print the result
            decimal result1 = input * 50;
            Console.WriteLine("Result 1: " + result1);

            // Add 25 to the input and print the result
            decimal result2 = input + 25;
            Console.WriteLine("Result 2: " + result2);

            // Divide the input by 12.5 and print the result
            decimal result3 = input / 12.5m;
            Console.WriteLine("Result 3: " + result3);

            // Check if the input is greater than 50 and print the result
            bool result4 = input > 50;
            Console.WriteLine("Result 4: " + result4);

            // Divide the input by 7 and print the remainder
            decimal remainder = input % 7;
            Console.WriteLine("Remainder: " + remainder);

            Console.ReadLine();
        }
    }
}
