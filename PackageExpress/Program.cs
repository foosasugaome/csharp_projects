using System;

namespace PackageExpress
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Welcome  note
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine();

            Console.WriteLine("Enter package weight in kilograms.");
            double packageWeight = Convert.ToDouble(Console.ReadLine());

            //Check if package  is over 50. 
            bool validWeight = packageWeight > 50 ? validWeight=false : validWeight = true;

            
            if (validWeight) //If package under 50
            {
                Console.WriteLine("Enter package width");
                double packageWidth = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter package height");
                double packageHeight = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter package length");
                double packageLength = Convert.ToDouble(Console.ReadLine());

                // Check  if  dimension  is   over 50. Exit if one is over 50.
                if (packageWidth > 50 || packageHeight > 50 || packageLength  > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else //  Compute quote.
                {
                    double dimension = packageWidth * packageHeight * packageLength;
                    double quote = (dimension * packageWeight) / 100;
                    Console.WriteLine("Your estimated  total for shipping this package is : $" + quote.ToString("0.00")  +  "\nThank you!");
                }
            }
            else
            {
                //Exit if  package is too heavy.
                Console.WriteLine("Package too Heave to  be shipped via Package Express. Have a good day.");
            }
            Console.ReadLine();
        }
    }
}
