//Problem 7. Quotes in Strings
//Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
//Do the above in two different ways - with and without using quoted strings.
//Print the variables to ensure that their value was correctly defined.



using System;


namespace QuotesInString
{
    class QuotesInString
    {
        static void Main(string[] args)
        {
            string alfa = "The \"use\" of quotations causes difficulties.";
            string beta = @"The ""use"" of quotations causes difficulties.";

            Console.WriteLine(alfa);
            Console.WriteLine(beta); 
        }
    }
}
