using System;


namespace OddOrEven
{
    class OddOrEven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number you want to check:");
            int a = int.Parse(Console.ReadLine());

            bool result = a % 2 == 0;

            Console.WriteLine("The integer is: {0}", result);
            if (result == false)
            {

                Console.WriteLine("Odd");

            }
            else if (result == true) 
            {
                Console.WriteLine("Even");
            }
        }
    }
}
