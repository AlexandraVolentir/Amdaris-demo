using System;
namespace Observer_pattern
{
    class CustomerObserverTypeB : IObserver
    {
        public void UpdateStock(ISubject subject)
        {
            if ((subject as Subject).StockState == 0 || (subject as Subject).StockState >= 2)
            {
                Console.WriteLine("CustomerOberverTypeB was sent a notification on stock change");
            }
        }
    }
}
