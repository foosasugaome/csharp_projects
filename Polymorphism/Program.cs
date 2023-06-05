using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{

    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an object of type Employee
            Employee employee = new Employee();
            employee.Name = "John Doe";

            // Create an object of type IQuittable (using polymorphism)
            IQuittable quittableEmployee = employee;

            // Call the Quit() method on the IQuittable object
            quittableEmployee.Quit();

            Console.ReadLine();
        }
    }
}
