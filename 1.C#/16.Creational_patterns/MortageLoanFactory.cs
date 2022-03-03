using System;
namespace Creational_patterns
{
    class MortageLoanFactory : LoanFactory
    {
        private int _rate;
        private int _sumOfMoney;

        public MortageLoanFactory(int sumOfMoney, int rate)
        {
            _sumOfMoney = sumOfMoney;
            _rate = rate;
        }

        public override Loan GetLoan()
        {
            return new MortageLoan(_sumOfMoney, _rate);
        }
    }
}