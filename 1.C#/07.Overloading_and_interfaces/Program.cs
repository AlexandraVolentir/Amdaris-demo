using System;

namespace Overloading_and_interfaces
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Angle angle1 = new Angle(2,45,23);
            Angle angle2 = new Angle(4, 45, 23);
            Angle angle3 = angle1 + angle2;
            angle1.ComputeAngle();
            angle2.ComputeAngle();
            Console.WriteLine("The sum of the angles is: ");
            angle3.ComputeAngle();
            //angle1.ComputeAngle();
        }
    }
}
