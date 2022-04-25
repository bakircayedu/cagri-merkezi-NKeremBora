namespace CallCenterProject.DataStructures.Queue
{
    public class CircularQueue<T>: IQueue<T>
    {
        private  T[]  list;
        private  int _rear = -1;
        private int _front = -1;
        public int Count { get; set; } = 0;
        public int Size { get; private set; }
        
        public CircularQueue(int _size)
        {
            list = new T[_size];
            Count = 0;
            Size = _size;
        }
       
        public T DeQueue()
        {
            if (Count == 0) throw new Exception("Queue is empty.");
            if (_front == Size - 1)
                _front = -1;
            ++_front;
            var temp = list[_front];
            list[_front] = default;
            Count--;
            return temp;
        }

        public void EnQueue(T item)
        {
            if (Count == Size) throw new Exception("Queue is full.");

            if (_rear == Size - 1)
                _rear = -1;
            _rear++;
            list[_rear] = item;
            Count++;
            return;
        }

        public T Peek()
        {
            if (Count == 0) throw new Exception("Queue is empty.");
            return list[_front];
        }

        public T[] Clone()
        {
            return list;
        }
       
    }
}