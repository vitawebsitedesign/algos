using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Michael.Algos.BigOTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Palindrome("hannah"));
            Console.WriteLine(Reverse("apple banana carrot"));
            Console.WriteLine(SubstringExists("cat", "cat"));
            Console.WriteLine(SubstringExists("c", "c"));
            Console.WriteLine(SubstringExists("a", "a"));
            Console.WriteLine(SubstringExists("cax", "cat"));
        }

        // time O(n/2)
        private static bool Palindrome(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                throw new ArgumentException(s);

            var halfway = Math.Floor(s.Length / 2d);
            for (var i = 0; i < halfway; i++)
            {
                if (s[i] != s[s.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }


        // time O(n)
        private static string Reverse(string s)
        {
            if (s == null)
                throw new ArgumentNullException(nameof(s));

            var sanitized = Regex.Replace(s.Trim(), @"/\s+/g", " ");
            return string.Join(" ", sanitized.Split(" ").Reverse());
        }

        // time O(h + n)
        private static bool SubstringExists(string haystack, string needle)
        {
            if (haystack == null)
                throw new ArgumentNullException(nameof(haystack));
            if (needle == null)
                throw new ArgumentException(nameof(needle));

            return haystack.Contains(needle);
        }
    }
}
