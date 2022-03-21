using System;

namespace Proxy
{

    // The Proxy has an interface identical to the RealSubject.
    class Proxy : ISubject
    {
        private RealAction _action;

        public Proxy(RealAction realSubject)
        {
            this._action = realSubject;
        }

        // lazy loading,caching, controlling the access, logging, etc.
        // can perform one of these things and then, depending on the result, pass the
        // execution to the same method in a linked RealSubject object.
        public void Request()
        {
            if (this.CheckAccess())
            {
                this._action.Request();

                this.LogAccess();
            }
        }

        public bool CheckAccess()
        {
            // Some real checks 
            Console.WriteLine("[Proxy] Validate access for bank account");

            return true;
        }

        public void LogAccess()
        {
            Console.WriteLine("[Proxy] Logged in the system the time of request.");
        }
    }
}
