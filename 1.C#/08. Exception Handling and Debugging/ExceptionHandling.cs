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
 * inner exceptions
 */

namespace ExceptionHandling
{
    class InvalidClientEmailException : Exception
    {
        public InvalidClientEmailException() { }
        public InvalidClientEmailException(string mail)
            : base(String.Format("Incorrect mail: {0}", mail)) // base class of th instance
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
                throw new NullReferenceException("Bank object is null.");

            Console.WriteLine(bnk.BankName);
        }
        public static Boolean validateMail(string email)
        {

            if (!email.EndsWith("@gmail.com"))
            {
                throw new InvalidClientEmailException(email);
            }
            return true;
        }
        public static void check()
        {
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
                validateMail(acc.Mail);
            }
            catch (InvalidClientEmailException ex)
            {
                Console.WriteLine(ex.Message);
            }
            // write try-catch-finally block with multiple catch statemens
            string path;
            try
            {
                path = @"/Users/Sandra/Desktop";
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
                path = "default path root";
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
                Console.WriteLine("General err");
                Console.WriteLine(err.Message);
            }

            // - recatch exception
            try
            {
                check();
            }
            catch (IndexOutOfRangeException)
            {
                // recatch exception
                Console.WriteLine("Termination of the program. Index out of range");
            }

            // - add conditional compilation symbols
            #if DEBUG
                             Console.WriteLine("Debug version");
            #else
                        Console.WriteLine("Release version");
            #endif

            // - declare implicit typed variable using keyword var
            for (var x = 1; x < 3; x++)
                Console.ReadKey();
            var file = @"/Uers/alexandra/Documents/file.txt";
            Console.WriteLine("The absolute path for the file is: {0}", file);


            // Inner exception
            try
            {
                try
                {
                    Console.WriteLine("n1 = ");
                    int number1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("n2 = ");
                    int number2 = Convert.ToInt32(Console.ReadLine());
                    int divisionResult = number1 / number2;
                    Console.WriteLine("Division = {0}", divisionResult);
                }
                catch (Exception err)
                {
                    
                    string path1 = @"User\alexandra\Desktop\LoginsFile.txt";
                    if (File.Exists(path1))
                    {
                        StreamWriter streamWriter = new StreamWriter(path1);
                        streamWriter.Write(err.GetType().Name + err.Message + err.StackTrace);
                        streamWriter.Close();
                        Console.WriteLine("a problem arrived. try later");
                    }
                    else
                    {
                        throw new FileNotFoundException(path1 + "  is inexistent ", err);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("outer or current exception is: " + e.Message);
                if (e.InnerException != null)
                {
                    Console.Write("inner exception : ");
                    Console.WriteLine(String.Concat(e.InnerException.StackTrace, e.InnerException.Message));
                }
            }
            Console.ReadLine();
        }
    }
}
