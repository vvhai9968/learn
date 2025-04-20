namespace Longest_Consecutive_Sequence_128;

public static class Program
{
    static void Main(string[] args)
    {
        var res = LongestConsecutive([100, 14, 200, 10, 13, 12]);
        Console.WriteLine(res);
    }

    private static int LongestConsecutive(int[] nums)
    {
        if (nums.Length == 0)
            return 0;

        var numSet = new HashSet<int>(nums);
        var maxLength = 0;

        foreach (var num in numSet)
        {
            if (numSet.Contains(num - 1)) continue;
            var currentNum = num;
            var currentStreak = 1;

            while (numSet.Contains(currentNum + 1))
            {
                currentNum++;
                currentStreak++;
            }

            if (currentStreak > maxLength)
                maxLength = currentStreak;
        }

        return maxLength;
    }
}