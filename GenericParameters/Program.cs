using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//create a console app that includes the following:

//Make the Employee class take a generic type parameter.

//Add a property to the Employee class called “things” and have its data type be a generic list matching the generic type of the class.

//Instantiate an Employee object with type “string” as its generic parameter. Assign a list of strings as the property value of Things.

//Instantiate an Employee object with type “int” as its generic parameter. Assign a list of integers as the property value of Things.

//Create a loop that prints all of the Things to the Console.

//Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.

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
