//Problem 12. Null Values Arithmetic
//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.

using System;


namespace NullValuesArithmetic
{
    class NullValuesArithmetic
    {
        static void Main(string[] args)
        {
            int? a = null;
            double? b = null;

            Console.WriteLine("The value of A is: {0}", a);
            Console.WriteLine("The value of B is: {0}", b);

            a = 20;
            b = 20.05;

            Console.WriteLine("The new value of A is:{0} \n The new value of B is: {1}", a, b);
        }
    }
}
