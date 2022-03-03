using System;
using System.Collections.Generic;
namespace Classes_in_Csharp
{

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
                if (personalCode.ToString().Length != 5)
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

    }

}