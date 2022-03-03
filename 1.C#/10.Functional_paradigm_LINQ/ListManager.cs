using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_paradigm_LINQ
{
    public class ListManager
    {
        public static List<Account> LoadSampleData()
        {
            var output = new List<Account>();

            output.Add(new Account { FirstName = "Michael", LastName = "Campbell", BirthDate = Convert.ToDateTime("2/6/1990"), YearsOfMembership = 14 });
            output.Add(new Account { FirstName = "Gwendolyn", LastName = "Shepherd", BirthDate = Convert.ToDateTime("5/9/1999"), YearsOfMembership = 1 });
            output.Add(new Account { FirstName = "Jane", LastName = "Fairfax", BirthDate = Convert.ToDateTime("11/3/1998"), YearsOfMembership = 4 });
            output.Add(new Account { FirstName = "Andrei", LastName = "Miles", BirthDate = Convert.ToDateTime("3/6/2001"), YearsOfMembership = 7 });
            output.Add(new Account { FirstName = "Gideon", LastName = "Fairfax", BirthDate = Convert.ToDateTime("4/5/1969"), YearsOfMembership = 25 });
            output.Add(new Account { FirstName = "George", LastName = "Rickman", BirthDate = Convert.ToDateTime("4/8/1972"), YearsOfMembership = 10 });

            return output;
        }

    }
}
