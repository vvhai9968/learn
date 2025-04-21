namespace _3Sum_15;

public class Program
{
    static void Main(string[] args)
    {
        var res = ThreeSum([-1, 0, 1, 2, -1, -4]);
    }

    private static IList<IList<int>> ThreeSum(int[] nums)
    {
        Array.Sort(nums);
        var res = new List<IList<int>>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 0) break;
            if (nums[i] > 0 && nums[i] == nums[i-1]) continue;
            int l = i + 1, r = nums.Length - 1;
            while (l < r)
            {
                var sum = nums[i] + nums[l] + nums[r];
                if (sum > 0)
                {
                    r--;
                }
                else if (sum < 0)
                {
                    l++;
                } else
                {
                    res.Add([nums[i], nums[l], nums [r]]);
                    while (l < r && nums[l] == nums[l - 1])
                    {
                        l++;
                    }
                }
            }
        }
        return res;
    }
    
}