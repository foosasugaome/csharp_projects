using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericParameters
{
    class Employee<T>
    {
        // Property to store a list of items of generic type T
        public List<T> Things { get; set; }

        // Constructor to initialize the Things list
        public Employee()
        {
            Things = new List<T>();
        }
    }
}
