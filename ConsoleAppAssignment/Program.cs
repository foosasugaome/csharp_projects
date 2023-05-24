using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Boolean comparison using a while statement
            Console.WriteLine("Boolean comparison using a while statement:");

            int counter = 1; // Initialize a counter variable

            while (counter <= 5) // Loop while the counter is less than or equal to 5
            {
                Console.WriteLine("Counter value: " + counter);
                counter++; // Increment the counter by 1
            }

            Console.WriteLine();

            // Boolean comparison using a do-while statement
            Console.WriteLine("Boolean comparison using a do-while statement:");

            int number;

            do
            {
                Console.Write("Enter a number greater than 10: ");
                number = int.Parse(Console.ReadLine());
            } while (number <= 10); // Loop while the number is less than or equal to 10

            Console.WriteLine("Number entered: " + number);

            Console.ReadLine();
        }    
    }
}
