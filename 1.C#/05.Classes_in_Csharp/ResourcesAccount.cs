using System;
namespace Classes_in_Csharp
{
    public class ResourcesAccount : Account
    {
        public static readonly string type = "Resources Account";
        public ResourcesAccount(int accNumber)
        {
            AccountNr = accNumber;
        }
        public override void calcDebitAmount()
        {
            Console.WriteLine("Calculate debit for Resources Account!");
        }
        public override void calcCreditAmount()
        {
            // code for calculating credit amount
        }
        public override int getBalance()
        {
            // code for calculating the balance
            Console.WriteLine("Calculate total balance for Resource account type");
            return 1;
        }
        public override int getBalance(string month)
        {
            Console.WriteLine("Calculate balance in resources account for {0} this year", month);
            return 1;
        }
        public override int getBalance(string month, string year)
        {
            Console.WriteLine("Calculate balance in resources account for {0}, year {1}", month, year);
            return 1;
        }

    }
}
