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
            int day = 4;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }

            
            Console.ReadLine();

        }
    }
}
