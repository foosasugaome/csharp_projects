using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//create a console app that includes the following:

//Create a class. In that class, create a void method that outputs an integer. Have the method divide the data passed to it by 2.

//In the Main() method, instantiate that class.

//Have the user enter a number. Call the method on that number. Display the output to the screen. It should be the entered number, divided by two. 

//Create a method with output parameters.

//Overload a method.

//Declare a class to be static.



namespace ClassMethods
{
    internal class Program
    {       
        static void Main()
        {
            // Instantiate an object of the "Calculator" class
            Calculator calculator = new Calculator();

            // Prompt the user to enter a number
            Console.Write("Enter a number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            // Call the "DivideByTwo" method on the entered number
            calculator.DivideByTwo(userInput);

            // Declare variables for output parameters
            int sum, difference;

            // Call the overloaded "Calculate" method with integer parameters
            calculator.Calculate(10, 5, out sum, out difference);

            // Print the sum and difference
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Difference: {difference}");

            // Call the overloaded "Calculate" method with double parameters
            double doubleSum, doubleDifference;
            calculator.Calculate(10.5, 3.2, out doubleSum, out doubleDifference);

            // Print the sum and difference
            Console.WriteLine($"Double Sum: {doubleSum}");
            Console.WriteLine($"Double Difference: {doubleDifference}");

            // Wait for user input before closing the console window
            Console.ReadLine();
        }
    }
}
