using Common;

internal class Program
{
    private static void Main(string[] args)
    {
        var linkedList = new SingleLinkedList.SingleLinkedList();
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
        linkedList.SetSortStrategy(new BubbleSort());
        linkedList.Sort();
        Console.WriteLine(linkedList);
    }
}