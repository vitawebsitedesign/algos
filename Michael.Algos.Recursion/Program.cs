using System;

namespace Michael.Algos.Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(fibRecursive(10));
        }

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
    }
}
