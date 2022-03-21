using System;

namespace IoC
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var notificationService = new C();
            var worker1 = new Worker("Michael Jones", notificationService );
            worker1.DelegateTicket("Sarah Deans");
            Console.ReadKey();
        }
    }
}
