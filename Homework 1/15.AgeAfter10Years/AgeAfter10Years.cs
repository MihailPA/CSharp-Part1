
//Problem 15.* Age after 10 Years
//Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.

using System;

namespace AgeAfter10Years
{
    class AgeAfter10Years
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Please enter your birthday dd/mm/yyyy:");
            DateTime birthday = DateTime.Parse(Console.ReadLine());
            DateTime now = DateTime.Now;
            int age = now.Year - birthday.Year;
            if (birthday.Month >= now.Month)
            {
                age = now.Year - birthday.Year - 1;
            }
            Console.WriteLine("You are {0} yaers old!", age);
            Console.WriteLine("After 10 years you will be {0}!", age + 10);
        }
    }
}
