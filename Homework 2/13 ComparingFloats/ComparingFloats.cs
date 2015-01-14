//Problem 13.* Comparing Floats
//Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
//Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the floating-point arithmetic. 
//Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.

using System;


namespace ComparingFloats
{
    class ComparingFloats
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please ENTER your first number:");
            double first = double.Parse(Console.ReadLine());

            Console.WriteLine("Please ENTER the number you want to compare with the first one:");
            double second = double.Parse(Console.ReadLine());

            bool result = Math.Abs(first - second) < 0.000001;
            
            Console.WriteLine("{0} = {1} - The result is: {2}", first, second, result);
        }
    }
}
