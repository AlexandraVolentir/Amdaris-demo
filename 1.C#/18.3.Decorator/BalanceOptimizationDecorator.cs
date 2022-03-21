using System;
namespace Decorator
{
    // Concrete Decorators call the wrapped object and alter its result in some
    // way.
    class BalanceOptimizationDecorator : Decorator
    {
        public BalanceOptimizationDecorator(Component comp) : base(comp)
        {
        }

        // Decorators may call parent implementation of the operation, instead
        // of calling the wrapped object directly. This approach simplifies
        // extension of decorator classes.
        public override string PerformAction()
        {
            return $"BalanceOptimizationDecorator({base.PerformAction()})";
        }
    }
}
