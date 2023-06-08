using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an Employee object with type "string"
            Employee<string> employee1 = new Employee<string>();

            // Assign a list of strings as the property value of Things
            employee1.Things = new List<string> { "Apple", "Banana", "Cherry" };

            // Instantiate an Employee object with type "int"
            Employee<int> employee2 = new Employee<int>();

            // Assign a list of integers as the property value of Things
            employee2.Things = new List<int> { 1, 2, 3, 4, 5 };

            // Loop through the Things list of employee1 and print each item
            Console.WriteLine("Employee 1's Things:");
            foreach (string thing in employee1.Things)
            {
                Console.WriteLine(thing);
            }

            // Loop through the Things list of employee2 and print each item
            Console.WriteLine("\nEmployee 2's Things:");
            foreach (int thing in employee2.Things)
            {
                Console.WriteLine(thing);
            }

            Console.ReadLine();
        }
    }
}
