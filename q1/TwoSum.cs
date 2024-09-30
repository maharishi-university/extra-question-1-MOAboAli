public class Solution
{
    public void RunTestCases()
    {
        int[] nums = { 2, 7, 11, 15 };
        Console.WriteLine("[" + string.Join(", ", TwoSum(nums, 9)) + "]");

        Console.ReadLine();

    }
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> numMap = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if (numMap.ContainsKey(complement))
            {
                return new int[] { numMap[complement], i };
            }

            numMap[nums[i]] = i;
        }

        throw new ArgumentException("No two sum solution");
    }


}