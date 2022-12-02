using NUnit.Framework;

namespace QueueUnitTests
{
    public class QueueTests
    {
        [SetUp]
        public void Setup()
        {
        }

        public void Enqueue_ThreeElements_QueueOrderOK()
        {
            MyQueue.MyQueue stack = new MyQueue.MyQueue();
            stack.Enqueue(1);
            stack.Enqueue(2);
            stack.Enqueue(3);
            Assert.AreEqual(stack.ToString(), "1\n2\n3\n");
        }

        [Test]
        public void EnqueueAndDequeue_PushThreeTimesPoPonce_TwoElementsInQueueFirstOneRemoved()
        {
            MyQueue.MyQueue stack = new MyQueue.MyQueue();
            stack.Enqueue(1);
            stack.Enqueue(2);
            stack.Enqueue(3);
            var last = stack.Dequeue();
            Assert.AreEqual(last.Value, 1);
            Assert.AreEqual(stack.ToString(), "2\n3\n");
        }
    }
}