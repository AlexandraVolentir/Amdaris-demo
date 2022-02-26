using System;
using System.Collections;

namespace Overloading_and_interfaces
{
    class SpeedComparer : IComparer
    {
        int IComparer.Compare(object x, object y)
        {
            Car t1 = (Car)x;
            Car t2 = (Car)y;

            return t1.Speed.CompareTo(t2.Speed);
        }
    }
}
