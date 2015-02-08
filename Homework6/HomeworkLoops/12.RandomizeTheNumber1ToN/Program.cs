//Problem 12.* Randomize the Numbers 1…N
//Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.

using System;


namespace _12.RandomizeTheNumber1ToN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the a number:");
            int n = int.Parse(Console.ReadLine());       

            int[] pool = new int[n];
            bool[] printed = new bool[n + 1];
            Random r = new Random();
            int randomized = r.Next(1, n + 1);

        for (int index = 0; index < n; index++)
        {
            randomized = r.Next(1, n + 1);
            if (!printed[randomized])
            {
                Console.Write("{0} ", randomized);
                printed[randomized] = true;
            }
            else
            {
                index--;
            }
        }
        Console.WriteLine();


                
            
        }
    }
}
