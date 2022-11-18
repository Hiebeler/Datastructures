namespace SingeltonPattern;

internal class King
{
    private static King? ourKing;
    private string Name;

    private King()
    {
    }

    public static King GetInstance()
    {
        if (ourKing == null) ourKing = new King();

        return ourKing;
    }

    public void SetName(string name)
    {
        Name = name;
    }

    public string Attack()
    {
        return Name + " wants to Attack";
    }

    public string Retriev()
    {
        return Name + " wants to Retriev";
    }
}