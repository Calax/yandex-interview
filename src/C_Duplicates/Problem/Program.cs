using System;

namespace Problem
{
    class Program
    {
        private class ConsoleReader : IReader
        {

            public void Dispose() { }

            public int ReadNumber()
            {
                return int.Parse(Console.ReadLine());
            }
        }

        private class ConsoleWriter : IWriter
        {
            public void Dispose() { }

            public void WriteNumber(int number)
            {
                Console.WriteLine(number);
            }
        }

        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            using (var reader = new ConsoleReader())
            using (var writer = new ConsoleWriter())
            {
                var calculator = new DuplicateCalculator(reader, writer);
                calculator.WriteUnique(n);                
            }
        }
    }

    public interface IReader : IDisposable
    {
        int ReadNumber();
    }

    public interface IWriter : IDisposable
    {
        void WriteNumber(int number);
    }

    public class DuplicateCalculator
    {
        private readonly IReader reader;
        private readonly IWriter writer;

        public DuplicateCalculator(IReader reader, IWriter writer)
        {
            this.reader = reader;
            this.writer = writer;
        }

        public void WriteUnique(int n)
        {
            if (n < 1) return;

            int s = reader.ReadNumber();
            var latest = s;
            writer.WriteNumber(latest);

            for (int i = 1; i < n; i++)
            {
                s = reader.ReadNumber();

                if (s > latest)
                {
                    latest = s;
                    writer.WriteNumber(latest);
                }
            }
        }
    }
}