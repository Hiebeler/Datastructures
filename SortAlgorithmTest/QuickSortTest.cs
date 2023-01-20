using System.Collections.Generic;
using Common;
using NUnit.Framework;
using SingleLinkedList;

namespace SortAlgorithmTest
{
    public class QuickSortTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestSelectionSort_Add3UnsortedNodes_ListIsSortedCorrect()
        {
            var linkedList = new SingleLinkedList.SingleLinkedList();
            linkedList.InsertFront(3);
            linkedList.InsertFront(1);
            linkedList.InsertLast(2);
            linkedList.SetSortStrategy(new QuickSort());
            linkedList.Sort();
            Assert.AreEqual(linkedList.ToString(), "1\n2\n3\n");
        }

        [Test]
        public void TestQuickSort_Add3Ints_ListIsSortedCorrect()
        {
            int[] arr = new int[] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };
            Quick_Sort(arr, 0, arr.Length - 1);
            Assert.AreEqual(-4, arr[0]);
        }

        private static void Quick_Sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                {
                    Quick_Sort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    Quick_Sort(arr, pivot + 1, right);
                }
            }

        }

        private static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while (true)
            {

                while (arr[left] < pivot)
                {
                    left++;
                }

                while (arr[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;

                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;


                }
                else
                {
                    return right;
                }
            }
        }
    }
}