using System;
namespace IoC
{
    interface ITicketNotificatorService
    {
        void NotifyTicketDelegation(Worker worker); 
    }
}
