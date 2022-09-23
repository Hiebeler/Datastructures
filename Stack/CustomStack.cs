using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class CustomStack<T>
    {
        private Node<T> _lastNode;

        public void push(T value)
        {
            _lastNode = new Node<T>(value, _lastNode);
        }

        public void pop()
        {
            _lastNode = _lastNode.previousNode;
        }

        public int size()
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
