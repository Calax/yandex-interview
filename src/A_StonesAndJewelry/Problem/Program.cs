using System;

namespace Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string j = Console.ReadLine();
            string s = Console.ReadLine();

            var result = StonesAndJewelry.CalculateJewelry(s, j);

            Console.WriteLine(result);
        }
    }

        public class StonesAndJewelry
    {
        public static int CalculateJewelry(string s, string j)
        {
            int result = 0;

            foreach (char ch in s)
            {
                if (j.IndexOf(ch) >= 0)
                {
                    ++result;
                }
            }

            return result;
        }
    }
}
