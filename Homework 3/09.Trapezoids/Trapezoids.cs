using System;


namespace Trapezoids
{
    class Trapezoids
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter side A:");
            double A = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter side B:");
            double B = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Heigh:");
            double height = double.Parse(Console.ReadLine());

            double area = (height * (A + B)) / 2;
            Console.WriteLine("The Area of the trapezoid is: {0}", area);
        }
    }
}
