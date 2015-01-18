using System;

namespace DivideBy7And5
{
    class DivideBy7And5
    {
        static void Main(string[] args)
        {
            int a=7;
            int b=5;
            int c= int.Parse(Console.ReadLine());
            bool result = (c % 7 == 0) && (c % 5 == 0);
            Console.WriteLine(result);
        }
    }
}
