using System;
namespace IoC
{
    public class ConsoleNotification : ITicketNotificatorService
    {
        public void NotifyTicketDelegation(Worker worker)
        {
            Console.WriteLine($"The ticket has been delegated to: {worker.Name}");
        }
    }
}
