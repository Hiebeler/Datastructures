using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common;

public class BubbleSort : SortStrategy
{
    public override void Sort(IMyList list)
    {
        var currentNode = list.First();
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
            currentNode = currentNode.nextNode;
        }
    }
}