using System;


namespace OperatorOverload
{
    // Employee class definition
    public class Employee
    {
        // Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Overloading the "==" operator
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // Check if the Id properties of the two objects are equal
            return emp1.Id == emp2.Id;
        }

        // Overloading the "!=" operator
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            // Check if the Id properties of the two objects are not equal
            return emp1.Id != emp2.Id;
        }
    }
}