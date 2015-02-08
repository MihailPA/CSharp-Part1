//Problem 5. The Biggest of 3 Numbers
//Write a program that finds the biggest of three numbers.


using System;


namespace TheBiggestof3Numbers
{
    class TheBiggestof3Numbers
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());

            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("Biggest: " + a);
                }
                else
                {
                    Console.WriteLine("Biggest: " + c);
                }
            }
            else
            {
                if (b > c)
                {
                    Console.WriteLine("Biggest: " + b);
                }
                else
                {
                    Console.WriteLine("Biggest: " + c);
                }
            }
        }
    }
}
