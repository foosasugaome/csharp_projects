using System;
using System.Collections.Generic;

namespace ConsoleAppArray
{
    internal class Program
    {
        static void Main()
        {
            // One-dimensional Array of strings
            string[] stringArray = { "Apple", "Banana", "Orange" };

            Console.WriteLine("Select an index of the string array:");
            int stringIndex = Convert.ToInt32(Console.ReadLine());

            // Check if the selected index is valid
            if (stringIndex >= 0 && stringIndex < stringArray.Length)
            {
                string selectedString = stringArray[stringIndex];
                Console.WriteLine("Selected string: " + selectedString);
            }
            else
            {
                Console.WriteLine("Invalid index selected!");
            }

            // One-dimensional Array of integers
            int[] intArray = { 10, 20, 30 };

            Console.WriteLine("Select an index of the integer array:");
            int intIndex = Convert.ToInt32(Console.ReadLine());

            // Check if the selected index is valid
            if (intIndex >= 0 && intIndex < intArray.Length)
            {
                int selectedInt = intArray[intIndex];
                Console.WriteLine("Selected integer: " + selectedInt);
            }
            else
            {
                Console.WriteLine("Invalid index selected!");
            }

            // List of strings
            List<string> stringList = new List<string> { "Cat", "Dog", "Elephant" };

            Console.WriteLine("Select an index of the string list:");
            int listIndex = Convert.ToInt32(Console.ReadLine());

            // Check if the selected index is valid
            if (listIndex >= 0 && listIndex < stringList.Count)
            {
                string selectedListItem = stringList[listIndex];
                Console.WriteLine("Selected list item: " + selectedListItem);
            }
            else
            {
                Console.WriteLine("Invalid index selected!");
            }

            Console.ReadLine();
        }
    }
}
