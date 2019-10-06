using System.Collections;
using System.Collections.Generic;
using Problem;

namespace Tests
{
    internal class ReaderStub : IReader
    {
        private Queue<string> q;
        internal ReaderStub(string[] lines)
        {
            q = new Queue<string>();
            for (int i = 0; i < lines.Length; i++)
                q.Enqueue(lines[i]);
        }

        public void Dispose()
        {
        }

        public string ReadLine()
        {
            return q.Dequeue();
        }
    }
}
