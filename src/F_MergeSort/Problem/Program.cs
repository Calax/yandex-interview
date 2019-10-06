using System;
using System.Collections.Generic;
using System.Text;

namespace Problem
{
    public class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            if (n < 1) return;

            var lines = new Line[n];

            for (int i = 0; i < n; i++)
            {
                var str = Console.ReadLine();
                lines[i] = new Line(GetLength(str), ParseDigits(str));
            }

            var res = Merger.Merge(lines);

            Console.WriteLine(string.Join(" ", res.Values));
        }

        private class ConsoleReader : IReader
        {
            public string ReadLine()
            {
                return Console.ReadLine();
            }
        }

        public static int GetLength(string s)
        {
            StringBuilder d = new StringBuilder();
            int i = 0;
            while (s.Length > i && s[i] != ' ')
            {
                d.Append(s[i]);
                ++i;
            }
            return int.Parse(d.ToString());
        }


        public static IEnumerable<byte> ParseDigits(string s)
        {
            bool skippedFirst = false;

            StringBuilder d = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ')
                {
                    d.Append(s[i]);
                }
                else
                {
                    if (!skippedFirst)
                    {
                        skippedFirst = true;
                    }
                    else
                    {
                        yield return byte.Parse(d.ToString());
                    }
                    d.Clear();
                }
            }

            if (d.Length > 0 && skippedFirst)
                yield return byte.Parse(d.ToString());
        }
    }

    public interface IReader
    {
        string ReadLine();
    }

    public class Merger
    {
        public static Line Merge(Line[] source)
        {
            var lines = new List<Line>(source.Length);
            foreach (var line in source)
            {
                lines.Add(line);
            }

            lines.Sort((x, y) => x.Length.CompareTo(y.Length));

            Line smaller;
            Line smallest;

            while (lines.Count > 1)
            {
                smallest = lines[0];
                smaller = lines[1];

                lines.Remove(smaller);
                lines.Remove(smallest);
                lines.Add(new Line(smaller.Length + smallest.Length, Merge(smaller.Values, smallest.Values)));
            }

            return lines[0];
        }

        private static IEnumerable<byte> Merge(IEnumerable<byte> res, IEnumerable<byte> q)
        {
            bool iMove = true;
            bool jMove = true;

            using (var i = res.GetEnumerator())
            using (var j = q.GetEnumerator())
            {
                iMove = i.MoveNext();
                jMove = j.MoveNext();

                while (iMove && jMove)
                {
                    if (i.Current < j.Current)
                    {
                        yield return i.Current;
                        iMove = i.MoveNext();
                    }
                    else
                    {
                        yield return j.Current;
                        jMove = j.MoveNext();
                    }
                }

                if (iMove)
                {
                    do
                    {
                        yield return i.Current;
                    }
                    while (i.MoveNext());
                }

                if (jMove)
                {
                    do
                    {
                        yield return j.Current;
                    }
                    while (j.MoveNext());
                }
            }
        }
    }

    public class Line
    {
        public Line(int length, IEnumerable<byte> values)
        {
            Length = length;
            Values = values;
        }
        public int Length { get; }
        public IEnumerable<byte> Values { get; }
    }
}
