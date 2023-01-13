using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common;

public class QuickSort : SortStrategy
{
    public override void SortDescending(IMyList list)
    {
        quickSort(list, true);
    }

    public override void Sort(IMyList list)
    {
        quickSort(list, false);
    }

    private void quickSort(IMyList list, bool descending)
    {
        sort(list.First(), Last(list));
    }

    public Node Last(IMyList list)
    {
        var currentNode = list.First();
        while (currentNode.nextNode != null) currentNode = currentNode.nextNode;

        return currentNode;
    }

    Node paritionLast(Node start, Node end)
    {
        if (start == end || start == null || end == null)
            return start;

        Node pivot_prev = start;
        Node curr = start;
        int pivot = (int)end.Value;

        // iterate till one before the end,
        // no need to iterate till the end
        // because end is pivot
        while (start != end)
        {
            if ((int) start.Value < pivot)
            {
                // keep tracks of last modified item
                pivot_prev = curr;
                int temp = (int) curr.Value;
                curr.Value = (int)start.Value;
                start.Value = temp;
                curr = curr.nextNode;
            }
            start = start.nextNode;
        }

        // swap the position of curr i.e.
        // next suitable index and pivot
        int temp2 = (int) curr.Value;
        curr.Value = pivot;
        end.Value = temp2;

        // return one previous to current
        // because current is now pointing to pivot
        return pivot_prev;
    }

    void sort(Node start, Node end)
    {
        if (start == null || start == end || start == end.nextNode)
            return;

        // split list and partition recurse
        Node pivot_prev = paritionLast(start, end);
        sort(start, pivot_prev);

        // if pivot is picked and moved to the start,
        // that means start and pivot is same
        // so pick from next of pivot
        if (pivot_prev != null && pivot_prev == start)
            sort(pivot_prev.nextNode, end);

        // if pivot is in between of the list,
        // start from next of pivot,
        // since we have pivot_prev, so we move two nodes
        else if (pivot_prev != null
                 && pivot_prev.nextNode != null)
            sort(pivot_prev.nextNode.nextNode, end);
    }
}