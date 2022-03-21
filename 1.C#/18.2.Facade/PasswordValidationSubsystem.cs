using System;
namespace Facade
{
    public class PasswordValidationSubsystem
    {
        public string firstAction()
        {
            return "PasswordValidationSubsystem: Password was validated\n";
        }

        public string lastAction()
        {
            return "PasswordValidationSubsystem: Access to card is permited\n";
        }
    }
}

