//Problem 6. The Biggest of Five Numbers
//Write a program that finds the biggest of five numbers by using only five if statements.

using System;


namespace TheBiggestOfFiveNumbers
{
    class TheBiggestOfFiveNumbers
    {
        static void Main(string[] args)
        {
             Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());
        Console.Write("d = ");
        double d = double.Parse(Console.ReadLine());
        Console.Write("e = ");
        double e = double.Parse(Console.ReadLine());

        double greatest = a;

        if (b > greatest)
        {
            greatest = b;
        }
        if (c > greatest)
        {
            greatest = c;
        }
        if (d > greatest)
        {
            greatest = d;
        }
        if (e > greatest)
        {
            greatest = e;
        }
        Console.WriteLine("biggest: " + greatest);
    
        }
    }
}
