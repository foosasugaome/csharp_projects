using System;
using System.Text;

namespace StringOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Concatenating three strings
            string string1 = "Hello";
            string string2 = "world";
            string string3 = "!";

            string result = string1 + " " + string2 + string3; // Concatenate the strings using the + operator

            Console.WriteLine("Concatenated string: " + result);
            Console.WriteLine();

            // Converting a string to uppercase
            string originalString = "Hello, World!";
            string upperCaseString = originalString.ToUpper(); // Convert the string to uppercase using the ToUpper() method

            Console.WriteLine("Original string: " + originalString);
            Console.WriteLine("Uppercase string: " + upperCaseString);
            Console.WriteLine();

            // Creating a StringBuilder and building a paragraph of text
            StringBuilder paragraph = new StringBuilder(); // Create a StringBuilder object

            paragraph.Append("This is the first sentence. "); // Append the first sentence to the StringBuilder
            paragraph.Append("This is the second sentence. "); // Append the second sentence to the StringBuilder
            paragraph.Append("This is the third sentence."); // Append the third sentence to the StringBuilder

            string finalParagraph = paragraph.ToString(); // Convert the StringBuilder to a string

            Console.WriteLine("Paragraph:");
            Console.WriteLine(finalParagraph);

            Console.ReadLine();
        }
    }
}
