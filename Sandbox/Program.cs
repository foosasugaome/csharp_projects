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
            //Ternary Operator
            Console.WriteLine("Enter a number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter another number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            string result = num1 > num2 ? "num1 is greater than num2" : "num2 is greater than num1";
               
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
