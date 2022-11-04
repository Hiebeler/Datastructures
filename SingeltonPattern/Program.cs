using SingeltonPattern;

class Program
{
    public static void Main(string[] args)
    {
        King ourKing = King.GetInstance();
        ourKing.SetName("Emanuel");
        Console.WriteLine(ourKing.Attack());

        King fakeKing = King.GetInstance();
        fakeKing.SetName("Bim");
        Console.WriteLine(fakeKing.Retriev());
        Console.WriteLine(ourKing.Attack());
    }
}
