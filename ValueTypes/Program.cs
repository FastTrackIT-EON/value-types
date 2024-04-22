using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // illustrate division by zero (with sign)
            // for float and double
            float a = 10;
            float b = -0F;
            float c = a / b;
            Console.WriteLine(c);

            // but decimal throws error
            decimal x = 10;
            decimal y = 0;
            decimal z = x / y;
            Console.WriteLine(z);

            Console.WriteLine("Press any key to close");
            Console.ReadKey();
        }

        static void Examples_with_int()
        {
            // illustrate pre-fix / post-fix increment operators
            int x = 10;
            Console.WriteLine("Value before: " + x);
            int result = ++x;
            Console.WriteLine("Result: " + result);
            Console.WriteLine("Value after: " + x);

            // illustrate division for integers - vs - real numbers
            unchecked
            {
                float a = 5;
                int a2 = (int)float.MaxValue;
                Console.WriteLine("A2=" + a2);
                int b = 2;
                float c = (float)a / b;
                Console.WriteLine(c);
            }

            // arithmetic overflow
            Add(uint.MaxValue, 1);
            checked
            {
                int z = int.MaxValue;
                Console.WriteLine("Z = " + z);
                z = z + 1;
                Console.WriteLine("Z = " + z);
            }
        }

        static void Add(uint x, uint y)
        {
            if (x < uint.MaxValue - y)
            {
                uint result = x + y;
                Console.WriteLine("Result: " + result);
            }
            else
            {
                Console.WriteLine("Result: Arithmetic overflow");
            }
        }

        static void Examples_with_bool()
        {
            bool bitwiseAnd = ReturnValue(false) & ReturnValue(true);
            Console.WriteLine(" ----------- ");
            bool conditionalAnd = ReturnValue(false) && ReturnValue(true);

            // conditional and enables the following verification
            string text = null;
            if (text != null && text.Length > 2)
            {
                Console.WriteLine("Text has more than 2 characters");
            }


            Console.WriteLine(" ----------- ");
            Console.WriteLine(" ----------- ");

            bool bitwiseOr = ReturnValue(true) | ReturnValue(false);

            Console.WriteLine(" ----------- ");

            bool conditionalOr = ReturnValue(true) || ReturnValue(false);

            Console.WriteLine("Press any key to close");
            Console.ReadKey();
        }

        static bool ReturnValue(bool value)
        {
            Console.WriteLine("Called ReturnValue with: " + value);
            return value;
        }
    }
}
