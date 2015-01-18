using System;


namespace GravitationOnTheMoon
{
    class GravitationOnTheMoon
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter your weight:");
            double myWeight = double.Parse(Console.ReadLine());
            double myMoonWeight = (myWeight* 0.17);
            Console.WriteLine("Your MoonWeight is:");
            Console.WriteLine(myMoonWeight);
        }
    }
}
