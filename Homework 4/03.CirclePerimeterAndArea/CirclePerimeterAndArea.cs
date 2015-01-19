//Problem 3. Circle Perimeter and Area
//Write a program that reads the radius r of a circle and 
//prints its perimeter and area formatted with 2 digits after the decimal point.

using System;


namespace CirclePerimeterAndArea
{
    class CirclePerimeterAndArea
    {
        static void Main(string[] args)
        {
            Console.Write("Enter radius:");
            double r = double.Parse(Console.ReadLine());

            double area =Math.PI* r * r;
            double perimeter =Math.PI* 2 * r;

            Console.WriteLine("The Area of the Circle is: {0:F2} \nThe Perimeter of the Circle is: {1:F2}", area, perimeter);
           
        }
    }
}
