using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_paradigm_LINQ
{
    public class Account
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int YearsOfMembership { get; set; }
        public DateTime BirthDate { get; set; }
        public string FullName
        {
            get
            {
                return $"{ FirstName } { LastName }";
            }
        }
    }
}