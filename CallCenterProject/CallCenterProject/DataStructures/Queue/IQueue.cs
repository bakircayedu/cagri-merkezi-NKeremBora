using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenterProject.DataStructures.Queue
{
    public interface IQueue<T>
    {
        
        int Count { get; }
        int Size { get; }
        void EnQueue(T item);
        T Peek();
        T DeQueue();
    }

    public enum QueueType
    {
        PriorityQueue = 0,
        CircularQueue = 1,
    }
}
