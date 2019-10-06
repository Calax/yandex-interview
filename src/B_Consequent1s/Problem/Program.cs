using System;

namespace Problem
{
    class Program
    {
        private class ConsoleReader : IReader
        {
            public void Dispose()
            {
            }

            public string ReadLine()
            {
                return Console.ReadLine();
            }
        }


        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var max = 0;

            using (var calculator = new ConsequentOnesCalculator(new ConsoleReader()))
            {
                max = calculator.GetOnesLongestSequenceLength(n);
            }

            Console.WriteLine(max);
        }
    }

    public class ConsequentOnesCalculator : IDisposable
    {
        private readonly IReader reader;

        public ConsequentOnesCalculator(IReader reader)
        {
            this.reader = reader;
        }

        public int GetOnesLongestSequenceLength(int n)
        {
            int max = 0;
            int cur = 0;

            for (int i = 0; i < n; i++)
            {
                int s = int.Parse(reader.ReadLine());

                if (s == 1) cur++;
                else cur = 0;

                if (cur > max) max = cur;
            }

            return max;
        }

        public void Dispose()
        {
            reader.Dispose();
        }
    }

    public interface IReader : IDisposable
    {
        string ReadLine();
    }
}
