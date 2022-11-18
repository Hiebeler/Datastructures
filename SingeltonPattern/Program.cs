using SingeltonPattern;

internal class Program
{
    public static void Main(string[] args)
    {
        var ourKing = King.GetInstance();
        ourKing.SetName("Emanuel");
        Console.WriteLine(ourKing.Attack());

        var fakeKing = King.GetInstance();
        fakeKing.SetName("Bim");
        Console.WriteLine(fakeKing.Retriev());
        Console.WriteLine(ourKing.Attack());
    }
}