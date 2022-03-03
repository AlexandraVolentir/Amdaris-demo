using System;
namespace Creational_patterns
{ 
    class StudentLoanFactory : LoanFactory
    {
        private int _rate;
        private int _sumOfMoney;

        public StudentLoanFactory(int sumOfMoney, int rate)
        {
            _sumOfMoney = sumOfMoney;
            _rate = rate;
        }

        public override Loan GetLoan()
        {
            return new StudentLoan(_sumOfMoney, _rate);
        }
    }
}