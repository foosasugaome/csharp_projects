using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Void method that writes the person's full name to the console
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
