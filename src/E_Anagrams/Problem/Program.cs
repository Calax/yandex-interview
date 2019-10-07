using System;
using System.Collections.Generic;

namespace Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = Console.ReadLine();
            var s2 = Console.ReadLine();

            var anagrams = AnagramDetector.AreAnagrams(s1, s2);

            Console.WriteLine(anagrams ? "1" : "0");
        }
    }

    public static class AnagramDetector
    {
        public static bool AreAnagrams(string s1, string s2)
        {
            var dict = new Dictionary<char, int>();

            char key;
            int val;
            for (int i = 0; i < s1.Length; i++)
            {
                key = s1[i];

                if (dict.TryGetValue(key, out val))
                {
                    ++dict[key];
                }
                else
                {
                    dict[key] = 1;
                }
            }

            for (int i = 0; i < s2.Length; i++)
            {
                key = s2[i];
                if (dict.TryGetValue(key, out val))
                {
                    --dict[key];
                }
                else
                {
                    dict[key] = -1;
                }
            }

            bool res = true;
            foreach (var resVal in dict.Values)
            {
                res &= resVal == 0;
            }

            return res;
        }
    }
}
