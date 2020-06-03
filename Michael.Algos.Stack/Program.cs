using System.Collections.Generic;

namespace Michael.Algos.Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<int>();
            stack.Push(1);
            stack.Peek();
            stack.Pop();
        }
    }
}
