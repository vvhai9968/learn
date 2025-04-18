namespace Product_Of_Array_Except_Self_238;

public class Program
{
    static void Main(string[] args)
    {
        var res = ProductExceptSelf([1, 2, 3, 4]);
    }

    private static int[] ProductExceptSelf1(int[] nums)
    {
        var length = nums.Length;
        var res = new int[length];
        for (var i = 0; i < length; i++)
        {
            var c = 1;
            for (var j = 0; j < length; j++)
            {
                if (i != j )
                {
                    c *=nums[j];
                }
            }

            res[i] = c;
        }
        return res;
    }
    
    private static int[] ProductExceptSelf(int[] nums)
    {
        var length = nums.Length;
        var result = new int[length];
        
        result[0] = 1;
        for (var i = 1; i < length; i++)
        {
            result[i] = result[i - 1] * nums[i - 1];
        }
        
        var suffix = 1;
        for (var i = length - 1; i >= 0; i--)
        {
            result[i] *= suffix;
            suffix *= nums[i];
        }

        return result;
    }

}
