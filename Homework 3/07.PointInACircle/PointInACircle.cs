using System;


namespace PointInACircle
{
    class PointInACircle
    {
        static void Main(string[] args)
        {
            Console.Write("Enter x value: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Enter y value: ");
            double y = double.Parse(Console.ReadLine());
            int radius = 2;

            bool Circle = ((x*x) + (y*y)) <= (radius*radius);

            Console.WriteLine("Is it in the circle ---> {0}",Circle);
        }
    }
}
