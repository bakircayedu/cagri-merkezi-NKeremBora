using CallCenterProject.DataStructures.LinkedList.SinglyLinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenterProject.DataStructures.Stack
{
    public class LinkedListStack<T> : IStack<T>
    {
        private readonly SinglyLinkedList<T> list = new();
        public int Count { get; private set; }

        public void Clear()
        {
            list.Head = null;
        }

        public T Peek()
        {
            if (Count == 0) throw new Exception("Empty stack!");
            return list.Head.Value;
        }

        public T Pop()
        {
            if (Count == 0) throw new Exception("Empty stack!");
            Count--;
            return list.RemoveFirst();
        }

        public void Push(T item)
        {
            if (item == null) throw new ArgumentNullException("item");
            list.AddFirst(item);
            Count++;
        }
    }
}
