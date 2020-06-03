using System.Collections.Generic;
using System.Linq;

namespace Michael.Algos.ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>();
            list.AddRange(Enumerable.Range(1, 10)); // space O(n)

            list.Add(1);        // time O(1)
            list.Remove(1);     // time O(n)
        }
    }
}
