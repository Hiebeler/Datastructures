namespace Common;

public class Palindrom
{
    public static bool IsPalindrom(string palindrom)
    {
        Stack<char> palindromStack = new Stack<char>(palindrom);
        int iterations = (int)Math.Ceiling((decimal)palindromStack.Count / 2);
        for (int i = 0; i < iterations; i++)
        {
            char z = palindromStack.Pop();
            char t = palindrom[i];
            if (z != palindrom[i])
            {
                return false;
            }
        }
        return true;
    }
}