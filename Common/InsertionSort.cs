using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common;

public class InsertionSort : SortStrategy
{
    public override void Sort(IMyList list)
    {
        insertionSort(list, false);
    }

    public override void SortDescending(IMyList list)
    {
        insertionSort(list, true);
    }

    private void insertionSort(IMyList list, bool reverse)
    {
        var currentNode = list.First().nextNode;
        while (currentNode != null)
        {
            for (var cur = list.First(); cur != null; cur = cur.nextNode)
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
}