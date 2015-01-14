//Problem 16.* Print Long Sequence
//Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …

using System;


namespace PrintLongSequence
{
    class PrintLongSequence
    {
        static void Main(string[] args)
        {
            for (int p = 2; p <= 1002; )
            {
                Console.WriteLine(p++);
                Console.WriteLine(-p++);
            }
        }
    }
}
