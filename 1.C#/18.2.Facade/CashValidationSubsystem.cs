using System;
namespace Facade
{
    public class CashValidationSubsystem
    {
        public string firstAction()
        {
            return "CashValidationSubsystem: Cash operation was validated\n";
        }

        public string lastAction()
        {
            return "CashValidationSubsystem: Cash eliberated\n";
        }
    }
}


