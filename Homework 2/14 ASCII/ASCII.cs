//Problem 14.* Print the ASCII Table
//Find online more information about ASCII (American Standard Code for Information Interchange) 
//and write a program that prints the entire ASCII table of characters on the console (characters from 0 to 255).
//Note: Some characters have a special purpose and will not be displayed as expected. You may skip them or display them differently.
//Note: You may need to use for-loops (learn in Internet how).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII
{
    class ASCII
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;


            for (int symbol = 0; symbol < 256; symbol++)
            {
                Console.WriteLine("{0} = {1}", symbol, (char)symbol);
            }
        }
    }
}
