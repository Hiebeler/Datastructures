using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQueue
{
    public class MyQueue : ISubject
    {
        private SingleLinkedList.SingleLinkedList internalList = new SingleLinkedList.SingleLinkedList();
        private List<IObserver> _observers = new List<IObserver>();
        public object Enqueue(object argValue)
        {
            internalList.InsertLast(argValue);
            Notify();
            return argValue;
        }

        public Node Dequeue()
        {
            var retval = internalList.First();
            internalList.DeleteFirst();
            Notify();
            return retval;
        }

        public void Attach(IObserver observer)
        {
            Console.WriteLine("Subject: Attached an observer.");
            this._observers.Add(observer);
        }
        public void Detach(IObserver observer)
        {
            this._observers.Remove(observer);
            Console.WriteLine("Subject: Detached an observer.");
        }

        public void Notify()
        {
            Console.WriteLine("Subject: Notifying observers...");

            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }


        public override string ToString()
        {
            return internalList.ToString();
        }

    }
}
