using System;


namespace ThirdDigitIs7
{
    class ThirdDigitIs7
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number with four or more digits: ");
            int number = int.Parse(Console.ReadLine());
            bool digit = (number / 100) % 10 == 7;
            Console.WriteLine("Is 7 the third digit of the number (right to left) : " + number + "? - " + digit);
        }
    }
}
