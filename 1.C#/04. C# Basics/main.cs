using System;
using System.Collections.Generic;
using System.Threading;

/*
 - create a hello world
 - create instances of value types and reference types
 - use static methods
 - write a method for each type of parameter modifier
 - use boxing and unboxing
 + static methods
 + threads
 */

namespace FirstPrj
{
    class Bank
    {
        public static string bank;
        public int accountId;
        static List<int> loans = new List<int>(5);

        static Bank()
        {
            loans.Add(3450000);
            loans.Add(45000);
            loans.Add(10000);
            loans.Add(13000);
            loans.Add(30000);

        }
        public void addTaxes(int sum)
        {
            sum += 500;
        }
        public void getBank(string bankName)
        {
            bankName = "Transilvania";
        }
        public static void giveNameToBank()
        {
            bank = "MAIB";
        }
        public static void giveStudentLoan(out int loan)
        {
            loan = 16000;
            loan *= 2;
        }
        static void LoanEnquiery(ref string str1)
        {
            if (str1 == "Loan")
            {
                Console.WriteLine("Loan enquery was aproved");
            }
            else
            {
                Console.WriteLine("Loan enquiery was disaproved");
            }
            str1 = "Moldova AgroinBank";
        }
        public static void ThreadProc()
        {
            int sum = 0;
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Thread no 2, sum = {0}", sum);
                sum += 5;
                Thread.Sleep(2);
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!\n");

            // create instances of value types and reference types
            int x = 10;
            int y = x;
            y = 40;
            Console.WriteLine(y);
            Bank b = new Bank();
            b.addTaxes(y);
            Console.WriteLine(y);
            //b.getBank("Raiffaisen");
            Console.WriteLine(bank);
            int[] arr = new int[20];

            // use static methods
            Bank b1 = new Bank();
            Bank.giveNameToBank();
            Console.WriteLine(bank);

            // write a method for each type of parameter modifier
            int studentLoan;
            giveStudentLoan(out studentLoan);
            Console.WriteLine("The loan of the student would be: ", studentLoan);
            string str = "Loan";

            // Pass as a reference parameter
            LoanEnquiery(ref str);
            Console.WriteLine(str);


            // use boxing and unboxing
            int loan1 = 45000;
            object boxed = loan1;
            loan1 = (int)boxed;  // unboxing
            Console.WriteLine(loan1);
            Console.WriteLine(boxed);


            // static constructors
            Console.WriteLine("Another loans: ");
            foreach (var val in loans)
            {
                Console.WriteLine(val);
            }

            // threading
            Console.WriteLine("Main thread: Start a second thread.");
            Thread t = new Thread(new ThreadStart(ThreadProc));
            t.Start();
            int totalSum = 0;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Main thread. Sum = {0}", totalSum);
                totalSum += 2;
                Thread.Sleep(3);
            }
            t.Join();
            Console.ReadKey();

        }
    }
}
