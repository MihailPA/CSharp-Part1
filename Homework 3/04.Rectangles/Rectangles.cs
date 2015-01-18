using System;


namespace Rectangles
{
    class Rectangles
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the width of the rectangle:");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter the height of the rectangle:");
            double height = double.Parse(Console.ReadLine());
            double area = width * height;
            double perimeter = 2 * width + 2 * height;
            Console.WriteLine("The area of the rectangle is:{0} \nThe perimeter of the rectangle is: {1}", area, perimeter);

        }
    }
}
