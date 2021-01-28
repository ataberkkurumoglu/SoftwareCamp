using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsWork
{
    class NList<T>
    {
        T[] items;
        public NList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {          
            T[] tempA = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempA.Length; i++)
            {
                items[i]= tempA[i];
            }
            items[items.Length - 1] = item;
        }
        public int Length
        {
            get { return items.Length; }
        }
    }
}
