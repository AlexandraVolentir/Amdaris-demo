using System;
namespace Functional_paradigm_LINQ
{

    public class BubbleSorter
    {
        //public delegate bool IsAGreaterThanBDeleGate(object a, object b);

        public static void Sort<T>(T[] values, Func<T, T, bool> isAGreaterThanB)
        {
            bool swapped;
            do
            {
                swapped = false;

                for (int i = 0; i <= values.Length - 2; i++)
                {
                    if (isAGreaterThanB(values[i], values[i + 1]))
                    {
                        T temp = values[i];
                        values[i] = values[i + 1];
                        values[i + 1] = temp;
                        swapped = true;
                    }
                }
            } while (swapped);
        }
    }
}
