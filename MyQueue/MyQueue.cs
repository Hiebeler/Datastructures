using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQueue
{
    public class MyQueue
    {
        private SingleLinkedList.SingleLinkedList internalList = new SingleLinkedList.SingleLinkedList();

        public object Enqueue(object argValue)
        {
            internalList.InsertLast(argValue);
            return argValue;
        }

        public Node Dequeue()
        {
            var retval = internalList.First();
            internalList.DeleteFirst();
            return retval;
        }

        public override string ToString()
        {
            return internalList.ToString();
        }

    }
}
