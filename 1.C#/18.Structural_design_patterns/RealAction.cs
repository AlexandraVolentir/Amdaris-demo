using System;
namespace Proxy
{
   
    // capable of doing some useful work which may also be very slow or
    // sensitive - e.g. correcting input data, can solve these issues
    // without any changes to the RealAction's code.
    class RealAction : ISubject
    {
        public void Request()
        {
            Console.WriteLine("[RealAction] Fetch data and work on Request...");
        }
    }
}
