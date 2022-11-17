namespace Common;

public class Node
{
    public Node? nextNode;

    public Node(object value)
    {
        nextNode = null;
        Value = value;
    }

    public object Value { get; set; }
}