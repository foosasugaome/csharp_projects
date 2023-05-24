using System;

namespace CarInsuranceApprovalProgram
{
    internal class Program
    {
        static void Main()
        {
            // Print the program title
            Console.WriteLine("Car Insurance Approval Program");

            // Ask applicant's age
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            // Ask if the applicant ever had a DUI
            Console.WriteLine("Have you ever had a DUI? (Yes or No)");
            string answer = Console.ReadLine().ToLower();
            bool hasDUI = answer == "yes";

            // Ask for the number of speeding tickets
            Console.WriteLine("How many speeding tickets do you have?");
            int speedingTickets = Convert.ToInt32(Console.ReadLine());

            // Check the qualification rules
            bool qualified = (age > 15) && (!hasDUI) && (speedingTickets <= 3);

            // Print the result
            Console.WriteLine("Qualified? " + qualified);

            bool result = (true ^ true) || (true ^ false);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
