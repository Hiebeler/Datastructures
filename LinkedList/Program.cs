    using SingleLinkedList;

    class Program
    {
        static void Main(string[] args)
        {
            SingleLinkedList.SingleLinkedList linkedList = new SingleLinkedList.SingleLinkedList();
            linkedList.InsertFront("hallo");
        linkedList.InsertFront(123);
        /*linkedList.InsertAt(4, 4);
        linkedList.InsertAt("moin", 0);
        linkedList.InsertLast(3);
        linkedList.InsertLast(33);
        Console.WriteLine(linkedList);
        linkedList.DeleteFirst();
        linkedList.DeleteLast();
        linkedList.DeleteAt(1);
        Console.WriteLine(linkedList);
        Console.WriteLine(linkedList.First());
        Console.WriteLine(linkedList.Last());*/
        //Console.WriteLine(linkedList.GetNode("hallo")!.Value);
        Node node = linkedList.GetNode("hallo")!;
        linkedList.InsertAfter(node, "moin");
        linkedList.DeleteNode(node);
        Console.WriteLine(linkedList);
        }
    }
