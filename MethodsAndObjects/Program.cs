using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate and initialize an Employee object
            Employee employee = new Employee()
            {
                FirstName = "Sample",
                LastName = "Student"
            };

            // Call the superclass method SayName() on the Employee object
            employee.SayName();

            Console.ReadLine();
        }
    }
}
