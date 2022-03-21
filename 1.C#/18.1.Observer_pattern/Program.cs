using System;
/*
 * 
 * Observer is a behavioral design pattern that allows some objects to 
 * notify other objects about changes in their state.
   The Observer pattern provides a way to subscribe and unsubscribe to and
   from these events for any object that implements a subscriber interface.
 */


namespace Observer_pattern
{
  
    class Program
    {
        static void Main(string[] args)
        {
            // The client code.
            var subject = new Subject();
            var observerA = new CustomerObserverTypeA();
            subject.Attach(observerA);

            var observerB = new CustomerObserverTypeB();
            subject.Attach(observerB);

            subject.StockSituation();
            subject.StockSituation();

            subject.Detach(observerB);

            subject.StockSituation();
        }
    }
}