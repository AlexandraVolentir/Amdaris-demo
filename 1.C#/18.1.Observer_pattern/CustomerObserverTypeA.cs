using System;
namespace Observer_pattern
{
    public class CustomerObserverTypeA : IObserver
    {
        public void UpdateStock(ISubject subject)
        {
            if ((subject as Subject).StockState < 3)
            {
                Console.WriteLine("CustomerOberverTypeA was sent a notification on stock change");
            }
        }
    }
}
