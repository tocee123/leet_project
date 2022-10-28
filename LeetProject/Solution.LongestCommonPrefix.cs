namespace LeetProject
{
    public partial class Solution
    {
        [Theory]
        [InlineData(new[] { "flower", "flow", "flight" }, "fl")]
        [InlineData(new[] { "dog", "racecar", "car" }, "")]
        public void LongestCommonPrefix_Tests(string[] input, string expected)
        {
            LongestCommonPrefix(input).Should().Be(expected);
        }

        public string LongestCommonPrefix(string[] strs)
        {
            string longestCommonPrefix = "";
            var i = 0;
            while (true)
            {
                var commonPrefix = strs.First()[..i];
                if (!strs.All(x => x.StartsWith(commonPrefix)))
                {
                    break;
                }
                i++;
                longestCommonPrefix = commonPrefix;
            }
            return longestCommonPrefix;
        }
    }
}
