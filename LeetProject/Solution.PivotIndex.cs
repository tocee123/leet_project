namespace LeetProject
{
    public partial class Solution
    {
        [Theory]
        [InlineData(new[] { 1, 7, 3, 6, 5, 6 }, 3)]
        [InlineData(new[] { 1, 2, 3 }, -1)]
        [InlineData(new[] { 2, 1, -1 }, 0)]
        public void PivotIndexTests(int[] input, int expected)
        {
            PivotIndex(input).Should().Be(expected);
        }

        public int PivotIndex(int[] nums)
        {
            var pivotIndex = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                var leftSum = nums[..i].Sum();
                var rightSum = nums[i..].Sum();
                if (leftSum == rightSum)
                {
                    pivotIndex = i;
                    break;
                }
            }
            return pivotIndex;
        }
    }
}
