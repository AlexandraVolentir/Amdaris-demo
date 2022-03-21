using System;
namespace Csharp_4_6_7_8
{
    public class A { }
    public class B : A { }
    public class Bank
    {
        public Bank()
        {
            dateTime = new DateTime(4, 5, 2001);
        }
        DateTime dateTime;
        private string _bankName;
        public string BankName
        {
            get { return _bankName; }
            set
            {
                if(value.Length >= 4)
                {
                    _bankName = value;
                }
            }
        }
        public int NumberOfClients
        {
            get; set;
        }
        public string _bankInfo() => _bankName + NumberOfClients.ToString();
        public int BankActivity() => (int)(DateTime.Now - dateTime).TotalDays / 365;
        public DateTime CuurencyUpdate { get; } = DateTime.Now;
    }
}
