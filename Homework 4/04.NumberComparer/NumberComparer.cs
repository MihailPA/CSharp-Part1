//Problem 4. Number Comparer
//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements.


using System;


namespace NumberComparer
{
    class NumberComparer
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a number:");
            double firstNum = double.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter another number:");
            double anotherNum = double.Parse(Console.ReadLine());
            double greater = Math.Max(firstNum, anotherNum);
            Console.WriteLine("The greater number is:"+ greater);

        }
    }
}
