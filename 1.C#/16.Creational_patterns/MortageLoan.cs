using System;

namespace Creational_patterns
{
    class MortageLoan : Loan
    {
        private readonly string _loanType;
        private int _sumOfMoney;
        private int _rate;

        public MortageLoan(int sum, int rate)
        {
            _loanType = "Mortage Loan";
            _sumOfMoney = sum;
            _rate = rate;
        }

        public override string LoanType
        {
            get { return _loanType; }
        }

        public override int SumOfMoney
        {
            get { return _sumOfMoney; }
            set { _sumOfMoney = value; }
        }

        public override int Rate
        {
            get { return _rate; }
            set { _rate = value; }
        }
    }
}