using System;
namespace Proxy
{
    // The ISubject interface declares common operations for both RealSubject and proxy
    // As long as the client works with RealAction using this
    // interface, you'll be able to pass it a proxy instead of a real subject.
    public interface ISubject
    {
        void Request();
    }
}
