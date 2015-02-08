//Problem 1. Exchange If Greater
//Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. 
//As a result print the values a and b, separated by a space.

using System;


namespace ExchangeIfGreater
{
    class ExchangeIfGreater
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first number:");
            double a = Double.Parse(Console.ReadLine());
            Console.Write("Enter your second number: ");
            double b = Double.Parse(Console.ReadLine());
            double c = 0;

            if (a > b)
            {
                c = a;
                a = b;
                b = c;
            }

            Console.WriteLine(a + " " + b);
        }
    }
}
