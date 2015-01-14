//Problem 11. Bank Account Data
//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, 
//IBAN, 3 credit card numbers associated with the account.
//Declare the variables needed to keep the information for a single bank account using the appropriate 
//data types and descriptive names.



using System;

namespace BankAccountData
{
    class BankAccountData
    {
        static void Main(string[] args)
        {
            string FirstName = "Mihail";
            string MiddleName = "Asenov";
            string LastName = "Prachkov";
            Console.WriteLine("Holder name: \n {0} \n {1} \n {2}", FirstName, MiddleName, LastName);

            string money = "$";
            byte balance = 244;
            string bankname = "First Investment Bank";
            long iban = 1245632834978l;
            ulong card1 = 6783473654432211u;
            ulong card2 = 3681215621217878u;
            ulong card3 = 4444333312127273u;
            Console.WriteLine("Available amount of money in: {0} \n Balance: {1} \n {2}", money, balance, bankname);
            Console.WriteLine("IBAN:" + iban);
            Console.WriteLine("Credit Card Numbers associated with that account: \n Credit card 1: {0} \n Credit card 2: {1} \n Credit card 3: {2}", card1, card2, card3);



        }
    }
}
