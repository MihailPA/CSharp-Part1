//Problem 11. Random Numbers in Given Range
//Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].

using System;


namespace _11.RandomNumbersInGivenRange
{
    class RandomNumberInGivenRange
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter integer n=");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter integer min=");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter integer (min != max) max=");
            int max = int.Parse(Console.ReadLine());

            Random random = new Random();



            for (int i = 0; i < n; i++)
            {
                int randomNumber = random.Next(min, max);
                Console.Write(randomNumber + " ");
            }
            Console.WriteLine();


        }
    }
}
