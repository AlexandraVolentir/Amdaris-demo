using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_paradigm_LINQ
{
    class Program
    {
        public static void OutputList(List<Account> list)
        {
            foreach (var person in list)
            {
                Console.WriteLine($"{ person.FirstName } { person.LastName } ({ person.BirthDate.ToShortDateString() }): Membership { person.YearsOfMembership }");
            }
            Console.WriteLine("\n");
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


            // via delegates
            // rewrite using anonymous functions
            // rewrite using lambda expressions
            // using extension methods on the collection
            // using select/where operators on the collection

           

            var userArray = listOfPeople.ToArray();
            
            // BubbleSorter.Sort(userArray, new BubbleSorter.IsAGreaterThanBDeleGate(CompareUsers));
           
            SelectionSorter.Sort(userArray, CompareUsers);
            BubbleSorter.Sort(userArray, delegate (User a, User b) { return a.Age > b.Age; });
            BubbleSorter.Sort(userArray, (a, b) => a.Age > b.Age);

            foreach (var user in userArray)
            {
                Console.WriteLine($"{user.FirstName} {user.Age}");
            }

            Console.ReadLine();

        }
    }
}
