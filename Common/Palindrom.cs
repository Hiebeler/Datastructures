namespace Common;

public class Palindrom
{
    public static bool IsPalindrom(string palindrom)
    {
        Stack<char> palindromStack = new Stack<char>(palindrom);
        int iterations = palindromStack.Count / 2;
        for (int i = 0; i < iterations; i++)
        {
            if (palindromStack.Pop() != palindrom[i])
            {
                return false;
            }
        }
        return true;
    }
}