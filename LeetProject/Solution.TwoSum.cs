namespace LeetProject
{
    public partial class Solution
    {
        [Fact]
        public void TwoSumTests()
        {
            var nums = new[] { 3, 3 };
            var result = TwoSum(nums, 6);


            foreach (var i in result)
            {
                output.WriteLine(i.ToString());
            }
        }

        public int[] TwoSum(int[] nums, int target)
        {
            var result = Array.Empty<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        result = new[] { i, j };
                        return result;
                    }
                }
            }
            return result;
        }
    }
}
