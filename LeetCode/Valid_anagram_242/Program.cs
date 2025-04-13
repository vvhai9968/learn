namespace Valid_anagram_242;

public class Program
{
    private static void Main(string[] args)
    {
        var isAnagram = IsAnagram("anagram","nagaram");
        Console.WriteLine(isAnagram);
    }
    
    private static bool IsAnagram1(string s, string t) {
        if (s.Length != t.Length) return false;
        var sSort = s.ToCharArray();
        var tSort = t.ToCharArray();
        Array.Sort(sSort);
        Array.Sort(tSort);
        return sSort.SequenceEqual(tSort);
    }

    private static bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;
       
        var countS = new Dictionary<char, int>();
        var countT = new Dictionary<char, int>();
        for (var i = 0; i < s.Length; i++) {
            countS[s[i]] = countS.GetValueOrDefault(s[i], 0) + 1;
            countT[t[i]] = countT.GetValueOrDefault(t[i], 0) + 1;
        }
        return countS.Count == countT.Count && !countS.Except(countT).Any();
    }
}