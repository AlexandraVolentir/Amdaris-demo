using System;
namespace Events
{
    public class HomeEquityLoanService
    {
        public void OnAccountAnalysed(object source, AccountEventArgs e)
        {
            Console.WriteLine("HomeEquityLoanService: Creating a home equity loan...." + e.Account.Title);
        }
    }
}
