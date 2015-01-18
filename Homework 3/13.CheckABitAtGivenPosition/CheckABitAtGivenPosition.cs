using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckABitAtGivenPosition
{
    class CheckABitAtGivenPosition
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter an integer n: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Please enter an integer for position p: ");
            int position = int.Parse(Console.ReadLine());
            bool Check = ((num >> position) & 1) == 1;
            Console.WriteLine("n = " + num + "; value of bit at index p = " + position + " --> " + Check);
        }
    }
}
