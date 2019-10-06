using System.Collections.Generic;
using Problem;

internal class WriterMock : IWriter
{
    private Queue<string> q = new Queue<string>();

    public void WriteLine(string s)
    {
        q.Enqueue(s);
    }

    internal string GetLine()
    {
        return q.Dequeue();
    }
}