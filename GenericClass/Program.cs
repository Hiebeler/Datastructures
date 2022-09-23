using GenericClass;

class Program
{
    static void Main(string[] args)
    {
        GenericList<int> genericListInt = new GenericList<int>();
        genericListInt.Add(1);
        genericListInt.Add(5);
        genericListInt.Add(12345);
        foreach (int item in genericListInt.getList())
        {
            Console.WriteLine(item);
        }

        GenericList<string> genericListString = new GenericList<string>();
        genericListString.Add("hollo");
        genericListString.Add("moin");
        genericListString.Add("servus");
        Console.WriteLine(genericListString.getItem(1));
    }
}
