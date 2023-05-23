using System;

namespace StudentDailyReport
{
    internal class Program
    {
        static void Main()
        {
            // Print the header
            Console.WriteLine("Academy of Learning Career College");
            Console.WriteLine("Student Daily Report");            

            // Ask and save student data
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();

            Console.WriteLine("What page number?");
            int pageNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Do you need help with anything? Please answer 'true' or 'false'.");
            bool needsHelp = bool.Parse(Console.ReadLine());

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string positiveExperiences = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            double studyHours = double.Parse(Console.ReadLine());

            // Print a thank you message
            Console.WriteLine();
            Console.WriteLine("Thank you for your answers. An Instructor will respond shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
