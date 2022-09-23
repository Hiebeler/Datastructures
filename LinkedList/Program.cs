using LinkedQueue;

class Program
{
    static void Main(string[] args)
    {
        LinkedQueue<int> stack = new LinkedQueue<int>();
        stack.Push(1);
        stack.Push(123);
        stack.Push(4);
        stack.Push(3);
        stack.Pop();
        Console.WriteLine(stack.Size());
    }
}