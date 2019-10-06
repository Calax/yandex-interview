using System.Collections.Generic;
using Problem;

internal class ReaderStub : IReader
{
    private Queue<int> q;
    public ReaderStub(int[] inputs)
    {
        q = new Queue<int>();
        for (int i = 0; i < inputs.Length; i++)
        {
            q.Enqueue(inputs[i]);
        }
    }

    public void Dispose()
    {

    }

    public int ReadNumber()
    {
        return q.Dequeue();
    }
}