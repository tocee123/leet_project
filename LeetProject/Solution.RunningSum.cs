namespace LeetProject
{
    public partial class Solution
    {
        [Theory]
        [InlineData(new[] { 1, 2, 3, 4 }, new[] { 1, 3, 6, 10 })]
        [InlineData(new[] { 1, 1, 1, 1, 1 }, new[] { 1, 2, 3, 4, 5 })]
        [InlineData(new[] { 3, 1, 2, 10, 1 }, new[] { 3, 4, 6, 16, 17 })]
        public void RunningSumTests(int[] input, int[] expected)
        {
            RunningSum(input).Should().BeEquivalentTo(expected);
        }

        public int[] RunningSum(int[] nums)
        {
            for (int i = 1; i < nums.Length; i++)
            {
                nums[i] = nums[i - 1]+nums[i];
            }
            return nums;
        }
    }
}
