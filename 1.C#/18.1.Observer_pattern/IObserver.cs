using System;
namespace Observer_pattern
{
    public interface IObserver
    {
        // Receive update from subject
        void UpdateStock(ISubject subject);
    }
}
