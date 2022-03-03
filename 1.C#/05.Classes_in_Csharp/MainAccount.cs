using System;
namespace Classes_in_Csharp
{
    public class MainAccount : Account
    {
        public static readonly string type = "Main Account";
        public MainAccount(int accNumber)
        {
            AccountNr = accNumber;
        }
        public override void calcDebitAmount()
        {
            Console.WriteLine("Calculating debit for Main account!");
        }
        public override void calcCreditAmount()
        {
            // code for calculating credit amount
        }
        public override int getBalance()
        {
            // code for calculating the balance
            Console.WriteLine("Calculate total balance for main account type");
            return 1;
        }
        public override int getBalance(string month)
        {
            Console.WriteLine("Calculate balance in main account for {0} this year", month);
            return 1;
        }
        public override int getBalance(string month, string year)
        {
            Console.WriteLine("Calculate balance in main account for {0}, year {1}", month, year);
            return 1;
        }
    }
}
