using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputToTextFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for a number
            Console.Write("Enter a number: ");
            string userInput = Console.ReadLine();
            

            // Write the user input to the text file
            File.WriteAllText(@"D:\Logs\log.txt", userInput);

            // Read the contents of the text file
            string fileContents = File.ReadAllText(@"D:\Logs\log.txt");

            // Print the contents of the text file to the console
            Console.WriteLine("Text file contents: ");
            Console.WriteLine(fileContents);
        }
    }
}
