using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenterProject.DataStructures.Stack
{
    public class ArrayStack<T>: IStack<T>
    {
        public int Count { get; private set; }
        private readonly List<T> list = new List<T>();

        public void Clear()
        {
            list.Clear();
        }

        public T Peek()
        {
            if (Count == 0) throw new Exception("Empty stack.");
            return list[list.Count - 1];
        }

        public T Pop()
        {
            if (Count == 0) throw new Exception("Empty stack.");
            var temp = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            Count--;
            return temp;
        }

        public void Push(T item)
        {
            if (item == null) throw new ArgumentNullException("value");
            list.Add(item);
            Count++;
        }
    }
}
