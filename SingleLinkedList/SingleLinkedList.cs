using Common;

namespace SingleLinkedList;

public class SingleLinkedList : IMyList
{
    private Node head;
    private SortStrategy sortStrategy;

    public Node First()
    {
        return head;
    }

    public void SwitchNode(Node firstNode, Node secondNode)
    {
        if (!Exists(firstNode) || !Exists(secondNode))
            return;
        (firstNode.Value, secondNode.Value) = (secondNode.Value, firstNode.Value);
    }

    public void SetSortStrategy(SortStrategy _sortStrategy)
    {
        sortStrategy = _sortStrategy;
    }

    public void Sort()
    {
        sortStrategy.Sort(this);
    }

    public void InsertFront(object value)
    {
        var newNode = new Node(value);
        if (head != null) newNode.nextNode = head;

        head = newNode;
    }

    public void InsertLast(object value)
    {
        var newNode = new Node(value);
        if (head == null)
        {
            head = newNode;
        }
        else
        {
            var currentNode = head;
            while (currentNode.nextNode != null) currentNode = currentNode.nextNode;

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

        var currentNode = head;
        var perviosNode = head;
        var countIndex = 0;
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

    public void InsertAfter(Node previousNode, object newData)
    {
        var currentNode = head;
        while (currentNode != null)
        {
            if (currentNode == previousNode)
            {
                var previousNextNode = currentNode.nextNode;
                currentNode.nextNode = new Node(newData);
                currentNode.nextNode.nextNode = previousNextNode;
            }

            if (currentNode.nextNode == null) return;
            currentNode = currentNode.nextNode;
        }
    }

    public void DeleteFirst()
    {
        head = head.nextNode;
    }

    public void DeleteLast()
    {
        var previousNode = head;
        var currentNode = head;
        while (currentNode.nextNode != null)
        {
            previousNode = currentNode;
            currentNode = currentNode.nextNode;
        }

        previousNode.nextNode = null;
    }

    public void DeleteAt(int index)
    {
        var currentNode = head;
        var perviosNode = head;
        var countIndex = 0;
        while (countIndex != index)
        {
            perviosNode = currentNode;
            currentNode = currentNode.nextNode;
            countIndex++;
        }

        perviosNode.nextNode = currentNode.nextNode;
    }

    public bool DeleteNode(Node node)
    {
        var currentNode = head;
        var previousNode = head;
        while (currentNode != null)
        {
            if (currentNode == node)
            {
                if (currentNode == head)
                    DeleteFirst();
                else
                    previousNode.nextNode = currentNode.nextNode;
                return true;
            }

            if (currentNode.nextNode == null) return false;
            previousNode = currentNode;
            currentNode = currentNode.nextNode;
        }

        return false;
    }

    public Node Last()
    {
        var currentNode = head;
        while (currentNode.nextNode != null) currentNode = currentNode.nextNode;

        return currentNode;
    }

    public Node? GetNode(object data)
    {
        var currentNode = head;
        while (currentNode != null)
        {
            if (currentNode.Value.Equals(data)) return currentNode;

            if (currentNode.nextNode == null) return null;
            currentNode = currentNode.nextNode;
        }

        return null;
    }

    public int Count()
    {
        var currentNode = head;
        var i = 0;
        while (currentNode != null)
        {
            i++;
            currentNode = currentNode.nextNode;
        }

        return i;
    }

    public bool Exists(Node node)
    {
        var currentNode = head;
        if (currentNode == node) return true;
        while (currentNode != null)
        {
            if (currentNode == node) return true;

            currentNode = currentNode.nextNode;
        }

        return false;
    }

    public void InsertionSort()
    {
        insertionSort(false);
    }

    public void InsertionSortReverse()
    {
        insertionSort(true);
    }

    private void insertionSort(bool reverse)
    {
        var currentNode = head.nextNode;
        while (currentNode != null)
        {
            for (var cur = head; cur != null; cur = cur.nextNode)
            {
                if (cur == currentNode)
                    break;
                if (reverse)
                {
                    if ((int)cur.Value > (int)currentNode.Value)
                        continue;
                }
                else
                {
                    if ((int)cur.Value < (int)currentNode.Value)
                        continue;
                }

                (cur.Value, currentNode.Value) = (currentNode.Value, cur.Value);
            }

            currentNode = currentNode.nextNode;
        }
    }

    public override string ToString()
    {
        var current = head;
        var result = "";
        while (current != null)
        {
            result += current.Value + "\n";
            current = current.nextNode;
        }

        return result;
    }
}