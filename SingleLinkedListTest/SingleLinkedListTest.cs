using System.Linq;
using NUnit.Framework;
using SingleLinkedList;

namespace SingleLinkedListTest
{
    public class SingleLinkedListTest
    {
        [Test]
        public void TestLinkedListCount_AddItems_ReturnsCorrectCount()
        {
            SingleLinkedList.SingleLinkedList linkedList = new SingleLinkedList.SingleLinkedList();
            linkedList.InsertFront("first");
            linkedList.InsertLast("last");
            linkedList.InsertAt("middle",1);
            Assert.AreEqual(linkedList.Count(), 3);
            linkedList.DeleteFirst();
            Assert.AreEqual(linkedList.Count(), 2);
        }

        [Test]
        public void TestLinkedListInsertFirst_AddItems_InsertsCorrect()
        {
            SingleLinkedList.SingleLinkedList linkedList = new SingleLinkedList.SingleLinkedList();
            linkedList.InsertFront(1);
            linkedList.InsertFront(2);
            Assert.AreEqual(linkedList.ToString(), "2\n1\n");
        }

        [Test]
        public void TestLinkedListInsertLast_AddItems_InsertsCorrect()
        {
            SingleLinkedList.SingleLinkedList linkedList = new SingleLinkedList.SingleLinkedList();
            linkedList.InsertLast(1);
            linkedList.InsertLast(2);
            Assert.AreEqual(linkedList.ToString(), "1\n2\n");
        }

        [Test]
        public void TestLinkedListGetNode_AddItems_ReturnsCorrectNode()
        {
            SingleLinkedList.SingleLinkedList linkedList = new SingleLinkedList.SingleLinkedList();
            linkedList.InsertFront("first");
            Assert.AreEqual(linkedList.GetNode("first").Value, "first");
        }


        [Test]
        public void TestLinkedListInsertAfter_AddItems_InsertsCorrect()
        {
            SingleLinkedList.SingleLinkedList linkedList = new SingleLinkedList.SingleLinkedList();
            linkedList.InsertFront(1);
            Node node = linkedList.GetNode(1)!;
            linkedList.InsertAfter(node, 2);
            linkedList.InsertAfter(node, 3);
            Assert.AreEqual(linkedList.ToString(), "1\n3\n2\n");
        }

        [Test]
        public void TestLinkedListDeleteNode_AddItemsAndDeleteItems_ListIsCorrect()
        {
            SingleLinkedList.SingleLinkedList linkedList = new SingleLinkedList.SingleLinkedList();
            linkedList.InsertFront(1);
            Node node = linkedList.GetNode(1)!;
            linkedList.InsertAfter(node, 2);
            linkedList.DeleteNode(node);
            Assert.AreEqual(linkedList.ToString(), "2\n");
        }
    }
}