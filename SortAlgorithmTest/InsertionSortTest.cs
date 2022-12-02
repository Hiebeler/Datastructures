using Common;
using NUnit.Framework;
using SingleLinkedList;

namespace SortAlgorithmTest
{
    public class InsertionSortTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestInsertionSort_AddSomeIntsAndSortThem_ListIsSortedCorrect()
        {
            var linkedList = new SingleLinkedList.SingleLinkedList();
            linkedList.InsertFront(3);
            linkedList.InsertFront(1);
            linkedList.InsertLast(2);
            linkedList.SetSortStrategy(new InsertionSort());
            linkedList.Sort();
            Assert.AreEqual(linkedList.First().Value, 1);
            Assert.AreEqual(linkedList.GetNode(1).nextNode.Value, 2);
            Assert.AreEqual(linkedList.Last().Value, 3);
        }

        [Test]
        public void TestInsertionSortReverse_AddSomeIntsAndReverseSortThem_ListIsSortedInReverse()
        {
            var linkedList = new SingleLinkedList.SingleLinkedList();
            linkedList.InsertFront(3);
            linkedList.InsertFront(1);
            linkedList.InsertLast(2);
            linkedList.SetSortStrategy(new InsertionSort());
            linkedList.SortDescending();
            Assert.AreEqual(linkedList.First().Value, 3);
            Assert.AreEqual(linkedList.GetNode(3).nextNode.Value, 2);
            Assert.AreEqual(linkedList.Last().Value, 1);
        }

        [Test]
        public void TestInsertionSortReverse_AddMultipleSimilareIntsAndSortThem_ListIsSortedInReverse()
        {
            var linkedList = new SingleLinkedList.SingleLinkedList();
            linkedList.InsertFront(1);
            linkedList.InsertLast(2);
            linkedList.InsertFront(3);
            linkedList.InsertFront(3);
            linkedList.InsertLast(4);
            linkedList.SetSortStrategy(new InsertionSort());
            linkedList.SortDescending();
            Assert.AreEqual(linkedList.First().Value, 4);
            Assert.AreEqual(linkedList.GetNode(4).nextNode.Value, 3);
            Assert.AreEqual(linkedList.GetNode(4).nextNode.nextNode.Value, 3);
            Assert.AreEqual(linkedList.GetNode(4).nextNode.nextNode.nextNode.Value, 2);
            Assert.AreEqual(linkedList.Last().Value, 1);
        }
    }
}