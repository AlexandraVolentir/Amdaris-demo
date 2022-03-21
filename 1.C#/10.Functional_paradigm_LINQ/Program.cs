using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_paradigm_LINQ
{
    class Program
    {
        public delegate void petanim(string pet);
        public static void OutputList(List<Account> list)
        {
            foreach (var person in list)
            {
                Console.WriteLine($"{ person.FirstName } { person.LastName } ({ person.BirthDate.ToShortDateString() }): Membership { person.YearsOfMembership }");
            }
            Console.WriteLine("\n");
        }
        static bool CompareUsers(object a, object b)
        {
            var user1 = (Account)a;
            var user2 = (Account)b;
            return user1.YearsOfMembership > user2.YearsOfMembership;
        }

        public static void Main(string[] args)
        {
            List<Account> listOfPeople = ListManager.LoadSampleData();

            // ORDER BY
            listOfPeople = listOfPeople.OrderBy(x => x.LastName).ToList();
            OutputList(listOfPeople);
            

            listOfPeople  = listOfPeople.OrderByDescending(x => x.LastName).ThenByDescending(x => x.YearsOfMembership).ToList();
            OutputList(listOfPeople);



            listOfPeople = listOfPeople.Where(x => x.YearsOfMembership >= 10 && x.BirthDate.Month == 4).ToList();
            OutputList(listOfPeople);

            int sumOfMembershipYears = listOfPeople.Sum(x => x.YearsOfMembership);
            Console.WriteLine($"Sum of membership years: {sumOfMembershipYears}");

            sumOfMembershipYears = listOfPeople.Where(x => x.BirthDate.Month == 3).Sum(x => x.YearsOfMembership);
            Console.WriteLine($"Sum of membership years: {sumOfMembershipYears}");
           

            var userArray = listOfPeople.ToArray();
           
            BubbleSorter.Sort(userArray, CompareUsers);

            var sourceObjects = new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //BubbleSorter.Sort(sourceObjects, BubbleSorter.IsAGreaterThanBDeleGate);

            // lambda expressions
            BubbleSorter.Sort(userArray, delegate (Account a, Account b) { return a.YearsOfMembership > b.YearsOfMembership; });
            BubbleSorter.Sort(userArray, (a, b) => a.YearsOfMembership > b.YearsOfMembership);

            foreach (var user in userArray)
            {
                Console.WriteLine($"{user.FirstName} {user.YearsOfMembership}");
            }

            petanim p = delegate (string mypet)
            {
                Console.WriteLine("My favorite pet is: {0}",
                                                     mypet);
            };
            p("Dog");

            Console.ReadLine();

        }
    }
}
