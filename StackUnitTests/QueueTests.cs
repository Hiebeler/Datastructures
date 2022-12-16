using System;
using MyQueue;
using NUnit.Framework;
using Stack;
using MyQueue;

namespace StackUnitTests
{
    class QueueObserver : IObserver
    {
        public int callCount = 0;
        public void Update(ISubject subject)
        {
            callCount++;
        }
    }

    public class QueueTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Enqueue_ThreeElements_QueueOrderOK()
        {
            MyQueue.MyQueue queue = new MyQueue.MyQueue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            Assert.AreEqual(queue.ToString(), "1\n2\n3\n");
        }

        [Test]
        public void EnqueueAndDequeeu_EnqueueThreeTimesDequeueonce_TwoElementsInQueueFirstOneRemoved()
        {
            MyQueue.MyQueue queue = new MyQueue.MyQueue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            var last = queue.Dequeue();
            Assert.AreEqual(last.Value, 1);
            Assert.AreEqual(queue.ToString(), "2\n3\n");
        }

        [Test]
        public void Observer_EnqueDeque2Times_UpdteIsCalledTwice()
        {
            MyQueue.MyQueue queue = new MyQueue.MyQueue();
            QueueObserver queueObserver = new QueueObserver();
            queue.Attach(queueObserver);
            queue.Enqueue(1);
            queue.Dequeue();

            Assert.AreEqual(queueObserver.callCount, 2);
        }


        [Test]
        public void Observer_Observing2Queus_UpdteIsCalledForEachQueue()
        {
            MyQueue.MyQueue queue1 = new MyQueue.MyQueue();
            MyQueue.MyQueue queue2 = new MyQueue.MyQueue();
            QueueObserver queueObserver = new QueueObserver();
            queue1.Attach(queueObserver);
            queue2.Attach(queueObserver);
            queue1.Enqueue(1);
            queue1.Dequeue();
            Assert.AreEqual(queueObserver.callCount, 2);
            queue1.Enqueue(1);
            Assert.AreEqual(queueObserver.callCount, 3);

        }
    }
}