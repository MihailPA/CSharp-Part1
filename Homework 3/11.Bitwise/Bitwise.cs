using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitwise
{
    class Bitwise
    {
        static void Main(string[] args)
        {
            Console.Write("Enter uint: ");
            uint n = uint.Parse(Console.ReadLine());
            byte bitAtPositionThree = (byte)((n >> 3) & 1);
            Console.WriteLine("bit at third position is " + bitAtPositionThree);
        }
    }
}
