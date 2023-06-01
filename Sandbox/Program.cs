using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    internal class Program
    {
        static void Main()
        {
            ////Ternary Operator
            //Console.WriteLine("Enter a number");
            //int num1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter another number");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //string result = num1 > num2 ? "num1 is greater than num2" : "num2 is greater than num1";

            //Console.WriteLine(result);


            // Switch Challenge
            //int day = 4;
            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    case 4:
            //        Console.WriteLine("Thursday");
            //        break;
            //    case 5:
            //        Console.WriteLine("Friday");
            //        break;
            //    case 6:
            //        Console.WriteLine("Saturday");
            //        break;
            //    case 7:
            //        Console.WriteLine("Sunday");
            //        break;
            //}


            //List<int> intList = new List<int>();
            //intList.Add(4);
            //intList.Add(10);
            //intList.Remove(10);
            //Console.WriteLine(intList[0]);

            //List<string> stringList = new List<string>();
            //stringList.Add("hello");
            //stringList.Add("world");
            //stringList.Remove("world");
            //Console.WriteLine(stringList[0]);

            // Iteration (array)
            //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

            //for (int i = 0; i < testScores.Length; i++)
            //{
            //    if (testScores[i] > 85)
            //    {
            //        Console.WriteLine("Passing test score: "  + testScores[i]);
            //    }
            //}

            // Iteration (list)
            //List<int> scores = new List<int>();
            //scores.Add(98);
            //scores.Add(99);
            //scores.Add(85);
            //scores.Add(70);
            //scores.Add(82);
            //scores.Add(34);
            //scores.Add(91);
            //scores.Add(90);
            //scores.Add(94);

            //foreach (int score in scores) 
            //{ 
            //    if (score > 85)
            //    {
            //        Console.WriteLine("Passing score : " + score);
            //    }
            //}

            //List<string> names = new List<string>() { "Norman", "Sheryl", "Noah", "Julian", "Olivia"};

            //foreach (string name in names)
            //{
            //    if (name == "Norman")
            //    {
            //        Console.WriteLine(name);
            //    }

            //}

            //List<int> testScores = new List<int>() { 98, 99, 85, 70, 82, 34, 91, 90, 94 };
            //List<int> passingScores = new List<int>();

            //foreach  (int score in testScores)
            //{
            //    if (score > 85)
            //    {
            //        passingScores.Add(score);
            //    }
            //}
            //Console.WriteLine(passingScores.Count);

            // Exception Handling
            try
            {
                Console.WriteLine("Pick a number");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick a 2nd number");
                int numberTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dividing the two ...");
                int nummberThree = numberOne / numberTwo;
                Console.WriteLine(numberOne + " divided by " + numberTwo + " is equlas  to "  + nummberThree);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex) 
            { 
                Console.WriteLine(ex.Message);
            }
            finally { Console.ReadLine(); }

            Console.ReadLine();

        }
    }
}

