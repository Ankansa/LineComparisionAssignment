using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisionAssignment
{
    internal class TwoLineCompareUc2
    {
        public static int x1;
        public static int y1;
        public static int x2;
        public static int y2;
        public static int x3;
        public static int y3;
        public static int x4;
        public static int y4;
        public static void TwoLineInput()
        {
            Console.WriteLine("Enter the value for points ");
            Console.WriteLine("Enter x value for point1 of Line1");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y value for point1 of Line1");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter x value for point2 of Line1");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y value for point2 of Line1");
            y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter x value for point1 of Line2");
            x3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y value for point1 of Line2");
            y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter x value for point2 of Line2");
            x4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y value for point2 of Line2");
            y4 = Convert.ToInt32(Console.ReadLine());

        }

        public static void TwoLineLength()
        {
            double value1, value2;
            TwoLineInput();
            double A1 = ((x1 * x1 - x2 * x2) + (y1 * y1 - y2 * y2));
            double A2 = ((x3 * x3 - x4 * x4) + (y3 * y3 - y4 * y4));

            if (A1 < 0)
            {
                value1 = A1 * (-1);
            }
            else
            {
                value1 = A1;
            }
            double length1 = Math.Sqrt(value1);


            if (A2 < 0)
            {
                value2 = A2 * (-1);
            }
            else
            {
                value2 = A2;
            }
            double length2 = Math.Sqrt(value2);

            Console.WriteLine("Length of line1 is : {0} units ", length1);
            Console.WriteLine("Length of line2 is : {0} units ", length2);


            if (length1 == length2)
            {
                Console.WriteLine("line 1 of length {0} units is equal to Line 2 of length {1} units", length1, length2);
            }
            else
            {
                Console.WriteLine("line 1 of length {0} units is not equal to Line 2 of length {1} units", length1, length2);
            }

        }
    }
}
