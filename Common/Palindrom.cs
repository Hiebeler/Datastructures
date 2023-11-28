namespace Common;

public class Palindrom
{
    public static bool IsPalindrom(string palindrom)
    {
        Stack<char> palindromStack = new Stack<char>(palindrom);
        for (int i = 0; i < palindromStack.Count; i++)
        {
            if (palindromStack.Pop() != palindrom[i])
            {
                return false;
            }
        }
        return true;
    }
}