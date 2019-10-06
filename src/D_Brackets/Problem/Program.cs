using System;

namespace Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var writer = new ConsoleWriter();
            var generator = new BracketGenerator(writer);
            generator.Gen(n, 0, 0, "");
        }

        private class ConsoleWriter : IWriter
        {
            public void Dispose() { }

            public void WriteLine(string s)
            {
                Console.WriteLine(s);
            }
        }
    }

    public class BracketGenerator
    {
        private IWriter writer;
        public BracketGenerator(IWriter writer)
        {
            this.writer = writer;
        }

        public void Gen(int n, int oCount, int cCount, string str)
        {
            if(str.Length == 2 * n){
                writer.WriteLine(str);
                return;
            }

            if(oCount < n)
            {
                Gen(n, oCount + 1, cCount, str + "(");
            }

            if(oCount > cCount){
                Gen(n, oCount, cCount + 1, str + ")");
            }
        }
    }

    public interface IWriter
    {
        void WriteLine(string s);
    }
}
