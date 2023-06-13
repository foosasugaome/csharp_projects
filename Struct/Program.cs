using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    // Define a struct called Number with a property "Amount" of type decimal
    struct Number
    {
        public decimal Amount { get; set; }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            // Create an object of type Number
            Number myNumber  = new Number();

            // Assign a value to the Amount property of the myNumber object
            myNumber.Amount = 10.5m;

            // Print the amount to the console
            Console.WriteLine("Amount: " + myNumber.Amount);
            Console.ReadLine();
        }
    }
}
