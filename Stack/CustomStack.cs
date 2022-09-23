using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    internal class CustomStack<T>
    {
        List<T> list = new List<T>();

        public void push(T item)
        {
            list.Add(item);
        }

        public void pop()
        {
            list.RemoveAt(list.Count - 1);
        }

        public int size()
        {
            return list.Count();
        }
    }
}
