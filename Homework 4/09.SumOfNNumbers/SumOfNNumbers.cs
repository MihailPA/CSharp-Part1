//Problem 9. Sum of n Numbers
//Write a program that enters a number n and after that enters more n numbers and 
//calculates and prints their sum. Note: You may need to use a for-loop.

using System;


namespace SumOfNNumbers
{
    class SumOfNNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            double n = double.Parse(Console.ReadLine());
            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {

                Console.WriteLine("Enter a number:");
                double input = double.Parse(Console.ReadLine());
                sum += input;
            }
            Console.WriteLine("The sum of the entered numbers is: " + sum);
        }
    }
}
