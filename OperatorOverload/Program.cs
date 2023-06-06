using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate two Employee objects
            Employee emp1 = new Employee();
            Employee emp2 = new Employee();

            // Assign values to their properties
            emp1.Id = 1;
            emp1.FirstName = "John";
            emp1.LastName = "Doe";

            emp2.Id = 2;
            emp2.FirstName = "Jane";
            emp2.LastName = "Smith";

            // Compare the two Employee objects using the overloaded operators
            if (emp1 == emp2)
            {
                Console.WriteLine("The Employee objects are equal.");
            }
            else
            {
                Console.WriteLine("The Employee objects are not equal.");
            }
            Console.ReadLine();
        }
    }
}
