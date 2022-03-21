using System;
namespace Decorator
{

    public class Account
    {
        // The client code works with all objects using the Component interface.
        // This way it can stay independent of the concrete classes of
        // components it works with.
        public void AccountInput(Component component)
        {
            Console.WriteLine("[finally] " + component.PerformAction());
        }
    }
}
