using System;
using System.Collections.Generic;
using System.Threading;

namespace Observer_pattern
{
    // The Subject owns some important state and notifies observers when the
    // state changes.
    public class Subject : ISubject
    {
        // For the sake of simplicity, the Subject's state, essential to all
        // subscribers, is stored in this variable.
        public int StockState { get; set; } = 0;

        // List of subscribers. In real life, the list of subscribers can be
        // stored more comprehensively (categorized by event type, etc.).
        private List<IObserver> _listOfObservers = new List<IObserver>();

        // The subscription management methods.
        public void Attach(IObserver observer)
        {
            Console.WriteLine("Subject: Attached an observer.");
            this._listOfObservers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            this._listOfObservers.Remove(observer);
            Console.WriteLine("Subject: Detached an observer.");
        }

        // Trigger an update in each subscriber.
        public void Notify()
        {
            Console.WriteLine("Subject: Notifying clients...");

            foreach (var observer in _listOfObservers)
            {
                observer.UpdateStock(this);
            }
        }

        // Usually, the subscription logic is only a fraction of what a Subject
        // can really do. Subjects commonly hold some important business logic,
        // that triggers a notification method whenever something important is
        // about to happen (or after it).
        public void StockSituation()
        {
            Console.WriteLine("\nSubject: I am importing new clothes and items");
            this.StockState = new Random().Next(0, 10);

            Thread.Sleep(15);

            Console.WriteLine("Subject: My stock state has just changed to: " + this.StockState);
            this.Notify();
        }
    }
}
