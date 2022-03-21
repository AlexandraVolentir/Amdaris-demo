using System;

namespace Advanced_LINQ
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
