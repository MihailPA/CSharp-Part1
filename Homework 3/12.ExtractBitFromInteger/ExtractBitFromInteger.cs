using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractBitFromInteger
{
    class ExtractBitFromInteger
    {
        static void Main(string[] args)
        {
            Console.Write("Enter integer: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter position: ");
            int p = int.Parse(Console.ReadLine());

            byte bitAtPositionP = (byte)((n >> p) & 1);
            Console.WriteLine("bit at #{0} is {1}", p, bitAtPositionP);
        }
    }
}
