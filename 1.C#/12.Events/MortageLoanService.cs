using System;
namespace Events
{
    public class MortageLoanService
    {
        public void OnAccountAnalysed(object source, AccountEventArgs e)
        {
            Console.WriteLine("MortageLoanService: Creating a mortage loan...." + e.Account.Title);
        }
    }
}
