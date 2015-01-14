//Problem 9. Print a Sequence
//Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...

using System;

namespace PrintASequence
{
    class PrintASequence
    {
        static void Main(string[] args)
        {
            for (int p = 2; p <= 10; )
            {
                Console.WriteLine(p++);
                Console.WriteLine(-p++);
            }
        }
    }
}

