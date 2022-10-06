using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList
{
    public class SingleLinkedList
    {
        private Node head;

        public void InsertFront(object value)
        {
            Node newNode = new Node(value);
            if (head != null)
            {
                newNode.nextNode = head;
            }

            head = newNode;
        }

        public void InsertLast(object value)
        {
            Node newNode = new Node(value);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node currentNode = head;
                while (currentNode.nextNode != null)
                {
                    currentNode = currentNode.nextNode;
                }

                currentNode.nextNode = newNode;
            }
        }

        public void InsertAt(object value, int index)
        {
            if (index == 0)
            {
                InsertFront(value);
                return;
            }

            Node currentNode = head;
            Node perviosNode = head;
            int countIndex = 0;
            while (countIndex != index)
            {
                if (currentNode.nextNode == null)
                {
                    Console.WriteLine(index + " was out of Bounds");
                    return;
                }

                perviosNode = currentNode;
                currentNode = currentNode.nextNode;
                countIndex++;
            }

            perviosNode.nextNode = new Node(value);
            perviosNode.nextNode.nextNode = currentNode;
        }

        public void DeleteFirst()
        {
            head = head.nextNode;
        }

        public void DeleteLast()
        {
            Node previousNode = head;
            Node currentNode = head;
            while (currentNode.nextNode != null)
            {
                previousNode = currentNode;
                currentNode = currentNode.nextNode;
            }

            previousNode.nextNode = null;
        }

        public void DeleteAt(int index)
        {
            Node currentNode = head;
            Node perviosNode = head;
            int countIndex = 0;
            while (countIndex != index)
            {
                perviosNode = currentNode;
                currentNode = currentNode.nextNode;
                countIndex++;
            }

            perviosNode.nextNode = currentNode.nextNode;
        }

        public object First()
        {
            return head.Value;
        }

        public object Last()
        {
            Node currentNode = head;
            while (currentNode.nextNode != null)
            {
                currentNode = currentNode.nextNode;
            }

            return currentNode.Value;
        }

        public int Count()
        {
            Node currentNode = head;
            int i = 0;
            while (currentNode != null)
            {
                i++;
                currentNode = currentNode.nextNode;
            }

            return i;
        }

        public override string ToString()
        {

            Node current = head;
            String result = "";
            while (current != null)
            {
                result += current.Value + "\n";
                current = current.nextNode;
            }

            return result;
        }
    }
}
