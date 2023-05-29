using System;
using System.Collections.Generic;


namespace ConsoleAppArrays
{
    internal class Program
    {
        static void Main()
        {
            // One-dimensional array of strings
            string[] stringArray = { "Hello", "World", "Goodbye" };

            Console.WriteLine("Enter some text:");
            string userInput = Console.ReadLine();

            // Loop to update each string in the array
            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] += userInput;
            }

            // Infinite loop (before fixing)
            // Uncomment the block below to see the infinite loop in action
            /*
            while (true)
            {
                Console.WriteLine("This is an infinite loop!");
            }
            */

            // Fixing the infinite loop            
            // Added a new loop that waits for user input to exit the loop
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            // Loop to print each string in the array
            foreach (string str in stringArray)
            {
                Console.WriteLine(str);
            }

            // Loop with "<" operator
            Console.WriteLine("Loop with '<' operator:");
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i]);
            }

            // Loop with "<=" operator
            Console.WriteLine("Loop with '<=' operator:");
            for (int i = 0; i <= stringArray.Length - 1; i++)
            {
                Console.WriteLine(stringArray[i]);
            }


            // List of strings with unique items
            List<string> stringList = new List<string> { "Apple", "Banana", "Orange", "Grapes", "Mango" };

            Console.WriteLine("Enter text to search in the list:");
            string searchText = Console.ReadLine();

            bool foundMatch = false;

            // Loop to iterate through the list and find the matching text
            for (int i = 0; i < stringList.Count; i++)
            {
                if (stringList[i].Contains(searchText))
                {
                    Console.WriteLine("Match found at index: " + i);
                    foundMatch = true;
                    break; // Exit the loop once a match is found
                }
            }

            if (!foundMatch)
            {
                Console.WriteLine("Input text is not found in the list.");
            }

            // List of strings with duplicate items
            List<string> stringListDuplicate = new List<string> { "Apple", "Banana", "Orange", "Grapes", "Apple" };

            Console.WriteLine("Enter text to search in the list:");
            searchText = Console.ReadLine();

            foundMatch = false;
            bool foundTextInList = false;

            // Loop to iterate through the list and find matching texts
            for (int i = 0; i < stringListDuplicate.Count; i++)
            {
                if (stringListDuplicate[i].Contains(searchText))
                {
                    Console.WriteLine("Match found at index: " + i);
                    foundMatch = true;
                }

                if (stringList[i].Equals(searchText))
                {
                    foundTextInList = true;
                }
            }

            if (!foundMatch)
            {
                Console.WriteLine("No matches found.");
            }

            if (!foundTextInList)
            {
                Console.WriteLine("Input text is not in the list.");
            }


            // List of strings with duplicate items
            List<string> stringList3 = new List<string> { "A", "B", "C", "D", "C" };

            // List to keep track of seen strings
            List<string> seenStrings = new List<string>();

            // Foreach loop to evaluate each item in the list
            foreach (string item in stringList3)
            {
                if (seenStrings.Contains(item))
                {
                    // Item is a duplicate
                    Console.WriteLine(item + " - this item is a duplicate");
                }
                else
                {
                    // Item is unique
                    seenStrings.Add(item);
                    Console.WriteLine(item + " - this item is unique");
                }
            }


            Console.ReadLine();
        }
    }
}
