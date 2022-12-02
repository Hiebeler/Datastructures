using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common;

public class BubbleSort : SortStrategy
{
    public override void SortDescending(IMyList list)
    {
       bubbleSort(list, true);
    }

    public override void Sort(IMyList list)
    {
        bool sorted = false;
        while (!sorted)
        {
            sorted = true;
            for (var cur = list.First(); cur.nextNode != null; cur = cur.nextNode)
            {
                if ((int)cur.Value > (int)cur.nextNode.Value)
                {
                    list.SwitchNode(cur, cur.nextNode);
                    sorted = false;
                }
            }
        }
    }

    private void bubbleSort(IMyList list, bool descending)
    {
        bool sorted = false;
        while (!sorted)
        {
            sorted = true;
            for (var cur = list.First(); cur.nextNode != null; cur = cur.nextNode)
            {
                if ((descending && (int)cur.Value < (int)cur.nextNode.Value) || (!descending && (int)cur.Value < (int)cur.nextNode.Value))
                {
                    list.SwitchNode(cur, cur.nextNode);
                    sorted = false;
                }
            }
        }
    }
}