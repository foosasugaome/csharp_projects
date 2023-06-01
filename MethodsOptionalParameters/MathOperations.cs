using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsOptionalParameters
{
    public class MathOperations
    {
        // Method that performs a math operation on two integers, with one optional parameter
        public int PerformOperation(int number1, int number2 = 0)
        {
            // Example math operation: add the two numbers together
            int result = number1 + number2;
            return result;
        }
    }
}
