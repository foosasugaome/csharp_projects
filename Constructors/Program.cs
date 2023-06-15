using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a const variable
            const int myConstVariable = 10;

            // Create a variable using the keyword "var"
            var myVarVariable = "Hello, World!";

            // Chain two constructors together
            MyClass myObject = new MyClass();

            Console.WriteLine(myConstVariable);
            Console.WriteLine(myVarVariable);
            Console.ReadLine();
        }
    }
}
