using NUnit.Framework;
using Stack;

namespace UnitTests
{
    public class Tests
    {
        [Test]
        public void TestStackSize_AddItems_ReturnsCorrectStackSize()
        {
            CustomStack<string> stack = new CustomStack<string>();
            Assert.AreEqual(stack.Size(), 0);
            stack.Push("halloo");
            Assert.AreEqual(stack.Size(), 1);
        }
    }
}