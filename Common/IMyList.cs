using System.Diagnostics;

namespace Common;

public interface IMyList
{
    void SwitchNode(Node argFirstNode, Node argSecondNode);
    void SetSortStrategy(SortStrategy sortStrategy);
    Node First();
    void Sort();
}
