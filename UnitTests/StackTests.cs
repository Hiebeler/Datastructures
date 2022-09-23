using NUnit.Framework;
using Stack;

namespace UnitTests
{
    public class Tests
    {
        [Test]
        public void TestStack()
        {
            CustomStack<string> stack = new CustomStack<string>();
            stack.push("halloo");
            stack.push("moin");
            stack.push("servus");
            stack.push("guten Tag");
            stack.pop();
            Assert.IsTrue(stack.size() == 3);
        }
    }
}