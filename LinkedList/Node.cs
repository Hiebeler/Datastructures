using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList
{ 
    public class Node
    {
        public object Value { get; set; }
        public Node? nextNode;

        public Node(object value)
        {
            nextNode = null;
            Value = value;
        }
    }
}
