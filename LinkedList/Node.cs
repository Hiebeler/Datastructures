using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedQueue
{
    internal class Node<T>
    {
        public T Value { get; set; }
        public Node<T> previousNode;

        public Node(T value, Node<T> _previousNode)
        {
            previousNode = _previousNode;
            Value = value;
        }
    }
}
