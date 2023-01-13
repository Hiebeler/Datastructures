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
    }
}