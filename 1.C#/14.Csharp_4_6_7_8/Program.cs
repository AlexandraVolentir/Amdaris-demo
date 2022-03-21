using System;
using System.Collections.Generic;
using System.IO;

/*
 Think of a method with optional parameters in your domain
 call methods with optional parameters and using named arguments
 experiment with dynamic
 convert to autoproperty
 consider expression bodied methods
 consider string interpolation
 think of exception filtering application
 preconditions with nameof
 see if you can apply null conditional operator
 test C# 7.0 features
 self study conventions
 */

namespace Csharp_4_6_7_8
{

    class MainClass
    {
        public static int DiceSum2(IEnumerable <object> values)
        {
            var sum = 0;
            foreach(var item in values)
            {
                if (item is int val)
                {
                    sum += val;
                }
                else if (item is IEnumerable<object> sublist)
                    sum += DiceSum2(sublist);
            }
            return sum;
        }
        public static int AddNumber(int firstNumber, int secondNumber = 250)
        {
            return firstNumber + secondNumber;
        }
        public static void Main(string[] args)
        {

            
            //Think of a method with optional parameters in your domain

            //call methods with optional parameters and using named arguments
            AddNumber(firstNumber: 123);
            //experiment with dynamic

            //dynamic val2 = 3234;
            //Console.WriteLine("Get the actual type of val2: {0}", val2.GetType().ToString());

            //convert to autoproperty
            Bank bank = new Bank();
            bank.BankName = "Transilvania";

            //consider expression bodied methods

            //consider string interpolation
            string firstName = "Michael";
            string lastName = "Crump";
            Console.WriteLine($"{firstName} {lastName} is my name");
            string path;

            //think of exception filtering application
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

                // this is a new line
                Console.WriteLine("Pathul depaseste lungimea maximala disponibila");
                Console.WriteLine(err.Message);
            }
            catch (Exception err)
            {
                Console.WriteLine("General err");
                Console.WriteLine(err.Message);
            }
            //preconditions with nameof

            // A nameof expression produces the name of a variable, type, or member as the string constant
            string newName = null;
            if(newName == null)
            {
                throw new Exception(nameof(newName) + " is null");
            }

            //see if you can apply null conditional operator
            string person = null;
            Console.WriteLine(person != null ? person : "person name null");
            //test C# 7.0 features

            // out variables
            string input = "222";
            if(int.TryParse(input, out int result))
                Console.WriteLine(result);

            // tuples
            var letters = ("a", "b");
            (string Alpha, string Beta) namedLetters = ("A", "B");
            var alphabet = (Alpha: "a", Beta: "beta");
            (string First, string Second) firstLetters = (Alpha: "a", Beta: "b");

            // safe type cast : as operator - perform certain types of conversions between compatible reference types or nullable types
            // implicit conversions - no special syntax is required
            int num = 12234;
            long bigNum = num;
            //B b = new B();
            //A a = b;

            // explicit conversions(safe) - require a cast operator
            //A a = new B();
            //A b = (B)a;


            // user-defined conversions - are performed byspecial methods that ypu can define to enable explicit conversions
            //A a = new A();
            //B b = a as B();


        }
    }
}
