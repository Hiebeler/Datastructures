    class Program
    {
        static void Main(string[] args)
        {
            SingleLinkedList.SingleLinkedList linkedList = new SingleLinkedList.SingleLinkedList();
            linkedList.InsertFront("hallo");
            linkedList.InsertFront(123);
            linkedList.InsertAt(4, 4);
            linkedList.InsertAt("moin", 0);
            linkedList.InsertLast(3);
            linkedList.InsertLast(33);
            linkedList.printAllNodes();
            linkedList.DeleteFirst();
            linkedList.DeleteLast();
            linkedList.DeleteAt(1);
            linkedList.printAllNodes();
            Console.WriteLine(linkedList.First());
            Console.WriteLine(linkedList.Last());
        }
    }
