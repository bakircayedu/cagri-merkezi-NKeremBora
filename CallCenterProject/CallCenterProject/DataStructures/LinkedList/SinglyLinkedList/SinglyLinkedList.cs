using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenterProject.DataStructures.LinkedList.SinglyLinkedList
{
    public class SinglyLinkedList<T> : IEnumerable<T>
    {
        private bool _isHeadNull => Head == null;
        public SinglyLinkedListNode<T> Head { get; set; }
        public int Size { get; set; }

        public void AddFirst(T value)
        {
            SinglyLinkedListNode<T> newNode = new(value);
            if (_isHeadNull)
            {
                Head = newNode;
                Size++;
                return;
            }
            newNode.Next = Head;
            Head = newNode;
            Size++;
        }
        public void AddLast(T value)
        {
            var current = Head;
            SinglyLinkedListNode<T> newNode = new(value);
            if (_isHeadNull)
            {
                Head = newNode;
                Size++;
                return;
            }
            while(current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
            Size++;
        }
        public void AddAfter(SinglyLinkedListNode<T> node, T value)
        {
            if (node == null) throw new ArgumentNullException();
            if (_isHeadNull)
            {
                AddFirst(value);
                return;
            }

            SinglyLinkedListNode<T> newNode = new(value);
            var current = Head;

            while(current != null)
            {
                if (current.Equals(node))
                {
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    Size++;
                    return;
                }
                current = current.Next;
            }
            throw new ArgumentException("the reference node is not in this list.");
        }
        public void AddBefore(SinglyLinkedListNode<T> node, T value)
        {
            if (node == null) throw new ArgumentNullException();
            if (_isHeadNull)
            {
                AddFirst(value);
                return;
            }
            if(Head == node)
            {
                AddFirst(value);
                return;
            }
            SinglyLinkedListNode<T> newNode = new(value);
            var current = Head.Next;
            var temp = Head;
            while(current != null)
            {
                if (current.Equals(node))
                {
                    newNode.Next = current;
                    temp.Next = newNode;
                    Size++;
                    return;
                }
                temp = temp.Next;
                current = current.Next;
            }
        }
        public T RemoveFirst()
        {
            if (_isHeadNull)  throw new Exception("Underflow! Nothing to remove.");

            var firstValue = Head.Value;
            Head = Head.Next;
            return firstValue;
            
        }
        public T RemoveLast()
        {
            if (_isHeadNull) throw new Exception("Underflow! Nothing to remove.");

            var current = Head;
            var temp = Head;
            T lastValue;
            if(current.Next == null)
            {
                lastValue = Head.Value;
                Head = null;
                return lastValue;
            }
            while(current.Next != null)
            {
                temp = current;
                current = current.Next;
            }
            lastValue = current.Value;
            temp.Next = null;
            return lastValue;
        }
        public void Remove(T value)
        {
            if (_isHeadNull) throw new Exception("Underflow! Nothing to remove.");
            if (value == null) throw new ArgumentNullException();
            var current = Head.Next;
            var temp = Head;
            if (Head.Value.Equals(value))
            {
                Head = current;
                return;
            }
            while(current != null)
            {
                if (current.Value.Equals(value))
                {
                    temp.Next = current.Next;
                    return;
                }
                current = current.Next;
                temp = temp.Next;
            }
        }
        public List<T> Clone()
        {
            var clone = new List<T>();
            foreach (var item in this)
                clone.Add(item);
            return clone;

        }

        public IEnumerator<T> GetEnumerator()
        {
            return new SinglyLinkedListEnumerator<T>(Head);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
