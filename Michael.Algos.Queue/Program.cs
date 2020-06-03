using System.Collections.Generic;

namespace Michael.Algos.Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            var q = new Queue<int>();
            q.Enqueue(1);
            q.Peek();
            q.Dequeue();
        }
    }
}
