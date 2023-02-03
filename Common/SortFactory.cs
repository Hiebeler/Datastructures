using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class SortFactory
    {
        public SortStrategy SortStrategyFactory(String method)
        {
            switch (method)
            {
                case "Insertion Sort":
                    return new InsertionSort();
                case "Bubble Sort":
                    return new BubbleSort();
                case "Selection Sort":
                    return new SelectionSort();
                case "Quick Sort":
                    return new QuickSort();
                default:
                    throw new ArgumentException("Invalid Sort Method", "type");
            }
        }
    }
}
