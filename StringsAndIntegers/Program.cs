using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;


namespace StringsAndIntegers
{
    internal class Program
    {
        static void Main()
        {

                //Perform these actions and create a console app that includes the following:
                //Create a list of integers.Ask the user for a number to divide each number in the list by.Write a loop that takes each integer in the list, divides it by the number the user entered, and displays the result to the screen.
                //Run the code, entering in non - zero numbers as the user.Look at the displayed results.
                //Run the code again, entering in zero as the number to divide by.Note any error messages you get.
                //Run the code once again, entering in a string as the number to divide by.Note any error messages you get.
                //Now put the loop in a try/catch block.Below and outside of the try/catch block, make the program print a message to the display to let you know the program has emerged from the try/catch block and continued on with program execution.In the catch block, display the error message to the screen.Then try various combinations of user input: valid numbers, zero and a string.Ensure the proper error messages display on the screen, and that the code after the try/catch block gets executed.

                // Create a list of integers
            List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

                // Ask the user for a number to divide each number in the list by
            bool numValid = false;
                while (!numValid) {
                    try
                    {
                        Console.Write("Enter a number to divide each element in the list by: ");
                        // Parse the user input into an integer divisor
                    float divisor = float.Parse(Console.ReadLine());                    

                    if (divisor == 0) 
                    {
                        Console.WriteLine("Enter a number other than 0.");
                    }
                    else
                    {
                        // Loop through each element in the list
                        foreach (int number in numbers) 
                        {
                            // Divide each element by the divisor and display the result
                            float result = number / divisor;
                            Console.WriteLine($"Result of division: {result}");
                        }
                        numValid = true;
                    }
                }
                catch (FormatException)
                {
                    // Catch a FormatException if the user input is not a valid integer
                    Console.WriteLine("Invalid input! Please enter a valid integer.");
                }                
                catch (Exception ex)
                {
                    // Catch any other exceptions and display the error message
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }

            }
            // Display a message indicating that the program has continued after the try/catch block
            Console.WriteLine("Program execution continued after the try/catch block.");
            Console.ReadLine();
        }
    }
}
