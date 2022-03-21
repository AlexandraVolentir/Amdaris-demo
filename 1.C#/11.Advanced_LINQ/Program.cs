using System;
using System.Collections.Generic;
using System.Linq;
namespace Advanced_LINQ
{
    static class MyClass
    {
        public static IEnumerable<string> _myTake(this IEnumerable<string> list1, int count)
        {
            List<string> newList = new List<string>();
            for(int i = 0; i < count; i++)
            {
                newList[i] = list1.ElementAt(i);
            }
            return newList;
        }
        public static IEnumerable<string> _myTake1(this IEnumerable<string> list1, int count)
        {
            int index = 0;
            foreach(var obj in list1)
            {
                if(index < count)
                {
                    yield return obj;
                    index++;
                }
                else
                {
                    yield break;
                }
            }
        }
        public static int _myCount(this IEnumerable<int> list1, Func<int, bool>funciton)
        {

            //int count3 = items.Count(x => x < 5);
            int counter = 0;
            foreach (var obj in list1)
            {
                if(funciton(obj))
                {
                    counter++;
                }
            }
            return counter;
        }

    }
    class MainClass
    {
      
        public static void Main(string[] args)
            {
            // filtering
            int[] col = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 25, 26, 27, 27 };
            var div = col.Where(x => x % 3 != 0);
            var fitst10 = col.Take(10);
            var take = col.Skip(5).Take(4);
            var last5 = col.TakeWhile(x => x < 25);
            var gtt5 = col.SkipWhile(x => x < 25); //gtt5={5,6,7,8,1,2}
            var distinct = col.Distinct(); 


            // projection
            var users = new[]
            {
                new User {FirstName = "John", LastName = "Ohnon"},
                new User {FirstName = "Sarah", LastName = "Connor"},
                new User {FirstName = "Robbie", LastName = "Williams"},
            };
            IEnumerable<string> lastNames = users.Select(x => x.LastName);


            // joining - useful for associating elm from different source sequences that have no
            // direct relationship in the object model
            Person person1 = new Person { Name = "Fairfax, Fred" };
            Person person2 = new Person { Name = "John, Smith" };
            Person person3 = new Person { Name = "Frank, Perry" };

            Subdivision b1 = new Subdivision { Name = "B1", Owner = person1 };
            Subdivision b2 = new Subdivision { Name = "B2", Owner = person2 };
            Subdivision b3 = new Subdivision { Name = "B3", Owner = person3 };
            Subdivision b4 = new Subdivision { Name = "B4", Owner = person1 };
            List<Person> people = new List<Person> { person1, person2, person3 };
            List<Subdivision> subdivisions = new List<Subdivision> { b1, b2, b3, b4 };
            var query =
                people.Join(subdivisions,
                            person => person,
                            subdivision => subdivision.Owner,
                            (person, subdivision) =>
                                new { OwnerName = person.Name, Subdivision = subdivision.Name });

            // ordering - return the same elements in a different order
            Loan[] loans = { new Loan { Name="L3", CreationTime=8 },
                   new Loan { Name="L2", CreationTime=4, Sum = 100000 },
                   new Loan { Name="L1", CreationTime=1, Sum = 20000 }

            };

            IEnumerable<Loan> queryForLoans = loans.OrderBy(x => x.CreationTime).ThenBy(x=> x.Sum);

            foreach (Loan loan in queryForLoans)
            {
                Console.WriteLine("{0} - {1} - {2}", loan.Name, loan.CreationTime, loan.Sum);
            }
            Console.WriteLine();
            IEnumerable<Loan> queryForLoans2 = loans.OrderByDescending(x => x.Sum);

            foreach (Loan loan in queryForLoans2)
            {
                Console.WriteLine("{0} - {1} - {2}", loan.Name, loan.CreationTime, loan.Sum);
            }


            // group by
            var loanGroupBy = loans.GroupBy(x => x.CreationTime);

            // conat
            char[] sequence1 = { 'p', 'q', 'r', 's', 'y', 'z' };
            char[] sequence2 = { 'p', 'm', 'o', 'e', 'c', 'z' };
            var result = sequence1.Concat(sequence2);
            Console.WriteLine("New Sequence:");
            foreach (var val in result)
            {
                Console.WriteLine(val);
            }
            // union will exclude duplicate, others - intersect, except

            // conversion methods - toDictionary
            List<Product> listProducts = new List<Product>
            {
                new Product { ID= 1001, Name = "Mobile", Price = 800 },
                new Product { ID= 1002, Name = "Laptop", Price = 900 },
                new Product { ID= 1003, Name = "Desktop", Price = 800 }
            };
            Dictionary<int, Product> productsDictionary = listProducts.ToDictionary(x => x.ID);
            foreach (KeyValuePair<int, Product> kvp in productsDictionary)
            {
                Console.WriteLine(kvp.Key + " Name : " + kvp.Value.Name + ", Price: " + kvp.Value.Price);
            }
 
            // element operatoss - ElementAt
            string[] names =
            { "Hartono, Tommy", "Adams, Terry", "Andersen, Henriette Thaulow",

            "Hedlund, Magnus", "Ito, Shu" };
            Random random = new Random(DateTime.Now.Millisecond);

            string name = names.ElementAt(random.Next(0, names.Length));


            // aggregation methods
            IEnumerable<int> items = new List<int> { 8, 3, 2 };

            // these two lines do the same
            long count = items.Where(x => x < 5).LongCount();  // count: 2
            long count2 = items.LongCount(x => x < 5);          // count: 2
            int count3 = items.Count(x => x < 5);
            // there are more like Min, Max, Sum, Average, Aggregate


            bool hasElements = listProducts.Any();
            IEnumerable<int> squares = Enumerable.Range(1, 10).Select(x => x * x);

            // anonymous methods
            Func<string, string> someFunc = delegate (string someVariable)
            {
                return "hello " + someVariable;
            };
            // lambda function
            Func<string, string> someFunc2 = someVariable => "hi lambda";

            // invoke
            string str = someFunc("fox");
            Console.WriteLine(str);
        }
    }
}







/*
closure is a function along with its lexical environment
(available variables and their values) when the function is created
it can be inferred that Closure remembers the values of the variables during its creation
 when a local variable is capturec into a closure a helper class is created and the variable is transformed into property
 closures - anonymous methods, delegates, and lambda expressions
 closure - first-class function containing free variables environment
A closure is defined as a first-class function containing free variables bound in the lexical environment.The C# programming language treats the first-class function as though it were a first-class data type. This means that you can assign the function to a variable, invoke it, or pass it around much the same way you work with any other first-class data type.

A closure is a particular type of function that is intrinsically
linked to the environment in which it is referenced.
As a result, closures can use variables pertaining to
the referencing environment, despite these values being
outside the scope of the closure.
*/
