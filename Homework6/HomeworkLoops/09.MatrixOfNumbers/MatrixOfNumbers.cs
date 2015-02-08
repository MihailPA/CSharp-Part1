//Problem 9. Matrix of Numbers
//Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix 
//like in the examples below. Use two nested loops.

using System;


namespace _09.MatrixOfNumbers
{
    class MatrixOfNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number bigger than 1 and smaller than 20: ");
            int n = int.Parse(Console.ReadLine());
            

            int counter = 0;
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= n; col++)
                {
                    Console.Write("{0} ", col + counter);
                }

                Console.WriteLine();
                counter++;
            }
        }
    }
}
