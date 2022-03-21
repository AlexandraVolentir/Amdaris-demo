using System;

/*
 Proxy is a structural design pattern that provides an object
that acts as a substitute for a real service object used by a client.
A proxy receives client requests, does some work (access control, caching, etc.)
and then passes the request to a service object.
 */

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount client = new BankAccount();
            Console.WriteLine("[Client] Entering credentials for his bank account:");
            RealAction subj = new RealAction();
            client.ProcessSubjectClient(subj);
            Console.WriteLine();
            Console.WriteLine("[Client] Executing the same client code with a proxy:");
            Proxy proxy = new Proxy(subj);
            client.ProcessSubjectClient(proxy);
        }
    }
}

