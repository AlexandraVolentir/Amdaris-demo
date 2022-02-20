using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

/* create methods which checks input arguments and throws exceptions
 * create custom exceptions and throw them
 * write try-catch-finally block with multiple catch statemens
 * check exception
 * add conditional compilation symbols
 * use debug class to write debug information to output window
 * declare implicit typed variable using keyword var
 */

namespace prj
{
    class InvalidClientEmailException : Exception
    {
        public InvalidClientEmailException() { }
        public InvalidClientEmailException(string mail)
            : base(String.Format("Incorrect mail: {0}", mail)) // base from base class of th instance
        {
        }
    }
    class Bank
    {
        public string BankName { get; set; }
    }

    class Account
    {
        public int AccountNo { get; set; }
        public string ClientNmae { get; set; }
        public string Mail { get; set; }
        static public int getIndexSquare(int[] arr, int index)
        {
            if (index > arr.Length - 1)
            {
                throw new IndexOutOfRangeException("Index is out of range");
            }
            return arr[index] * arr[index];

        }
        public static void writeBankName(Bank bnk)
        {
            if (bnk == null)
                throw new NullReferenceException("Student object is null.");

            Console.WriteLine(bnk.BankName);
        }
        public static Boolean ValidateMail(string email)
        {

            if (!email.EndsWith("@gmail.com"))
            {
                throw new InvalidClientEmailException(email);
            }
            return true;
        }
        public static void check()
        {
            // Here, numer is longer than denom.
            int[] arr1 = { 45, 65, 72, 3440, 3433, 5 };
            int[] arr2 = { 9, 5, 6, 0, 2 };

            for (int i = 0; i < arr1.Length; i++)
            {
                try
                {
                    Console.WriteLine(arr1[i] + " divided by " +
                                      arr2[i] + " = " +
                                      arr1[i] / arr2[i]);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Division by zero!");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Index out of range!");
                    throw; // check exception
                }
            }
        }
        public static void Main()
        {
            // - create methods which checks input arguments and throws exceptions
            Bank bnk1 = null;
            try
            {
                writeBankName(bnk1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            int[] arr = { 45, 34, 566, 21, 3 };
            int a;
            try
            {
                a = getIndexSquare(arr, 9);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            // - create custom exceptions and throw them
            var acc = new Account();

            try
            {
                acc.Mail = "a@3gmail.com";
                ValidateMail(acc.Mail);
            }
            catch (InvalidClientEmailException ex)
            {
                Console.WriteLine(ex.Message);
            }

            // write try-catch-finally block with multiple catch statemens
            string path;
            try
            {
                path = "/Users/Sandra/Desktop";
                var fs = new FileStream(path, FileMode.CreateNew);
            }
            catch (FileNotFoundException err)
            {
                Console.WriteLine("Fileul sau folderul nu a putut fi gasit");
                Console.WriteLine(err.Message);
            }
            catch (DirectoryNotFoundException err)
            {
                Console.WriteLine("Folderul nu a putut fi gasit");
                Console.WriteLine(err.Message);
            }
            catch (DriveNotFoundException err)
            {
                Console.WriteLine("Driveul specificat in path e invalid");
                Console.WriteLine(err.Message);
            }
            catch (PathTooLongException err)
            {
                Console.WriteLine("Pathul depaseste lungimea maximala disponibila");
                Console.WriteLine(err.Message);
            }
            finally
            {
                path = "default";
            }

            // InvalidCastException
            bool flag = true;
            try
            {
                IConvertible var1 = flag;
                Char ch = var1.ToChar(null);
                Console.WriteLine("Conversia a avut succes.");
            }
            catch (InvalidCastException err)
            {
                Console.WriteLine("Nu poate converti boolean la char");
                Console.WriteLine(err.Message);
            }
            catch (Exception err)
            {
                Console.WriteLine("General Error");
                Console.WriteLine(err.Message);
            }

            // check exception
            try
            {
                check();
            }
            catch (IndexOutOfRangeException)
            {
                // recatch exception
                Console.WriteLine("Termination of the program. Index out of range");
            }
            // add conditional compilation symbols
            #if DEBUG
                Console.WriteLine("Debug version");
            #else
                Console.WriteLine("Release version");
            #endif

            // declare implicit typed variable using keyword var
            for (var x = 1; x < 3; x++)
                Console.ReadKey();
            var file = "/Uers/alexandra/Documents/file.txt";
            Console.WriteLine("The absolute path for the file is: {0}", file);
        }
    }
}
