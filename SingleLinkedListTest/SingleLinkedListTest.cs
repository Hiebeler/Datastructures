using Common;
using NUnit.Framework;

namespace SingleLinkedListTest;

public class SingleLinkedListTest
{
    [Test]
    public void TestLinkedListCount_AddItems_ReturnsCorrectCount()
    {
        var linkedList = new SingleLinkedList.SingleLinkedList();
        linkedList.InsertFront("first");
        linkedList.InsertLast("last");
        linkedList.InsertAt("middle", 1);
        Assert.AreEqual(linkedList.Count(), 3);
        linkedList.DeleteFirst();
        Assert.AreEqual(linkedList.Count(), 2);
    }

    [Test]
    public void TestLinkedListInsertFirst_AddItems_InsertsCorrect()
    {
        var linkedList = new SingleLinkedList.SingleLinkedList();
        linkedList.InsertFront(1);
        linkedList.InsertFront(2);
        Assert.AreEqual(linkedList.ToString(), "2\n1\n");
    }

    [Test]
    public void TestLinkedListInsertLast_AddItems_InsertsCorrect()
    {
        var linkedList = new SingleLinkedList.SingleLinkedList();
        linkedList.InsertLast(1);
        linkedList.InsertLast(2);
        Assert.AreEqual(linkedList.ToString(), "1\n2\n");
    }

    [Test]
    public void TestLinkedListGetNode_AddItems_ReturnsCorrectNode()
    {
        var linkedList = new SingleLinkedList.SingleLinkedList();
        linkedList.InsertFront("first");
        Assert.AreEqual(linkedList.GetNode("first").Value, "first");
    }


    [Test]
    public void TestLinkedListInsertAfter_AddItems_InsertsCorrect()
    {
        var linkedList = new SingleLinkedList.SingleLinkedList();
        linkedList.InsertFront(1);
        var node = linkedList.GetNode(1)!;
        linkedList.InsertAfter(node, 2);
        linkedList.InsertAfter(node, 3);
        Assert.AreEqual(linkedList.ToString(), "1\n3\n2\n");
    }

    [Test]
    public void TestLinkedListDeleteNode_AddItemsAndDeleteItems_ListIsCorrect()
    {
        var linkedList = new SingleLinkedList.SingleLinkedList();
        linkedList.InsertFront(1);
        var node = linkedList.GetNode(1)!;
        linkedList.InsertAfter(node, 2);
        linkedList.DeleteNode(node);
        Assert.AreEqual(linkedList.ToString(), "2\n");
    }

    [Test]
    public void TestSwitchNodes_Add2ItemsAndSwitchThem_ItemsAreSwitched()
    {
        var linkedList = new SingleLinkedList.SingleLinkedList();
        linkedList.InsertFront(1);
        var node1 = linkedList.GetNode(1)!;
        linkedList.InsertLast(2);
        var node2 = linkedList.GetNode(2);
        linkedList.SwitchNode(node1, node2);
        Assert.AreEqual(linkedList.First().Value, 2);
        Assert.AreEqual(linkedList.Last().Value, 1);
    }

    [Test]
    public void TestSwitchNodes_SwitchEmptyList_ListIsEmpty()
    {
        var linkedList = new SingleLinkedList.SingleLinkedList();
        var node2 = new Node(2);
        linkedList.InsertFront(3);
        linkedList.InsertFront(1);
        var node1 = linkedList.GetNode(1);
        linkedList.SwitchNode(node1, node2);
        Assert.AreEqual(linkedList.First().Value, 1);
        Assert.AreEqual(linkedList.Last().Value, 3);
    }

    [Test]
    public void TestInsertionSort_AddSomeIntsAndSortThem_ListIsSortedCorrect()
    {
        var linkedList = new SingleLinkedList.SingleLinkedList();
        linkedList.InsertFront(3);
        linkedList.InsertFront(1);
        linkedList.InsertLast(2);
        linkedList.SetSortStrategy(new InsertionSort());
        linkedList.Sort();
        Assert.AreEqual(linkedList.First().Value, 1);
        Assert.AreEqual(linkedList.GetNode(1).nextNode.Value, 2);
        Assert.AreEqual(linkedList.Last().Value, 3);
    }

    [Test]
    public void TestInsertionSortReverse_AddSomeIntsAndReverseSortThem_ListIsSortedInReverse()
    {
        var linkedList = new SingleLinkedList.SingleLinkedList();
        linkedList.InsertFront(3);
        linkedList.InsertFront(1);
        linkedList.InsertLast(2);
        linkedList.SetSortStrategy(new InsertionSortReverse());
        linkedList.Sort();
        Assert.AreEqual(linkedList.First().Value, 3);
        Assert.AreEqual(linkedList.GetNode(3).nextNode.Value, 2);
        Assert.AreEqual(linkedList.Last().Value, 1);
    }

    [Test]
    public void TestInsertionSortReverse_AddMultipleSimilareIntsAndSortThem_ListIsSortedInReverse()
    {
        var linkedList = new SingleLinkedList.SingleLinkedList();
        linkedList.InsertFront(1);
        linkedList.InsertLast(2);
        linkedList.InsertFront(3);
        linkedList.InsertFront(3);
        linkedList.InsertLast(4);
        linkedList.SetSortStrategy(new InsertionSortReverse());
        linkedList.Sort();
        Assert.AreEqual(linkedList.First().Value, 4);
        Assert.AreEqual(linkedList.GetNode(4).nextNode.Value, 3);
        Assert.AreEqual(linkedList.GetNode(4).nextNode.nextNode.Value, 3);
        Assert.AreEqual(linkedList.GetNode(4).nextNode.nextNode.nextNode.Value, 2);
        Assert.AreEqual(linkedList.Last().Value, 1);
    }
}