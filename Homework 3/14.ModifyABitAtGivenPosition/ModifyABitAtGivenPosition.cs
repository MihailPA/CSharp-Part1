using System;


namespace ModifyABitAtGivenPosition
{
    class ModifyABitAtGivenPosition
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integer");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter bit value");
            int v = int.Parse(Console.ReadLine());
            Console.WriteLine("nter position");
            int p = int.Parse(Console.ReadLine());
            int mask = 1 << p;
            int m;
            if (v == 1)
            {
                m = n | mask;
            }
            else
            {
                m = n ^ mask;
            }
            Console.WriteLine(m);
        }
    }
}
