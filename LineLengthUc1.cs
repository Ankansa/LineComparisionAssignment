using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisionAssignment
{
    internal class LineLengthUc1
    {

        public static int x1;
        public static int x2;
        public static int y1;
        public static int y2;
        public static void points()

        {
            Console.WriteLine("Enter the value for points ");
            Console.WriteLine("Enter x value for point1");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y value for point1");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter x value for point2");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y value for point2");
            y2 = Convert.ToInt32(Console.ReadLine());

        }

        public static void LineLength()
        {
            double value;
            points();
            double A = ((x1 * x1 - x2 * x2) + (y1 * y1 - y2 * y2));
            if (A < 0)
            {
                value = A * (-1);
            }
            else
            {
                value = A;
            }
            double length = Math.Sqrt(value);
            Console.WriteLine("Length of line is : {0} units", length);
        }
    }
}
