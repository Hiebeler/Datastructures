using LinkedQueue;
using NUnit.Framework;
using Stack;

namespace UnitTests
{
    public class StackTests
    {
        [Test]
        public void TestLinkedQueueSize_AddItems_ReturnsCorrectStackSize()
        {
            LinkedQueue<string> stack = new LinkedQueue<string>();
            Assert.AreEqual(stack.Size(), 0);
            stack.Push("halloo");
            Assert.AreEqual(stack.Size(), 1);
        }

        [Test]
        public void TestStackSize_AddItems_ReturnsCorrectStackSize()
        {
            CustomStack<string> stack = new CustomStack<string>();
            Assert.AreEqual(stack.size(), 0);
            Node föalskdjf = new Node();
            föalskdjf.SetData<int>(3);
            stack.push(föalskdjf);
            Assert.AreEqual(stack.size(), 1);


        }
    }
}