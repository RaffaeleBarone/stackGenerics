using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class GenericStack<T>
{
    private Stack<T> _stack;

    public GenericStack()
    {
        _stack = new Stack<T>();
    }

    public void Push(T item)
    {
        _stack.Push(item);
    }

    public T Pop()
    {
        if (_stack.Count == 0)
        {
            throw new InvalidOperationException("Lo stack è vuoto");
        }

        return _stack.Pop();
    }

    public T Peek()
    {
        if (_stack.Count == 0)
        {
            throw new InvalidOperationException("Lo stack è vuoto");
        }
        return _stack.Peek();
    }
}