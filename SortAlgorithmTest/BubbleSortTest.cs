using Common;
using NUnit.Framework;
using SingleLinkedList;

namespace SortAlgorithmTest
{
    public class BubbleSortTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestBubbleSort_Add3UnsortedNodes_ListIsSortedCorrect()
        {
            var linkedList = new SingleLinkedList.SingleLinkedList();
            linkedList.InsertFront(3);
            linkedList.InsertFront(1);
            linkedList.InsertLast(2);
            linkedList.SetSortStrategy(new BubbleSort());
            linkedList.Sort();
            Assert.AreEqual(linkedList.ToString(), "1\n2\n3\n");
        }

        [Test]
        public void TestBubbleSortDescending_Add3UnsortedNodes_ListIsSortedCorrect()
        {
            var linkedList = new SingleLinkedList.SingleLinkedList();
            linkedList.InsertFront(3);
            linkedList.InsertFront(1);
            linkedList.InsertLast(2);
            linkedList.SetSortStrategy(new BubbleSort());
            linkedList.SortDescending();
            Assert.AreEqual(linkedList.ToString(), "3\n2\n1\n");
        }
    }
}