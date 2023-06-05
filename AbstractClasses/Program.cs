using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an 'Employee' object
            Employee employee = new Employee();

            // Set the 'firstName' and 'lastName' properties
            employee.FirstName = "Sample";
            employee.LastName = "Student";

            // Call the 'SayName' method
            employee.SayName();

            // Keep the console window open
            Console.ReadLine();
        }
    }
}
