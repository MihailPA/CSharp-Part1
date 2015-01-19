//Problem 10. Fibonacci Numbers
//Write a program that reads a number n and prints on the console the 
//first n members of the Fibonacci sequence (at a single line, separated
//by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …

using System;


namespace FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the last Fibonacci member:");
            int fibonNum = int.Parse(Console.ReadLine());

            decimal firstNum = 0m;
            decimal secondNum = 1m;
            decimal sum;

            for (int i = 0; i < fibonNum; i++)
            {
                Console.Write("{0}, ", firstNum);

                sum = firstNum + secondNum;
                firstNum = secondNum;
                secondNum = sum;
            }
        }
    }
}
