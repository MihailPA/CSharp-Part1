//Problem 11.* Numbers in Interval Dividable by Given Number
//Write a program that reads two positive integer numbers and prints how many numbers p exist 
//between them such that the reminder of the division by 5 is 0.


using System;

namespace NumbersInIntervalDividablebyGivenNumber
{
    class NumbersinIntervalDividablebyGivenNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int second = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = first; i <= second; i++)
            {

                if (i % 5 == 0)
                {
                    counter++;
                    Console.Write("{0}, ", i);
                }
            }
            Console.WriteLine("\nThere are {0} numbers between {1} and {2}, that the reminder of their division by 5 is 0"
                                , counter, first, second);
        }
    }
}
