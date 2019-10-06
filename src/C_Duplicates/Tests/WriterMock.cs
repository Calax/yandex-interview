using System.Collections.Generic;
using Problem;

internal class WriterMock : IWriter
{
    private Queue<int> q = new Queue<int>();

    public void Dispose()
    {
        q.Clear();
    }

    public void WriteNumber(int number)
    {
        q.Enqueue(number);
    }

    internal int GetNumber()
    {
        return q.Dequeue();
    }
}