using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedQueue
{
    public class LinkedQueue<T>
    {
        private Node<T> _lastNode;

        public void Push(T value)
        {
            _lastNode = new Node<T>(value, _lastNode);
        }

        public void Pop()
        {
            _lastNode = _lastNode.previousNode;
        }

        public int Size()
        {
            Node<T> test = _lastNode;
            int i = 0;
            while (test != null)
            {
                i++;
                test = test.previousNode;
            }

            return i;
        }
    }
}
