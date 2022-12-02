using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class SelectionSort : SortStrategy
    {
        public override void Sort(IMyList list)
        {
            selectionSort(list, false);
        }

        public override void SortDescending(IMyList list)
        {
            selectionSort(list, true);
        }

        private void selectionSort(IMyList list, bool descending)
        {
            for (var cur = list.First(); cur.nextNode != null; cur = cur.nextNode)
            {
                Node minNode = cur;
                for (var innerCur = cur; innerCur != null; innerCur = innerCur.nextNode)
                {
                    if ((descending && (int) innerCur.Value > (int) minNode.Value) || (!descending && (int)innerCur.Value > (int)minNode.Value))
                        minNode = innerCur;
                }

                list.SwitchNode(cur, minNode);
            }
        }
    }
}
