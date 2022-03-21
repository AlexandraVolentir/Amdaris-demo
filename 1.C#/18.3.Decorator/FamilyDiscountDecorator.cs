using System;
namespace Decorator
{
    // Decorators can execute their behavior either before or after the call to
    // a wrapped object.
    class FamilyDiscountecorator : Decorator
    {
        public FamilyDiscountecorator(Component comp) : base(comp)
        {
        }

        public override string PerformAction()
        {
            return $"FamilyDiscountecorator({base.PerformAction()})";
        }
    }
}
