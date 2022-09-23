using Stack;

class Program
{
    static void Main(string[] args)
    {
        CustomStack<int> test = new CustomStack<int>();
        Node bla = new Node();
        bla.SetData<string>("hallo");
        test.push(bla);
        Node föalskdjf = new Node();
        bla.SetData<int>(3);
        test.push(föalskdjf);
        Console.WriteLine(test.size());
        test.pop();
        Console.WriteLine(test.size());
    }

}
    

