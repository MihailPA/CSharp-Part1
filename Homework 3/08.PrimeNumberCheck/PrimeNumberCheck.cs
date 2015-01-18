using System;


namespace PrimeNumberCheck
{
    class PrimeNumberCheck
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a number:");
            int num = int.Parse(Console.ReadLine());
            bool result= num >=100;
            
            if ((num == 1 || num == 2 || num == 3 || num == 5 || num == 7)
                    ^ (num % 2 != 0 && num % 3 != 0 && num % 5 != 0 && num % 7 != 0))
            {
                Console.WriteLine("The number is Prime");
            }
            else
                Console.WriteLine("The number is NOT Prime");
            
        }
    }
}
