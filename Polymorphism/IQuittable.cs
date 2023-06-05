using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    // Define the IQuittable interface with the Quit() method
    interface IQuittable
    {
        void Quit();
    }

    // Employee class that inherits from IQuittable interface
    class Employee : IQuittable
    {
        public string Name { get; set; }

        // Implement the Quit() method
        public void Quit()
        {
            Console.WriteLine("Employee has quit the job.");            
        }
    }
}
