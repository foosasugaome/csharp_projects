using AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    // Abstract class 'Person'
    public abstract class Person
    {
        // Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Method to say the name
        public abstract void SayName();
    }

    // Class 'Employee' inheriting from 'Person'
    class Employee : Person
    {
        // Implementation of the 'SayName' method
        public override void SayName()
        {
            Console.WriteLine($"Employee Name: {FirstName} {LastName}");
        }
    }
}

