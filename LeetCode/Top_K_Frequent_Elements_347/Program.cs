namespace Group_Anagrams_49;

public class Program
{
    static void Main(string[] args)
    {
        var result = TopKFrequent([1,1,1,4,2,2,3,3], 2);

    }

    private static int[] TopKFrequent1(int[] nums, int k)
    {
        var numDic = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            numDic[num] = numDic.GetValueOrDefault(num, 0) + 1;
        }

        var rusult = numDic.OrderByDescending(x => x.Value).Take(k).Select(x=> x.Value).ToArray();
        return rusult;
    }
    
    public static int[] TopKFrequent(int[] nums, int k) {
        var count = new Dictionary<int, int>();
        foreach (var num in nums) {
            if (count.ContainsKey(num)) {
                count[num]++;
            } else {
                count[num] = 1;
            }
        }

        var heap = new PriorityQueue<int, int>();
        foreach (var entry in count) {
            heap.Enqueue(entry.Key, entry.Value);
            if (heap.Count > k) {
                heap.Dequeue();
            }
        }
        
        var res = new int[k];
        for (int i = 0; i < k; i++) {
            res[i] = heap.Dequeue();
        }
        return res;
    }
}