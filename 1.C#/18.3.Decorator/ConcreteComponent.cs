// Concrete Components provide default implementations of the operations.
// There might be several variations of these classes.
namespace Decorator
{
    class BasicComponent : Component
    {
        public override string PerformAction()
        {
            return "The most basic component";
        }
    }
}
