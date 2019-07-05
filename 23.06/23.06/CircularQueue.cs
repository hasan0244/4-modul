using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._06
{
    public class CircularQueue<T>
    {
        private T[] elements;
        private int startIndex=0;
        private int endIndex=0;
        private const int DefaultCapacity = 16;
        public int Count { get; private set; }

        public CircularQueue()
        {
            elements = new T[16];
        }
        public void Enqueue(T element)
        {
            if(Count==elements.Length)
            {
                Grow();
            }
            elements[endIndex] = element;
            endIndex = (endIndex + 1) % elements.Length;
            Count++;
        }

        private void Grow()
        {
            T[] newElements = new T[elements.Length + 2];
            CopyAllElementsTo(newElements);
            elements = newElements;
            startIndex = 0;
            startIndex = Count;
        }

        private void CopyAllElementsTo(T[] newElements)
        {
            int sourceIndex = startIndex;
            int destinationIndex = 0;
            for (int i = 0; i < Count; i++)
            {
                newElements[destinationIndex] = elements[sourceIndex];
                sourceIndex = (sourceIndex + 1) % elements.Length;
                destinationIndex++;
            }
        }

        public T Dequeue()
        {
            if (Count == 0)
                throw new InvalidOperationException();
            T result = elements[startIndex];
            startIndex = (startIndex + 1) % elements.Length;
            Count--;
            return result;          
        }
        public T[] ToArray()
        {
            var reusltArr = new T[Count];
            CopyAllElementsTo(reusltArr);
            return reusltArr;
        }

    }
}
