using System.Linq;
using NUnit.Framework;
using Stack;

namespace UnitTests
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
    }
}