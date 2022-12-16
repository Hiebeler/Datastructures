using Common;
using NUnit.Framework;
using SingleLinkedList;

namespace SortAlgorithmTest
{
    public class SelectionSortTest
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
            linkedList.SetSortStrategy(new SelectionSort());
            linkedList.Sort();
            Assert.AreEqual(linkedList.ToString(), "1\n2\n3\n");
        }

        [Test]
        public void TestSelectionSortDescending_Add3UnsortedNodes_ListIsSortedCorrect()
        {
            var linkedList = new SingleLinkedList.SingleLinkedList();
            linkedList.InsertFront(3);
            linkedList.InsertFront(6);
            linkedList.InsertFront(4);
            linkedList.InsertFront(1);
            linkedList.InsertFront(7);
            linkedList.InsertFront(5);
            linkedList.InsertLast(2);
            linkedList.SetSortStrategy(new SelectionSort());
            linkedList.SortDescending();
            Assert.AreEqual(linkedList.ToString(), "7\n6\n5\n4\n3\n2\n1\n");
        }
    }
}