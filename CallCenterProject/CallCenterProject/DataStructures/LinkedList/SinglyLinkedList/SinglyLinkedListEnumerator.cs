
using System.Collections;

namespace CallCenterProject.DataStructures.LinkedList.SinglyLinkedList
{
    public class SinglyLinkedListEnumerator<T> : IEnumerator<T>
    {
        // linkedliste foreach ile donemilken icin IEnumerator yapisina ihtiyac duyariz
        private SinglyLinkedListNode<T> _head;
        private SinglyLinkedListNode<T> _current;
        public SinglyLinkedListEnumerator(SinglyLinkedListNode<T> head)
        {
            _head = head;

        }
        public T Current => _current.Value;

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            _head = null;
        }

        public bool MoveNext()
        {
            if (_current == null)
            {
                _current = _head;
                return true;
            }
            else
            {
                _current = _current.Next;
                return _current != null;
            }
        }

        public void Reset()
        {
            _current = null;
        }
    }
}