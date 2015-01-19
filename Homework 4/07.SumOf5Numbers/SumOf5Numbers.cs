//Problem 7. Sum of 5 Numbers
//Write a program that enters 5 numbers 
//(given in a single line, separated by a space), calculates and prints their sum.


using System;


namespace SumOf5Numbers
{
    class SumOf5Numbers
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter 5 numbers separated by a space: ");

            string numbers = Console.ReadLine();
            string[] fiveNumbers = numbers.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            double sum = 0;

            for (int i = 0; i < fiveNumbers.Length; i++)
            {
                sum += double.Parse(fiveNumbers[i]);
            }

            Console.WriteLine("The Sum of this numbers is: " + sum);
        }
    }
}
