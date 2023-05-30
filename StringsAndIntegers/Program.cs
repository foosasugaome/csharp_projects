using System;
using System.Collections.Generic;


namespace StringsAndIntegers
{
    internal class Program
    {
        static void Main()
        {
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
