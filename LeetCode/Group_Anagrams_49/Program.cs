namespace Group_Anagrams_49;

public class Program
{
    static void Main(string[] args)
    {
        var result = GroupAnagrams(["eat", "tea", "tan", "ate", "nat", "bat"]);
    }

    private static IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var groupStr = new Dictionary<string, IList<string>>();
        foreach (var item in strs)
        {
            var value = item.ToCharArray();
            Array.Sort(value);
            var sortS = new string(value);
            if (groupStr.ContainsKey(sortS))
            {
                groupStr[sortS].Add(item);
            }
            else
            {
                groupStr[sortS] = [item];
            }
        }
        return groupStr.Values.ToList();
    }
}