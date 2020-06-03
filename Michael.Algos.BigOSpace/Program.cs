using System;
using System.Collections.Generic;

namespace Michael.Algos.BigOSpace
{
    class Program
    {
        private static IDictionary<int, int> cacheDyn;

        static Program()
        {
            cacheDyn = new Dictionary<int, int>();
            cacheDyn.Add(0, 0);
            cacheDyn.Add(1, 1);
        }

        static void Main(string[] args)
        {
            var n = 10;
            Console.WriteLine(fibRecursive(n));
            Console.WriteLine(fibDyn(n));
            Console.WriteLine(fibItr(n));
        }

        // space O(n)
        private static int fibRecursive(int n)
        {
            if (n < 0)
                throw new ArgumentOutOfRangeException(nameof(n));
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;

            return fibRecursive(n - 1) + fibRecursive(n - 2);
        }

        // space O(n)
        private static int fibDyn(int n)
        {
            if (n < 0)
                throw new ArgumentOutOfRangeException(nameof(n));

            if (cacheDyn.ContainsKey(n))
                return cacheDyn[n];

            var res = fibDyn(n - 1) + fibDyn(n - 2);
            cacheDyn.Add(n, res);
            return res;
        }

        // space O(3)
        private static int fibItr(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;

            var prev2 = 0;
            var prev1 = 1;
            var f = prev2 + prev1;

            for (var i = 2; i <= n; i++)
            {
                f = prev2 + prev1;
                prev2 = prev1;
                prev1 = f;
            }

            return f;
        }
    }
}
