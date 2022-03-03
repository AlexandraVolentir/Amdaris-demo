using System;
namespace Creational_patterns
{
    class PayDayLoanFactory : LoanFactory
    {
        private int _rate;
        private int _sumOfMoney;

        public PayDayLoanFactory(int sumOfMoney, int rate)
        {
            _sumOfMoney = sumOfMoney;
            _rate = rate;
        }

        public override Loan GetLoan()
        {
            return new PayDayLoan(_sumOfMoney, _rate);
        }
    }
}