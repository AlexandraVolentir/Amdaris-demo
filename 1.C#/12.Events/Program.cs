using System;
using System.Collections;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new Account() { Title = "account1" };
            var accountAnalyser = new AccountAnalyser(); // publisher
            var studentLoanService = new StudentLoanService(); // subscriber
            var autoLoanService = new AutoLoanService(); // subscriber
            var mortageLoanService = new MortageLoanService(); // subscriber
            var homeEquityLoanService = new HomeEquityLoanService(); // subscriber

            // += registers a handler for that event
            // we dont use brackets because this is a reference, a pointer to that methods
            // VideoEncoded event, behind the scene, is a list of pointers to methods
            accountAnalyser.AccountAnalysed += studentLoanService.OnAccountAnalysed;
            accountAnalyser.AccountAnalysed += autoLoanService.OnAccountAnalysed;
            accountAnalyser.AccountAnalysed += mortageLoanService.OnAccountAnalysed;
            accountAnalyser.AccountAnalysed += homeEquityLoanService.OnAccountAnalysed;

            accountAnalyser.AccountAnalysed -= studentLoanService.OnAccountAnalysed;
            accountAnalyser.AccountAnalysed -= autoLoanService.OnAccountAnalysed;
            accountAnalyser.AccountAnalysed -= mortageLoanService.OnAccountAnalysed;
            accountAnalyser.AccountAnalysed -= homeEquityLoanService.OnAccountAnalysed;
            accountAnalyser.Analyze(account);
        }
    }
}