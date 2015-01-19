//Problem 1. Sum of 3 Numbers
//Write a program that reads 3 real numbers from the console and prints their sum.

using System;

namespace SumOf3Numbers
{
    class SumOf3Numbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter three real numbers!");
            Console.WriteLine("Please Enter your first number:");
            double firstNum = double.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter your second number:");
            double secondNum = double.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter your third number:");
            double thirdNum = double.Parse(Console.ReadLine());
            double result = firstNum + secondNum + thirdNum;
            Console.WriteLine("The sum of your numbers is:{0}", result);

       
        }
    }
}
