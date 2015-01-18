using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInsideACircleAndOutsideOfARectangle
{
    class PointInsideACircleAndOutsideOfARectangle
    {
        static void Main(string[] args)
        {
            Console.Write("X : ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Y : ");
            double y = double.Parse(Console.ReadLine());
            double radius = 1.5;
            bool Yes = (((x - 1) * (x - 1)) + ((y - 1) * (y - 1)) <= radius * radius);
            bool No = (x <= 5 && x >= -1) && (y <= 1 && y >= -1);

            if (Yes && !No)
            {
                Console.WriteLine("Yes - The point is in the Circle and outside of the Rectangle!");
            }
            else
            {
                Console.WriteLine("No - The point is in the Circle and in the Rectangle!");
            }
        }
    }
}
