using System;
namespace Events
{
    public class AutoLoanService
    {
        public void OnAccountAnalysed(object source, AccountEventArgs e)
        {
            Console.WriteLine("AutoLoanService: Creating an Auto loan...." + e.Account.Title);
        }
    }
}
