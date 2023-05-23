using System;

namespace AnonymousIncomeComparison
{
    internal class Program
    {
        static void Main()
        {
            // Print the program title
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine();

            // Get details for Person 1
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            decimal hourlyRate1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Hours worked per week?");
            int hoursWorkedPerWeek1 = Convert.ToInt32(Console.ReadLine());

            // Get details for Person 2
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            decimal hourlyRate2 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Hours worked per week?");
            int hoursWorkedPerWeek2 = Convert.ToInt32(Console.ReadLine());

            // Calculate annual salary for Person 1
            decimal annualSalary1 = hourlyRate1 * hoursWorkedPerWeek1 * 52;

            // Calculate annual salary for Person 2
            decimal annualSalary2 = hourlyRate2 * hoursWorkedPerWeek2 * 52;

            // Print the annual salaries
            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine(annualSalary1);

            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine(annualSalary2);

            // Compare the salaries and print the result
            bool person1MakesMore = annualSalary1 > annualSalary2;
            Console.WriteLine("Person 1 makes more money than Person 2");
            Console.WriteLine(person1MakesMore);

            Console.ReadLine();
        }
    }
}
