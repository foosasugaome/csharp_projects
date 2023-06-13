using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    // Define the Employee class with properties: Id, FirstName, LastName
    class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of employees
            List<Employee> employees = new List<Employee>()
            {
                new Employee { Id = 1, FirstName = "John", LastName = "Doe" },
                new Employee { Id = 2, FirstName = "Jane", LastName = "Smith" },
                new Employee { Id = 3, FirstName = "Joe", LastName = "Johnson" },
                new Employee { Id = 4, FirstName = "Mike", LastName = "Miller" },
                new Employee { Id = 5, FirstName = "Joe", LastName = "Brown" },
                new Employee { Id = 6, FirstName = "Sarah", LastName = "Davis" },
                new Employee { Id = 7, FirstName = "Adam", LastName = "Wilson" },
                new Employee { Id = 8, FirstName = "Emily", LastName = "Taylor" },
                new Employee { Id = 9, FirstName = "Joe", LastName = "Thomas" },
                new Employee { Id = 10, FirstName = "Mark", LastName = "Anderson" }
            };

            // Create a new list of employees with the first name "Joe" using foreach loop
            List<Employee> joesList = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    joesList.Add(employee);
                }
            }

            // Print the list of employees with the first name "Joe"
            Console.WriteLine("Employees with the first name Joe (using foreach loop):");
            foreach (Employee joe in joesList)
            {
                Console.WriteLine($"Id: {joe.Id}, Name: {joe.FirstName} {joe.LastName}");
            }

            // Create a new list of employees with the first name "Joe" using lambda expression
            List<Employee> joesListLambda = employees.Where(employee => employee.FirstName == "Joe").ToList();

            // Print the list of employees with the first name "Joe" using lambda expression
            Console.WriteLine("\nEmployees with the first name Joe (using lambda expression):");
            foreach (Employee joe in joesListLambda)
            {
                Console.WriteLine($"Id: {joe.Id}, Name: {joe.FirstName} {joe.LastName}");
            }

            // Create a new list of employees with Id number greater than 5 using lambda expression
            List<Employee> greaterThanFiveList = employees.Where(employee => employee.Id > 5).ToList();

            // Print the list of employees with Id number greater than 5 using lambda expression
            Console.WriteLine("\nEmployees with Id number greater than 5 (using lambda expression):");
            foreach (Employee employee in greaterThanFiveList)
            {
                Console.WriteLine($"Id: {employee.Id}, Name: {employee.FirstName} {employee.LastName}");
            }
            Console.ReadLine();
        }
    }
}
