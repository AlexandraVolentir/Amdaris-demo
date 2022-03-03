using System;


/*
 - create a C# program which uses classes to model real world objects
 - use methods and fields to encapsulate class implementation
 - use properties to make some properties accessible or replace trivial methods (getters/setters)
 - create class hierarchy to model real world hierarchies (animals in zoo, shapes in drawing system, etc)
 - create a method and make its overloaded and overriden versions
 */

namespace Classes_in_Csharp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Client client1 = new Client(10001, "Andrei", "Munteanu", Convert.ToDateTime("03/05/1988"), "Chisinau, Ginta Latina 13/1", "3738585851", "Moldova", "4555555555555", true);

            Console.WriteLine("An account of type Main Account was created for client nr. {0} ", client1.accountMain.AccountNr);
            client1.accountMain.getBalance();
            client1.accountMain.getBalance("Feb", "2020");
            client1.accountMain.getBalance("May", "2008");
            client1.accountMain.getBalance("Jan");
            Console.ReadKey();
        }
    }

}