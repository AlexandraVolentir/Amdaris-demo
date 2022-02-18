using System;
using System.Collections.Generic;

/*
 - create a C# program which uses classes to model real world objects
 - use methods and fields to encapsulate class implementation
 - use properties to make some properties accessible or replace trivial methods (getters/setters)
 - create class hierarchy to model real world hierarchies (animals in zoo, shapes in drawing system, etc)
 - create a method and make its overloaded and overriden versions
 */

namespace SecondPrj
{
    abstract public class Account
    {
        public int AccountNr { get; set; }
        public int Balance { get; set; }
        public string Remarks { get; set; }

        public abstract void calcDebitAmount();
        public abstract void calcCreditAmount();
        public abstract int getBalance();
        public abstract int getBalance(string month);
        public abstract int getBalance(string month, string year);

    }

    public class ResourcesAccount : Account
    {
        public static readonly string type = "Resources Account";
        public ResourcesAccount(int accNumber)
        {
            AccountNr = accNumber;
        }
        public override void calcDebitAmount()
        {
            Console.WriteLine("Calculate debit for Resources Account!");
        }
        public override void calcCreditAmount()
        {
            // code for calculating credit amount
        }
        public override int getBalance()
        {
            // code for calculating the balance
            Console.WriteLine("Calculate total balance for Resource account type");
            return 1;
        }
        public override int getBalance(string month)
        {
            Console.WriteLine("Calculate balance in resources account for {0} this year", month);
            return 1;
        }
        public override int getBalance(string month, string year)
        {
            Console.WriteLine("Calculate balance in resources account for {0}, year {1}", month, year);
            return 1;
        }

    }
    public class MainAccount : Account
    {
        public static readonly string type = "Main Account";
        public MainAccount(int accNumber)
        {
            AccountNr = accNumber;
        }
        public override void calcDebitAmount()
        {
            Console.WriteLine("Calculating debit for Main account!");
        }
        public override void calcCreditAmount()
        {
            // code for calculating credit amount
        }
        public override int getBalance()
        {
            // code for calculating the balance
            Console.WriteLine("Calculate total balance for main account type");
            return 1;
        }
        public override int getBalance(string month)
        {
            Console.WriteLine("Calculate balance in main account for {0} this year", month);
            return 1;
        }
        public override int getBalance(string month, string year)
        {
            Console.WriteLine("Calculate balance in main account for {0}, year {1}", month, year);
            return 1;
        }
    }
    public class Client
    {

        public readonly bool individual;
        private int personalCode;
        private string identificationNr;
        int numberOfClients = 0;
        private int PersonalCode
        {
            get { return personalCode; }
            set
            {
                if(personalCode.ToString().Length != 5)
                {
                    personalCode = value;
                }
                else
                {
                    personalCode = -1;
                }

            }
        }
        private string IdentificationNr
        {
            get { return identificationNr; }
            set
            {
                if (value.ToString().Length == 13)
                {
                    identificationNr = value;
                }
                else
                {
                    identificationNr = String.Empty;
                }

            }
        }
        internal MainAccount accountMain;
        internal ResourcesAccount accoutRsc;
        private string Name { get; set; }
        private string Surname { get; set; }
        private DateTime BirthDate { get; set; }
        private string HomeAddress { get; set; }
        private string Telephone { get; set; }
        private string Country { get; set; }

        static private List<Client> listClients = new List<Client>();
        public Client(int code, string name, string surname, DateTime birthDate, string homeAddress, string tel, string country, string idNo, bool individual)
        {
            PersonalCode = code;
            Name = name;
            Surname = surname;
            BirthDate = birthDate;
            HomeAddress = homeAddress;
            Telephone = tel;
            Country = country;
            IdentificationNr = idNo;
            this.individual = individual;
            Console.WriteLine($"{Name} {Surname}, {calculateClientAge()} years old\n" +
                $"currently living in {Country}, {HomeAddress},\nwith id number {IdentificationNr}\nhas created a bank account at MAIB.");
            numberOfClients++;
            listClients.Add(this);
            accountMain = new MainAccount(numberOfClients);
            accoutRsc = new ResourcesAccount(numberOfClients);
            numberOfClients++;
        }
        public int calculateClientAge()
        {
            var today = DateTime.Today;
            var age = today.Year - BirthDate.Year;
            if (BirthDate.Date > today.AddYears(-age)) age--;
            return age;
        }
        public static void Main(string[] args)
        {
            Client client1 = new Client(10001, "Andrei", "Munteanu", Convert.ToDateTime("03/05/1988"), "Chisinau, Ginta Latina 13/1","3738585851", "Moldova", "4555555555555", true);

            Console.WriteLine("An account of type Main Account was created for client nr. {0} ", client1.accountMain.AccountNr);
            client1.accountMain.getBalance();
            client1.accountMain.getBalance("Feb", "2020");
            client1.accountMain.getBalance("May", "2008");
            client1.accountMain.getBalance("Jan");
            Console.ReadKey();
        }
    }
}
