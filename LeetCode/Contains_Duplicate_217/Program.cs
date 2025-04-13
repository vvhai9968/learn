namespace Contains_Duplicate_217;

public class Program
{
    private static void Main(string[] args)
    {
        var result = ContainsDuplicate([1, 2, 3, 1]);
        Console.WriteLine(result);
    }

    #region Method 1: complexity O(N2) time out when encountering big data

    private static bool ContainsDuplicate1(int[] nums)
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

    private static bool ContainsDuplicate(int[] nums)
    {
        var arrDistinct = new Dictionary<int, int>();
        return nums.Any(t => !arrDistinct.TryAdd(t, t));
    }

    #endregion
    
    #region Method 3: complexity O(N)

    private static bool ContainsDuplicate3(int[] nums)
    {
        var seen = new HashSet<int>();
        return nums.Any(x => !seen.Add(x));
    }

    #endregion
}