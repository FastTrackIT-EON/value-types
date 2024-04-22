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
