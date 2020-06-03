namespace Michael.Algos.HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var table = new System.Collections.Hashtable(); // O(n)
            table.Add(1, 1);    // O(1)
            table.Add(2, 2);

            if (table.Contains(1))
            {
                var x = table[1];   // O(1)
            }
            
            table.Remove(1);    // O(1)
        }
    }
}
