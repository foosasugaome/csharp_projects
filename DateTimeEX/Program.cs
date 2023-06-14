using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeEX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Print the current date and time
            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine("Current date and time: " + currentDateTime);

            // Ask the user for a number
            Console.Write("Enter a number of hours: ");
            int hours = int.Parse(Console.ReadLine());

            // Calculate the future time
            DateTime futureDateTime = currentDateTime.AddHours(hours);

            // Print the future time
            Console.WriteLine("After {0} hours, the time will be: {1}", hours, futureDateTime);

            Console.ReadLine();
        }
    }
}
