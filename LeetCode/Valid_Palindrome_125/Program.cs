namespace Valid_Palindrome_125;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(IsPalindrome("A man, a plan, a canal: Panama"));
        Console.WriteLine(IsPalindrome("race a car"));
    }

    public static bool IsPalindrome1(string s)
    {
        var newStr = "";
        foreach (var c in s)
        {
            if (char.IsLetterOrDigit(c))
            {
                newStr += char.ToLower(c);
            }
        }

        var newStrReverse = new string(newStr.Reverse().ToArray());
        return newStr == newStrReverse;
    }

    private static bool IsPalindrome(string s)
    {
        var filtered = new List<char>();

        foreach (var c in s)
        {
            if (char.IsLetterOrDigit(c))
            {
                filtered.Add(char.ToLower(c));
            }
        }

        int left = 0, right = filtered.Count - 1;
        while (left < right)
        {
            if (filtered[left] != filtered[right])
            {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }
}