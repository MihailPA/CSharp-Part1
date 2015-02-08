//Problem 6. Calculate N! / K!
//Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
//Use only one loop.

using System;
using System.Numerics;

namespace _06.CalculateNAndK
{
    class CalculateNAndK
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n:");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter k:");
            int k = int.Parse(Console.ReadLine());
            int facturelN = 1;
            int facturelK = 1;
            int div = 1;
            int counter = 1;

            while (counter <= n)
            {
                facturelN *= counter;
                if (counter <= k)
                {
                    facturelK *= counter;
                }

                div = (facturelN / facturelK);
                counter++;
            }

            Console.WriteLine("n!/k! = {0}", div);
        }
    }
}
