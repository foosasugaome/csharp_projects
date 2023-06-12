using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    // Enum for the days of the week
    enum DayOfWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Prompt the user to enter the current day of the week
                Console.Write("Enter the current day of the week: ");
                string input = Console.ReadLine();

                // Convert the user input to the enum value
                DayOfWeek currentDay = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), input, true);

                // Assign the value to a variable of the enum data type
                Console.WriteLine("Current day: " + currentDay);
            }
            catch (ArgumentException)
            {
                // Catch an exception if the entered day is not a valid day of the week
                Console.WriteLine("Please enter an actual day of the week.");
            }

            Console.ReadLine();
        }
    }
}
