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
    class Client
    {
        private int personalCode;
        private string identificationNr;
        //private string name, surname;
        //private string homeAddress, telephone;
        //private string country, nationality;
        uint numberOfClients = 0;
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
        private string Name { get; set; }
        private string Surname { get; set; }
        private string BirthDate { get; set; }
        private string HomeAddress { get; set; }
        private string Telephone { get; set; }
        private string Country { get; set; }
        static private List<Client> listClients = new List<Client>();
        public Client(int code, string name, string surname, string birthDate, string homeAddress, string tel, string country, string idNo)
        {
            PersonalCode = code;
            Name = name;
            Surname = surname;
            BirthDate = birthDate;
            HomeAddress = homeAddress;
            Telephone = tel;
            Country = country;
            IdentificationNr = idNo;
            Console.WriteLine($"{Name} {Surname}, born at {BirthDate}, \n" +
                $"currently living in {Country}, {HomeAddress},\nwith id number {IdentificationNr}\nhas created a bank account.");
        }

        public static void Main(string[] args)
        {
            Client client1 = new Client(10001, "Andrei", "Munteanu","03/05/1988", "Chisinau, Ginta Latina 13/1","3738585851", "Moldova", "4555555555555");


            Console.ReadKey();
        }
    }
}
