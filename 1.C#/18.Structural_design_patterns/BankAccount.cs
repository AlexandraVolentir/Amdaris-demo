using System;
using Proxy;

namespace Proxy
{
    public class BankAccount
    {
        public void ProcessSubjectClient(ISubject subject)
        {
            subject.Request();
        }
    }
}
