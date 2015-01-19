//Problem 2. Print Company Information
//A company has name, address, phone number, fax number, web site and manager. 
//The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager 
//and prints it back on the console.

using System;


namespace PrintCompanyInformation
{
    class PrintCompanyInformation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Company name:");
            string companyName = Console.ReadLine();
            Console.WriteLine("Please Enter Company address:");
            string companyAddress = Console.ReadLine();
            Console.WriteLine("Please Enter Phone number:");
            long phoneNum =long.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Fax number:");
            int faxNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Web site:");
            string webSite = (Console.ReadLine());
            Console.WriteLine("Please Enter your Manager first name:");
            string managerFName = (Console.ReadLine());
            Console.WriteLine("Please Enter you Manager last name:");
            string managerLName = Console.ReadLine();
            Console.WriteLine("Please Enter your Manager phone number:");
            long managerPNum = long.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter your Manager age:");
            int managerAge = int.Parse(Console.ReadLine());


            Console.WriteLine("Company Information \n {0} \n Address:{1} \n Tel.{2} ", companyName, companyAddress, phoneNum);
            Console.WriteLine(" Fax:({0}) \n Web Site:{1} \n Manager: {2} {3} (Age:{4}, Tel.{5})", faxNum, webSite, managerFName, managerLName, managerAge, managerPNum);



        }
    }
}
