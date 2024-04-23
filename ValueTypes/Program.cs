using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ValueTypes
{
    internal class Program
    {
        const string Saturday = "Saturday";

        static void Main(string[] args)
        {

            int dayOfWeek = (int)DayOfWeek.Miercuri;
           


            DayOfWeek otherDayOfWeek = (DayOfWeek)100;
            if (Enum.IsDefined(typeof(DayOfWeek), 100))
            {
                DayOfWeek correctDayOfWeek = (DayOfWeek)100;
                Console.Write(correctDayOfWeek);
            }
            else
            {
                Console.WriteLine("Value 100 is not defined");
            }

            DayOfWeek parsedDayOfWeek;
            if(Enum.TryParse("Marti", true, out parsedDayOfWeek))
            {
                Console.WriteLine(parsedDayOfWeek);
            }
            else
            {
                Console.WriteLine("Value 'Marti' is not defined");
            }

            DayOfWeek dayToTest = DayOfWeek.Joi;
            if ((DayOfWeek.Weekend & dayToTest) == dayToTest)
            {
                Console.WriteLine(dayToTest + " is part of the weekend");
            }


            Console.WriteLine("Press any key to close");
            Console.ReadKey();
        }

        static void Examples_with_DateTime_and_TimeStamp()
        {
            DateTime dateTime = DateTime.Now;

            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("ro-RO");
            Console.WriteLine("Date (ro-RO): " + dateTime.ToString());

            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
            Console.WriteLine("Date (en-US): " + dateTime.ToString());

            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("fa");
            Console.WriteLine("Date (fa): " + dateTime.ToString());

            DateTime d1 = new DateTime(year: 2024, month: 4, day: 22);
            DateTime d2 = d1 + TimeSpan.FromDays(2);
            TimeSpan d3 = d2 - d1;

            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
            DateTime parseResult1;
            bool canParse = DateTime.TryParseExact(
                "4-22-2024",
                new string[] {
                    "M/dd/yyyy", "MM/dd/yyyy",
                    "dd-M-yyyy", "dd-MM-yyyy",
                    "MM-dd-yyyy", "M-dd-yyyy" },
                CultureInfo.InvariantCulture.DateTimeFormat,
                DateTimeStyles.None,
                out parseResult1);

            if (canParse)
            {
                Console.WriteLine("Year: " + parseResult1.Year);
                Console.WriteLine("Month: " + parseResult1.Month);
                Console.WriteLine("Day: " + parseResult1.Day);
            }
            else
            {
                Console.WriteLine("String is not a valid DateTime");
            }

            TimeSpan ts = TimeSpan.FromDays(2) + TimeSpan.FromHours(25);
            Console.WriteLine("Timespan Days:" + ts.Days);
            Console.WriteLine("Timespan Total Days:" + ts.TotalDays);
            Console.WriteLine("Timespan Hours:" + ts.Hours);
            Console.WriteLine("Timespan Total Hours:" + ts.TotalHours);
        }

        static void Examples_with_floating_point_numbers()
        {
            // illustrate division by zero (with sign)
            // for float and double
            float a = 10;
            float b = -0F;
            float c = a / b;
            Console.WriteLine(c);

            // but decimal throws error
            decimal x = 10M;
            decimal y = 0;
            decimal z = x / y;
            Console.WriteLine(z);
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
