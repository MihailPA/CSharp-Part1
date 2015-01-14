//Declare Variables
//Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort,
//int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
//Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.


using System;


namespace _01_DeclareVariables
{
    class DeclareVariables
    {
        static void Main(string[] args)
        {
            sbyte number1 = -115;
            byte number2 = 97;
            short number3 = -10000;
            ushort number4 = 52130;
            int number5 = 4825932;
            Console.WriteLine(number1);
            Console.WriteLine(number2);
            Console.WriteLine(number3);
            Console.WriteLine(number4);
            Console.WriteLine(number5);
        }
    }
}
