public class Program
{
    static void Main(string[] args)
    {
        var result = ContainsDuplicate([1, 2, 3, 1]);
        Console.WriteLine(result);
    }

    #region Method 1: complexity O(N2) time out when encountering big data

    public static bool ContainsDuplicate1(int[] nums)
    {
        for (var i = 0; i < nums.Length; i++)
        {
            for (var j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] == nums[j])
                {
                    return true;
                }
            }
        }

        return false;
    }

    #endregion

    #region Method 2: complexity O(N)

    public static bool ContainsDuplicate(int[] nums)
    {
        var arrDistinct = new Dictionary<int, int>();
        foreach (var t in nums)
        {
            if (arrDistinct.ContainsKey(t)) return true;
            arrDistinct[t] = t;
        }

        return false;
    }

    #endregion
    
    #region Method 3: complexity O(N)

    public static bool ContainsDuplicate3(int[] nums)
    {
        var seen = new HashSet<int>();
        foreach(var x in nums)
        {
            if (!seen.Add(x)) return true;
        }
        return false;
    }

    #endregion
}