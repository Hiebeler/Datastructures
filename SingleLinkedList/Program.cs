using SingleLinkedList;

class Program
{
    static void Main(string[] args)
    {
        SingleLinkedList.SingleLinkedList linkedList = new SingleLinkedList.SingleLinkedList();
        /*linkedList.InsertFront("hallo");
        linkedList.InsertFront(12121231233);
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
        Console.WriteLine(linkedList.Last());
        Console.WriteLine(linkedList.GetNode("hallo")!.Value);
        Node node = linkedList.GetNode("hallo")!;
        linkedList.InsertAfter(node, "moin");
        linkedList.DeleteNode(node);
        Node node1 = linkedList.GetNode(123)!;
        Node node2 = linkedList.GetNode("moin")!;
        linkedList.Switch(node1, node2);
        */
        linkedList.InsertFront(4);
        linkedList.InsertFront(4);
        linkedList.InsertFront(10);
        linkedList.InsertFront(3);
        linkedList.InsertFront(5);
        linkedList.InsertFront(2);
        linkedList.InsertFront(100);
        linkedList.InsertFront(68);
        linkedList.InsertFront(345);
        linkedList.InsertFront(23);
        linkedList.InsertFront(12);
        linkedList.InsertFront(24);
        linkedList.InsertFront(22);
        linkedList.InsertionSortReverse();
        Console.WriteLine(linkedList);
    }
}