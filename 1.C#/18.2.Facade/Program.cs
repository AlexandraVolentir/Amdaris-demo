using System;


// provides a simple interface to the complex logic of one/may subsystems
// it delegates the client requests to the
// appropriate objects within the subsystem. it is also responsible
// for managing their lifecycle. All of this protects the client from the
// undesired complexity of the subsystem.
namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            PasswordValidationSubsystem s1 = new PasswordValidationSubsystem();
            CashValidationSubsystem s2 = new CashValidationSubsystem();
            Facade facade1 = new Facade(s1, s2);
            Client.PerformAccountChanges(facade1);
        }
    }
}
