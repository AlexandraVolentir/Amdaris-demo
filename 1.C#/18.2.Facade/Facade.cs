using System;
namespace Facade
{
    public class Facade
    {
        protected PasswordValidationSubsystem _subsystem1;

        protected CashValidationSubsystem _subsystem2;

        public Facade(PasswordValidationSubsystem subsystem1, CashValidationSubsystem subsystem2)
        {
            this._subsystem1 = subsystem1;
            this._subsystem2 = subsystem2;
        }

        public string Operation()
        {
            string finalResult = "Preparing the working systems.........:\n";
            finalResult += this._subsystem1.firstAction();
            finalResult += this._subsystem2.firstAction();
            finalResult += "Put subsystems at work:\n";
            finalResult += this._subsystem1.lastAction();
            finalResult += this._subsystem2.lastAction();
            return finalResult;
        }
    }
}
