using System.Linq;
using NUnit.Framework;
using Stack;

namespace UnitTests
{
    public class StackTests
    {
        [Test]
        public void TestLinkedList_AddItems_ReturnsCorrectList()
        {
            SingleLinkedList.SingleLinkedList stack = new SingleLinkedList.SingleLinkedList();
            Assert.AreEqual(stack.Count(), 0);
            stack.InsertFront("first");
            stack.InsertLast("last");
            stack.InsertAt("middle",1);
            Assert.AreEqual(stack.Count(), 3);
            Assert.AreEqual(stack.Last(), "last");
            Assert.AreEqual(stack.First(), "first");
            stack.DeleteFirst();
            Assert.AreEqual(stack.First(), "middle");
        }

        [Test]
        public void TestStackSize_AddItems_ReturnsCorrectStackSize()
        {
            CustomStack<string> stack = new CustomStack<string>();
            Assert.AreEqual(stack.size(), 0);
            Node f�alskdjf = new Node();
            f�alskdjf.SetData<int>(3);
            stack.push(f�alskdjf);
            Assert.AreEqual(stack.size(), 1);


        }
    }
}