using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenterProject.DataStructures.Stack
{
    public interface IStack<T>
    {
        int Count { get; }
        void Clear();
        void Push(T item);
        T Peek();
        T Pop();
    }

    public enum StackType
    {
        Array = 0,
        linkedList = 1,
    }
}


