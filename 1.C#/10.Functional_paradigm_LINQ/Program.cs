using System;

namespace Functional_paradigm_LINQ
{
    class MainClass: IEn
    {
        public static void Main(string[] args)
        {
            int[] nums = new int[] { 0, 1, 2 };
            var res = from a in nums where a < 3 orderby a select a;
            foreach (int i in res)
            Console.WriteLine(i);
        }
    }
}
