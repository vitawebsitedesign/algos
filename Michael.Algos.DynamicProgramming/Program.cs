using System;
using System.Collections.Generic;

namespace Michael.Algos.DynamicProgramming
{
    class Program
    {
        private static IDictionary<int, int> cache = new Dictionary<int, int>();

        static void Main(string[] args)
        {
            Console.WriteLine(fibDyn(10));
        }

        private static int fibDyn(int n)
        {
            if (n < 0)
                throw new ArgumentOutOfRangeException(nameof(n));

            if (cache.ContainsKey(n))
                return cache[n];

            var res = fibDyn(n - 1) + fibDyn(n - 2);
            cache.Add(n, res);
            return res;
        }
    }
}
