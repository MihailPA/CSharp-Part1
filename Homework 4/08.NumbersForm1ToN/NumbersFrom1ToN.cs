//Problem 8. Numbers from 1 to n
//Write a program that reads an integer number n from the console 
//and prints all the numbers in the interval [1..n], each on a single line.

using System;


namespace NumbersForm1ToN
{
    class NumbersFrom1ToN
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number: ");
            int n = int.Parse(Console.ReadLine());

            for (int a = 1; a <= n; a++)
            {
                Console.WriteLine(a);
            }
        }
    }
}
