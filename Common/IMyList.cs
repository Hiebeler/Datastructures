namespace Common;

public interface IMyList
{
    void SwitchNode(Node argFirstNode, Node argSecondNode);
    void SetSortStrategy(SortStrategy sortStrategy);
    Node First();
    void Sort();
}

public abstract class SortStrategy
{
    public abstract void Sort(IMyList list);
}

public class InsertionSort : SortStrategy
{
    public override void Sort(IMyList list)
    {
        var currentNode = list.First().nextNode;
        while (currentNode != null)
        {
            for (var cur = list.First(); cur != null; cur = cur.nextNode)
            {
                if (cur == currentNode)
                    break;
                if ((int)cur.Value < (int)currentNode.Value)
                    continue;
                (cur.Value, currentNode.Value) = (currentNode.Value, cur.Value);
            }

            currentNode = currentNode.nextNode;
        }
    }
}

public class InsertionSortReverse : SortStrategy
{
    public override void Sort(IMyList list)
    {
        var currentNode = list.First().nextNode;
        while (currentNode != null)
        {
            for (var cur = list.First(); cur != null; cur = cur.nextNode)
            {
                if (cur == currentNode)
                    break;
                if ((int)cur.Value > (int)currentNode.Value)
                    continue;
                (cur.Value, currentNode.Value) = (currentNode.Value, cur.Value);
            }

            currentNode = currentNode.nextNode;
        }
    }
}