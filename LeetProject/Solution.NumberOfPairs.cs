namespace LeetProject
{
    public partial class Solution
    {
        [Theory]
        [InlineData(new[] { 1, 3, 2, 1, 3, 2, 2 }, new[] { 3, 1 })]
        [InlineData(new[] { 1, 1 }, new[] { 1, 0 })]
        [InlineData(new[] { 0 }, new[] { 0, 1 })]
        public void NumberOfPairsTests(int[] input, int[] expected)
        {
            NumberOfPairs(input).Should().Equal(expected);
        }

        public int[] NumberOfPairs(int[] nums)
        {
            var dictionary = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!dictionary.ContainsKey(nums[i]))
                {
                    dictionary[nums[i]] = 0;
                }
                dictionary[nums[i]]++;
            }

            return new[] { dictionary.Values.Sum(x => x / 2), dictionary.Values.Sum(x => x % 2) };
        }
    }
}
