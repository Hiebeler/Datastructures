using GenericClass;

internal class Program
{
    private static void Main(string[] args)
    {
        var genericListInt = new GenericList<int>();
        genericListInt.Add(1);
        genericListInt.Add(5);
        genericListInt.Add(12345);
        foreach (var item in genericListInt.getList()) Console.WriteLine(item);

        var genericListString = new GenericList<string>();
        genericListString.Add("hollo");
        genericListString.Add("moin");
        genericListString.Add("servus");
        Console.WriteLine(genericListString.getItem(1));
    }
}