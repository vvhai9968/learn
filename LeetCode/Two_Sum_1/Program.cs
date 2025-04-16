namespace Two_Sum_1;

public class Program
{
    private static void Main(string[] args)
    {
        var result = TwoSum([1, 3, 5, 7], 8);
        Console.WriteLine(result);
    }
    
    public static int[] TwoSum1(int[] nums, int target) {
        for(var i = 0; i < nums.Length; i++){
            for(var j = i + 1; j < nums.Length; j++){
                if(target == nums[i] + nums[j]) return [i, j];
            }
        }
        return [];
    }

    private static int[] TwoSum(int[] nums, int target) {
        var num = new Dictionary<int,int>();
        for(var i = 0; i < nums.Length; i++){
            var numNeed = target - nums[i];
            if(num.TryGetValue(numNeed, out var value)){
                return [i, value];
            }
            num[nums[i]] = i;
        }
        return [];
    }
}