using System;

/*
 Decorator is a structural pattern that allows adding new behaviors
to objects dynamically by placing them inside special wrapper objects.
 */

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Account client = new Account();
            BasicComponent basic = new BasicComponent();
            Console.WriteLine("[Client] having a basic component");
            client.AccountInput(basic);
            Console.WriteLine();

            BalanceOptimizationDecorator decorator1 = new BalanceOptimizationDecorator(basic);
            FamilyDiscountecorator decorator2 = new FamilyDiscountecorator(decorator1);
            Console.WriteLine("[Client] having a decorated component");
            client.AccountInput(decorator2);
        }
    }
}