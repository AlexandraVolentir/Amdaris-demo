using System;
using System.Threading;

namespace Events
{
    public class AccountEventArgs : EventArgs
    {
        public Account Account { get; set; }
    }
    public class AccountAnalyser
    {
        // 1 - Define a delegate
        // 2 - Define an event based on that delegate
        // 3 - Raise the vent

        // first, declare a delegate that actually holds reference to a function that looks
        // like this: it is void, it has typically to parameters - the first one should
        // be of type object - the source of the event, whcih includes any additional name
        // about the event
        // delegate
        // so we can create a delegate explicitly
        //public delegate void AccountAnalysedHandler(object source, AccountEventArgs args); // it could be EventArgs as wel
        // second, define an event AccountAnalysed based on that delegate

        public event EventHandler<AccountEventArgs> AccountAnalysed;

        public void Analyze(Account account)
        {
            Console.WriteLine("Anayzing account....");
            Thread.Sleep(3000);
            // once the encoding is finished, we call this methods
            // we assume  that this method will notify all the subscribers
            OnAccountAnalysed(account);
        }

        // .NET suggests that event publisher methods should be protected, virtual and void
        // name should start with On
        // this methods has the purpose of notifying subscribers
        protected virtual void OnAccountAnalysed(Account account)
        {
            // if there are any subscribers, we are going to call them, passing refference to account analyser and no additional data
            if(AccountAnalysed != null)
            {
                AccountAnalysed(this, new AccountEventArgs(){ Account = account }); // returns an instance of event args which is empty- EventArgs.Empty
            }

        }
    }
}