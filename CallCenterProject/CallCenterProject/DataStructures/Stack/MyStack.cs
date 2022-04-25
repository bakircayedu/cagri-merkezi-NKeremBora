using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenterProject.DataStructures.Stack
{
    public class MyStack<T>
    {
        private readonly IStack<T> _stack;
        public int Count => _stack.Count;

        public MyStack(StackType type = StackType.Array)
        {
            if (type == StackType.Array)
            {
                _stack = new ArrayStack<T>();
            }
            else
            {
                _stack = new LinkedListStack<T>();
            }
        }

        public void Push(T item)
        {
            _stack.Push(item);
        }

        public T Pop()
        {
            return _stack.Pop();
        }
        
    }
}
