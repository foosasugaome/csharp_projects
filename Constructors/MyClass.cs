using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class MyClass
    {
        public MyClass() : this("Default value")
        {
        }

        public MyClass(string value)
        {
            Console.WriteLine("Constructor called with value: " + value);
        }
    }
}
