using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
//Perform these actions and create a console app that includes the following:

//1. Create an interface called IQuittable and have it define a void method called Quit().

//2. Have your Employee class from the previous drill inherit that interface and implement the Quit() method in any way you choose.

//3. Use polymorphism to create an object of type IQuittable and call the Quit() method on it. Hint: an object can be of an interface type if it implements that specific interface.

//4. Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.


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
