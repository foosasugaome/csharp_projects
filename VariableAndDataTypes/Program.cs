using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableAndDataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What is your name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your name is " + yourName);
            //Console.ReadLine();


            //Console.WriteLine("What is your favorite number?");
            //string favoriteNumber = Console.ReadLine();
            //int favNum = Convert.ToInt32(favoriteNumber);
            //int total = favNum + 5;
            //Console.WriteLine("Your favorite number plus 5 is: " + total);
            //Console.ReadLine();

            bool isStudying = false;
            Console.WriteLine(isStudying);
            Console.ReadLine();

            byte value = 255;
            sbyte temperature = -10;
            char letter = 'A';
            decimal price = 9.99m;
            double pi = 3.14159;
            float distance = 3.5f;
            int age = 25;
            uint count = 100;
            long population = 1000000L;
            ulong total = 999999999UL;            
            ushort quantity = 500;
            string name = "John Doe";
            object data = "Some data";

        }
    }
}
