using Common;
using SingleLinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class MyStack
    {
        private SingleLinkedList.SingleLinkedList internalList = new SingleLinkedList.SingleLinkedList();

        public object Push(object argValue)
        {
            internalList.InsertLast(argValue);
            return argValue;
        }

        public Node Pop()
        {
            var retval = internalList.Last();
            internalList.DeleteLast();
            return retval;
        }

        public override string ToString()
        {
            return internalList.ToString();
        }

    }
}