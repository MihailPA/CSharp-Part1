using System;


namespace Four_DigitNumber
{
    class FourDigitNumber
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int Position1 = number / 1000;
            int Position2 = (number / 100) % 10;
            int Position3 = (number / 10) % 10;
            int Position4 = number % 10;
            int sum = Position1 + Position2 + Position3 + Position4;
            Console.WriteLine("The sum of the four digits is:" + sum);
            Console.WriteLine("Reversed: {3}{2}{1}{0}", Position1, Position2, Position3, Position4);
            Console.WriteLine("Last digit on first place: {0}{1}{2}{3}", Position4, Position1, Position2, Position3);
            Console.WriteLine("The places of second and third digits are changed:{0}{1}{2}{3}", Position1, Position3, Position2, Position4);

        }
    }
}
