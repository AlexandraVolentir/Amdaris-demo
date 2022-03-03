using System;
namespace Classes_in_Csharp
{
    abstract public class Account
    {
        public int AccountNr { get; set; }
        public int Balance { get; set; }
        public string Remarks { get; set; }

        public abstract void calcDebitAmount();
        public abstract void calcCreditAmount();
        public abstract int getBalance();
        public abstract int getBalance(string month);
        public abstract int getBalance(string month, string year);
    }
}
