using System;
namespace Creational_patterns
{
    abstract class Loan
    {
        public abstract string LoanType { get; }
        public abstract int SumOfMoney { get; set; }
        public abstract int Rate { get; set; }
    }
}
