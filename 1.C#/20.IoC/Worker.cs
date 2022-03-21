using System;
namespace IoC
{
    public class Worker
    {
      
        private ITicketNotificatorService _notificationService;
        public string Name { get; private set; }
        internal Worker(string username, ITicketNotificatorService notificationService)
        {
            Name = username;
            //_notificationService = new ConsoleNotification(); -it would have been a dependency
            // but we inject instead

            _notificationService = notificationService;

        }
        public void DelegateTicket(string newUsername)
        {
             Name = newUsername;
            _notificationService.NotifyTicketDelegation(this);
        }
    }
}
