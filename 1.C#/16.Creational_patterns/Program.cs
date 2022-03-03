using System;

namespace Creational_patterns
{   
    public class Program
    {
        static void Main()
        {
            LoanFactory factory = null;
            Console.WriteLine("Enter the loan you would like to acquire: ");
            string loan = Console.ReadLine();

            switch (loan)
            {
                case "student":
                    factory = new StudentLoanFactory(2000, 4);
                    break;
                case "payday":
                    factory = new PayDayLoanFactory(100000, 10);
                    break;
                case "mortage":
                    factory = new MortageLoanFactory(43000, 11);
                    break;
                default:
                    break;
            }

            Loan loan1 = factory.GetLoan();
            Console.WriteLine("\nA new loan was created : \n");
            Console.WriteLine("Loan Type: {0}\nSum: {1}\nAnnual Rate: {2}",
                loan1.LoanType, loan1.SumOfMoney, loan1.Rate);
            Console.ReadKey();
        }
    }
}