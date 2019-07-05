using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ArrayStack<T>
    {
        private T[] elements;
        public int Count { get; private set; }
        private const int InitialCapacity = 16;
        public ArrayStack(int capacity = InitialCapacity)
        {
            elements = new T[capacity];
        }
        public void Push(T element)
        {
            if (Count == elements.Length)
               Grow ();
            elements[Count] = element;
           Count++;
            
        }
        private void Grow()
        {
            Array.Resize(ref elements, elements.Length);
        }
        public T Pop()
        {
            if (Count==0)
            {
                throw new InvalidOperationException();
            }
            T element = elements[Count - 1];
            Count--;
            return element;
        }
        public T[] ToArray()
        {
            T[] newElements = new T[Count];
            Array.Copy(elements, newElements, Count);
            newElements = newElements.Reverse().ToArray();
            return newElements;
        }
        

    }
}
