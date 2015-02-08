//Problem 5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N
//Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
//Use only one loop. Print the result with 5 digits after the decimal point.

using System;
using System.Numerics;

namespace _05.Calculate
{
    class Calculate
    {
        static void Main(string[] args)
        {
       
           
            Console.Write("Enter x: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter n: ");
            int x = int.Parse(Console.ReadLine());
            int nFacturel = 1;
            double xPower = 1;
            double sum = 1;
            int counter = 1;

            while (counter <= n)
            {
                nFacturel *= counter;
                xPower = Math.Pow(x, counter);
                sum += (nFacturel / xPower);
                counter++;
            }

            Console.WriteLine("S = {0}", sum);
        }
    }
}
