//Problem 15. Hexadecimal to Decimal Number
//Using loops write a program that converts a hexadecimal integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.HexadecimalToDecimal
{
    class HexadecimalToDecimal
    {
       static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(n.ToString("X"));
        }

       public static string convert(string n)
       {
           string result = string.Empty;
           switch (n)
           {
               case "1":
               case "2":
               case "3":
               case "4":
               case "5":
               case "6":
               case "7":
               case "8":
               case "9":
                   result = n;
                   break;
               case "10":
                   result = "A";
                   break;
               case "11":
                   result = "B";
                   break;
               case "12":
                   result = "C";
                   break;
               case "13":
                   result = "D";
                   break;
               case "14":
                   result = "E";
                   break;
               case "15":
                   result = "F";
                   break;
               default:
                   result = "0";
                   break;
           }
           return result;
       }
    }
}
