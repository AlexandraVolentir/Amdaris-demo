using System;
namespace Events
{
    public class StudentLoanService
    {
        public void OnAccountAnalysed(object source, AccountEventArgs e)
        {
            Console.WriteLine("StudentLoanService: Creating a Student loan...." + e.Account.Title);
        }
    }
}
